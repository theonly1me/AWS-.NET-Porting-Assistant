using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataTransmission;
using System.Data;
using System.Drawing.Printing;
using System.IO;
using System.Drawing;
using DataTransmission.Masters;
namespace OnlineBusTicket
{
    public partial class BookingCounter : System.Web.UI.Page
    {
        #region Class Level Declaration
      
        DataSet DS = new DataSet();
        DataTable dt = new DataTable();
        DataTable DT_Auto = new DataTable();
        pbooking _pbook = new pbooking();
        PBusSchedule _pbusSchedule = new PBusSchedule();
        Font verdana10Font;

        StreamReader reader;


        #endregion

        #region Page Load
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    #region IsPostBack

                    CommonUtility.getDDLData(ddlOperator, "Operator_Name", "Operator_ID", "Eticket_MST_Operators", "IsActive", "1");
                    ddlOperator.Items.Insert(0, new ListItem("Select Operator", "-1"));
                    ddl_bus.Items.Insert(0, new ListItem("Select Operator", "-1"));


                    //CommonUtility.getDDLData(ddl_source, "Location_Name", "Location_ID", "Eticket_MST_Location", "IsActive", "1");
                    //CommonUtility.getDDLData(ddl_destin, "Location_Name", "Location_ID", "Eticket_MST_Location", "IsActive", "1");

                    ddl_source.Items.Insert(0, new ListItem("Select Source", "-1"));
                    ddl_destin.Items.Insert(0, new ListItem("Select Destination", "-1"));
                    //funcBindLocation();

                    #endregion

                    //grd.Visible = false;
                    //passArea.Visible = false;
                    //controw.Visible = false;

                 

                    lbl_bookingDate.Text = System.DateTime.Now.ToString("dd MMM yyyy");


                    try
                    {
                        grd_fare_breakup.DataSource = null;
                        grd_fare_breakup.DataBind();
                        txt_ind_fare.Text = string.Empty;
                        txt_ind_male_no.Text = string.Empty;
                        hid_fare.Value = string.Empty;
                        //grd.Visible = false;
                        //passArea.Visible = false;
                        //controw.Visible = false;

                        grd.Visible = true;
                        passArea.Visible = true;
                        controw.Visible = true;
                    }

                    catch (Exception ex)
                    {
                        lbl_msg.Visible = true;
                        lbl_msg.Text = ex.ToString();
                        lbl_msg.CssClass = "general";
                    }
                } 
                
            }

            catch (Exception ex)
            {
                lbl_msg.Visible = true;
                lbl_msg.Text = ex.ToString();
                lbl_msg.CssClass = "general";
            }
        }
        #endregion
        
        #region Dropdown Events

        #region Operator DropDown

        protected void ddlOperator_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string filter = "Bus_Operator_ID=" + ddlOperator.SelectedValue + " AND IsActive=1";
                CommonUtility.getDDLMultiWhereth(ddl_bus, "Bus_Name", "Bus_ID", "Eticket_MST_BUS_DESC", filter);
                ddl_bus.Items.Insert(0, new ListItem("Select Bus", "-1"));
            }
            catch (Exception ex)
            {
                lbl_msg.Visible = true;
                lbl_msg.Text = ex.ToString();
                lbl_msg.CssClass = "general";
            }


            

           
        }

       
      
        #endregion

        #region Bus DropDown

        protected void ddl_bus_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                funcBindLocation(); 
                lbl_Perkm.Visible = true;
                object[] obj = new object[1];
                obj[0] = ddl_bus.SelectedValue;
                DataTable _DtFare = _pbook.GetBusFareForBookingCounter(obj);
                if (_DtFare != null)
                {
                    if (_DtFare.Rows[0]["Charges"].ToString() != string.Empty)
                    {
                        lbl_Perkm.Text = _DtFare.Rows[0]["Charges"].ToString()+" /Km ";
                    }
                    else
                    {
                        lbl_Perkm.Text = "5.00"+"/KM";
                    }
                }
                else
                {
 
                }
            }
            catch (Exception ex)
            {
                lbl_msg.Visible = true;
                lbl_msg.Text = ex.ToString();
                lbl_msg.CssClass = "general";
            }

        }

        #endregion

        #region ddl_source_SelectedIndexChanged
        protected void ddl_source_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CallFareBreakup();
            }
            catch (Exception ex)
            {
                lbl_msg.Visible = true;
                lbl_msg.Text = ex.ToString();
                lbl_msg.CssClass = "general";
            }
           
            //try
            //{

            //    grd_fare_breakup.DataSource = null;
            //    grd_fare_breakup.DataBind();
            //    txt_ind_fare.Text = string.Empty;
            //    txt_ind_male_no.Text = string.Empty;
            //    hid_fare.Value = string.Empty;
            //    grd.Visible = false;
            //    passArea.Visible = false;
            //    controw.Visible = false;
            //}

            //catch (Exception ex)
            //{
            //    lbl_msg.Visible = true;
            //    lbl_msg.Text = ex.ToString();
            //    lbl_msg.CssClass = "general";
            //}
        }
        #endregion

        #region ddl_destin_SelectedIndexChanged
        protected void ddl_destin_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CallFareBreakup();
            }
            catch (Exception ex)
            {
                lbl_msg.Visible = true;
                lbl_msg.Text = ex.ToString();
                lbl_msg.CssClass = "general";
            }
           


            //try
            //{
            //    grd_fare_breakup.DataSource = null;
            //    grd_fare_breakup.DataBind();
            //    txt_ind_fare.Text = string.Empty;
            //    txt_ind_male_no.Text = string.Empty;
            //    hid_fare.Value = string.Empty;
            //    grd.Visible = false;
            //    passArea.Visible = false;
            //    controw.Visible = false;
            //}

            //catch (Exception ex)
            //{
            //    lbl_msg.Visible = true;
            //    lbl_msg.Text = ex.ToString();
            //    lbl_msg.CssClass = "general";
            //}
        }
        #endregion

        #endregion

        #region Functions

        #region CallFareBreakup
        public void CallFareBreakup()
        {
            grd_fare_breakup.DataSource = null;
            grd_fare_breakup.DataBind();
 
            object[] obj = new object[3];
            obj[0] = ddl_bus.SelectedValue;
            obj[1] = ddl_source.SelectedValue;
            obj[2] = ddl_destin.SelectedValue;
            DataTable _DTFare_Distance = _pbook.GET_FARE_ON_BOOKING_COUNTER_POINT(obj);
            if (_DTFare_Distance != null)
            {
                if (_DTFare_Distance.Rows.Count > 0)
                {
                    grd.Visible = true;
                    passArea.Visible = true;
                    controw.Visible = true;
                    grd_fare_breakup.DataSource = _DTFare_Distance;
                    grd_fare_breakup.DataBind();
                    txt_ind_fare.Text = grd_fare_breakup.Rows[0].Cells[4].Text;
                    hid_fare.Value = txt_ind_fare.Text;
                    if (grd_fare_breakup.Rows[0].Cells[4].Text == "11010.00")
                    {
                        ScriptManager.RegisterClientScriptBlock(this, GetType(), "key", "DefaultFare();", true);
                    }
                    
                   
                }
                else
                {
                    txt_ind_fare.Text = "11010.00";
                    ScriptManager.RegisterClientScriptBlock(this, GetType(), "key", "DefaultFare();", true);
                }
            }
            else
            {
                txt_ind_fare.Text = "11010.00";
                ScriptManager.RegisterClientScriptBlock(this, GetType(), "key", "DefaultFare();", true);
            }
        }
        #endregion
        #region Fill Location as per Route
        public void funcBindLocation()
        {
            try
            {
                ddl_source.Items.Clear();
                ddl_destin.Items.Clear();

                object[] obj = new object[2];
                obj[0] = Convert.ToInt32(ddl_bus.SelectedValue);
                obj[1] = 2;
                DataTable DTBus = _pbusSchedule.GetBusNameNoDropdownSchedule(obj);
                if (DTBus.Rows.Count > 0)
                {
                    ddl_source.DataSource = DTBus;
                    ddl_source.DataValueField = "Location_ID";
                    ddl_source.DataTextField = "Location_Name";
                    ddl_source.DataBind();
                    ddl_source.Items.Insert(0, new ListItem("Select Source", "-1"));

                    ddl_destin.DataSource = DTBus;
                    ddl_destin.DataValueField = "Location_ID";
                    ddl_destin.DataTextField = "Location_Name";
                    ddl_destin.DataBind();
                    ddl_destin.Items.Insert(0, new ListItem("Select Destination", "-1"));


                }
                else if (DTBus.Rows.Count == 0)
                {
                    ddl_source.Items.Insert(0, new ListItem("Select Source", "-1"));
                    ddl_destin.Items.Insert(0, new ListItem("Select Destination", "-1"));
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

        public void funcPrintCall()
        {
            string filename = Server.MapPath("Ticket.txt");
            //Create a StreamReader object
            reader = new StreamReader(filename);
            //Create a Verdana font with size 10
            verdana10Font = new Font("Verdana", 10);
            //Create a PrintDocument object
            PrintDocument pd = new PrintDocument();
            //Add PrintPage event handler
            pd.PrintPage += new PrintPageEventHandler(this.PrintTextFileHandler);
            //Call Print Method
            pd.Print();
            //Close the reader
            if (reader != null)
                reader.Close();
        }

        private void PrintTextFileHandler(object sender, PrintPageEventArgs ppeArgs)
        {
            //Get the Graphics object
            Graphics g = ppeArgs.Graphics;

            float linesPerPage = 0;
            float yPos = 0;
            int count = 0;
            //Read margins from PrintPageEventArgs
            //float leftMargin = ppeArgs.MarginBounds.Left;
            //float topMargin = ppeArgs.MarginBounds.Top;

            float leftMargin = 30;
            float topMargin = 1;
            float bottomMargin = 20;
            string line = null;
            //Calculate the lines per page on the basis of the height of the page and the height of the font
            linesPerPage = ppeArgs.MarginBounds.Height /
            verdana10Font.GetHeight(g);
            //Now read lines one by one, using StreamReader
            while (count < linesPerPage &&
            ((line = reader.ReadLine()) != null))
            {
                //Calculate the starting position
                yPos = topMargin + (count *
                verdana10Font.GetHeight(g));
                //Draw text
                g.DrawString(line, verdana10Font, Brushes.Black,
                leftMargin, yPos, new StringFormat());
                //Move to next line
                count++;
            }
            //If PrintPageEventArgs has more pages to print
            if (line != null)
            {
                ppeArgs.HasMorePages = true;
            }
            else
            {
                ppeArgs.HasMorePages = false;
            }
        }

        #endregion

        #region Button Events

        #region btn_cont_Click
        protected void btn_cont_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValid)
                {
                    string ticketno = "BUS2000123";
                    string[] str = new string[10];
                    str[0] = "Online Bus E-Ticket|Counter Ticket";
                    str[1] = "------------------------------";
                    str[2] = "Ticket No : " + ticketno;
                    str[3] = "Date of Booking :" + lbl_bookingDate.Text;
                    str[4] = "Date of Visit : " + txt_DateofVisit.Text;
                    str[5] = "No. of Passengers : " + txt_ind_male_no.Text;
                    str[6] = "Leaving From : " + ddl_source.SelectedItem.Text;
                    str[7] = "Going to : " + ddl_destin.SelectedItem.Text;

                    str[8] = "Fare :Rs. " + txt_ind_fare.Text + ".00";
                    System.IO.File.WriteAllLines(Server.MapPath("ticket.txt"), str);

                    funcPrintCall();
                }
            }
            catch (Exception ex)
            {
                lbl_msg.Visible = true;
                lbl_msg.Text = ex.ToString();
                lbl_msg.CssClass = "general";
            }
        }
        #endregion

        #region btn_cal_Click
        protected void btn_cal_Click(object sender, EventArgs e)
        {
            try
            {
                CallFareBreakup();
            }
            catch (Exception ex)
            {
                lbl_msg.Visible = true;
                lbl_msg.Text = ex.ToString();
                lbl_msg.CssClass = "general";
            }
           
        }
        #endregion

        protected void btn_res_Click(object sender, EventArgs e)
        {
            ddl_source.SelectedIndex = -1;
            ddl_destin.SelectedIndex = -1;
            lbl_Perkm.Text = string.Empty;
            ddlOperator.SelectedIndex = -1;
            ddl_bus.SelectedIndex = -1;
            txt_DateofVisit.Text = string.Empty;
            grd_fare_breakup.DataSource = null;
            txt_ind_male_no.Text = string.Empty;
            txt_ind_fare.Text = string.Empty;
            grd.Visible = false;
            passArea.Visible = false;
            controw.Visible = false;

        }

        #endregion






    }
}
