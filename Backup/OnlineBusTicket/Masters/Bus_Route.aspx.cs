using System;
using System.Web.UI.WebControls;
using System.Data;
using DataTransmission.Masters;
using System.Web.UI;
using System.Configuration;
using System.Data.SqlClient;
namespace OnlineBusTicket.Masters
{
    public partial class Bus_Route : System.Web.UI.Page
    {
        #region Declaration
       
        BusAllocation busAllocation;
        PBus pBus = new PBus();
        DataTable tblTotal = new DataTable();
        DataTable tblAlloted = new DataTable();
        DataTable tblProcedure = new DataTable();
       
        #endregion
        #region page Load
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
               
                funcFillRoute();

               
                trBtn.Visible = false;
                trGrid.Visible = false;
                
                lbl_msg.Visible = false;
                lbl_msg.Text = "";

                tblTotal.Columns.Clear();
                tblTotal.Rows.Clear();
                tblTotal.Columns.Add(new DataColumn("Location_ID", typeof(Int32)));
                tblTotal.Columns.Add(new DataColumn("Location_Name", typeof(String)));
                tblTotal.Columns.Add(new DataColumn("ArrivalTime", typeof(String)));
                tblTotal.Columns.Add(new DataColumn("DepartureTime", typeof(String)));
                tblTotal.Columns.Add(new DataColumn("Dist", typeof(String)));
                ViewState["tblTotal"] = tblTotal;

                tblAlloted.Columns.Clear();
                tblAlloted.Rows.Clear();
                tblAlloted.Columns.Add(new DataColumn("Location_ID", typeof(Int32)));
                tblAlloted.Columns.Add(new DataColumn("Location_Name", typeof(String)));
                tblAlloted.Columns.Add(new DataColumn("ArrivalTime", typeof(String)));
                tblAlloted.Columns.Add(new DataColumn("DepartureTime", typeof(String)));
                tblAlloted.Columns.Add(new DataColumn("Dist", typeof(String)));
                ViewState["tblAlloted"] = tblAlloted;

             	
                tblProcedure.Columns.Clear();
                tblProcedure.Rows.Clear();
                tblProcedure.Columns.Add(new DataColumn("sno", typeof(Int32)));
                tblProcedure.Columns.Add(new DataColumn("LocationId", typeof(Int32)));
                tblProcedure.Columns.Add(new DataColumn("ArrivalTime", typeof(String)));
                tblProcedure.Columns.Add(new DataColumn("DepartrTime", typeof(String)));
                tblProcedure.Columns.Add(new DataColumn("Distance", typeof(String)));
                ViewState["tblProcedure"] = tblProcedure;
            }

        }
        #endregion
        #region function
        private void funcFillRoute()
        {
            busAllocation = new BusAllocation();
            busAllocation.OFlag = 5;
            DataSet ds = pBus.funcBusRouteAllocation(busAllocation);
            if (ds.Tables[0].Rows.Count > 0)
            {
                ddlRouteName.DataSource = ds.Tables[0];
                ddlRouteName.DataTextField = "Route_Name";
                ddlRouteName.DataValueField = "Routet_ID";
                ddlRouteName.DataBind();
            }
            ddlRouteName.Items.Insert(0, "Select Route");
            ddlBusName.Items.Clear();
            ddlBusName.Items.Insert(0, "Select Bus");
        }
        private void funcFillBusName()
        {
            if (ddlRouteName.SelectedItem.Value == "Select Route")
            {
                ddlBusName.Items.Clear();  
                ddlBusName.Items.Insert(0, "Select Bus");
            }
            else
            {
                ddlBusName.Items.Clear();  
                busAllocation = new BusAllocation();
                busAllocation.Route_ID = Convert.ToInt32(ddlRouteName.SelectedItem.Value);
                busAllocation.OFlag = 6;
                DataSet ds = pBus.funcBusRouteAllocation(busAllocation);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    ddlBusName.DataSource = ds.Tables[0];
                    ddlBusName.DataTextField = "Bus_Name";
                    ddlBusName.DataValueField = "Bus_ID";
                    ddlBusName.DataBind();
                }
                ddlBusName.Items.Insert(0, "Select Bus");
            }

            trBtn.Visible = false;
            trGrid.Visible = false;
            tblTotal.Rows.Clear();
            tblAlloted.Rows.Clear();

            grdLocTotal.DataSource = null;
            grdLocTotal.DataBind();

            grdLocAlloted.DataSource = null;
            grdLocAlloted.DataBind();
            lbl_msg.Visible = false;
            lbl_msg.Text = "";
        }
        private void funcFillBusLocation()
        {
            lbl_msg.Visible = false;
            lbl_msg.Text = "";
            if (ddlBusName.SelectedItem.Value == "Select Bus")
            {
                tblTotal.Rows.Clear();
                tblAlloted.Rows.Clear();

                grdLocTotal.DataSource = null;
                grdLocTotal.DataBind();

                grdLocAlloted.DataSource = null;
                grdLocAlloted.DataBind();

                trBtn.Visible = false;
                trGrid.Visible = false;
            }
            else
            {

                trBtn.Visible = true;
                trGrid.Visible = true;

                tblTotal = (DataTable)ViewState["tblTotal"];
                tblAlloted = (DataTable)ViewState["tblAlloted"];

                busAllocation = new BusAllocation();
                busAllocation.Bus_ID = Convert.ToInt32(ddlBusName.SelectedItem.Value);
                busAllocation.Route_ID = Convert.ToInt32(ddlRouteName.SelectedItem.Value);
                busAllocation.OFlag = 7;
                DataSet ds = pBus.funcBusRouteAllocation(busAllocation);
                tblTotal = ds.Tables[0];
                tblAlloted = ds.Tables[1];

                ViewState["tblTotal"] = tblTotal;
                ViewState["tblAlloted"] = tblAlloted;


                if (tblTotal.Rows.Count > 0)
                {
                    grdLocTotal.DataSource = tblTotal;
                    grdLocTotal.DataBind();

                }
                else
                {
                    grdLocTotal.DataSource = null;
                    grdLocTotal.DataBind();
                }

                if (tblAlloted.Rows.Count > 0)
                {
                    grdLocAlloted.DataSource = tblAlloted;
                    grdLocAlloted.DataBind();

                }
                else
                {
                    grdLocAlloted.DataSource = null;
                    grdLocAlloted.DataBind();
                }
            }
        }
        #endregion
        #region Grid Event
        protected void grdLocTotal_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdLocTotal.PageIndex = e.NewPageIndex;
            funcFillBusLocation();
        }
        #endregion
        protected void ddlRouteName_SelectedIndexChanged(object sender, EventArgs e)
        {
            funcFillBusName();
        }

        protected void ddlBusName_SelectedIndexChanged(object sender, EventArgs e)
        {
            funcFillBusLocation();
        }

        protected void grdLocTotal_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {

            tblTotal = (DataTable)ViewState["tblTotal"];
            tblAlloted = (DataTable)ViewState["tblAlloted"];

            Int32 _int = e.NewSelectedIndex;
            String LocId = ((Label)(grdLocTotal.Rows[e.NewSelectedIndex].FindControl("lblLocId"))).Text;
            String Location = ((Label)(grdLocTotal.Rows[e.NewSelectedIndex].FindControl("lblLocation"))).Text;
            


          
            String expression = "Location_ID = "+ LocId;
            DataRow[] foundRows;
            foundRows = tblAlloted.Select(expression);
            if (foundRows.Length == 0)
            {
                DataRow drow = tblAlloted.NewRow();
                drow["Location_ID"] = LocId;
                drow["Location_Name"] = Location;
                drow["ArrivalTime"] = "";
                drow["DepartureTime"] = "";
                drow["Dist"] = "0";

                tblAlloted.Rows.Add(drow);
                grdLocAlloted.DataSource = tblAlloted;
                grdLocAlloted.DataBind();


            
                tblTotal.Rows.RemoveAt(_int);
 
                grdLocTotal.DataSource = tblTotal;
                grdLocTotal.DataBind();

                ViewState["tblTotal"] = tblTotal;
                ViewState["tblAlloted"] = tblAlloted;
            }
   
        }

        protected void grdLocAlloted_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            tblTotal = (DataTable)ViewState["tblTotal"];
            tblAlloted = (DataTable)ViewState["tblAlloted"];

            
            Int32 _int = e.NewSelectedIndex;
            String LocId = ((Label)(grdLocAlloted.Rows[e.NewSelectedIndex].FindControl("lblLocId"))).Text;
            String Location = ((Label)(grdLocAlloted.Rows[e.NewSelectedIndex].FindControl("lblLocation"))).Text;

           

            String expression = "Location_ID = " + LocId;
            DataRow[] foundRows;
            foundRows = tblTotal.Select(expression);
            if (foundRows.Length == 0)
            {
                DataRow drow = tblTotal.NewRow();
                drow["Location_ID"] =  LocId;
                drow["Location_Name"] = Location;
                drow["ArrivalTime"] = "";
                drow["DepartureTime"] = "";
                drow["Dist"] = "0";

                tblTotal.Rows.Add(drow);
                grdLocTotal.DataSource = tblTotal;
                grdLocTotal.DataBind();


                tblAlloted.Rows.RemoveAt(_int);
                grdLocAlloted.DataSource = tblAlloted;
                grdLocAlloted.DataBind();


                ViewState["tblTotal"] = tblTotal;
                ViewState["tblAlloted"] = tblAlloted;
            }
                   
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {

            tblAlloted = (DataTable)ViewState["tblAlloted"];
           
            tblProcedure = (DataTable)ViewState["tblProcedure"];
            tblProcedure.Rows.Clear();
            Int32 j =0;
            foreach (GridViewRow grdR in grdLocAlloted.Rows)
            { 
                Label lblLocId = (Label)grdR.FindControl("lblLocId");
                Label lblLocation = (Label)grdR.FindControl("lblLocation");
                
                TextBox  txtArrival = (TextBox)grdR.FindControl("txtArrival");
                TextBox  txtDeparture = (TextBox)grdR.FindControl("txtDeparture");
                TextBox  txtDistance = (TextBox)grdR.FindControl("txtDistance");

                        DataRow drow = tblProcedure.NewRow();
                        drow["Sno"] = j;
                        drow["LocationId"] = lblLocId.Text;
                        drow["ArrivalTime"] = txtArrival.Text;
                        drow["DepartrTime"] = txtDeparture.Text;
                        drow["Distance"] = txtDistance.Text; 
                      
                        tblProcedure.Rows.Add(drow);
                       j += 1;
            }

            if (tblProcedure.Rows.Count > 3)
            {

                string strcon = ConfigurationManager.ConnectionStrings["Connection String"].ToString();
                SqlConnection con = new SqlConnection(strcon);
                SqlCommand cmd = new SqlCommand();
                SqlDataReader dr = null;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;
                cmd.CommandText = "usp_ETicket_BUS_ROUTE_LOCATION_Save";
                cmd.Parameters.AddWithValue("@tblBusLocationAllocation", tblProcedure);
                cmd.Parameters.AddWithValue("@Bus_Id", ddlBusName.SelectedItem.Value);
                cmd.Parameters.AddWithValue("@Route_Id", ddlRouteName.SelectedItem.Value);
                cmd.Parameters.AddWithValue("@LoginBy", Convert.ToString(Session["LogIN"]));

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


                    trBtn.Visible = false;
                    trGrid.Visible = false;
                    tblTotal.Rows.Clear();
                    tblAlloted.Rows.Clear();



                    grdLocTotal.DataSource = null;
                    grdLocTotal.DataBind();

                    grdLocAlloted.DataSource = null;
                    grdLocAlloted.DataBind();
                    ddlRouteName.SelectedValue = "Select Route";

                    ddlRouteName.SelectedValue = "Select Route";
                    ddlBusName.Items.Clear();
                    ddlBusName.Items.Insert(0, "Select Bus");
                    ddlBusName.SelectedValue = "Select Bus";

                    lbl_msg.Visible = true;
                    lbl_msg.Text = "Record Saved Successfully";
                }
                con.Close();

            }
            else
            {
                lbl_msg.Visible = true;
                lbl_msg.Text = "Please Add Atlaest 4 Location to a Route";
            }
        }

        protected void btncancel_Click(object sender, EventArgs e)
        {
            trBtn.Visible = false;
            trGrid.Visible = false;
            tblTotal.Rows.Clear();
            tblAlloted.Rows.Clear();

            ddlRouteName.SelectedValue = "Select Route";

            ddlBusName.Items.Clear();
            ddlBusName.Items.Insert(0, "Select Bus");
            ddlBusName.SelectedValue = "Select Bus";

            grdLocTotal.DataSource = null;
            grdLocTotal.DataBind();

            grdLocAlloted.DataSource = null;
            grdLocAlloted.DataBind();
            lbl_msg.Visible = false;
            lbl_msg.Text = "";
        }

 
    }
}