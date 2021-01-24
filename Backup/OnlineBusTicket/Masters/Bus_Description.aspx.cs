using System;
using System.Web.UI.WebControls;
using System.Data;
using DataTransmission.Masters;
using System.Web.UI;
namespace OnlineBusTicket.Masters
{
    public partial class Bus_Description : System.Web.UI.Page
    {
        #region Declaration
        Bus bus;
        PBus pBus = new PBus();
        #endregion
        #region page Load
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                funcGridBind();
                for (int i = 41; i <= 41; i++)
                {
                    ddlNoOfSeats.Items.Add(new ListItem(i.ToString()));
                }
                
                String WhereClause1 = "Isactive=1";
                pBus.getDDLMultiWhereth(ddlOperator, "Operator_Name", "Operator_ID", "Eticket_MST_Operators", WhereClause1.ToString());
                ddlOperator.Items.Insert(0, "Select Operator");

                String WhereClause2 = "Isactive=1";
                pBus.getDDLMultiWhereth(ddlBusRoute, "Route_Name", "Routet_ID", "Eticket_MST_Route_Name", WhereClause2.ToString());
                ddlBusRoute.Items.Insert(0, "Select Route");
               
                trBtn.Visible = true;
                trGrid.Visible = true;
                trAddEdit.Visible = false;

                btnAddNew.Visible = true;
                btnSave.Visible = false;
                btnReset.Visible = false;
                btnCancel.Visible = false;

                btnSave.Text = "";
            }

        }
        #endregion
        #region function
        private void funcGridBind()
        {
            try
            {
                txtChargPerKm.Attributes.Add("onkeypress", "javascript:return allownumbers(event);");

                bus = new Bus();
                bus.OFlag = 4;
                DataSet ds = pBus.funcBusMaster(bus);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    grdBus.DataSource = ds.Tables[0];
                    grdBus.DataBind();

                }
                else
                {
                    grdBus.DataSource = null;
                    grdBus.DataBind();
                }
            }
            catch (Exception ex)
            {

               
            }

        }
        private void funcSave()
        {
            bus = new Bus();
            bus.Bus_ID = 0;
            bus.Bus_Name = txtBusName.Text.Trim();
            bus.Bus_No = txtBusNo.Text.Trim();
            bus.Bus_Operator_ID = Convert.ToInt32(ddlOperator.SelectedValue);
            bus.Routet_ID = Convert.ToInt32(ddlBusRoute.SelectedValue);
            bus.Bus_Desc = txtDescription.Text.Trim();
            if (chckVolvo.Checked == true)
            {
                bus.Bus_Volvo = 1;
            }
            else
            {
                bus.Bus_Volvo = 0;
            }

            if (chckAC.Checked == true)
            {
                bus.Bus_AC = 1;
            }
            else
            {
                bus.Bus_AC = 0;
            }

            if (chckSL.Checked == true)
            {
                bus.Bus_SL = 1;
            }
            else
            {
                bus.Bus_SL = 0;
            }

            if (chckST.Checked == true)
            {
                bus.Bus_ST = 1;
            }
            else
            {
                bus.Bus_ST = 0;
            }

            bus.LogIN = "Ashu";
            bus.Bus_Seater = Convert.ToInt32(ddlNoOfSeats.SelectedItem.Value);
            bus.Charge = Convert.ToInt32(txtChargPerKm.Text);
            bus.OFlag = 1;

            DataSet ds = pBus.funcBusMaster(bus);
            if (ds.Tables[0].Rows.Count > 0)
            {
                grdBus.DataSource = ds.Tables[0];
                grdBus.DataBind();

            }
            else
            {
                grdBus.DataSource = null;
                grdBus.DataBind();
            }

        }
        private void funcUpdate()
        {
            bus = new Bus();
            bus.Bus_ID = Convert.ToInt32(Session["BusId"]);
            bus.Bus_Name = txtBusName.Text.Trim();
            bus.Bus_No = txtBusNo.Text.Trim();
            bus.Bus_Operator_ID = Convert.ToInt32(ddlOperator.SelectedValue);
            bus.Routet_ID = Convert.ToInt32(ddlBusRoute.SelectedValue);
            bus.Bus_Desc = txtDescription.Text.Trim();
            if (chckVolvo.Checked == true)
            {
                bus.Bus_Volvo = 1;
            }
            else
            {
                bus.Bus_Volvo = 0;
            }

            if (chckAC.Checked == true)
            {
                bus.Bus_AC = 1;
            }
            else
            {
                bus.Bus_AC = 0;
            }

            if (chckSL.Checked == true)
            {
                bus.Bus_SL = 1;
            }
            else
            {
                bus.Bus_SL = 0;
            }

            if (chckST.Checked == true)
            {
                bus.Bus_ST = 1;
            }
            else
            {
                bus.Bus_ST = 0;
            }

            bus.LogIN = "Ashu";
            bus.Bus_Seater = Convert.ToInt32(ddlNoOfSeats.SelectedItem.Value);
            bus.Charge = Convert.ToInt32(txtChargPerKm.Text);
            bus.OFlag = 2;

            DataSet ds = pBus.funcBusMaster(bus);
            if (ds.Tables[0].Rows.Count > 0)
            {
                grdBus.DataSource = ds.Tables[0];
                grdBus.DataBind();

            }
            else
            {
                grdBus.DataSource = null;
                grdBus.DataBind();
            }

        }
        private void funcDelete()
        {
            bus = new Bus();
            bus.Bus_ID = Convert.ToInt32(Session["BusId"]);
            bus.LogIN = "Ashu";
            bus.OFlag = 3;

            DataSet ds = pBus.funcBusMaster(bus);
            if (ds.Tables[0].Rows.Count > 0)
            {
                grdBus.DataSource = ds.Tables[0];
                grdBus.DataBind();

            }
            else
            {
                grdBus.DataSource = null;
                grdBus.DataBind();
            }

        }
        #endregion
        #region Grid Event
        protected void grdBus_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdBus.PageIndex = e.NewPageIndex;
            funcGridBind();
        }
        protected void grdBus_RowCommand(object sender, GridViewCommandEventArgs e)
        {

            bus = new Bus();
            if (e.CommandName == "GoToEdit")
            {

                GridViewRow row = (GridViewRow)(((LinkButton)e.CommandSource).NamingContainer);
                int i = row.RowIndex;
                Label lblOprId = (Label)row.FindControl("lblOprId");
                Label lblRouteId = (Label)row.FindControl("lblRouteId");
                Label lblDesc = (Label)row.FindControl("lblDesc");
                Label lblCharge = (Label)row.FindControl("lblCharge");
               
 
                CheckBox chckBoxVolvo = (CheckBox)row.FindControl("chckBoxVolvo");
                CheckBox chckBoxAC = (CheckBox)row.FindControl("chckBoxAC");
                CheckBox chckBoxSL = (CheckBox)row.FindControl("chckBoxSL");
                CheckBox chckBoxST = (CheckBox)row.FindControl("chckBoxST");

                Session["BusId"] = Convert.ToInt32(grdBus.DataKeys[i].Value);

                txtBusName.Text = row.Cells[1].Text.Trim();
                txtBusNo.Text = row.Cells[2].Text.Trim();
                ddlOperator.SelectedValue = lblOprId.Text;
                ddlBusRoute.SelectedValue = lblRouteId.Text;
                txtDescription.Text = lblDesc.Text.Trim();  

                chckVolvo.Checked = Convert.ToBoolean(chckBoxVolvo.Checked);
                chckAC.Checked = Convert.ToBoolean(chckBoxAC.Checked);
                chckSL.Checked = Convert.ToBoolean(chckBoxSL.Checked);
                chckST.Checked = Convert.ToBoolean(chckBoxST.Checked);
                ddlNoOfSeats.SelectedValue = row.Cells[5].Text.Trim();
                txtChargPerKm.Text = lblCharge.Text;

                trBtn.Visible = true;
                trGrid.Visible = false;
                trAddEdit.Visible = true;

                btnAddNew.Visible = false;
                btnSave.Visible = true;
                btnReset.Visible = true;
                btnCancel.Visible = true;
                btnSave.Text = "Update";
                
            }
            else if (e.CommandName == "GoToDelete")
            {
                GridViewRow row = (GridViewRow)(((LinkButton)e.CommandSource).NamingContainer);
                int i = row.RowIndex;
                Label lblOprId = (Label)row.FindControl("lblOprId");
                Label lblRouteId = (Label)row.FindControl("lblRouteId");

                CheckBox chckBoxVolvo = (CheckBox)row.FindControl("chckBoxVolvo");
                CheckBox chckBoxAC = (CheckBox)row.FindControl("chckBoxAC");
                CheckBox chckBoxSL = (CheckBox)row.FindControl("chckBoxSL");
                CheckBox chckBoxST = (CheckBox)row.FindControl("chckBoxST");

                Session["BusId"] = Convert.ToInt32(grdBus.DataKeys[i].Value);
                funcDelete(); 
            }
        }
        #endregion
        #region BtnEvent
        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            trBtn.Visible = true;
            trGrid.Visible = false;
            trAddEdit.Visible = true;

            btnAddNew.Visible = false;
            btnSave.Visible = true;
            btnReset.Visible = true;
            btnCancel.Visible = true;
            btnSave.Text = "Save";
        }
        protected void btnSave_Click(object sender, EventArgs e)
        {
            if ((chckVolvo.Checked == false && chckAC.Checked == false && chckSL.Checked == false && chckST.Checked == false) == true)
            {
                ScriptManager.RegisterClientScriptBlock(this, GetType(), "hh", "alert('Please Select atleast one Classification');", true);
            }
            else
            {
                if (btnSave.Text == "Save")
                {
                    funcSave();
                }
                else if (btnSave.Text == "Update")
                {
                    funcUpdate();
                }
                trBtn.Visible = true;
                trGrid.Visible = true;
                trAddEdit.Visible = false;

                btnAddNew.Visible = true;
                btnSave.Visible = false;
                btnReset.Visible = false;
                btnCancel.Visible = false;
                btnSave.Text = "";
            }
        }
        protected void btnReset_Click(object sender, EventArgs e)
        {
            Session["BusId"] = 0;
            txtBusName.Text = "";
            txtBusNo.Text = "";
            ddlOperator.SelectedValue = "Select Operator";
            txtDescription.Text = "";
            chckVolvo.Checked = false;
            chckAC.Checked = false;
            chckSL.Checked = false;
            chckST.Checked = false;
            
         
            ddlNoOfSeats.SelectedItem.Value = "41";
        }
        protected void btnCancel_Click(object sender, EventArgs e)
        {
            trBtn.Visible = true;
            trGrid.Visible = true;
            trAddEdit.Visible = false;

            btnAddNew.Visible = true;
            btnSave.Visible = false;
            btnReset.Visible = false;
            btnCancel.Visible = false;
        }
        #endregion
    }
}