using System;
using System.Data;
using System.Web.UI.WebControls;
using System.Configuration;
using Microsoft.Data.SqlClient;

namespace OnlineBusTicket.Booking
{
    public partial class TicketBooking : System.Web.UI.Page
    {
        DataTable tblProcedure = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                object[] obj_Final_For_Booking = new object[19];
                //Session["obj_Final_For_Booking"] = obj_Final_For_Booking;
                obj_Final_For_Booking = (object[])Session["obj_Final_For_Booking"];
                Session["BusOperator"] = Convert.ToString(obj_Final_For_Booking[0]); // "Sandhu Transport";
                Session["BusNo"] = Convert.ToString(obj_Final_For_Booking[1]); //"UP 75 A-2709";
                Session["DepartureTime"] = Convert.ToString(obj_Final_For_Booking[2]); // "09:30";
                Session["ArrivalTime"] = Convert.ToString(obj_Final_For_Booking[3]); //"17:50";
                Session["BusType"] = "";
                if (Convert.ToString(obj_Final_For_Booking[4]) == "True")
                {
                    Session["BusType"] = Convert.ToString(Session["BusType"]) + "AC,";
                }

                if (Convert.ToString(obj_Final_For_Booking[5]) == "True")
                {
                    Session["BusType"] = Convert.ToString(Session["BusType"]) + "Volvo,";
                }

                if (Convert.ToString(obj_Final_For_Booking[6]) == "True")
                {
                    Session["BusType"] = Convert.ToString(Session["BusType"]) + "SL,";
                }

                if (Convert.ToString(obj_Final_For_Booking[7]) == "True")
                {
                    Session["BusType"] = Convert.ToString(Session["BusType"]) + "ST,";
                }

                //obj_Final_For_Booking[0] = obj[1];//BusOperator
                //obj_Final_For_Booking[1] = obj[12];//BusNo
                //obj_Final_For_Booking[2] = obj[10];//DepartureTime
                //obj_Final_For_Booking[3] = obj[11];//ArrivalTime
                //obj_Final_For_Booking[4] = obj[2];//BusTypeAC
                //obj_Final_For_Booking[5] = obj[3];//BusTypeVolvo
                //obj_Final_For_Booking[6] = obj[4];//BusTypeSL
                //obj_Final_For_Booking[7] = obj[5];//BusTypeST
                //obj_Final_For_Booking[8] = ddl_BoardingPoint.SelectedValue;//Source Or Boarding Point
                //obj_Final_For_Booking[9] = ddl_BoardingPoint.SelectedItem.Text;//Source Or Boarding Point
                //obj_Final_For_Booking[10] = obj[9];//Destination
                //obj_Final_For_Booking[11] = Session["Destination_Point_Name"].ToString();
                //obj_Final_For_Booking[12] = obj[0];//Bus_ID
                //obj_Final_For_Booking[13] = obj[13];//BusName
                //obj_Final_For_Booking[14] = obj[6];//Route_ID
                //obj_Final_For_Booking[15] = obj[7];//Bording_Date
                //obj_Final_For_Booking[16] = Convert.ToInt32(Session["lst"]);//Total_Passengers
                //obj_Final_For_Booking[17] = lbl_SelectedValue;//SeatNos
                //obj_Final_For_Booking[18] = lbl_final_fare_val;//TotalAmount
                Session["Source"] = Convert.ToString(obj_Final_For_Booking[9]); //"Old Delhi";
                Session["Destination"] = Convert.ToString(obj_Final_For_Booking[11]); //Hazrat Nizamuddin
                //Session["User_ID"] = 1;
                //Session["User_Type"] = 1;
                Session["Bus_ID"] = Convert.ToString(obj_Final_For_Booking[12]); //1
                Session["Route_ID"] = Convert.ToString(obj_Final_For_Booking[14]); //1
                Session["Bording_Date"] = Convert.ToDateTime(obj_Final_For_Booking[15]).ToString("dd-MMM-yyyy"); //1
                //Session["Booking_Quoto"] = From Fisrt Page1;
                //Session["Booking_Quoto_Name"] = Gen//From first page
                Session["Boarding_Point"] = Convert.ToString(obj_Final_For_Booking[8]); //1
                Session["Destination_Point"] = Convert.ToString(obj_Final_For_Booking[10]); //1
                Session["Ticket_Type"] = 1; //Confirm from LookUp
                Session["Total_Passengers"] = Convert.ToString(obj_Final_For_Booking[16]); //2
                Session["SeatNos"] = Convert.ToString(obj_Final_For_Booking[17]); //"22,23,24,25,26,27";
                Session["TotalAmount"] = Convert.ToDecimal(obj_Final_For_Booking[18]); //2
                //Session["Login"] = "Ashu"; from first Page
                //////////////////////////
                //Session["BusOperator"] = "Sandhu Transport";
                //Session["BusNo"] = "UP 75 A-2709";
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
                tblProcedure.Columns.Clear();
                tblProcedure.Rows.Clear();
                tblProcedure.Columns.Add(new DataColumn("sno", typeof(Int32)));
                tblProcedure.Columns.Add(new DataColumn("First_Name", typeof(String)));
                tblProcedure.Columns.Add(new DataColumn("Middle_Name", typeof(String)));
                tblProcedure.Columns.Add(new DataColumn("Last_Name", typeof(String)));
                tblProcedure.Columns.Add(new DataColumn("Gender", typeof(Int32)));
                tblProcedure.Columns.Add(new DataColumn("Seat_No", typeof(Int32)));
                tblProcedure.Columns.Add(new DataColumn("Seat_Type", typeof(Int32)));
                tblProcedure.Columns.Add(new DataColumn("CreatedBy", typeof(String)));
                tblProcedure.Columns.Add(new DataColumn("IsActive", typeof(Int32)));
                ViewState["tblProcedure"] = tblProcedure;
                lblBusOperator.Text = Convert.ToString(Session["BusOperator"]);
                lblBusNo.Text = Convert.ToString(Session["BusNo"]);
                lblBusType.Text = Convert.ToString(Session["BusType"]);
                lblBordingTime.Text = Convert.ToString(Session["Bording_Date"]);
                lblDepartureTime.Text = Convert.ToString(Session["DepartureTime"]);
                lblArrivalTime.Text = Convert.ToString(Session["ArrivalTime"]);
                lblNoOfPassenger.Text = Convert.ToString(Session["Total_Passengers"]);
                tr1.Visible = false;
                tr2.Visible = false;
                tr3.Visible = false;
                tr4.Visible = false;
                tr5.Visible = false;
                tr6.Visible = false;
                if (Convert.ToString(Session["Total_Passengers"]) == "1")
                {
                    tr1.Visible = true;
                    string[] words = Convert.ToString(Session["SeatNos"]).Split(',');
                    Session["Pas1Seat"] = words[0];
                    lblPas1SeatNo.Text = Convert.ToString(Session["Pas1Seat"]);
                }
                else if (Convert.ToString(Session["Total_Passengers"]) == "2")
                {
                    tr1.Visible = true;
                    tr2.Visible = true;
                    string[] words = Convert.ToString(Session["SeatNos"]).Split(',');
                    Session["Pas1Seat"] = words[0];
                    Session["Pas2Seat"] = words[1];
                    lblPas1SeatNo.Text = Convert.ToString(Session["Pas1Seat"]);
                    lblPas2SeatNo.Text = Convert.ToString(Session["Pas2Seat"]);
                }
                else if (Convert.ToString(Session["Total_Passengers"]) == "3")
                {
                    tr1.Visible = true;
                    tr2.Visible = true;
                    tr3.Visible = true;
                    string[] words = Convert.ToString(Session["SeatNos"]).Split(',');
                    Session["Pas1Seat"] = words[0];
                    Session["Pas2Seat"] = words[1];
                    Session["Pas3Seat"] = words[2];
                    lblPas1SeatNo.Text = Convert.ToString(Session["Pas1Seat"]);
                    lblPas2SeatNo.Text = Convert.ToString(Session["Pas2Seat"]);
                    lblPas3SeatNo.Text = Convert.ToString(Session["Pas3Seat"]);
                }
                else if (Convert.ToString(Session["Total_Passengers"]) == "4")
                {
                    tr1.Visible = true;
                    tr2.Visible = true;
                    tr3.Visible = true;
                    tr4.Visible = true;
                    string[] words = Convert.ToString(Session["SeatNos"]).Split(',');
                    Session["Pas1Seat"] = words[0];
                    Session["Pas2Seat"] = words[1];
                    Session["Pas3Seat"] = words[2];
                    Session["Pas4Seat"] = words[3];
                    lblPas1SeatNo.Text = Convert.ToString(Session["Pas1Seat"]);
                    lblPas2SeatNo.Text = Convert.ToString(Session["Pas2Seat"]);
                    lblPas3SeatNo.Text = Convert.ToString(Session["Pas3Seat"]);
                    lblPas4SeatNo.Text = Convert.ToString(Session["Pas4Seat"]);
                }
                else if (Convert.ToString(Session["Total_Passengers"]) == "5")
                {
                    tr1.Visible = true;
                    tr2.Visible = true;
                    tr3.Visible = true;
                    tr4.Visible = true;
                    tr5.Visible = true;
                    string[] words = Convert.ToString(Session["SeatNos"]).Split(',');
                    Session["Pas1Seat"] = words[0];
                    Session["Pas2Seat"] = words[1];
                    Session["Pas3Seat"] = words[2];
                    Session["Pas4Seat"] = words[3];
                    Session["Pas5Seat"] = words[4];
                    lblPas1SeatNo.Text = Convert.ToString(Session["Pas1Seat"]);
                    lblPas2SeatNo.Text = Convert.ToString(Session["Pas2Seat"]);
                    lblPas3SeatNo.Text = Convert.ToString(Session["Pas3Seat"]);
                    lblPas4SeatNo.Text = Convert.ToString(Session["Pas4Seat"]);
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
                    string[] words = Convert.ToString(Session["SeatNos"]).Split(',');
                    Session["Pas1Seat"] = words[0];
                    Session["Pas2Seat"] = words[1];
                    Session["Pas3Seat"] = words[2];
                    Session["Pas4Seat"] = words[3];
                    Session["Pas5Seat"] = words[4];
                    Session["Pas6Seat"] = words[5];
                    lblPas1SeatNo.Text = Convert.ToString(Session["Pas1Seat"]);
                    lblPas2SeatNo.Text = Convert.ToString(Session["Pas2Seat"]);
                    lblPas3SeatNo.Text = Convert.ToString(Session["Pas3Seat"]);
                    lblPas4SeatNo.Text = Convert.ToString(Session["Pas4Seat"]);
                    lblPas5SeatNo.Text = Convert.ToString(Session["Pas5Seat"]);
                    lblPas6SeatNo.Text = Convert.ToString(Session["Pas6Seat"]);
                }
            }
        }

        public void funcCollectData()
        {
            tblProcedure = (DataTable)ViewState["tblProcedure"];
            tblProcedure.Rows.Clear();
            if (Convert.ToString(Session["Total_Passengers"]) == "1")
            {
                DataRow drow = tblProcedure.NewRow();
                drow["sno"] = 1;
                drow["First_Name"] = txtPas1FirstName.Text.Trim();
                drow["Middle_Name"] = txtPas1MidName.Text.Trim();
                drow["Last_Name"] = txtPas1LastName.Text.Trim();
                drow["Gender"] = ddlPas1Gender.SelectedItem.Value;
                drow["Seat_No"] = lblPas1SeatNo.Text;
                drow["Seat_Type"] = "1";
                drow["CreatedBy"] = Convert.ToString(Session["Login"]);
                drow["IsActive"] = "1";
                tblProcedure.Rows.Add(drow);
            }
            else if (Convert.ToString(Session["Total_Passengers"]) == "2")
            {
                DataRow drow1 = tblProcedure.NewRow();
                drow1["sno"] = 1;
                drow1["First_Name"] = txtPas1FirstName.Text.Trim();
                drow1["Middle_Name"] = txtPas1MidName.Text.Trim();
                drow1["Last_Name"] = txtPas1LastName.Text.Trim();
                drow1["Gender"] = ddlPas1Gender.SelectedItem.Value;
                drow1["Seat_No"] = lblPas1SeatNo.Text;
                drow1["Seat_Type"] = "1";
                drow1["CreatedBy"] = Convert.ToString(Session["Login"]);
                drow1["IsActive"] = "1";
                tblProcedure.Rows.Add(drow1);
                DataRow drow2 = tblProcedure.NewRow();
                drow2["sno"] = 2;
                drow2["First_Name"] = txtPas2FirstName.Text.Trim();
                drow2["Middle_Name"] = txtPas2MidName.Text.Trim();
                drow2["Last_Name"] = txtPas2LastName.Text.Trim();
                drow2["Gender"] = ddlPas2Gender.SelectedItem.Value;
                drow2["Seat_No"] = lblPas2SeatNo.Text;
                drow2["Seat_Type"] = "1";
                drow2["CreatedBy"] = Convert.ToString(Session["Login"]);
                drow2["IsActive"] = "1";
                tblProcedure.Rows.Add(drow2);
            }
            else if (Convert.ToString(Session["Total_Passengers"]) == "3")
            {
                DataRow drow1 = tblProcedure.NewRow();
                drow1["sno"] = 1;
                drow1["First_Name"] = txtPas1FirstName.Text.Trim();
                drow1["Middle_Name"] = txtPas1MidName.Text.Trim();
                drow1["Last_Name"] = txtPas1LastName.Text.Trim();
                drow1["Gender"] = ddlPas1Gender.SelectedItem.Value;
                drow1["Seat_No"] = lblPas1SeatNo.Text;
                drow1["Seat_Type"] = "1";
                drow1["CreatedBy"] = Convert.ToString(Session["Login"]);
                drow1["IsActive"] = "1";
                tblProcedure.Rows.Add(drow1);
                DataRow drow2 = tblProcedure.NewRow();
                drow2["sno"] = 2;
                drow2["First_Name"] = txtPas2FirstName.Text.Trim();
                drow2["Middle_Name"] = txtPas2MidName.Text.Trim();
                drow2["Last_Name"] = txtPas2LastName.Text.Trim();
                drow2["Gender"] = ddlPas2Gender.SelectedItem.Value;
                drow2["Seat_No"] = lblPas2SeatNo.Text;
                drow2["Seat_Type"] = "1";
                drow2["CreatedBy"] = Convert.ToString(Session["Login"]);
                drow2["IsActive"] = "1";
                tblProcedure.Rows.Add(drow2);
                DataRow drow3 = tblProcedure.NewRow();
                drow3["sno"] = 3;
                drow3["First_Name"] = txtPas3FirstName.Text.Trim();
                drow3["Middle_Name"] = txtPas3MidName.Text.Trim();
                drow3["Last_Name"] = txtPas3LastName.Text.Trim();
                drow3["Gender"] = ddlPas3Gender.SelectedItem.Value;
                drow3["Seat_No"] = lblPas3SeatNo.Text;
                drow3["Seat_Type"] = "1";
                drow3["CreatedBy"] = Convert.ToString(Session["Login"]);
                drow3["IsActive"] = "1";
                tblProcedure.Rows.Add(drow3);
            }
            else if (Convert.ToString(Session["Total_Passengers"]) == "4")
            {
                DataRow drow1 = tblProcedure.NewRow();
                drow1["sno"] = 1;
                drow1["First_Name"] = txtPas1FirstName.Text.Trim();
                drow1["Middle_Name"] = txtPas1MidName.Text.Trim();
                drow1["Last_Name"] = txtPas1LastName.Text.Trim();
                drow1["Gender"] = ddlPas1Gender.SelectedItem.Value;
                drow1["Seat_No"] = lblPas1SeatNo.Text;
                drow1["Seat_Type"] = "1";
                drow1["CreatedBy"] = Convert.ToString(Session["Login"]);
                drow1["IsActive"] = "1";
                tblProcedure.Rows.Add(drow1);
                DataRow drow2 = tblProcedure.NewRow();
                drow2["sno"] = 2;
                drow2["First_Name"] = txtPas2FirstName.Text.Trim();
                drow2["Middle_Name"] = txtPas2MidName.Text.Trim();
                drow2["Last_Name"] = txtPas2LastName.Text.Trim();
                drow2["Gender"] = ddlPas2Gender.SelectedItem.Value;
                drow2["Seat_No"] = lblPas2SeatNo.Text;
                drow2["Seat_Type"] = "1";
                drow2["CreatedBy"] = Convert.ToString(Session["Login"]);
                drow2["IsActive"] = "1";
                tblProcedure.Rows.Add(drow2);
                DataRow drow3 = tblProcedure.NewRow();
                drow3["sno"] = 3;
                drow3["First_Name"] = txtPas3FirstName.Text.Trim();
                drow3["Middle_Name"] = txtPas3MidName.Text.Trim();
                drow3["Last_Name"] = txtPas3LastName.Text.Trim();
                drow3["Gender"] = ddlPas3Gender.SelectedItem.Value;
                drow3["Seat_No"] = lblPas3SeatNo.Text;
                drow3["Seat_Type"] = "1";
                drow3["CreatedBy"] = Convert.ToString(Session["Login"]);
                drow3["IsActive"] = "1";
                tblProcedure.Rows.Add(drow3);
                DataRow drow4 = tblProcedure.NewRow();
                drow4["sno"] = 4;
                drow4["First_Name"] = txtPas4FirstName.Text.Trim();
                drow4["Middle_Name"] = txtPas4MidName.Text.Trim();
                drow4["Last_Name"] = txtPas4LastName.Text.Trim();
                drow4["Gender"] = ddlPas4Gender.SelectedItem.Value;
                drow4["Seat_No"] = lblPas4SeatNo.Text;
                drow4["Seat_Type"] = "1";
                drow4["CreatedBy"] = Convert.ToString(Session["Login"]);
                drow4["IsActive"] = "1";
                tblProcedure.Rows.Add(drow4);
            }
            else if (Convert.ToString(Session["Total_Passengers"]) == "4")
            {
                DataRow drow1 = tblProcedure.NewRow();
                drow1["sno"] = 1;
                drow1["First_Name"] = txtPas1FirstName.Text.Trim();
                drow1["Middle_Name"] = txtPas1MidName.Text.Trim();
                drow1["Last_Name"] = txtPas1LastName.Text.Trim();
                drow1["Gender"] = ddlPas1Gender.SelectedItem.Value;
                drow1["Seat_No"] = lblPas1SeatNo.Text;
                drow1["Seat_Type"] = "1";
                drow1["CreatedBy"] = Convert.ToString(Session["Login"]);
                drow1["IsActive"] = "1";
                tblProcedure.Rows.Add(drow1);
                DataRow drow2 = tblProcedure.NewRow();
                drow2["sno"] = 2;
                drow2["First_Name"] = txtPas2FirstName.Text.Trim();
                drow2["Middle_Name"] = txtPas2MidName.Text.Trim();
                drow2["Last_Name"] = txtPas2LastName.Text.Trim();
                drow2["Gender"] = ddlPas2Gender.SelectedItem.Value;
                drow2["Seat_No"] = lblPas2SeatNo.Text;
                drow2["Seat_Type"] = "1";
                drow2["CreatedBy"] = Convert.ToString(Session["Login"]);
                drow2["IsActive"] = "1";
                tblProcedure.Rows.Add(drow2);
                DataRow drow3 = tblProcedure.NewRow();
                drow3["sno"] = 3;
                drow3["First_Name"] = txtPas3FirstName.Text.Trim();
                drow3["Middle_Name"] = txtPas3MidName.Text.Trim();
                drow3["Last_Name"] = txtPas3LastName.Text.Trim();
                drow3["Gender"] = ddlPas3Gender.SelectedItem.Value;
                drow3["Seat_No"] = lblPas3SeatNo.Text;
                drow3["Seat_Type"] = "1";
                drow3["CreatedBy"] = Convert.ToString(Session["Login"]);
                drow3["IsActive"] = "1";
                tblProcedure.Rows.Add(drow3);
                DataRow drow4 = tblProcedure.NewRow();
                drow4["sno"] = 4;
                drow4["First_Name"] = txtPas4FirstName.Text.Trim();
                drow4["Middle_Name"] = txtPas4MidName.Text.Trim();
                drow4["Last_Name"] = txtPas4LastName.Text.Trim();
                drow4["Gender"] = ddlPas4Gender.SelectedItem.Value;
                drow4["Seat_No"] = lblPas4SeatNo.Text;
                drow4["Seat_Type"] = "1";
                drow4["CreatedBy"] = Convert.ToString(Session["Login"]);
                drow4["IsActive"] = "1";
                tblProcedure.Rows.Add(drow4);
                DataRow drow5 = tblProcedure.NewRow();
                drow5["sno"] = 5;
                drow5["First_Name"] = txtPas5FirstName.Text.Trim();
                drow5["Middle_Name"] = txtPas5MidName.Text.Trim();
                drow5["Last_Name"] = txtPas5LastName.Text.Trim();
                drow5["Gender"] = ddlPas5Gender.SelectedItem.Value;
                drow5["Seat_No"] = lblPas5SeatNo.Text;
                drow5["Seat_Type"] = "1";
                drow5["CreatedBy"] = Convert.ToString(Session["Login"]);
                drow5["IsActive"] = "1";
                tblProcedure.Rows.Add(drow5);
            }
            else if (Convert.ToString(Session["Total_Passengers"]) == "6")
            {
                DataRow drow1 = tblProcedure.NewRow();
                drow1["sno"] = 1;
                drow1["First_Name"] = txtPas1FirstName.Text.Trim();
                drow1["Middle_Name"] = txtPas1MidName.Text.Trim();
                drow1["Last_Name"] = txtPas1LastName.Text.Trim();
                drow1["Gender"] = ddlPas1Gender.SelectedItem.Value;
                drow1["Seat_No"] = lblPas1SeatNo.Text;
                drow1["Seat_Type"] = "1";
                drow1["CreatedBy"] = Convert.ToString(Session["Login"]);
                drow1["IsActive"] = "1";
                tblProcedure.Rows.Add(drow1);
                DataRow drow2 = tblProcedure.NewRow();
                drow2["sno"] = 2;
                drow2["First_Name"] = txtPas2FirstName.Text.Trim();
                drow2["Middle_Name"] = txtPas2MidName.Text.Trim();
                drow2["Last_Name"] = txtPas2LastName.Text.Trim();
                drow2["Gender"] = ddlPas2Gender.SelectedItem.Value;
                drow2["Seat_No"] = lblPas2SeatNo.Text;
                drow2["Seat_Type"] = "1";
                drow2["CreatedBy"] = Convert.ToString(Session["Login"]);
                drow2["IsActive"] = "1";
                tblProcedure.Rows.Add(drow2);
                DataRow drow3 = tblProcedure.NewRow();
                drow3["sno"] = 3;
                drow3["First_Name"] = txtPas3FirstName.Text.Trim();
                drow3["Middle_Name"] = txtPas3MidName.Text.Trim();
                drow3["Last_Name"] = txtPas3LastName.Text.Trim();
                drow3["Gender"] = ddlPas3Gender.SelectedItem.Value;
                drow3["Seat_No"] = lblPas3SeatNo.Text;
                drow3["Seat_Type"] = "1";
                drow3["CreatedBy"] = Convert.ToString(Session["Login"]);
                drow3["IsActive"] = "1";
                tblProcedure.Rows.Add(drow3);
                DataRow drow4 = tblProcedure.NewRow();
                drow4["sno"] = 4;
                drow4["First_Name"] = txtPas4FirstName.Text.Trim();
                drow4["Middle_Name"] = txtPas4MidName.Text.Trim();
                drow4["Last_Name"] = txtPas4LastName.Text.Trim();
                drow4["Gender"] = ddlPas4Gender.SelectedItem.Value;
                drow4["Seat_No"] = lblPas4SeatNo.Text;
                drow4["Seat_Type"] = "1";
                drow4["CreatedBy"] = Convert.ToString(Session["Login"]);
                drow4["IsActive"] = "1";
                tblProcedure.Rows.Add(drow4);
                DataRow drow5 = tblProcedure.NewRow();
                drow5["sno"] = 5;
                drow5["First_Name"] = txtPas5FirstName.Text.Trim();
                drow5["Middle_Name"] = txtPas5MidName.Text.Trim();
                drow5["Last_Name"] = txtPas5LastName.Text.Trim();
                drow5["Gender"] = ddlPas5Gender.SelectedItem.Value;
                drow5["Seat_No"] = lblPas5SeatNo.Text;
                drow5["Seat_Type"] = "1";
                drow5["CreatedBy"] = Convert.ToString(Session["Login"]);
                drow5["IsActive"] = "1";
                tblProcedure.Rows.Add(drow5);
                DataRow drow6 = tblProcedure.NewRow();
                drow6["sno"] = 6;
                drow6["First_Name"] = txtPas6FirstName.Text.Trim();
                drow6["Middle_Name"] = txtPas6MidName.Text.Trim();
                drow6["Last_Name"] = txtPas6LastName.Text.Trim();
                drow6["Gender"] = ddlPas6Gender.SelectedItem.Value;
                drow6["Seat_No"] = lblPas6SeatNo.Text;
                drow6["Seat_Type"] = "1";
                drow6["CreatedBy"] = Convert.ToString(Session["Login"]);
                drow6["IsActive"] = "1";
                tblProcedure.Rows.Add(drow6);
            }

            Session["Email"] = txtEMailId.Text.Trim();
            Session["Mobile"] = txtMobileNo.Text.Trim();
            Session["LandLine"] = txtLandLineNo.Text.Trim();
            Session["tblProcedure"] = tblProcedure;
        }

        protected void imgBtnPayBook_Click1(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            funcCollectData();
            Response.Redirect("Payment_Mode.aspx");
        }
    }
}