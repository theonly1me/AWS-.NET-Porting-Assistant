using System;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataTransmission.Masters;
using DataTransmission;
using System.Data.SqlClient;
using System.Configuration;


namespace OnlineBusTicket
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        #region Declaration
        PBusSchedule _pbusSchedule = new PBusSchedule();
        static Int32 noofdays;
        DataTable _dtTemp = new DataTable();
        int no_Of_month;

        #endregion

        #region Page_Load
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    lbl_msg.Visible = false;
                    #region For Current Month n Year
                    string monthNo = Convert.ToString(System.DateTime.Now.ToLongDateString());
                    string s = Convert.ToString(monthNo);
                    string[] month = (s.Split(','));
                    string monthaname = month[1];
                    lblMon.Text = month[1];
                    int year = System.DateTime.Now.Year;
                    no_Of_month = Convert.ToInt32(System.DateTime.Now.Month);
                    HiddenField1.Value = no_Of_month.ToString(); //ADDED BY ABHINAV, USED WHILE ADDING IN TEMP TABLE
                    noofdays = Convert.ToInt32(System.DateTime.DaysInMonth(year, no_Of_month));
                    lblY.Text = year.ToString();

                    #endregion

                    trCheck.Visible = false;
                    trDays.Visible = false;
                    trButton.Visible = false;

                    #region Making DropDown Select as first entry
                    ddlBusOperator.Items.Insert(0, new ListItem("--Select Operator--", "-1"));
                    BindBusOperatorDropDown();
                    ddlBusName.Items.Insert(0, new ListItem("--Select Bus Name--", "-1"));
                    //BindBusNameDropDown();
                    #endregion

                    #region Fill Checkbox List
                    for (int i = 1; i <= noofdays; i++)
                    {
                        ListItem li = new ListItem();
                        li.Text = Convert.ToString(i);
                        li.Value = Convert.ToString(i);
                        chckCustom.Items.Add(li);

                    }
                    #endregion

                    #region Declare Table Variable
                    _dtTemp.Columns.Clear();
                    _dtTemp.Rows.Clear();
                    _dtTemp.Columns.Add("BusId", typeof(Int32));
                    _dtTemp.Columns.Add("BusDateTime", typeof(DateTime));
                    _dtTemp.Columns.Add("isActive", typeof(bool));

                    ViewState["temp"] = _dtTemp;
                    #endregion

                }
            }
            catch (Exception ex)
            {

                lbl_msg.Visible = true;
                lbl_msg.Text = "Unable to connect with server";
                lbl_msg.CssClass = "general";
            }

        }
        #endregion

        #region rbDays_SelectedIndexChanged
        protected void rbDays_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                lbl_msg.Visible = false;
                if (rbDays.SelectedValue == "1")
                {
                    trDays.Visible = true;
                    trCheck.Visible = false;
                }
                else if (rbDays.SelectedValue == "2")
                {
                    trDays.Visible = false;
                    trCheck.Visible = true;

                }

                rbPlan.SelectedIndex = -1;
                chckCustom.SelectedIndex = -1;
                trButton.Visible = true;



            }
            catch (Exception ex)
            {

                lbl_msg.Visible = true;
                lbl_msg.Text = "Unable to connect with server";
                lbl_msg.CssClass = "general";
            }

        }
        #endregion

        #region BindDropdownList for Bus Operator
        public void BindBusOperatorDropDown()
        {
            try
            {

                CommonUtility.getDDLData(ddlBusOperator, "Operator_Name", "Operator_ID", "Eticket_MST_Operators", "", "");
                ddlBusOperator.Items.Insert(0, new ListItem("--Select Operator--", "-1"));

            }
            catch (Exception ex)
            {

                lbl_msg.Visible = true;
                lbl_msg.Text = "Unable to connect with server";
                lbl_msg.CssClass = "general";
            }

        }
        #endregion

        #region BindDropdownList for Bus name n No
        public void BindBusNameDropDown()
        {
            try
            {
                object[] obj = new object[2];
                obj[0] = Convert.ToInt32(ddlBusOperator.SelectedValue);
                obj[1] = 1;
                DataTable DTBus = _pbusSchedule.GetBusNameNoDropdownSchedule(obj);
                if (DTBus.Rows.Count > 0)
                {
                    ddlBusName.DataSource = DTBus;
                    ddlBusName.DataValueField = "Bus_ID";
                    ddlBusName.DataTextField = "BusNameNo";
                    ddlBusName.DataBind();
                    ddlBusName.Items.Insert(0, new ListItem("--Select Bus Name--", "-1"));

                }
                else if (DTBus.Rows.Count == 0)
                {
                    ddlBusName.Items.Insert(0, new ListItem("--No Bus Name--", "-1"));
                    ddlBusName.Items.Clear();
                    ddlBusName.Items.Insert(0, new ListItem("--No Bus Name Selected--", "-1"));
                }

            }
            catch (Exception ex)
            {

                lbl_msg.Visible = true;
                lbl_msg.Text = "Unable to connect with server";
                lbl_msg.CssClass = "general";
            }

        }
        #endregion

        #region Button Events

        #region btnSave_Click
        protected void btnSave_Click(object sender, EventArgs e)
        {
            FuncTable();
            
            trCheck.Visible = false;
            trButton.Visible = false;
            trDays.Visible = false;
            rbDays.SelectedIndex = -1;
            ddlBusName.SelectedIndex = -1;
            ddlBusOperator.SelectedIndex = -1;
        }
        #endregion

        #region btnReset_Click
        protected void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                ddlBusName.SelectedIndex = -1;
                ddlBusOperator.SelectedIndex = -1;
                            
                if(rbDays.SelectedValue=="1")
                {
                    rbPlan.SelectedIndex = -1;
                }

                else 
                {
                    rbPlan.Visible = false;
                }
                rbDays.SelectedIndex = -1; 
                chckCustom.SelectedIndex = -1;
                lbl_msg.Visible = false;
            }
            catch (Exception ex)
            {

                lbl_msg.Visible = true;
                lbl_msg.Text = "Unable to connect with server";
                lbl_msg.CssClass = "general";
            }


        }
        #endregion

        #region btnCancel_Click
        protected void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                Response.Redirect("WebForm1.aspx");
                lbl_msg.Visible = false;
            }
            catch (Exception ex)
            {

                lbl_msg.Visible = true;
                lbl_msg.Text = "Unable to connect with server";
                lbl_msg.CssClass = "general";
            }
        }
        #endregion

        #endregion

        #region CheckBox Events
        public void funcCheckDate1(int dayLimit)
        {
            try
            {

                int count = 0;
                int yea1r = System.DateTime.Now.Year;
                int no_Of_month1 = Convert.ToInt32(System.DateTime.Now.Month);
                int noofdays1 = Convert.ToInt32(System.DateTime.DaysInMonth(yea1r, no_Of_month1));
                if (noofdays1 == 30)
                {
                    count = 29;
                }
                else if (noofdays1 == 31)
                {
                    count = 30;
                }
                else if (noofdays1 == 29)
                {
                    count = 28;
                }
                else
                {
                    count = 27;
                }



                for (int i = 1; i <= count; i++)
                {
                    ListItem li = new ListItem();
                    li.Text = Convert.ToString(i);
                    li.Value = Convert.ToString(i);
                    chckCustom.Items[i].Selected = false;

                }

                int year = System.DateTime.Now.Year;
                int no_Of_month = Convert.ToInt32(System.DateTime.Now.Month);
                int noofdays = Convert.ToInt32(System.DateTime.DaysInMonth(year, no_Of_month));
                int day = System.DateTime.Now.Day;

                int CalcDiff = (noofdays - day);

                // if (CalcDiff >= Convert.ToInt32(TextBox1.Text))
                if (CalcDiff >= Convert.ToInt32(rbPlan.SelectedValue))
                {
                    for (int i = day; i <= (Convert.ToInt32(rbPlan.SelectedValue) - 1) + day; i++)
                    {
                        chckCustom.Items[i].Selected = true;

                    }
                }

                else
                {
                    ScriptManager.RegisterClientScriptBlock(this, GetType(), "key", "NoResults();", true);
                    rbPlan.SelectedIndex = -1;
                }




            }
            catch (Exception ex)
            {

                lbl_msg.Visible = true;
                lbl_msg.Text = "Unable to connect with server";
                lbl_msg.CssClass = "general";
            }
        }
        #endregion

        #region UserDefined Function
        private void FuncTable()
        {
            DataTable dtBus = new DataTable();
            if (ViewState["temp"] != null)
            {
                dtBus = ((DataTable)ViewState["temp"]).Clone();
                foreach (ListItem chk in chckCustom.Items)
                {

                    if (chk.Selected == true)
                    {
                        DataRow drow = dtBus.NewRow();
                        drow["BusId"] = ddlBusName.SelectedItem.Value;
                      //  string strDate = System.DateTime.Now.Month + "/" + chk.Text + "/" + lblY.Text;
                        string strDate = lblY.Text + "-" + HiddenField1.Value + "-" + chk.Text; 
                        drow["BusDateTime"] = Convert.ToDateTime(strDate);
                        drow["isActive"] = 1;
                        dtBus.Rows.Add(drow);
                    }
                }

                string strcon = ConfigurationManager.ConnectionStrings["Connection String"].ToString();
                SqlConnection con = new SqlConnection(strcon);
                SqlCommand cmd = new SqlCommand();
                SqlDataReader dr = null;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;
                cmd.CommandText = "usp_ETicket_BUS_Schedule_Save";
                cmd.Parameters.AddWithValue("@dtBusSchedule", dtBus);
                cmd.Parameters.AddWithValue("@busId", ddlBusName.SelectedItem.Value);
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {

                    }
                }
                else
                {
                    lbl_msg.Visible = true;
                    lbl_msg.Text = "Record Saved Successfully";
                }
                con.Close();
            }
        }
        #endregion

        #region rbPlan_SelectedIndexChanged (Group day n custom dates)
        protected void rbPlan_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                funcCheckDate1(Convert.ToInt32(rbPlan.SelectedValue));
                trCheck.Visible = true;
                lbl_msg.Visible = false;
            }
            catch (Exception ex)
            {

                lbl_msg.Visible = true;
                lbl_msg.Text = "Unable to connect with server";
                lbl_msg.CssClass = "general";
            }
        }
        #endregion

        #region ddlBusOperator_SelectedIndexChanged
        protected void ddlBusOperator_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (ddlBusOperator.SelectedItem.Value != "-1")
                {
                    BindBusNameDropDown();
                    lbl_msg.Visible = false;
                }
                else
                {

                }
               
                
                
            }
            catch (Exception ex)
            {

                lbl_msg.Visible = true;
                lbl_msg.Text = "Unable to connect with server";
                lbl_msg.CssClass = "general";
            }
        }
        #endregion
    }
}