using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using DataTransmission;

namespace OnlineBusTicket
{
    public partial class BusIntegration : System.Web.UI.Page
    {

        #region Declaration
        DataSet _busSet = new DataSet();
        pbooking _pbook = new pbooking();
        #endregion

        #region PageLoad
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                #region IsPostBack
                if (!IsPostBack)
                {
                    if (Session["Boarding_Point"] != null && Session["Destination_Point"] != null && Session["DepartureDate"] != null)
                    {
                        _busSet = (DataSet)Session["_busSet"];
                        if (_busSet != null)
                        {
                            if (_busSet.Tables[0].Rows.Count > 0)
                            {
                                grd_result.DataSource = _busSet.Tables[0];
                                grd_result.DataBind();
                                lbl_Results.Text = _busSet.Tables[0].Rows.Count + " Results found from " + Session["Boarding_Point_Name"].ToString() + " to " + Session["Destination_Point_Name"].ToString() + " for " + Session["DepartureDate"].ToString();
                            }
                            else
                            {
                                ScriptManager.RegisterClientScriptBlock(this, GetType(), "key", "NoResults();", true);
                            }
                        }
                        else
                        {
                            ScriptManager.RegisterClientScriptBlock(this, GetType(), "key", "NoResults();", true);
                        }
                    }
                }


                #endregion
            }
            catch (Exception ex)
            {


            }
        }
        #endregion



        #region Clear Cache
        private void ExpirePageCache()
        {
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Cache.SetExpires(DateTime.Now - new TimeSpan(1, 0, 0));
            Response.Cache.SetLastModified(DateTime.Now);
            Response.Cache.SetAllowResponseInBrowserHistory(false);

        }
        #endregion

        #region GridEvents
        #region grd_result_RowDataBound
        protected void grd_result_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            foreach (GridViewRow row in grd_result.Rows)
            {
                HiddenField hid_AC = (HiddenField)row.FindControl("hid_AC");
                HiddenField hid_VO = (HiddenField)row.FindControl("hid_VO");
                HiddenField hid_SL = (HiddenField)row.FindControl("hid_SL");
                HiddenField hid_ST = (HiddenField)row.FindControl("hid_ST");
                Image img_AC = (Image)row.FindControl("img_AC");
                Image img_Volvo = (Image)row.FindControl("img_Volvo");
                Image img_SL = (Image)row.FindControl("img_SL");
                Image img_Siting = (Image)row.FindControl("img_Siting");
                Label lbl_AvailableSeats = (Label)row.FindControl("lbl_AvailableSeats");
                ImageButton img_select=(ImageButton)row.FindControl("img_select");
               

                #region Showing Bus type image

                if (hid_AC.Value == "True")
                {
                    img_AC.Visible = true;
                }
                else
                {
                    img_AC.Visible = false;
                }
                if (hid_VO.Value == "True")
                {
                    img_Volvo.Visible = true;
                }
                else
                {
                    img_Volvo.Visible = false;
                }
                if (hid_SL.Value == "True")
                {
                    img_SL.Visible = true;
                }
                else
                {
                    img_SL.Visible = false;
                }
                if (hid_ST.Value == "True")
                {
                    img_Siting.Visible = true;
                }
                else
                {
                    img_Siting.Visible = false;
                }
                #endregion

                if (lbl_AvailableSeats.Text == "0")
                {
                    img_select.Visible = false;
                }
                else
                {
                    img_select.Visible=true;
                }
            }
        }
        #endregion

        #region RowCommand grd_result_RowCommand
        protected void grd_result_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                if (e.CommandName == "gotoedit")
                {

                    GridViewRow row = (GridViewRow)(((LinkButton)e.CommandSource).NamingContainer);

                    LinkButton lnk_busno = (LinkButton)row.FindControl("lnk_busno");
                    Session["_BUSID"] = lnk_busno.Text;

                    System.Text.StringBuilder sb = new System.Text.StringBuilder();
                    sb.Append("javascript:OpenDialog();");
                    ScriptManager.RegisterClientScriptBlock(this, GetType(), "strkey", "<script>" + sb + "</script>", false);


                }
                else if (e.CommandName == "Select")
                {
                    GridViewRow row = (GridViewRow)(((ImageButton)e.CommandSource).NamingContainer);
                    ImageButton img_select = (ImageButton)row.FindControl("img_select");
                    String _Bus_ID = ((LinkButton)row.FindControl("lnk_busno")).Text;
                    Label lbl_operators = (Label)row.FindControl("lbl_operators");
                    Label lbl_RouteID = (Label)row.FindControl("lbl_RouteID");

                     Label lbl_Departure = (Label)row.FindControl("lbl_Departure");
                     Label lbl_Arrival = (Label)row.FindControl("lbl_Arrival");
                     Label lbl_Busno_actual = (Label)row.FindControl("lbl_Busno_actual");
                     Label lbl_busName = (Label)row.FindControl("lbl_busName");

                    HiddenField hid_AC = (HiddenField)row.FindControl("hid_AC");
                    HiddenField hid_VO = (HiddenField)row.FindControl("hid_VO");
                    HiddenField hid_SL = (HiddenField)row.FindControl("hid_SL");
                    HiddenField hid_ST = (HiddenField)row.FindControl("hid_ST");

                    object[] obj = new object[14];
                    obj[0] = _Bus_ID;
                    obj[1] = lbl_operators.Text;
                    obj[2] = hid_AC.Value;
                    obj[3] = hid_VO.Value;
                    obj[4] = hid_SL.Value;
                    obj[5] = hid_ST.Value;

                    obj[6] = lbl_RouteID.Text;
                    obj[7] = Session["DepartureDate"].ToString();
                    obj[8] = Session["Boarding_Point"].ToString();
                    obj[9] = Session["Destination_Point"].ToString();
                    obj[10] = lbl_Departure.Text;
                    obj[11] = lbl_Arrival.Text;
                    obj[12] = lbl_Busno_actual.Text;
                    obj[13] = lbl_busName.Text;

                  
                    //Actual BoardingPoint, No of passengers,Seat nos and other information Time at boarding station will be calculated at next page

                    Session["BusDetails"] = obj;
                    Response.Redirect("~\\Booking\\BusViews.aspx");

                }


            }
            catch (Exception ex)
            {

            }

        }
        #endregion
        #endregion


    }
}