using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataTransmission;
using System.Data;
using DataTransmission;

namespace OnlineBusTicket
{
    public partial class Default : System.Web.UI.Page
    {
        #region Declaration

        #region Declaration
        DataSet _busSet = new DataSet();
        pbooking _pbook = new pbooking();
        UserAcount oUserAcount;
        PUserAcount oPUserAcount;
        DataSet ds;
        object[] obj = new object[4];
        #endregion
        #endregion

        #region PageLoad
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    SetVisibilty();
                    if (Session["Problem"] != null)
                    {
                        ScriptManager.RegisterClientScriptBlock(this, GetType(), "key", "SomeProblemInBusView;", true);
                    }

                    CommonUtility.getDDLData(ddl_source, "Location_Name", "Location_ID", "Eticket_MST_Location", "IsActive", "1");
                    CommonUtility.getDDLData(ddl_destin, "Location_Name", "Location_ID", "Eticket_MST_Location", "IsActive", "1");
                    ddl_source.Items.Insert(0, new ListItem("Select Source", "-1"));
                    ddl_destin.Items.Insert(0, new ListItem("Select Destination", "-1"));
                }

            }
            catch (Exception ex)
            {


            }
        }

        private void SetVisibilty()
        {
            tblLogin.Visible = Session["Login"] == null ? true : false;
            divImage.Visible = liAcount.Visible = Session["Login"] != null ? true : false;
            lnkLogin.Text = Session["Login"] != null ? Session["Login"].ToString() : "";
            lnkSignOut.Text = Session["Login"] != null ? "Sign Out" : "";
            liReg.Visible = liRegAgent.Visible = Session["Login"] == null ? true : false;
        }
        #endregion

        #region Button1_Click
        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {

                
                obj[0] = ddl_source.SelectedValue;
                obj[1] = ddl_destin.SelectedValue;
                obj[2] = txt_dep_date.Text;
                if (Session["User_ID"] != null && Session["User_Type"] != null)
                {
                    if (Convert.ToInt32(Session["User_Type"]) == 1 || Convert.ToInt32(Session["User_Type"]) == 5)
                    {
                        obj[3] = 1;
                    }
                    else if (Convert.ToInt32(Session["User_Type"]) == 2)
                    {
                        obj[3] = 2;
                    }

                    _callSearch();
                }
                else
                {
                    obj[3] = 1;
                    _callSearch();
                }

               
            }
            catch (Exception ex)
            {


            }

        }
        #endregion

        #region Function for Search button 

        public void _callSearch()
        {
            #region Calling Buses details
            _busSet = _pbook.GetBusesDetails(obj);

            if (_busSet != null)
            {
                if (_busSet.Tables[0].Rows.Count > 0)
                {
                    Session["Boarding_Point"] = ddl_source.SelectedValue;
                    Session["Destination_Point"] = ddl_destin.SelectedValue;
                    Session["Boarding_Point_Name"] = ddl_source.SelectedItem.Text;
                    Session["Destination_Point_Name"] = ddl_destin.SelectedItem.Text;
                    Session["DepartureDate"] = txt_dep_date.Text;
                    Session["_busSet"] = _busSet;


                    if (Session["User_ID"] != null && Session["User_Type"] != null)
                    {
                        if (Session["User_Type"].ToString() == "1")
                        {
                            Session["Booking_Quoto_Name"] = "Gen";//general
                            Session["Booking_Quoto"] = 1;//general
                        }
                        else if (Session["User_Type"].ToString() == "2")
                        {
                            Session["Booking_Quoto_Name"] = "Agent";//Agent
                            Session["Booking_Quoto"] = 2;//Agent
                        }
                    }
                    else if (Session["User_ID"] == null && Session["User_Type"] == null)
                    {
                        Session["User_Type"] = "5";
                        Session["User_ID"] = null;
                        Session["Booking_Quoto_Name"] = "Gen";//general
                        Session["Booking_Quoto"] = 1;//general

                    }


                    Response.Redirect("~\\Booking\\BusIntegration.aspx");

                }
                else
                {
                    ScriptManager.RegisterClientScriptBlock(this, GetType(), "key", "NoResults();", true);
                    txt_dep_date.Text = string.Empty;
                    ddl_destin.SelectedIndex = -1;
                    ddl_source.SelectedIndex = -1;
                    Response.Redirect("~\\Default.aspx");

                }
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, GetType(), "key", "NoResults();", true);
                txt_dep_date.Text = string.Empty;
                ddl_destin.SelectedIndex = -1;
                ddl_source.SelectedIndex = -1;
                Response.Redirect("~\\Default.aspx");
            }
            #endregion
        }

        #endregion

        #region LoginButton_Click
        protected void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                UserAuthentication();
            }
            catch (Exception ex)
            {


            }
        }
        #endregion

        #region Function UserAuthentication
        protected void UserAuthentication()
        {
            oUserAcount = new UserAcount
            {
                Flag = 2,
                EMail = txtEMail.Text,
                Password = txtPassword.Text,
            };
            oPUserAcount = new PUserAcount();
            ds = oPUserAcount.UserAcount(oUserAcount);
            string s = ds.Tables[0].Rows[0][0].ToString();
            string[] Param = s.Split(new string[] { "*" }, StringSplitOptions.None);
            if (Param.Length == 3)
            {
                Session["User_ID"] = Param[0];
                Session["User_Type"] = Param[1];
                Session["Login"] = Param[2];
                liAcount.Visible = true;
                tblLogin.Visible = true;
                divImage.Visible = true;
                if (Param[1] == "4")
                {
                    //Admin

                    Response.Redirect("~/Administration/UserProfile.aspx");
                }
                else if (Param[1] == "3")
                {
                    //POS

                    Response.Redirect("~/Booking/BookingCounter.aspx");
                }
                else
                {
                    //Normal User,Agent,POS  Session["Booking_Quoto"]
                    if (Param[1] == "2")
                    {
                        Session["Booking_Quoto_Name"] = "Gen";//Agent
                        Session["Booking_Quoto"] = 1;//Agent
                    }
                    else
                    {
                        Session["Booking_Quoto_Name"] = "Agent";//Agent
                        Session["Booking_Quoto"] = 2;//Agent
                    }
                    SetVisibilty();
                    Response.Redirect("~/Default.aspx");
                }
            }
            else
            {
                lblFailureText.Visible = true;
                lblFailureText.Text = s;
                //Response.Redirect("~/Default.aspx");
            }

        }

        #endregion

        #region lnk_cnnot_Click
        protected void lnk_cnnot_Click(object sender, EventArgs e)
        {
            try
            {
                Response.Redirect("~/Default.aspx");
            }
            catch (Exception ex)
            {


            }
        }
        #endregion

        #region lnkSignOut_Click1
        protected void lnkSignOut_Click1(object sender, EventArgs e)
        {
            try
            {
                Session.Remove("Login");
                Session.Clear();
                Session.Abandon();
                Session["Login"] = null;
                SetVisibilty();
                Response.Redirect("~/Default.aspx");
            }
            catch (Exception ex)
            {


            }

        }
        #endregion
    }
}
