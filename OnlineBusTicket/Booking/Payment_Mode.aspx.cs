using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Net;
using System.Text;
using Microsoft.Data.SqlClient;

namespace OnlineBusTicket.Booking
{
    public partial class Payment_Mode : System.Web.UI.Page
    {
        DataTable tblProcedure = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                TabConPaymentMode.ActiveTabIndex = 0;
                bnkArea.Visible = true;
                crdNoArea.Visible = false;
                //Ok.Visible = false;
#region B
                BnkAreaB.Visible = true;
            //CardAreaB.Visible = false;
            //OkB.Visible = true;
#endregion
            }
        }

        public void funcSave()
        {
            //DataTable tblProcedure = new DataTable();
            //tblProcedure.Columns.Add(new DataColumn("sno", typeof(Int32)));
            //tblProcedure.Columns.Add(new DataColumn("First_Name", typeof(String)));
            //tblProcedure.Columns.Add(new DataColumn("Middle_Name", typeof(String)));
            //tblProcedure.Columns.Add(new DataColumn("Last_Name", typeof(String)));
            //tblProcedure.Columns.Add(new DataColumn("Gender", typeof(Int32)));
            //tblProcedure.Columns.Add(new DataColumn("Seat_No", typeof(Int32)));
            //tblProcedure.Columns.Add(new DataColumn("Seat_Type", typeof(Int32)));
            //tblProcedure.Columns.Add(new DataColumn("CreatedBy", typeof(String)));
            //tblProcedure.Columns.Add(new DataColumn("IsActive", typeof(Int32)));
            //ViewState["tblProcedure"] = tblProcedure;
            //DataRow drow1 = tblProcedure.NewRow();
            //drow1["Sno"] = 1;
            //drow1["First_Name"] = "Alok";
            //drow1["Middle_Name"] = "Kumar";
            //drow1["Last_Name"] = "Mishra";
            //drow1["Gender"] = 1;
            //drow1["Seat_No"] = Convert.ToInt32(Session["Pas1Seat"]); 
            //drow1["Seat_Type"] = "1";
            //drow1["CreatedBy"] = Convert.ToString(Session["Login"]);
            //drow1["IsActive"] = "1";
            //tblProcedure.Rows.Add(drow1);
            //DataRow drow2 = tblProcedure.NewRow();
            //drow2["Sno"] = 2;
            //drow2["First_Name"] = "Tanu";
            //drow2["Middle_Name"] = "Shree";
            //drow2["Last_Name"] = "Datta";
            //drow2["Gender"] = 2;
            //drow2["Seat_No"] = Convert.ToInt32(Session["Pas2Seat"]); 
            //drow2["Seat_Type"] = "1";
            //drow2["CreatedBy"] = Convert.ToString(Session["Login"]);
            //drow2["IsActive"] = "1";
            //tblProcedure.Rows.Add(drow2);
            //Session["BusOperator"] = "Sandhu Transport";
            //Session["BordingTime"] = "09:00";
            //Session["DepartureTime"] = "09:30";
            //Session["ArrivalTime"] = "17:50";
            //Session["BusType"] = "Volvo";
            //Session["User_ID"] = 1;
            //Session["User_Type"] = 1;
            //Session["Bus_ID"] = 1;
            //Session["Route_ID"] = 1;
            //Session["Bording_Date"] = DateTime.Now;
            //Session["Booking_Quoto"] = 1;
            //Session["Boarding_Point"] = 1;
            //Session["Destination_Point"] = 1;
            //Session["Ticket_Type"] = 1;
            //Session["Total_Passengers"] = 2;
            //Session["Login"] = "Ashu";
            //Session["TotalAmount"] = "1240";
            //Session["Email"] = "ashu@gmail.com";
            //Session["Mobile"] = "996822549";
            //Session["LandLine"] = "01203455";
            tblProcedure = (DataTable)Session["tblProcedure"];
            Session["PaymentMode"] = "1";
            Session["TransactionType"] = "2";
            string strcon = ConfigurationManager.ConnectionStrings["Connection String"].ToString();
            SqlConnection con = new SqlConnection(strcon);
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr = null;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.CommandText = "usp_ETicket_TRN_Booking";
            tblProcedure = (DataTable)Session["tblProcedure"];
            cmd.Parameters.AddWithValue("@tblPasangerDetail", tblProcedure);
            cmd.Parameters.AddWithValue("@Booking_ID", 0);
            if (Convert.ToInt32(Session["User_ID"]) == 0)
            {
                cmd.Parameters.AddWithValue("@User_ID", null);
            }
            else
            {
                cmd.Parameters.AddWithValue("@User_ID", Convert.ToInt32(Session["User_ID"]));
            }

            cmd.Parameters.AddWithValue("@User_Type", Convert.ToInt32(Session["User_Type"]));
            cmd.Parameters.AddWithValue("@Bus_ID", Convert.ToInt32(Session["Bus_ID"]));
            cmd.Parameters.AddWithValue("@Route_ID", Convert.ToInt32(Session["Route_ID"]));
            cmd.Parameters.AddWithValue("@BordingDate", Convert.ToDateTime(Session["Bording_Date"]));
            cmd.Parameters.AddWithValue("@Booking_Quoto", Convert.ToInt32(Session["Booking_Quoto"]));
            cmd.Parameters.AddWithValue("@Boarding_Point", Convert.ToInt32(Session["Boarding_Point"]));
            cmd.Parameters.AddWithValue("@Destination_Point", Convert.ToInt32(Session["Destination_Point"]));
            cmd.Parameters.AddWithValue("@Ticket_Type", Convert.ToInt32(Session["Ticket_Type"]));
            cmd.Parameters.AddWithValue("@Total_Passengers", Convert.ToInt32(Session["Total_Passengers"]));
            cmd.Parameters.AddWithValue("@Total_Amount", Convert.ToDecimal(Session["TotalAmount"]));
            cmd.Parameters.AddWithValue("@CreatedBy", Convert.ToString(Session["LogIN"]));
            cmd.Parameters.AddWithValue("@Email", Convert.ToString(Session["Email"]));
            cmd.Parameters.AddWithValue("@Mobile", Convert.ToString(Session["Mobile"]));
            cmd.Parameters.AddWithValue("@Landline", Convert.ToString(Session["LandLine"]));
            cmd.Parameters.AddWithValue("@PaymentMode", Convert.ToInt32(Session["PaymentMode"]));
            cmd.Parameters.AddWithValue("@TransactionType", Convert.ToInt32(Session["TransactionType"]));
            cmd.Parameters.AddWithValue("@flag", 1);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Session["BookingId"] = dr["Booking_ID"].ToString();
                }
            }
            else
            {
            }
        }

        public bool SendMail(string _fromaddress, string _fromname, string _toaddress, string _toname, string _subject, string _body, bool hasattachment)
        {
            try
            {
                System.Net.Mail.MailMessage _mailMessage = new System.Net.Mail.MailMessage();
                _mailMessage.From = new System.Net.Mail.MailAddress(_fromaddress, _fromname);
                _mailMessage.To.Add(new System.Net.Mail.MailAddress(_toaddress, _toname));
                _mailMessage.Subject = _subject;
                if (hasattachment)
                {
                    _mailMessage.Attachments.Add(new System.Net.Mail.Attachment(Server.MapPath("ticket.pdf")));
                }

                _mailMessage.Body = _body;
                _mailMessage.IsBodyHtml = true;
                System.Net.Mail.SmtpClient _smtpClient = new System.Net.Mail.SmtpClient("smtp.gmail.com", 587);
                _smtpClient.EnableSsl = true;
                _smtpClient.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
                System.Net.NetworkCredential _NetworkCredential = new NetworkCredential("hclpochelp@gmail.com", "hcl@123456");
                _smtpClient.UseDefaultCredentials = false;
                _smtpClient.Credentials = _NetworkCredential;
                _smtpClient.Send(_mailMessage);
                _mailMessage.Dispose();
                _smtpClient = null;
            }
            catch (Exception ex)
            {
            }

            return true;
        }

        public static string ticketconfimationlBody(string username, string visitdate, string numberofadults, string numberofchilderns, string ticketfare)
        {
            string url = HttpContext.Current.Request.Url.AbsoluteUri;
            //url = url.Substring(0, url.LastIndexOf("/")) + "/" + "managerApproval.aspx";
            StringBuilder sb = new StringBuilder();
            sb.Append("<table width='100%' border='2' style='border-color:#006699'>");
            sb.Append(@"<tr><td  style='height:45px; background-color:#41556D; color:White' align='center'><h1>E-Ticketing POC</h1></td></tr>");
            sb.Append("<tr><td>");
            sb.Append(@"<div style='COLOR:#3366CC; font-size:15px'");
            sb.Append(@"<p>Hi," + username + "</p>");
            //sb.Append(@"<p>Your ticket has booked for visit on  " + visitdate + " for " + numberofadults + " and " + numberofchilderns + "  </p>");
            sb.Append(@"<p>Your ticket has booked for travel on  " + visitdate + " </p>");
            //sb.Append(@"<p>Your total ticket fare is " + ticketfare + "   </p>");
            sb.Append(@"<p>Your Ticket is attached with the mail ,Kindly do not forget to take printout of the same  </p>");
            sb.Append(@"<p>Please visit :</p>");
            sb.Append("<a href=");
            sb.Append(url);
            sb.Append(" style='color:#00858A'>");
            sb.Append(url);
            sb.Append("</a></P>");
            sb.Append("</div >");
            sb.Append(@"<br /></td></tr></table>");
            return sb.ToString();
        }

        private void Checked()
        {
            rbICICI.Checked = false;
            rbHDFC.Checked = false;
            rbAXIS.Checked = false;
            rbCITI.Checked = false;
            rbAmcnExp.Checked = false;
        }

        protected void rbICICI_CheckedChanged(object sender, EventArgs e)
        {
            bnkArea.Visible = true;
            crdNoArea.Visible = true;
            Checked();
            rbICICI.Checked = true;
        }

        protected void rbHDFC_CheckedChanged(object sender, EventArgs e)
        {
            bnkArea.Visible = true;
            crdNoArea.Visible = true;
            Checked();
            rbHDFC.Checked = true;
        }

        protected void rbAXIS_CheckedChanged(object sender, EventArgs e)
        {
            bnkArea.Visible = true;
            crdNoArea.Visible = true;
            Checked();
            rbAXIS.Checked = true;
        }

        protected void rbCITI_CheckedChanged(object sender, EventArgs e)
        {
            bnkArea.Visible = true;
            crdNoArea.Visible = true;
            Checked();
            rbCITI.Checked = true;
        }

        protected void rbAmcnExp_CheckedChanged(object sender, EventArgs e)
        {
            bnkArea.Visible = true;
            crdNoArea.Visible = true;
            Checked();
            rbAmcnExp.Checked = true;
        }

        protected void lblSubmit_Click(object sender, EventArgs e)
        {
            bnkArea.Visible = false;
            crdNoArea.Visible = false;
            funcSave();
            string ticketmailbody = ticketconfimationlBody(Convert.ToString(Session["Login"]), "12/02/2012", "Adult", "Child", Convert.ToString(Session["Total_Passengers"]));
            SendMail("hclpochelp@gmail.com", Convert.ToString(Session["Login"]), "hclpochelp@gmail.com", "E-Ticket Booking", "Tickets booked ", ticketmailbody, true);
            string[] test = {"1", "2"};
            System.IO.File.WriteAllLines("D:\\test.txt", test);
            Response.Redirect("ToPDFPrint.aspx?TicketNo=" + Convert.ToInt32(Session["BookingId"]));
        }

        protected void rbICICIB_CheckedChanged(object sender, EventArgs e)
        {
            BnkAreaB.Visible = true;
            crdNoArea.Visible = true;
            rbICICI_CheckedChanged(sender, e);
        }

        protected void rbHDFCB_CheckedChanged(object sender, EventArgs e)
        {
            BnkAreaB.Visible = false;
            //CardAreaB.Visible = true;
            rbICICI_CheckedChanged(sender, e);
        }

        protected void rbAXISB_CheckedChanged(object sender, EventArgs e)
        {
            BnkAreaB.Visible = false;
            //CardAreaB.Visible = true;
            rbICICI_CheckedChanged(sender, e);
        }

        protected void rbIDBIB_CheckedChanged(object sender, EventArgs e)
        {
            BnkAreaB.Visible = true;
            crdNoArea.Visible = true;
            rbICICI_CheckedChanged(sender, e);
        }

        protected void rbSBIB_CheckedChanged(object sender, EventArgs e)
        {
            BnkAreaB.Visible = true;
            crdNoArea.Visible = true;
            rbICICI_CheckedChanged(sender, e);
        }

        protected void rbPNBB_CheckedChanged(object sender, EventArgs e)
        {
            BnkAreaB.Visible = true;
            crdNoArea.Visible = true;
            rbICICI_CheckedChanged(sender, e);
        }

        protected void rbFBB_CheckedChanged(object sender, EventArgs e)
        {
            BnkAreaB.Visible = true;
            crdNoArea.Visible = true;
            rbICICI_CheckedChanged(sender, e);
        }

        protected void rbSBB_CheckedChanged(object sender, EventArgs e)
        {
            BnkAreaB.Visible = true;
            crdNoArea.Visible = true;
            rbICICI_CheckedChanged(sender, e);
        }

        protected void rbIBB_CheckedChanged(object sender, EventArgs e)
        {
            BnkAreaB.Visible = false;
        //CardAreaB.Visible = true;
        }

        protected void rbKBB_CheckedChanged(object sender, EventArgs e)
        {
            BnkAreaB.Visible = true;
            crdNoArea.Visible = true;
            rbICICI_CheckedChanged(sender, e);
        }

        protected void rbABB_CheckedChanged(object sender, EventArgs e)
        {
            BnkAreaB.Visible = true;
            crdNoArea.Visible = true;
            rbICICI_CheckedChanged(sender, e);
        }

        protected void rbOBCB_CheckedChanged(object sender, EventArgs e)
        {
            BnkAreaB.Visible = true;
            crdNoArea.Visible = true;
            rbICICI_CheckedChanged(sender, e);
        }

        protected void rbCBB_CheckedChanged(object sender, EventArgs e)
        {
            BnkAreaB.Visible = true;
            crdNoArea.Visible = true;
            rbICICI_CheckedChanged(sender, e);
        }

        protected void rbBIB_CheckedChanged(object sender, EventArgs e)
        {
            BnkAreaB.Visible = true;
            crdNoArea.Visible = true;
            rbICICI_CheckedChanged(sender, e);
        }

        protected void rbIBBI_CheckedChanged(object sender, EventArgs e)
        {
            BnkAreaB.Visible = true;
            crdNoArea.Visible = true;
            rbICICI_CheckedChanged(sender, e);
        }

        protected void rbSBIABB_CheckedChanged(object sender, EventArgs e)
        {
            BnkAreaB.Visible = true;
            crdNoArea.Visible = true;
            rbICICI_CheckedChanged(sender, e);
        }

        protected void rbUBIBB_CheckedChanged(object sender, EventArgs e)
        {
            BnkAreaB.Visible = true;
            crdNoArea.Visible = true;
            rbICICI_CheckedChanged(sender, e);
        }

        protected void rbBOBB_CheckedChanged(object sender, EventArgs e)
        {
            BnkAreaB.Visible = true;
            crdNoArea.Visible = true;
            rbICICI_CheckedChanged(sender, e);
        }

        protected void btnSubmitB_Click(object sender, EventArgs e)
        {
            BnkAreaB.Visible = true;
            crdNoArea.Visible = true;
            rbICICI_CheckedChanged(sender, e);
            //OkB.Visible = true;
            int i = Convert.ToInt32(Session["TicketID"]);
            Response.Redirect("ToPDFPrint.aspx?TicketNo=" + i);
        }
    }
}