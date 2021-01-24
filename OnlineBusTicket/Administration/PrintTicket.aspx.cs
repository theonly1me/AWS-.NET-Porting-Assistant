using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataTransmission;
using System.Data;
using iTextSharp;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;
using System.Net;
using System.Text;
namespace OnlineBusTicket.Administration
{
    public partial class PrintTicket : System.Web.UI.Page
    {
        //TicketDTL ticket = new TicketDTL();
        //PTicket pticket = new PTicket();
        DataSet ds = new DataSet();
        DataTable dt;
        DataTable tblProcedure = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {                    

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
                        Session["Total_Passengers"] = tblProcedure.Rows.Count;
                        if (Convert.ToString(Session["Total_Passengers"]) == "1")
                        {
                            tr1.Visible = true;

                            txtPas1Name.Text = Convert.ToString(tblProcedure.Rows[0]["First_Name"]) + " " + Convert.ToString(tblProcedure.Rows[0]["Middle_Name"]) + " " + Convert.ToString(tblProcedure.Rows[0]["Last_Name"]);
                            //lblPas1SeatNo.Text = Convert.ToString(Session["Pas1Seat"]);
                            lblPas1SeatNo.Text = Convert.ToString(tblProcedure.Rows[0]["Seat_No"]);

                        }
                        else if (Convert.ToString(Session["Total_Passengers"]) == "2")
                        {
                            tr1.Visible = true;
                            tr2.Visible = true;

                            txtPas1Name.Text = Convert.ToString(tblProcedure.Rows[0]["First_Name"]) + " " + Convert.ToString(tblProcedure.Rows[0]["Middle_Name"]) + " " + Convert.ToString(tblProcedure.Rows[0]["Last_Name"]);
                            lblPas1SeatNo.Text = Convert.ToString(tblProcedure.Rows[0]["Seat_No"]);

                            txtPas2Name.Text = Convert.ToString(tblProcedure.Rows[1]["First_Name"]) + " " + Convert.ToString(tblProcedure.Rows[1]["Middle_Name"]) + " " + Convert.ToString(tblProcedure.Rows[1]["Last_Name"]);
                            lblPas2SeatNo.Text = Convert.ToString(tblProcedure.Rows[1]["Seat_No"]);



                        }
                        else if (Convert.ToString(Session["Total_Passengers"]) == "3")
                        {
                            tr1.Visible = true;
                            tr2.Visible = true;
                            tr3.Visible = true;

                            txtPas1Name.Text = Convert.ToString(tblProcedure.Rows[0]["First_Name"]) + " " + Convert.ToString(tblProcedure.Rows[0]["Middle_Name"]) + " " + Convert.ToString(tblProcedure.Rows[0]["Last_Name"]);
                            lblPas1SeatNo.Text = Convert.ToString(tblProcedure.Rows[0]["Seat_No"]);

                            txtPas2Name.Text = Convert.ToString(tblProcedure.Rows[1]["First_Name"]) + " " + Convert.ToString(tblProcedure.Rows[1]["Middle_Name"]) + " " + Convert.ToString(tblProcedure.Rows[1]["Last_Name"]);
                            lblPas2SeatNo.Text = Convert.ToString(tblProcedure.Rows[1]["Seat_No"]);

                            txtPas3Name.Text = Convert.ToString(tblProcedure.Rows[2]["First_Name"]) + " " + Convert.ToString(tblProcedure.Rows[2]["Middle_Name"]) + " " + Convert.ToString(tblProcedure.Rows[2]["Last_Name"]);
                            lblPas3SeatNo.Text = Convert.ToString(tblProcedure.Rows[2]["Seat_No"]);



                        }
                        else if (Convert.ToString(Session["Total_Passengers"]) == "4")
                        {
                            tr1.Visible = true;
                            tr2.Visible = true;
                            tr3.Visible = true;
                            tr4.Visible = true;

                            txtPas1Name.Text = Convert.ToString(tblProcedure.Rows[0]["First_Name"]) + " " + Convert.ToString(tblProcedure.Rows[0]["Middle_Name"]) + " " + Convert.ToString(tblProcedure.Rows[0]["Last_Name"]);                           
                            lblPas1SeatNo.Text = Convert.ToString(tblProcedure.Rows[0]["Seat_No"]);
                            txtPas2Name.Text = Convert.ToString(tblProcedure.Rows[1]["First_Name"]) + " " + Convert.ToString(tblProcedure.Rows[1]["Middle_Name"]) + " " + Convert.ToString(tblProcedure.Rows[1]["Last_Name"]);
                           
                            lblPas2SeatNo.Text = Convert.ToString(tblProcedure.Rows[1]["Seat_No"]);
                            txtPas3Name.Text = Convert.ToString(tblProcedure.Rows[2]["First_Name"]) + " " + Convert.ToString(tblProcedure.Rows[2]["Middle_Name"]) + " " + Convert.ToString(tblProcedure.Rows[2]["Last_Name"]);
                            
                            lblPas3SeatNo.Text = Convert.ToString(tblProcedure.Rows[2]["Seat_No"]);
                            txtPas4Name.Text = Convert.ToString(tblProcedure.Rows[3]["First_Name"]) + " " + Convert.ToString(tblProcedure.Rows[3]["Middle_Name"]) + " " + Convert.ToString(tblProcedure.Rows[3]["Last_Name"]);                            
                            lblPas4SeatNo.Text = Convert.ToString(tblProcedure.Rows[3]["Seat_No"]);



                        }
                        else if (Convert.ToString(Session["Total_Passengers"]) == "5")
                        {
                            tr1.Visible = true;
                            tr2.Visible = true;
                            tr3.Visible = true;
                            tr4.Visible = true;
                            tr5.Visible = true;

                            txtPas1Name.Text = Convert.ToString(tblProcedure.Rows[0]["First_Name"]) + " " + Convert.ToString(tblProcedure.Rows[0]["Middle_Name"]) + " " + Convert.ToString(tblProcedure.Rows[0]["Last_Name"]);
                            lblPas1SeatNo.Text = Convert.ToString(tblProcedure.Rows[0]["Seat_No"]);

                            txtPas2Name.Text = Convert.ToString(tblProcedure.Rows[1]["First_Name"]) + " " + Convert.ToString(tblProcedure.Rows[1]["Middle_Name"]) + " " + Convert.ToString(tblProcedure.Rows[1]["Last_Name"]);
                            lblPas2SeatNo.Text = Convert.ToString(tblProcedure.Rows[1]["Seat_No"]);

                            txtPas3Name.Text = Convert.ToString(tblProcedure.Rows[2]["First_Name"]) + " " + Convert.ToString(tblProcedure.Rows[2]["Middle_Name"]) + " " + Convert.ToString(tblProcedure.Rows[2]["Last_Name"]);
                            lblPas3SeatNo.Text = Convert.ToString(tblProcedure.Rows[2]["Seat_No"]);

                            txtPas4Name.Text = Convert.ToString(tblProcedure.Rows[3]["First_Name"]) + " " + Convert.ToString(tblProcedure.Rows[3]["Middle_Name"]) + " " + Convert.ToString(tblProcedure.Rows[3]["Last_Name"]);
                            lblPas4SeatNo.Text = Convert.ToString(tblProcedure.Rows[3]["Seat_No"]);

                            txtPas5Name.Text = Convert.ToString(tblProcedure.Rows[4]["First_Name"]) + " " + Convert.ToString(tblProcedure.Rows[4]["Middle_Name"]) + " " + Convert.ToString(tblProcedure.Rows[4]["Last_Name"]);
                            lblPas5SeatNo.Text = Convert.ToString(tblProcedure.Rows[4]["Seat_No"]);



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
                            lblPas1SeatNo.Text = Convert.ToString(tblProcedure.Rows[0]["Seat_No"]);

                            txtPas2Name.Text = Convert.ToString(tblProcedure.Rows[1]["First_Name"]) + " " + Convert.ToString(tblProcedure.Rows[1]["Middle_Name"]) + " " + Convert.ToString(tblProcedure.Rows[1]["Last_Name"]);
                            lblPas2SeatNo.Text = Convert.ToString(tblProcedure.Rows[1]["Seat_No"]);

                            txtPas3Name.Text = Convert.ToString(tblProcedure.Rows[2]["First_Name"]) + " " + Convert.ToString(tblProcedure.Rows[2]["Middle_Name"]) + " " + Convert.ToString(tblProcedure.Rows[2]["Last_Name"]);
                            lblPas3SeatNo.Text = Convert.ToString(tblProcedure.Rows[2]["Seat_No"]);

                            txtPas4Name.Text = Convert.ToString(tblProcedure.Rows[3]["First_Name"]) + " " + Convert.ToString(tblProcedure.Rows[3]["Middle_Name"]) + " " + Convert.ToString(tblProcedure.Rows[3]["Last_Name"]);
                            lblPas4SeatNo.Text = Convert.ToString(tblProcedure.Rows[3]["Seat_No"]);

                            txtPas5Name.Text = Convert.ToString(tblProcedure.Rows[4]["First_Name"]) + " " + Convert.ToString(tblProcedure.Rows[4]["Middle_Name"]) + " " + Convert.ToString(tblProcedure.Rows[4]["Last_Name"]);
                            lblPas5SeatNo.Text = Convert.ToString(tblProcedure.Rows[4]["Seat_No"]);

                            txtPas6Name.Text = Convert.ToString(tblProcedure.Rows[5]["First_Name"]) + " " + Convert.ToString(tblProcedure.Rows[5]["Middle_Name"]) + " " + Convert.ToString(tblProcedure.Rows[5]["Last_Name"]);
                            lblPas6SeatNo.Text = Convert.ToString(tblProcedure.Rows[5]["Seat_No"]);


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

      
        
        public static string ticketconfimationlBody(string username, string visitdate, string numberofadults, string numberofchilderns, string ticketfare)
        {
            string url = HttpContext.Current.Request.Url.AbsoluteUri;
            //url = url.Substring(0, url.LastIndexOf("/")) + "/" + "managerApproval.aspx";
            StringBuilder sb = new StringBuilder();
            sb.Append("<table width='100%' border='2' style='border-color:#006699'>");
            sb.Append(@"<tr><td  style='height:45px; background-color:#41556D; color:White' align='center'><h1>Archeological Survey of India - POC</h1></td></tr>");
            sb.Append("<tr><td>");
            sb.Append(@"<div style='COLOR:#3366CC; font-size:15px'");
            sb.Append(@"<p>Hi," + username + "</p>");
            //sb.Append(@"<p>Your ticket has booked for visit on  " + visitdate + " for " + numberofadults + " and " + numberofchilderns + "  </p>");
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
            //Response.Redirect(Convert.ToString(Session["tcktNo"]));
            Response.Redirect("~\\Default.aspx");
        }

        protected void eticket()
        {
            try
            {
                //Guid gid  = new Guid();
                //Session["tcktNo"] = "ticket" + gid.ToString() + ".pdf";
                //string newFile = Server.MapPath(Convert.ToString(Session["tcktNo"]));
                string newFile = Server.MapPath("ticket.pdf");

                string imagepath = Server.MapPath("~\\Images\\e-ticketing.jpg");
                Document document = new Document();
                //document.Close();
                FileStream fs = new FileStream("D:\\ticket.pdf", FileMode.Create, FileAccess.Write);
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

            }
            catch (Exception ex)
            {
                //fs.Flush();
                //document.Close();
            }

        }

        protected void btnToPDF_Click(object sender, EventArgs e)
        {

        }
    }
}