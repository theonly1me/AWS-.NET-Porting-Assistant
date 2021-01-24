using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataTransmission;
using System.Data;
namespace OnlineBusTicket.Administration
{
    public partial class BookingDetails : System.Web.UI.Page
    {
        DataSet ds;
        pbooking _pbook = new pbooking();
        protected void Page_Load(object sender, EventArgs e)
        {            
            //Session["User_ID"] = "2";
            //Session["User_Type"] = "2";
            if (!IsPostBack)
            {
                Session["User_Type"] = Session["Login"] != null ? Session["User_Type"].ToString() : "5";
                trPassenger.Visible = false;
                TdPayment.Visible = false;
                trSave.Visible = Request.QueryString[0] == "Details" ? false:true;
                btnSave.Text = Request.QueryString[0] == "Print" ? "Print Ticket" : "Cancel Ticket";
                lblHead.Text = lblLegend.Text = Request.QueryString[0] != "Details" ? Request.QueryString[0] == "Print" ? "Print Ticket" : "Cancel Ticket" : "Booking Details";                
                ViewState["TT"] = Request.QueryString[0] != "Details" ? "1" : null;
                                                    
                Bind();
            }
        }
        protected void Bind()
        {
            object[] obj = new object[5];
            obj[0] = Session["User_ID"]!=null? Convert.ToInt32(Session["User_ID"]):(int?)null;
            obj[1] = Convert.ToInt32(Session["User_Type"]);
            obj[2] = Session["Login"] != null ? (txtBookingId.Text.Trim() == string.Empty ? (int?)null : Convert.ToInt32(txtBookingId.Text)) : (txtBookingId.Text.Trim() == string.Empty ? -1 : Convert.ToInt32(txtBookingId.Text));
            obj[3] = ViewState["TT"] == null ? (int?)null : Convert.ToInt32(ViewState["TT"].ToString());
            obj[4] = 1;
            ds = _pbook.GetBookingDetails(obj);          
            grdBookingDetails.DataSource = ds;
            grdBookingDetails.DataBind();
            trPassenger.Visible = false;
            TdPayment.Visible = false;            
        }
        protected void grdBookingDetails_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdBookingDetails.PageIndex = e.NewPageIndex;
            Bind();
        }
        protected void rbSelector_CheckedChanged(object sender, System.EventArgs e)
        {
            //Clear the existing selected row 
            foreach (GridViewRow oldrow in grdBookingDetails.Rows)
            {
                ((RadioButton)oldrow.FindControl("rbSelector")).Checked = false;
                oldrow.BackColor = System.Drawing.Color.White;
                oldrow.ForeColor = System.Drawing.Color.Black;
            }

            //Set the new selected row
            RadioButton rb = (RadioButton)sender;
            GridViewRow row = (GridViewRow)rb.NamingContainer;
            row.BackColor = System.Drawing.Color.SteelBlue;
            row.ForeColor = System.Drawing.Color.White;
            ((RadioButton)row.FindControl("rbSelector")).Checked = true;
            int BookingId = Convert.ToInt32(grdBookingDetails.DataKeys[((GridViewRow)((CheckBox)sender).Parent.Parent).RowIndex].Value);
            BindPassenger(BookingId);
            BindPayment(BookingId);

            if (btnSave.Text == "Cancel Ticket" || btnSave.Text == "Print Ticket")
            {
                btnSave.Enabled = true;
                ViewState["BookingID"] = BookingId;
            }
        }
        protected void BindPassenger(int BookingId=0)
        {
            object[] obj = new object[5];
            obj[0] = null;
            obj[1] = null;
            obj[2] = BookingId;
            obj[4] = 2;
            ds = _pbook.GetBookingDetails(obj);
            trPassenger.Visible = true;
            grdPassengerDetails.DataSource = ds;
            grdPassengerDetails.DataBind();           
        }
        protected void BindPayment(int BookingId = 0)
        {
            object[] obj = new object[5];
            obj[0] = null;
            obj[1] = null;
            obj[2] = BookingId;
            obj[4] = 3;
            ds = _pbook.GetBookingDetails(obj);
            TdPayment.Visible = true;
            grdPaymentDetails.DataSource = ds;
            grdPaymentDetails.DataBind();          
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.Text == "Cancel Ticket")
            {
                CancelTicket(Convert.ToInt32(ViewState["BookingID"]));
            }
            else if (btnSave.Text == "Print Ticket")
            {
                PrepareSessionforPrint(Convert.ToInt32(ViewState["BookingID"]));
            }
        }

        private void PrepareSessionforPrint(int BookingId)
        {
            object[] obj = new object[5];
            obj[0] = null;
            obj[1] = null;
            obj[2] = BookingId;
            obj[4] = 6;
            DataSet dsBooking =  _pbook.GetBookingDetails(obj);
            if (dsBooking.Tables.Count == 4)
            {
                Session["BookingId"] = BookingId;
                if (dsBooking.Tables[0].Rows.Count > 0)
                {
                    Session["Booking_Quoto_Name"] = dsBooking.Tables[0].Rows[0]["Quota_Type"];
                    Session["BusOperator"] = dsBooking.Tables[0].Rows[0]["Operator_Name"];
                    Session["BusType"] = dsBooking.Tables[0].Rows[0]["BUS_TYPE"];
                    Session["BusNo"] = dsBooking.Tables[0].Rows[0]["Bus_No"];
                    Session["Source"] = dsBooking.Tables[0].Rows[0]["BordingPoint"];
                    Session["Destination"] = dsBooking.Tables[0].Rows[0]["DestinationPoint"];
                    Session["DepartureTime"] = dsBooking.Tables[0].Rows[0]["TimeDeparture"];
                    Session["ArrivalTime"] = dsBooking.Tables[0].Rows[0]["TimeArrival"];
                    Session["Bording_Date"] = dsBooking.Tables[0].Rows[0]["BoRDING_Date"];
                    Session["Total_Passengers"] = dsBooking.Tables[0].Rows[0]["Total_Passengers"];
                }
                if (dsBooking.Tables[2].Rows.Count > 0)
                {
                    Session["TotalAmount"] = dsBooking.Tables[2].Rows[0]["TotalAmount"];
                }
                DataTable tblProcedure = new DataTable();
                if (dsBooking.Tables[1].Rows.Count > 0)
                {
                    tblProcedure = dsBooking.Tables[1];
                    Session["tblProcedure"] = tblProcedure;
                }

                Response.Redirect("PrintTicket.aspx");
            }

        }

        protected void txtBookingId_TextChanged(object sender, EventArgs e)
        {
            Bind();
        }

        protected void CancelTicket(int BookingId)
        {
            object[] obj = new object[5];
            obj[0] = null;
            obj[1] = Convert.ToInt32(Session["User_Type"].ToString());
            obj[2] = BookingId;
            obj[4] = 5;
            ds = _pbook.GetBookingDetails(obj);
            lblMsg.Visible = true;
            lblMsg.Text = ds.Tables[0].Rows[0][0].ToString();
        }       
    }
}