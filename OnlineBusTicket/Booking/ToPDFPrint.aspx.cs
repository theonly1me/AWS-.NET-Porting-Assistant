using System;
using System.Web;
using System.Data;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;
using System.Net;
using System.Text;
using DataTransmission.Masters;
namespace OnlineBusTicket.Booking
{
    public partial class ToPDFPrint : System.Web.UI.Page
    {
        Location location;
        PLocation plocation = new PLocation();

        DataSet ds = new DataSet();
        DataTable dt;
        DataTable tblProcedure = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    //#region faltu

                    //Session["BookingId"] = "123455";
                    //Session["BusOperator"] = "Sandhu Transport";
                    //Session["BusNo"] = "UP 75 A-2709";
                    //Session["Booking_Quoto_Name"] = "Gen";


                    ////Session["BordingTime"] = "09:00";
                    //Session["DepartureTime"] = "09:30";
                    //Session["ArrivalTime"] = "17:50";
                    //Session["BusType"] = "Volvo";
                    //Session["Source"] = "New-Delhi";
                    //Session["Destination"] = "Agra";

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
                    //Session["SeatNos"] = "22,23,24,25,26,27";
                    //Session["TotalAmount"] = "1240";
                    //Session["Login"] = "Ashu";

                    //string[] words = Convert.ToString(Session["SeatNos"]).Split(',');
                    //Session["Pas1Seat"] = words[0];
                    //Session["Pas2Seat"] = words[1];

                    //Session["Email"] = "ashu@asd";
                    //Session["Mobile"] = "0991";
                    //Session["LandLine"] = "123";
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
                    //Session["tblProcedure"] = tblProcedure;

                    //#endregion
                    funcHotelImage(Convert.ToInt32(Session["Destination_Point"]));

                    lblTicketNo.Text = Convert.ToString(Session["BookingId"]);
                    lblTicketNoHeading.Text = Convert.ToString(Session["BookingId"]);
                    lblQuota.Text = Convert.ToString(Session["Booking_Quoto_Name"]);

                    lblBusOperator.Text = Convert.ToString(Session["BusOperator"]);
                    lblBusType.Text = Convert.ToString(Session["BusType"]);
                    lblBusNo.Text = Convert.ToString(Session["BusNo"]);

                    lblBusSource.Text = Convert.ToString(Session["Source"]);
                    lblBusUpto.Text = Convert.ToString(Session["Destination"]);

                    lblDepartureTime.Text = Convert.ToString(Session["DepartureTime"]);
                    lblBordingTime.Text = Convert.ToString(Session["DepartureTime"]);
                    lblArrivalTime.Text = Convert.ToString(Session["ArrivalTime"]);

                    lblBoardingDate.Text = Convert.ToDateTime(Session["Bording_Date"]).ToString("dd-MMM-yyyy");

                    lblNoOfPassenger.Text = Convert.ToString(Session["Total_Passengers"]);
                    lbltotalFare.Text = Convert.ToString(Session["TotalAmount"]);

                    lblBordingFrom.Text = Convert.ToString(Session["Source"]);

                    tr1.Visible = false;
                    tr2.Visible = false;
                    tr3.Visible = false;
                    tr4.Visible = false;
                    tr5.Visible = false;
                    tr6.Visible = false;

                    tblProcedure = (DataTable)Session["tblProcedure"];
                    if (tblProcedure.Rows.Count > 0)
                    {

                        if (Convert.ToString(Session["Total_Passengers"]) == "1")
                        {
                            tr1.Visible = true;

                            txtPas1Name.Text = Convert.ToString(tblProcedure.Rows[0]["First_Name"]) + " " + Convert.ToString(tblProcedure.Rows[0]["Middle_Name"]) + " " + Convert.ToString(tblProcedure.Rows[0]["Last_Name"]);
                            lblPas1SeatNo.Text = Convert.ToString(Session["Pas1Seat"]);

                        }
                        else if (Convert.ToString(Session["Total_Passengers"]) == "2")
                        {
                            tr1.Visible = true;
                            tr2.Visible = true;

                            txtPas1Name.Text = Convert.ToString(tblProcedure.Rows[0]["First_Name"]) + " " + Convert.ToString(tblProcedure.Rows[0]["Middle_Name"]) + " " + Convert.ToString(tblProcedure.Rows[0]["Last_Name"]);
                            lblPas1SeatNo.Text = Convert.ToString(Session["Pas1Seat"]);

                            txtPas2Name.Text = Convert.ToString(tblProcedure.Rows[1]["First_Name"]) + " " + Convert.ToString(tblProcedure.Rows[1]["Middle_Name"]) + " " + Convert.ToString(tblProcedure.Rows[1]["Last_Name"]);
                            lblPas2SeatNo.Text = Convert.ToString(Session["Pas2Seat"]);



                        }
                        else if (Convert.ToString(Session["Total_Passengers"]) == "3")
                        {
                            tr1.Visible = true;
                            tr2.Visible = true;
                            tr3.Visible = true;

                            txtPas1Name.Text = Convert.ToString(tblProcedure.Rows[0]["First_Name"]) + " " + Convert.ToString(tblProcedure.Rows[0]["Middle_Name"]) + " " + Convert.ToString(tblProcedure.Rows[0]["Last_Name"]);
                            lblPas1SeatNo.Text = Convert.ToString(Session["Pas1Seat"]);

                            txtPas2Name.Text = Convert.ToString(tblProcedure.Rows[1]["First_Name"]) + " " + Convert.ToString(tblProcedure.Rows[1]["Middle_Name"]) + " " + Convert.ToString(tblProcedure.Rows[1]["Last_Name"]);
                            lblPas2SeatNo.Text = Convert.ToString(Session["Pas2Seat"]);

                            txtPas3Name.Text = Convert.ToString(tblProcedure.Rows[2]["First_Name"]) + " " + Convert.ToString(tblProcedure.Rows[2]["Middle_Name"]) + " " + Convert.ToString(tblProcedure.Rows[2]["Last_Name"]);
                            lblPas3SeatNo.Text = Convert.ToString(Session["Pas3Seat"]);



                        }
                        else if (Convert.ToString(Session["Total_Passengers"]) == "4")
                        {
                            tr1.Visible = true;
                            tr2.Visible = true;
                            tr3.Visible = true;
                            tr4.Visible = true;

                            txtPas1Name.Text = Convert.ToString(tblProcedure.Rows[0]["First_Name"]) + " " + Convert.ToString(tblProcedure.Rows[0]["Middle_Name"]) + " " + Convert.ToString(tblProcedure.Rows[0]["Last_Name"]);
                            lblPas1SeatNo.Text = Convert.ToString(Session["Pas1Seat"]);

                            txtPas2Name.Text = Convert.ToString(tblProcedure.Rows[1]["First_Name"]) + " " + Convert.ToString(tblProcedure.Rows[1]["Middle_Name"]) + " " + Convert.ToString(tblProcedure.Rows[1]["Last_Name"]);
                            lblPas2SeatNo.Text = Convert.ToString(Session["Pas2Seat"]);

                            txtPas3Name.Text = Convert.ToString(tblProcedure.Rows[2]["First_Name"]) + " " + Convert.ToString(tblProcedure.Rows[2]["Middle_Name"]) + " " + Convert.ToString(tblProcedure.Rows[2]["Last_Name"]);
                            lblPas3SeatNo.Text = Convert.ToString(Session["Pas3Seat"]);

                            txtPas4Name.Text = Convert.ToString(tblProcedure.Rows[3]["First_Name"]) + " " + Convert.ToString(tblProcedure.Rows[3]["Middle_Name"]) + " " + Convert.ToString(tblProcedure.Rows[3]["Last_Name"]);
                            lblPas4SeatNo.Text = Convert.ToString(Session["Pas4Seat"]);




                        }
                        else if (Convert.ToString(Session["Total_Passengers"]) == "5")
                        {
                            tr1.Visible = true;
                            tr2.Visible = true;
                            tr3.Visible = true;
                            tr4.Visible = true;
                            tr5.Visible = true;

                            txtPas1Name.Text = Convert.ToString(tblProcedure.Rows[0]["First_Name"]) + " " + Convert.ToString(tblProcedure.Rows[0]["Middle_Name"]) + " " + Convert.ToString(tblProcedure.Rows[0]["Last_Name"]);
                            lblPas1SeatNo.Text = Convert.ToString(Session["Pas1Seat"]);

                            txtPas2Name.Text = Convert.ToString(tblProcedure.Rows[1]["First_Name"]) + " " + Convert.ToString(tblProcedure.Rows[1]["Middle_Name"]) + " " + Convert.ToString(tblProcedure.Rows[1]["Last_Name"]);
                            lblPas2SeatNo.Text = Convert.ToString(Session["Pas2Seat"]);

                            txtPas3Name.Text = Convert.ToString(tblProcedure.Rows[2]["First_Name"]) + " " + Convert.ToString(tblProcedure.Rows[2]["Middle_Name"]) + " " + Convert.ToString(tblProcedure.Rows[2]["Last_Name"]);
                            lblPas3SeatNo.Text = Convert.ToString(Session["Pas3Seat"]);

                            txtPas4Name.Text = Convert.ToString(tblProcedure.Rows[3]["First_Name"]) + " " + Convert.ToString(tblProcedure.Rows[3]["Middle_Name"]) + " " + Convert.ToString(tblProcedure.Rows[3]["Last_Name"]);
                            lblPas4SeatNo.Text = Convert.ToString(Session["Pas4Seat"]);

                            txtPas5Name.Text = Convert.ToString(tblProcedure.Rows[4]["First_Name"]) + " " + Convert.ToString(tblProcedure.Rows[4]["Middle_Name"]) + " " + Convert.ToString(tblProcedure.Rows[4]["Last_Name"]);
                            lblPas5SeatNo.Text = Convert.ToString(Session["Pas5Seat"]);



                        }
                        else if (Convert.ToString(Session["Total_Passengers"]) == "6")
                        {
                            tr1.Visible = true;
                            tr2.Visible = true;
                            tr3.Visible = true;
                            tr4.Visible = true;
                            tr5.Visible = true;
                            tr6.Visible = true;

                            txtPas1Name.Text = Convert.ToString(tblProcedure.Rows[0]["First_Name"]) + " " + Convert.ToString(tblProcedure.Rows[0]["Middle_Name"]) + " " + Convert.ToString(tblProcedure.Rows[0]["Last_Name"]);
                            lblPas1SeatNo.Text = Convert.ToString(Session["Pas1Seat"]);

                            txtPas2Name.Text = Convert.ToString(tblProcedure.Rows[1]["First_Name"]) + " " + Convert.ToString(tblProcedure.Rows[1]["Middle_Name"]) + " " + Convert.ToString(tblProcedure.Rows[1]["Last_Name"]);
                            lblPas2SeatNo.Text = Convert.ToString(Session["Pas2Seat"]);

                            txtPas3Name.Text = Convert.ToString(tblProcedure.Rows[2]["First_Name"]) + " " + Convert.ToString(tblProcedure.Rows[2]["Middle_Name"]) + " " + Convert.ToString(tblProcedure.Rows[2]["Last_Name"]);
                            lblPas3SeatNo.Text = Convert.ToString(Session["Pas3Seat"]);

                            txtPas4Name.Text = Convert.ToString(tblProcedure.Rows[3]["First_Name"]) + " " + Convert.ToString(tblProcedure.Rows[3]["Middle_Name"]) + " " + Convert.ToString(tblProcedure.Rows[3]["Last_Name"]);
                            lblPas4SeatNo.Text = Convert.ToString(Session["Pas4Seat"]);

                            txtPas5Name.Text = Convert.ToString(tblProcedure.Rows[4]["First_Name"]) + " " + Convert.ToString(tblProcedure.Rows[4]["Middle_Name"]) + " " + Convert.ToString(tblProcedure.Rows[4]["Last_Name"]);
                            lblPas5SeatNo.Text = Convert.ToString(Session["Pas5Seat"]);

                            txtPas6Name.Text = Convert.ToString(tblProcedure.Rows[5]["First_Name"]) + " " + Convert.ToString(tblProcedure.Rows[5]["Middle_Name"]) + " " + Convert.ToString(tblProcedure.Rows[5]["Last_Name"]);
                            lblPas6SeatNo.Text = Convert.ToString(Session["Pas6Seat"]);


                        }
                    }


                    eticket();
                    string ticketmailbody = ticketconfimationlBody(Convert.ToString(Session["Login"]), Convert.ToDateTime(Session["Bording_Date"]).ToString("dd-MMM-yyyy"), "Adult", "Child", Convert.ToString(Session["Total_Passengers"]));
                    string[] test = { "1", "2" };
                    System.IO.File.WriteAllLines("D:\\test.txt", test);
                }
            }
            catch (Exception ex)
            {
                trMsg.Visible = true;
            }
        }

        protected void btnToPDF_Click(object sender, EventArgs e)
        {

        }
        public void funcHotelImage(Int32 LocId)
        {
            try
            {
                location = new Location();
                location.LocationID = LocId;
                location.OFlag = 5;
                DataTable dt = plocation.GetLocationdescription(location);
                if (dt.Rows.Count >= 3)
                {
                    imgHotel1.ImageUrl = Convert.ToString(dt.Rows[0]["ImageUrl"]);
                    imgHotel2.ImageUrl = Convert.ToString(dt.Rows[1]["ImageUrl"]);
                    imgHotel3.ImageUrl = Convert.ToString(dt.Rows[2]["ImageUrl"]);


                    lblHotel1Name.Text = Convert.ToString(dt.Rows[0]["HotelName"]);
                    lblHotel1Address.Text = Convert.ToString(dt.Rows[0]["HotelAddress"]);
                    lblHotel1City.Text = Convert.ToString(dt.Rows[0]["Location_Name"]);
                    lblHotel1Phone.Text = Convert.ToString(dt.Rows[0]["HotelMobileNo"]);

                    lblHotel2Name.Text = Convert.ToString(dt.Rows[1]["HotelName"]);
                    lblHotel2Address.Text = Convert.ToString(dt.Rows[1]["HotelAddress"]);
                    lblHotel2City.Text = Convert.ToString(dt.Rows[1]["Location_Name"]);
                    lblHotel2Phone.Text = Convert.ToString(dt.Rows[1]["HotelMobileNo"]);

                    lblHotel3Name.Text = Convert.ToString(dt.Rows[2]["HotelName"]);
                    lblHotel3Address.Text = Convert.ToString(dt.Rows[2]["HotelAddress"]);
                    lblHotel3City.Text = Convert.ToString(dt.Rows[2]["Location_Name"]);
                    lblHotel3Phone.Text = Convert.ToString(dt.Rows[2]["HotelMobileNo"]);




                }
                else if (dt.Rows.Count >= 2)
                {
                    imgHotel1.ImageUrl = Convert.ToString(dt.Rows[0]["ImageUrl"]);
                    imgHotel2.ImageUrl = Convert.ToString(dt.Rows[1]["ImageUrl"]);

                    lblHotel1Name.Text = Convert.ToString(dt.Rows[0]["HotelName"]);
                    lblHotel1Address.Text = Convert.ToString(dt.Rows[0]["HotelAddress"]);
                    lblHotel1City.Text = Convert.ToString(dt.Rows[0]["Location_Name"]);
                    lblHotel1Phone.Text = Convert.ToString(dt.Rows[0]["HotelMobileNo"]);

                    lblHotel2Name.Text = Convert.ToString(dt.Rows[1]["HotelName"]);
                    lblHotel2Address.Text = Convert.ToString(dt.Rows[1]["HotelAddress"]);
                    lblHotel2City.Text = Convert.ToString(dt.Rows[1]["Location_Name"]);
                    lblHotel2Phone.Text = Convert.ToString(dt.Rows[1]["HotelMobileNo"]);


                }
                else if (dt.Rows.Count >= 1)
                {
                    imgHotel1.ImageUrl = Convert.ToString(dt.Rows[0]["ImageUrl"]);

                    lblHotel1Name.Text = Convert.ToString(dt.Rows[0]["HotelName"]);
                    lblHotel1Address.Text = Convert.ToString(dt.Rows[0]["HotelAddress"]);
                    lblHotel1City.Text = Convert.ToString(dt.Rows[0]["Location_Name"]);
                    lblHotel1Phone.Text = Convert.ToString(dt.Rows[0]["HotelMobileNo"]);



                }
                else
                {
                    //    imgHotel1.ImageUrl = Convert.ToString(dt.Rows[0]["ImageUrl"]);
                    //    imgHotel2.ImageUrl = Convert.ToString(dt.Rows[1]["ImageUrl"]);
                    //    imgHotel3.ImageUrl = Convert.ToString(dt.Rows[2]["ImageUrl"]);


                    lblHotel1Name.Text = "";
                    lblHotel1Address.Text = "";
                    lblHotel1City.Text = "";
                    lblHotel1Phone.Text = "";

                    lblHotel2Name.Text = "";
                    lblHotel2Address.Text = "";
                    lblHotel2City.Text = "";
                    lblHotel2Phone.Text = "";

                    lblHotel3Name.Text = "";
                    lblHotel3Address.Text = "";
                    lblHotel3City.Text = "";
                    lblHotel3Phone.Text = "";

                }
            }
            catch (Exception ex)
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
            StringBuilder sb = new StringBuilder();
            sb.Append("<table width='100%' border='2' style='border-color:#006699'>");
            sb.Append(@"<tr><td  style='height:45px; background-color:#41556D; color:White' align='center'><h1>Archeological Survey of India - POC</h1></td></tr>");
            sb.Append("<tr><td>");
            sb.Append(@"<div style='COLOR:#3366CC; font-size:15px'");
            sb.Append(@"<p>Hi," + username + "</p>");
            sb.Append(@"<p>Your ticket has booked for visit on  " + visitdate + " for " + numberofadults + " and " + numberofchilderns + "  </p>");
            sb.Append(@"<p>Your total ticket fare is " + ticketfare + "   </p>");
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

        protected void btn_Replan_Click(object sender, EventArgs e)
        {
            Response.Redirect("~\\Default.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("ticket.pdf");
        }

        protected void eticket()
        {
            try
            {
                string strDelete = Server.MapPath("Ticket\\");
                System.IO.DirectoryInfo downloadedMessageInfo = new DirectoryInfo(strDelete); 
                foreach (FileInfo file in downloadedMessageInfo.GetFiles()) 
                {
                    file.Delete(); 
                } 
            }
            catch (Exception ex)
            {

            }
            
            string newFile = Server.MapPath("Ticket\\"+Convert.ToString(Session["BookingId"]) + ".pdf");
            hidfldTicketNo.Value = Convert.ToString("Ticket\\"+ Session["BookingId"] + ".pdf");
            string imagepath = Server.MapPath("~\\Images\\e-ticketing.jpg");
            Document document = new Document();
          
            FileStream fs = new FileStream(newFile, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite, 1000, FileOptions.Asynchronous);
            PdfWriter writer = PdfWriter.GetInstance(document, fs);
            document.Open();

            iTextSharp.text.Image pic = iTextSharp.text.Image.GetInstance(imagepath);
            document.AddTitle(" ");


            PdfPTable table0 = new PdfPTable(1);
            PdfPTable tableImg = new PdfPTable(4);
            PdfPTable table = new PdfPTable(4);
            PdfPTable tableTicket = new PdfPTable(2);
            PdfPTable table1 = new PdfPTable(1);
            PdfPTable table2 = new PdfPTable(2);
            PdfPTable table3 = new PdfPTable(1);
            #region Image
            float width = pic.Width;
            PdfPCell cell = new PdfPCell();
            cell.AddElement(pic);
            cell.Colspan = 4;
            cell.HorizontalAlignment = 1;
            tableImg.AddCell(cell);
            document.Add(tableImg);
            #endregion

            #region Transporter
            table2 = new PdfPTable(2);
            table2.AddCell("Ticket No   : " + Convert.ToString(Session["BookingId"]));
            table2.AddCell("Quota    : " + Convert.ToString(Session["Booking_Quoto_Name"]));
            document.Add(table2);
            #endregion

            #region Transporter
            table0 = new PdfPTable(1);
            table0.AddCell("Bus Operator          : " + Convert.ToString(Session["BusOperator"]));
            document.Add(table0);

            #endregion

            #region First Lagend
            #region 2rd Row
            table.AddCell("BusNo");
            table.AddCell(": " + Convert.ToString(Session["BusNo"]));
            table.AddCell("BusType");
            table.AddCell(": " + Convert.ToString(Session["BusType"]));
            #endregion
            #region 3rd Row
            table.AddCell("From");
            table.AddCell(": " + Convert.ToString(Session["Source"]));
            table.AddCell("To");
            table.AddCell(": " + Convert.ToString(Session["Destination"]));
            #endregion
            #region 4rd Row
            table.AddCell("Dep.Time");
            table.AddCell(": " + Convert.ToString(Session["DepartureTime"]));
            table.AddCell("Arr.Time");
            table.AddCell(": " + Convert.ToString(Session["ArrivalTime"]));
            #endregion
            #region 5rd Row
            table.AddCell("Total Fair");
            table.AddCell(": " + Convert.ToString(Session["TotalAmount"]));
            table.AddCell("Total Passengers");
            table.AddCell(": " + Convert.ToString(Session["Total_Passengers"]));
            #endregion

            document.Add(table);
            #endregion

            #region Passanger Detail
            table1 = new PdfPTable(1);
            String sBody = "";
            tblProcedure = (DataTable)Session["tblProcedure"];
            if (Convert.ToString(Session["Total_Passengers"]) == "1")
            {
                sBody = "Passanger 1 : Seat No : " + Convert.ToString(Session["Pas1Seat"]) + " : " + Convert.ToString(tblProcedure.Rows[0]["First_Name"]) + " " + Convert.ToString(tblProcedure.Rows[0]["Middle_Name"]) + " " + Convert.ToString(tblProcedure.Rows[0]["Last_Name"]);
                table1.AddCell(sBody);
            }
            if (Convert.ToString(Session["Total_Passengers"]) == "2")
            {
                sBody = "Passanger 1 : Seat No : " + Convert.ToString(Session["Pas1Seat"]) + " : " + Convert.ToString(tblProcedure.Rows[0]["First_Name"]) + " " + Convert.ToString(tblProcedure.Rows[0]["Middle_Name"]) + " " + Convert.ToString(tblProcedure.Rows[0]["Last_Name"]);
                table1.AddCell(sBody);

                sBody = "Passanger 2 : Seat No : " + Convert.ToString(Session["Pas2Seat"]) + " : " + Convert.ToString(tblProcedure.Rows[1]["First_Name"]) + " " + Convert.ToString(tblProcedure.Rows[1]["Middle_Name"]) + " " + Convert.ToString(tblProcedure.Rows[1]["Last_Name"]);
                table1.AddCell(sBody);
            }
            if (Convert.ToString(Session["Total_Passengers"]) == "3")
            {
                sBody = "Passanger 1 : Seat No : " + Convert.ToString(Session["Pas1Seat"]) + " : " + Convert.ToString(tblProcedure.Rows[0]["First_Name"]) + " " + Convert.ToString(tblProcedure.Rows[0]["Middle_Name"]) + " " + Convert.ToString(tblProcedure.Rows[0]["Last_Name"]);
                table1.AddCell(sBody);

                sBody = "Passanger 2 : Seat No : " + Convert.ToString(Session["Pas2Seat"]) + " : " + Convert.ToString(tblProcedure.Rows[1]["First_Name"]) + " " + Convert.ToString(tblProcedure.Rows[1]["Middle_Name"]) + " " + Convert.ToString(tblProcedure.Rows[1]["Last_Name"]);
                table1.AddCell(sBody);

                sBody = "Passanger 3 : Seat No : " + Convert.ToString(Session["Pas3Seat"]) + " : " + Convert.ToString(tblProcedure.Rows[2]["First_Name"]) + " " + Convert.ToString(tblProcedure.Rows[2]["Middle_Name"]) + " " + Convert.ToString(tblProcedure.Rows[2]["Last_Name"]);
                table1.AddCell(sBody);
            }
            if (Convert.ToString(Session["Total_Passengers"]) == "4")
            {
                sBody = "Passanger 1 : Seat No : " + Convert.ToString(Session["Pas1Seat"]) + " : " + Convert.ToString(tblProcedure.Rows[0]["First_Name"]) + " " + Convert.ToString(tblProcedure.Rows[0]["Middle_Name"]) + " " + Convert.ToString(tblProcedure.Rows[0]["Last_Name"]);
                table1.AddCell(sBody);

                sBody = "Passanger 2 : Seat No : " + Convert.ToString(Session["Pas2Seat"]) + " : " + Convert.ToString(tblProcedure.Rows[1]["First_Name"]) + " " + Convert.ToString(tblProcedure.Rows[1]["Middle_Name"]) + " " + Convert.ToString(tblProcedure.Rows[1]["Last_Name"]);
                table1.AddCell(sBody);

                sBody = "Passanger 3 : Seat No : " + Convert.ToString(Session["Pas3Seat"]) + " : " + Convert.ToString(tblProcedure.Rows[2]["First_Name"]) + " " + Convert.ToString(tblProcedure.Rows[2]["Middle_Name"]) + " " + Convert.ToString(tblProcedure.Rows[2]["Last_Name"]);
                table1.AddCell(sBody);

                sBody = "Passanger 4 : Seat No : " + Convert.ToString(Session["Pas4Seat"]) + " : " + Convert.ToString(tblProcedure.Rows[3]["First_Name"]) + " " + Convert.ToString(tblProcedure.Rows[3]["Middle_Name"]) + " " + Convert.ToString(tblProcedure.Rows[3]["Last_Name"]);
                table1.AddCell(sBody);
            }
            if (Convert.ToString(Session["Total_Passengers"]) == "5")
            {
                sBody = "Passanger 1 : Seat No : " + Convert.ToString(Session["Pas1Seat"]) + " : " + Convert.ToString(tblProcedure.Rows[0]["First_Name"]) + " " + Convert.ToString(tblProcedure.Rows[0]["Middle_Name"]) + " " + Convert.ToString(tblProcedure.Rows[0]["Last_Name"]);
                table1.AddCell(sBody);

                sBody = "Passanger 2 : Seat No : " + Convert.ToString(Session["Pas2Seat"]) + " : " + Convert.ToString(tblProcedure.Rows[1]["First_Name"]) + " " + Convert.ToString(tblProcedure.Rows[1]["Middle_Name"]) + " " + Convert.ToString(tblProcedure.Rows[1]["Last_Name"]);
                table1.AddCell(sBody);

                sBody = "Passanger 3 : Seat No : " + Convert.ToString(Session["Pas3Seat"]) + " : " + Convert.ToString(tblProcedure.Rows[2]["First_Name"]) + " " + Convert.ToString(tblProcedure.Rows[2]["Middle_Name"]) + " " + Convert.ToString(tblProcedure.Rows[2]["Last_Name"]);
                table1.AddCell(sBody);

                sBody = "Passanger 4 : Seat No : " + Convert.ToString(Session["Pas4Seat"]) + " : " + Convert.ToString(tblProcedure.Rows[3]["First_Name"]) + " " + Convert.ToString(tblProcedure.Rows[3]["Middle_Name"]) + " " + Convert.ToString(tblProcedure.Rows[3]["Last_Name"]);
                table1.AddCell(sBody);

                sBody = "Passanger 5 : Seat No : " + Convert.ToString(Session["Pas5Seat"]) + " : " + Convert.ToString(tblProcedure.Rows[4]["First_Name"]) + " " + Convert.ToString(tblProcedure.Rows[4]["Middle_Name"]) + " " + Convert.ToString(tblProcedure.Rows[4]["Last_Name"]);
                table1.AddCell(sBody);
            }
            if (Convert.ToString(Session["Total_Passengers"]) == "6")
            {
                sBody = "Passanger 1 : Seat No : " + Convert.ToString(Session["Pas1Seat"]) + " : " + Convert.ToString(tblProcedure.Rows[0]["First_Name"]) + " " + Convert.ToString(tblProcedure.Rows[0]["Middle_Name"]) + " " + Convert.ToString(tblProcedure.Rows[0]["Last_Name"]);
                table1.AddCell(sBody);

                sBody = "Passanger 2 : Seat No : " + Convert.ToString(Session["Pas2Seat"]) + " : " + Convert.ToString(tblProcedure.Rows[1]["First_Name"]) + " " + Convert.ToString(tblProcedure.Rows[1]["Middle_Name"]) + " " + Convert.ToString(tblProcedure.Rows[1]["Last_Name"]);
                table1.AddCell(sBody);

                sBody = "Passanger 3 : Seat No : " + Convert.ToString(Session["Pas3Seat"]) + " : " + Convert.ToString(tblProcedure.Rows[2]["First_Name"]) + " " + Convert.ToString(tblProcedure.Rows[2]["Middle_Name"]) + " " + Convert.ToString(tblProcedure.Rows[2]["Last_Name"]);
                table1.AddCell(sBody);

                sBody = "Passanger 4 : Seat No : " + Convert.ToString(Session["Pas4Seat"]) + " : " + Convert.ToString(tblProcedure.Rows[3]["First_Name"]) + " " + Convert.ToString(tblProcedure.Rows[3]["Middle_Name"]) + " " + Convert.ToString(tblProcedure.Rows[3]["Last_Name"]);
                table1.AddCell(sBody);

                sBody = "Passanger 5 : Seat No : " + Convert.ToString(Session["Pas5Seat"]) + " : " + Convert.ToString(tblProcedure.Rows[4]["First_Name"]) + " " + Convert.ToString(tblProcedure.Rows[4]["Middle_Name"]) + " " + Convert.ToString(tblProcedure.Rows[4]["Last_Name"]);
                table1.AddCell(sBody);

                sBody = "Passanger 6 : Seat No : " + Convert.ToString(Session["Pas6Seat"]) + " : " + Convert.ToString(tblProcedure.Rows[5]["First_Name"]) + " " + Convert.ToString(tblProcedure.Rows[5]["Middle_Name"]) + " " + Convert.ToString(tblProcedure.Rows[5]["Last_Name"]);
                table1.AddCell(sBody);
            }
            document.Add(table1);

            #endregion

            #region Boarding
            table2 = new PdfPTable(2);
            table2.AddCell("Boarding Date");
            table2.AddCell(": " + Convert.ToDateTime(Session["Bording_Date"]).ToString("dd-MMM-yyyy"));
            table2.AddCell("Boarding Time");
            table2.AddCell(": " + Convert.ToString(Session["DepartureTime"]));
            table2.AddCell("Boarding Point");
            table2.AddCell(": " + Convert.ToString(Session["Source"]));

            document.Add(table2);

            #endregion

            #region Footer
            table3 = new PdfPTable(1);
            table3.AddCell("      Bus Operator Contact Number : 020-26121549/9325378164 / ");
            table3.AddCell("      Please use the Ticket Number as reference for interaction with the bus operator");

            document.Add(table3);

            #endregion
            fs.Flush();
            document.Close();
            writer.Close();
            writer.CloseStream = true;
            writer.Dispose();
            document.Dispose();
            fs.Dispose();
            FileInfo file1 = new FileInfo(Server.MapPath(Convert.ToString("ticket.pdf")));
            if (file1.Exists == true)
            {
                file1.CopyTo("/ticket/ticketfinal.pdf");
                file1.Delete();
            }
            //}
            //catch(Exception ex)
            //{
            //    //fs.Flush();
            //    //document.Close();
            //}

        }
    }
}