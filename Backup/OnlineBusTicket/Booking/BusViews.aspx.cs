using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using System.Data;
using DataTransmission;

namespace OnlineBusTicket
{
    public partial class BusViews : System.Web.UI.Page
    {
        #region Declaration
        DataSet _BusView = new DataSet();
        pbooking _pbook = new pbooking();
        List<String> lst = new List<String>();
        object[] obj = new object[12];
        #endregion

        #region PageLoad
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {

                #region ImageClickEventHandler
                ImageButton1.Click += new ImageClickEventHandler(CallImageButton);
                ImageButton2.Click += new ImageClickEventHandler(CallImageButton);
                ImageButton3.Click += new ImageClickEventHandler(CallImageButton);
                ImageButton4.Click += new ImageClickEventHandler(CallImageButton);
                ImageButton5.Click += new ImageClickEventHandler(CallImageButton);
                ImageButton6.Click += new ImageClickEventHandler(CallImageButton);
                ImageButton7.Click += new ImageClickEventHandler(CallImageButton);
                ImageButton8.Click += new ImageClickEventHandler(CallImageButton);
                ImageButton9.Click += new ImageClickEventHandler(CallImageButton);
                ImageButton10.Click += new ImageClickEventHandler(CallImageButton);
                ImageButton11.Click += new ImageClickEventHandler(CallImageButton);
                ImageButton12.Click += new ImageClickEventHandler(CallImageButton);
                ImageButton13.Click += new ImageClickEventHandler(CallImageButton);
                ImageButton14.Click += new ImageClickEventHandler(CallImageButton);
                ImageButton15.Click += new ImageClickEventHandler(CallImageButton);
                ImageButton16.Click += new ImageClickEventHandler(CallImageButton);
                ImageButton17.Click += new ImageClickEventHandler(CallImageButton);
                ImageButton18.Click += new ImageClickEventHandler(CallImageButton);
                ImageButton19.Click += new ImageClickEventHandler(CallImageButton);
                ImageButton20.Click += new ImageClickEventHandler(CallImageButton);
                ImageButton21.Click += new ImageClickEventHandler(CallImageButton);
                ImageButton22.Click += new ImageClickEventHandler(CallImageButton);
                ImageButton23.Click += new ImageClickEventHandler(CallImageButton);
                ImageButton24.Click += new ImageClickEventHandler(CallImageButton);
                ImageButton25.Click += new ImageClickEventHandler(CallImageButton);
                ImageButton26.Click += new ImageClickEventHandler(CallImageButton);
                ImageButton27.Click += new ImageClickEventHandler(CallImageButton);
                ImageButton28.Click += new ImageClickEventHandler(CallImageButton);
                ImageButton29.Click += new ImageClickEventHandler(CallImageButton);
                ImageButton30.Click += new ImageClickEventHandler(CallImageButton);
                ImageButton31.Click += new ImageClickEventHandler(CallImageButton);
                ImageButton32.Click += new ImageClickEventHandler(CallImageButton);
                ImageButton33.Click += new ImageClickEventHandler(CallImageButton);
                ImageButton34.Click += new ImageClickEventHandler(CallImageButton);
                ImageButton35.Click += new ImageClickEventHandler(CallImageButton);
                ImageButton36.Click += new ImageClickEventHandler(CallImageButton);
                ImageButton37.Click += new ImageClickEventHandler(CallImageButton);
                ImageButton38.Click += new ImageClickEventHandler(CallImageButton);
                ImageButton39.Click += new ImageClickEventHandler(CallImageButton);
                ImageButton40.Click += new ImageClickEventHandler(CallImageButton);
                ImageButton41.Click += new ImageClickEventHandler(CallImageButton);
                #endregion

                if (Session["BusDetails"] != null)
                {
                    if (!IsPostBack)
                    {

                        // CalculatingSelected_Seats();
                        SetBusView();
                        ddl_BoardingPoint_SelectedIndexChanged(sender, e);
                    }



                }
            }
            catch (Exception ex)
            {

            }
        }
        #endregion

        #region Functions

        #region CallImageButton
        public void CallImageButton(object sender, ImageClickEventArgs e)
        {
            try
            {
                if (Session["User_ID"] != null && Session["User_Type"] != null) // Will Work in case of logged in user(gen/agent)
                {
                    if (Session["User_Type"].ToString() == "1") //General
                    {
                        ImageButton btn = (ImageButton)(sender);
                        string id = btn.ID;
                        if (btn.ImageUrl == "~/Images/UnAllocatedSeat.png")
                        {
                            btn.ImageUrl = "~/Images/SelectedSeat.png";
                        }
                        else if (btn.ImageUrl == "~/Images/SelectedSeat.png")
                        {
                            btn.ImageUrl = "~/Images/UnAllocatedSeat.png";
                        }
                        else if (btn.ImageUrl == "~/Images/BookedSeates.png")
                        {
                            btn.Enabled = false;
                        }
                        else if (btn.ImageUrl == "~/Images/OtherAreaSeats.png")
                        {
                            btn.Enabled = false;
                        }
                        CalculatingSelected_Seats();
                    }
                    else if (Session["User_Type"].ToString() == "2") //Agent
                    {
                        ImageButton btn = (ImageButton)(sender);
                        string id = btn.ID;
                        if (btn.ImageUrl == "~/Images/UnAllocatedSeat.png")
                        {

                            btn.Enabled = false;
                        }
                        else if (btn.ImageUrl == "~/Images/SelectedSeat.png")
                        {
                            btn.ImageUrl = "~/Images/OtherAreaSeats.png";
                        }
                        else if (btn.ImageUrl == "~/Images/BookedSeates.png")
                        {
                            btn.Enabled = false;
                        }
                        else if (btn.ImageUrl == "~/Images/OtherAreaSeats.png")
                        {
                            btn.Enabled = true;
                            btn.ImageUrl = "~/Images/SelectedSeat.png";
                        }
                        CalculatingSelected_Seats();
                    }
                }
                else if (Session["User_ID"] == null && Session["User_Type"].ToString() == "5")
                {
                    ImageButton btn = (ImageButton)(sender);
                    string id = btn.ID;
                    if (btn.ImageUrl == "~/Images/UnAllocatedSeat.png")
                    {
                        btn.ImageUrl = "~/Images/SelectedSeat.png";
                    }
                    else if (btn.ImageUrl == "~/Images/SelectedSeat.png")
                    {
                        btn.ImageUrl = "~/Images/UnAllocatedSeat.png";
                    }
                    else if (btn.ImageUrl == "~/Images/BookedSeates.png")
                    {
                        btn.Enabled = false;
                    }
                    else if (btn.ImageUrl == "~/Images/OtherAreaSeats.png")
                    {
                        btn.Enabled = false;
                    }
                    CalculatingSelected_Seats();
                }

            }
            catch (Exception ex)
            {

            }

        }

        #endregion

        #region CalculatingSelected_Seats
        public void CalculatingSelected_Seats()
        {

            for (int i = 1; i <= 41; i++)
            {
                #region ForLoop
                if (i == 1)
                {
                    if (ImageButton1.ImageUrl == "~/Images/SelectedSeat.png")
                    {
                        lst.Add(Convert.ToString(ImageButton1.ToolTip));

                    }
                }

                else if (i == 2)
                {
                    if (ImageButton2.ImageUrl == "~/Images/SelectedSeat.png")
                    {
                        lst.Add(Convert.ToString(ImageButton2.ToolTip));

                    }
                }
                else if (i == 3)
                {
                    if (ImageButton3.ImageUrl == "~/Images/SelectedSeat.png")
                    {
                        lst.Add(Convert.ToString(ImageButton3.ToolTip));

                    }
                }
                else if (i == 4)
                {
                    if (ImageButton4.ImageUrl == "~/Images/SelectedSeat.png")
                    {
                        lst.Add(Convert.ToString(ImageButton4.ToolTip));

                    }
                }
                else if (i == 5)
                {
                    if (ImageButton5.ImageUrl == "~/Images/SelectedSeat.png")
                    {
                        lst.Add(Convert.ToString(ImageButton5.ToolTip));

                    }
                }
                else if (i == 6)
                {
                    if (ImageButton6.ImageUrl == "~/Images/SelectedSeat.png")
                    {
                        lst.Add(Convert.ToString(ImageButton6.ToolTip));

                    }
                }
                else if (i == 7)
                {
                    if (ImageButton7.ImageUrl == "~/Images/SelectedSeat.png")
                    {
                        lst.Add(Convert.ToString(ImageButton7.ToolTip));

                    }
                }
                else if (i == 8)
                {
                    if (ImageButton8.ImageUrl == "~/Images/SelectedSeat.png")
                    {
                        lst.Add(Convert.ToString(ImageButton8.ToolTip));

                    }
                }
                else if (i == 9)
                {
                    if (ImageButton9.ImageUrl == "~/Images/SelectedSeat.png")
                    {
                        lst.Add(Convert.ToString(ImageButton9.ToolTip));

                    }
                }
                else if (i == 10)
                {
                    if (ImageButton10.ImageUrl == "~/Images/SelectedSeat.png")
                    {
                        lst.Add(Convert.ToString(ImageButton10.ToolTip));

                    }
                }
                else if (i == 11)
                {
                    if (ImageButton11.ImageUrl == "~/Images/SelectedSeat.png")
                    {
                        lst.Add(Convert.ToString(ImageButton11.ToolTip));

                    }
                }
                else if (i == 12)
                {
                    if (ImageButton12.ImageUrl == "~/Images/SelectedSeat.png")
                    {
                        lst.Add(Convert.ToString(ImageButton12.ToolTip));

                    }
                }
                else if (i == 13)
                {
                    if (ImageButton13.ImageUrl == "~/Images/SelectedSeat.png")
                    {
                        lst.Add(Convert.ToString(ImageButton13.ToolTip));

                    }
                }
                else if (i == 14)
                {
                    if (ImageButton14.ImageUrl == "~/Images/SelectedSeat.png")
                    {
                        lst.Add(Convert.ToString(ImageButton14.ToolTip));

                    }
                }
                else if (i == 15)
                {
                    if (ImageButton15.ImageUrl == "~/Images/SelectedSeat.png")
                    {
                        lst.Add(Convert.ToString(ImageButton15.ToolTip));

                    }
                }
                else if (i == 16)
                {
                    if (ImageButton16.ImageUrl == "~/Images/SelectedSeat.png")
                    {
                        lst.Add(Convert.ToString(ImageButton16.ToolTip));

                    }
                }
                else if (i == 17)
                {
                    if (ImageButton17.ImageUrl == "~/Images/SelectedSeat.png")
                    {
                        lst.Add(Convert.ToString(ImageButton17.ToolTip));

                    }
                }
                else if (i == 18)
                {
                    if (ImageButton18.ImageUrl == "~/Images/SelectedSeat.png")
                    {
                        lst.Add(Convert.ToString(ImageButton18.ToolTip));

                    }
                }
                else if (i == 19)
                {
                    if (ImageButton19.ImageUrl == "~/Images/SelectedSeat.png")
                    {
                        lst.Add(Convert.ToString(ImageButton19.ToolTip));

                    }
                }
                else if (i == 20)
                {
                    if (ImageButton20.ImageUrl == "~/Images/SelectedSeat.png")
                    {
                        lst.Add(Convert.ToString(ImageButton20.ToolTip));

                    }
                }
                else if (i == 21)
                {
                    if (ImageButton21.ImageUrl == "~/Images/SelectedSeat.png")
                    {
                        lst.Add(Convert.ToString(ImageButton21.ToolTip));

                    }
                }
                else if (i == 22)
                {
                    if (ImageButton21.ImageUrl == "~/Images/SelectedSeat.png")
                    {
                        lst.Add(Convert.ToString(ImageButton22.ToolTip));

                    }
                }
                else if (i == 23)
                {
                    if (ImageButton23.ImageUrl == "~/Images/SelectedSeat.png")
                    {
                        lst.Add(Convert.ToString(ImageButton23.ToolTip));

                    }
                }
                else if (i == 24)
                {
                    if (ImageButton24.ImageUrl == "~/Images/SelectedSeat.png")
                    {
                        lst.Add(Convert.ToString(ImageButton24.ToolTip));

                    }
                }
                else if (i == 25)
                {
                    if (ImageButton25.ImageUrl == "~/Images/SelectedSeat.png")
                    {
                        lst.Add(Convert.ToString(ImageButton25.ToolTip));

                    }
                }
                else if (i == 26)
                {
                    if (ImageButton26.ImageUrl == "~/Images/SelectedSeat.png")
                    {
                        lst.Add(Convert.ToString(ImageButton26.ToolTip));

                    }
                }
                else if (i == 27)
                {
                    if (ImageButton27.ImageUrl == "~/Images/SelectedSeat.png")
                    {
                        lst.Add(Convert.ToString(ImageButton28.ToolTip));

                    }
                }
                else if (i == 28)
                {
                    if (ImageButton28.ImageUrl == "~/Images/SelectedSeat.png")
                    {
                        lst.Add(Convert.ToString(ImageButton28.ToolTip));

                    }
                }
                else if (i == 29)
                {
                    if (ImageButton29.ImageUrl == "~/Images/SelectedSeat.png")
                    {
                        lst.Add(Convert.ToString(ImageButton29.ToolTip));

                    }
                }
                else if (i == 30)
                {
                    if (ImageButton30.ImageUrl == "~/Images/SelectedSeat.png")
                    {
                        lst.Add(Convert.ToString(ImageButton30.ToolTip));

                    }
                }
                else if (i == 31)
                {
                    if (ImageButton31.ImageUrl == "~/Images/SelectedSeat.png")
                    {
                        lst.Add(Convert.ToString(ImageButton31.ToolTip));

                    }
                }
                else if (i == 32)
                {
                    if (ImageButton32.ImageUrl == "~/Images/SelectedSeat.png")
                    {
                        lst.Add(Convert.ToString(ImageButton32.ToolTip));

                    }
                }
                else if (i == 33)
                {
                    if (ImageButton33.ImageUrl == "~/Images/SelectedSeat.png")
                    {
                        lst.Add(Convert.ToString(ImageButton33.ToolTip));

                    }
                }
                else if (i == 34)
                {
                    if (ImageButton34.ImageUrl == "~/Images/SelectedSeat.png")
                    {
                        lst.Add(Convert.ToString(ImageButton34.ToolTip));

                    }
                }
                else if (i == 35)
                {
                    if (ImageButton35.ImageUrl == "~/Images/SelectedSeat.png")
                    {
                        lst.Add(Convert.ToString(ImageButton35.ToolTip));

                    }
                }
                else if (i == 36)
                {
                    if (ImageButton36.ImageUrl == "~/Images/SelectedSeat.png")
                    {
                        lst.Add(Convert.ToString(ImageButton36.ToolTip));

                    }
                }
                else if (i == 37)
                {
                    if (ImageButton37.ImageUrl == "~/Images/SelectedSeat.png")
                    {
                        lst.Add(Convert.ToString(ImageButton37.ToolTip));

                    }
                }
                else if (i == 38)
                {
                    if (ImageButton38.ImageUrl == "~/Images/SelectedSeat.png")
                    {
                        lst.Add(Convert.ToString(ImageButton38.ToolTip));

                    }
                }
                else if (i == 39)
                {
                    if (ImageButton39.ImageUrl == "~/Images/SelectedSeat.png")
                    {
                        lst.Add(Convert.ToString(ImageButton39.ToolTip));

                    }
                }
                else if (i == 40)
                {
                    if (ImageButton40.ImageUrl == "~/Images/SelectedSeat.png")
                    {
                        lst.Add(Convert.ToString(ImageButton40.ToolTip));

                    }
                }
                else if (i == 41)
                {
                    if (ImageButton41.ImageUrl == "~/Images/SelectedSeat.png")
                    {
                        lst.Add(Convert.ToString(ImageButton41.ToolTip));

                    }
                }
                #endregion

            }

            String str = string.Empty;
            for (int i = 0; i < lst.Count; i++)
            {
                if (str == string.Empty)
                {
                    str = lst[i].ToString();
                }
                else
                {
                    str = str + "," + lst[i].ToString();
                }
            }

            lbl_SelectedValue.Text = str;
            _displayFare();


        }
        #endregion

        #region SetBusView as per availablity
        public void SetBusView()
        {
            try
            {
                if (Session["BusDetails"] != null)
                {

                    obj = (object[])Session["BusDetails"];

                    object[] obj_bus_view = new object[2];
                    obj_bus_view[0] = obj[0]; //Busid
                    obj_bus_view[1] = obj[6]; // Routeid

                    _BusView = _pbook.GET_BUS_VIEW(obj_bus_view);

                    if (_BusView != null)
                    {
                        if (_BusView.Tables[0].Rows.Count > 0)
                        {
                            _fillBusView();

                            if (_BusView.Tables[1].Rows.Count > 0)
                            {
                                ddl_BoardingPoint.DataSource = _BusView.Tables[1];
                                ddl_BoardingPoint.DataTextField = "Location_Name";
                                ddl_BoardingPoint.DataValueField = "Location_ID";
                                ddl_BoardingPoint.DataBind();
                                //ddl_BoardingPoint.Items.Insert(0, new ListItem("Select Boarding Point", "-1"));
                                ddl_BoardingPoint.SelectedValue = "1";
                            }
                            else
                            {
                                ScriptManager.RegisterClientScriptBlock(this, GetType(), "key", "NoBoardingPointsExits();", true);
                                Session["Problem"] = "11A";
                                Response.Redirect("~\\Default.aspx");
                            }

                        }
                        else
                        {
                            ScriptManager.RegisterClientScriptBlock(this, GetType(), "key", "NoBusView();", true);

                            Session["Problem"] = "11A";
                            Response.Redirect("~\\Default.aspx");



                        }
                    }
                    else
                    {
                        ScriptManager.RegisterClientScriptBlock(this, GetType(), "key", "NoResults();", true);

                        Session["Problem"] = "11A";
                        Response.Redirect("~\\Default.aspx");

                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        #endregion

        #region _FillBusSeats
        public void _fillBusView()
        {

            ImageButton1.ImageUrl = _BusView.Tables[0].Rows[0]["SeatUrl"].ToString();
            ImageButton2.ImageUrl = _BusView.Tables[0].Rows[1]["SeatUrl"].ToString();
            ImageButton3.ImageUrl = _BusView.Tables[0].Rows[2]["SeatUrl"].ToString();
            ImageButton4.ImageUrl = _BusView.Tables[0].Rows[3]["SeatUrl"].ToString();
            ImageButton5.ImageUrl = _BusView.Tables[0].Rows[4]["SeatUrl"].ToString();
            ImageButton6.ImageUrl = _BusView.Tables[0].Rows[5]["SeatUrl"].ToString();
            ImageButton7.ImageUrl = _BusView.Tables[0].Rows[6]["SeatUrl"].ToString();
            ImageButton8.ImageUrl = _BusView.Tables[0].Rows[7]["SeatUrl"].ToString();
            ImageButton9.ImageUrl = _BusView.Tables[0].Rows[8]["SeatUrl"].ToString();
            ImageButton10.ImageUrl = _BusView.Tables[0].Rows[9]["SeatUrl"].ToString();
            ImageButton11.ImageUrl = _BusView.Tables[0].Rows[10]["SeatUrl"].ToString();
            ImageButton12.ImageUrl = _BusView.Tables[0].Rows[11]["SeatUrl"].ToString();
            ImageButton13.ImageUrl = _BusView.Tables[0].Rows[12]["SeatUrl"].ToString();
            ImageButton14.ImageUrl = _BusView.Tables[0].Rows[13]["SeatUrl"].ToString();
            ImageButton15.ImageUrl = _BusView.Tables[0].Rows[14]["SeatUrl"].ToString();
            ImageButton16.ImageUrl = _BusView.Tables[0].Rows[15]["SeatUrl"].ToString();
            ImageButton17.ImageUrl = _BusView.Tables[0].Rows[16]["SeatUrl"].ToString();
            ImageButton18.ImageUrl = _BusView.Tables[0].Rows[17]["SeatUrl"].ToString();
            ImageButton19.ImageUrl = _BusView.Tables[0].Rows[18]["SeatUrl"].ToString();
            ImageButton20.ImageUrl = _BusView.Tables[0].Rows[19]["SeatUrl"].ToString();
            ImageButton21.ImageUrl = _BusView.Tables[0].Rows[20]["SeatUrl"].ToString();
            ImageButton22.ImageUrl = _BusView.Tables[0].Rows[21]["SeatUrl"].ToString();
            ImageButton23.ImageUrl = _BusView.Tables[0].Rows[22]["SeatUrl"].ToString();
            ImageButton24.ImageUrl = _BusView.Tables[0].Rows[23]["SeatUrl"].ToString();
            ImageButton25.ImageUrl = _BusView.Tables[0].Rows[24]["SeatUrl"].ToString();
            ImageButton26.ImageUrl = _BusView.Tables[0].Rows[25]["SeatUrl"].ToString();
            ImageButton27.ImageUrl = _BusView.Tables[0].Rows[26]["SeatUrl"].ToString();
            ImageButton28.ImageUrl = _BusView.Tables[0].Rows[27]["SeatUrl"].ToString();
            ImageButton29.ImageUrl = _BusView.Tables[0].Rows[28]["SeatUrl"].ToString();
            ImageButton30.ImageUrl = _BusView.Tables[0].Rows[29]["SeatUrl"].ToString();
            ImageButton31.ImageUrl = _BusView.Tables[0].Rows[30]["SeatUrl"].ToString();
            ImageButton32.ImageUrl = _BusView.Tables[0].Rows[31]["SeatUrl"].ToString();
            ImageButton33.ImageUrl = _BusView.Tables[0].Rows[32]["SeatUrl"].ToString();
            ImageButton34.ImageUrl = _BusView.Tables[0].Rows[33]["SeatUrl"].ToString();
            ImageButton35.ImageUrl = _BusView.Tables[0].Rows[34]["SeatUrl"].ToString();
            ImageButton36.ImageUrl = _BusView.Tables[0].Rows[35]["SeatUrl"].ToString();
            ImageButton37.ImageUrl = _BusView.Tables[0].Rows[36]["SeatUrl"].ToString();
            ImageButton38.ImageUrl = _BusView.Tables[0].Rows[37]["SeatUrl"].ToString();
            ImageButton39.ImageUrl = _BusView.Tables[0].Rows[38]["SeatUrl"].ToString();
            ImageButton40.ImageUrl = _BusView.Tables[0].Rows[39]["SeatUrl"].ToString();
            ImageButton41.ImageUrl = _BusView.Tables[0].Rows[40]["SeatUrl"].ToString();




        }
        #endregion

        #region Display Fare

        public void _displayFare()
        {
          
                if (lbl_FareValue.Text != "0" && lst.Count > 0)
                {
                    lbl_final_fare_val.Text = Convert.ToString(Convert.ToDecimal(lbl_FareValue.Text) * (lst.Count));
                }
                else if (lbl_FareValue.Text == "0" && lst.Count == 0)
                {
                    lbl_FareValue.Text = "100";
                    lbl_final_fare_val.Text = Convert.ToString(Convert.ToDecimal(lbl_FareValue.Text) * (lst.Count));
                }
                else if (lst.Count == 0)
                {
                    lbl_final_fare_val.Text = "0";
                }
                Session["lst"] = lst.Count;
                hidfldCount.Value  = Convert.ToString(Session["lst"]);

           
        }

        #endregion

        #endregion

        #region Linkbuttons
        #region link button to find Another bus
        protected void lnk_otherBus_Click(object sender, EventArgs e)
        {
            Response.Redirect("~\\Booking\\BusIntegration.aspx");
        }
        #endregion
        #endregion

        #region DropdownEvents
        #region Calculate Fare from the boarding point
        protected void ddl_BoardingPoint_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CalculatingSelected_Seats();
                object[] obj_fare = new object[4];
                object[] obj_recieved = new object[12];
                obj_recieved = (object[])Session["BusDetails"];
                obj_fare[0] = obj_recieved[0]; //Busid
                obj_fare[1] = obj_recieved[6]; // Routeid
                obj_fare[2] = Convert.ToInt32(ddl_BoardingPoint.SelectedValue);
                obj_fare[3] = obj_recieved[9]; // DestinationPoint

                DataSet _FareSet = _pbook.GET_Fare_From_BoardingPoint(obj_fare);
                if (_FareSet != null)
                {
                    if (_FareSet.Tables[0].Rows.Count > 0 && _FareSet.Tables[0].Rows[0]["Fare"].ToString()!=string.Empty)
                    {
                        lbl_FareValue.Text = _FareSet.Tables[0].Rows[0]["Fare"].ToString();
                        _displayFare();
                    }
                    else if (_FareSet.Tables[0].Rows.Count > 0 && _FareSet.Tables[0].Rows[0]["Fare"].ToString()==string.Empty)
                    
                    {
                        lbl_FareValue.Text = "100";
                        //ScriptManager.RegisterClientScriptBlock(this, GetType(), "key", "NoFare();", true);

                    }
                }
                else
                {
                    lbl_FareValue.Text = "100";
                    //ScriptManager.RegisterClientScriptBlock(this, GetType(), "key", "NoFare();", true);

                }

            }
            catch (Exception ex)
            {

            }
        }
        #endregion


        #endregion

        #region img_cont_Click

        protected void img_cont_Click(object sender, ImageClickEventArgs e)
        {
            if (Session["BusDetails"] != null)
            {
                obj = (object[])Session["BusDetails"];
                object[] obj_Final_For_Booking = new object[19];
                obj_Final_For_Booking[0] = obj[1];//BusOperator
                obj_Final_For_Booking[1] = obj[12];//BusNo
                obj_Final_For_Booking[2] = obj[10];//DepartureTime
                obj_Final_For_Booking[3] = obj[11];//ArrivalTime
                obj_Final_For_Booking[4] = obj[2];//BusTypeAC
                obj_Final_For_Booking[5] = obj[3];//BusTypeVolvo
                obj_Final_For_Booking[6] = obj[4];//BusTypeSL
                obj_Final_For_Booking[7] = obj[5];//BusTypeST
                obj_Final_For_Booking[8] = ddl_BoardingPoint.SelectedValue;//Source Or Boarding Point
                obj_Final_For_Booking[9] = ddl_BoardingPoint.SelectedItem.Text;//Source Or Boarding Point
                obj_Final_For_Booking[10] = obj[9];//Destination
                obj_Final_For_Booking[11] = Session["Destination_Point_Name"].ToString();
                obj_Final_For_Booking[12] = obj[0];//Bus_ID
                obj_Final_For_Booking[13] = obj[13];//BusName
                obj_Final_For_Booking[14] = obj[6];//Route_ID
                obj_Final_For_Booking[15] = obj[7];//Bording_Date
                obj_Final_For_Booking[16] = Convert.ToInt32(Session["lst"]);//Total_Passengers
                obj_Final_For_Booking[17] = lbl_SelectedValue.Text;//SeatNos
                obj_Final_For_Booking[18] = lbl_final_fare_val.Text;//TotalAmount

                if (Convert.ToInt32(Session["lst"]) >= 1 && Convert.ToInt32(Session["lst"]) <= 6)
                {
                    Session["obj_Final_For_Booking"] = obj_Final_For_Booking;
                    Response.Redirect("~\\Booking\\TicketBooking.aspx");
                }
                else
                {
                
                }

            }

        }
        #endregion
    }
}