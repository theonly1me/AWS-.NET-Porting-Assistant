using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataTransmission.Masters;
using DataTransmission;
using System.Text;

namespace OnlineBusTicket.Masters
{
    public partial class Routes : System.Web.UI.Page
    {
        #region Declaration
        Route route;
        PRoute proute = new PRoute();
        DataTable dt = new DataTable();
        int routeid;
        #endregion

        #region Page Load
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                lbl_msg.Text = "";
                lbl_msg.Visible = false;
                if (!IsPostBack)
                {

                    GridBind();
                    btnAddNew.Visible = true;
                    inputarea.Visible = false;
                    pnlrecord.Visible = true;
                    grdrecord.Visible = true;
                    Pnlnew.Visible = false;
                    btnSave.Visible = false;
                    btnCancel.Visible = false;
                    btnReset.Visible = false;
                }
            }
            catch(Exception ex)
            {

                lbl_msg.Visible = true;
                lbl_msg.Text = ex.ToString();
                lbl_msg.CssClass = "general";
            }
        }
         #endregion

        #region Button Events

        #region btnAddNew_Click
        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                pnlrecord.Visible = false;
                Pnlnew.Visible = true;
                inputarea.Visible = true;
                btnCancel.Visible = true;
                btnReset.Visible = true;
                btnSave.Visible = true;
                btnAddNew.Visible = false;
                lbl_msg.Visible = false;

            }
            catch (Exception ex)
            {

                lbl_msg.Visible = true;
                lbl_msg.Text = ex.ToString();
                lbl_msg.CssClass = "general";
            }
        }

        #endregion

        #region btnReset_Click
        protected void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                txtRoutename.Text = string.Empty;
                txtRouteCode.Text = string.Empty;
                txtdescription.Text = string.Empty;
            }
            catch (Exception ex)
            {

                lbl_msg.Visible = true;
                lbl_msg.Text = ex.ToString();
                lbl_msg.CssClass = "general";
            }
        }
        #endregion

        #region btnCancel_Click
        protected void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                Response.Redirect("Routes.aspx");
            }
            catch (Exception ex)
            {

                lbl_msg.Visible = true;
                lbl_msg.Text = ex.ToString();
                lbl_msg.CssClass = "general";
            }
        }
        #endregion

        #region btnSave_Click
        protected void btnSave_Click(object sender, EventArgs e)
        {
           
            try
            {
                DataTable dtRoute = new DataTable();
                route = new Route();
                if (btnSave.Text == "Save")
                {
                    route.RouteName = txtRoutename.Text.Trim();
                    route.RouteCode = txtRouteCode.Text.Trim();
                    route.Description = txtdescription.Text.Trim();
                    route.OFlag = 1;
                    int val = proute.FuncInsertUpdateDeleteRoute(route);
                    if (val > 0)
                    {
                        lbl_msg.Text = "";
                        lbl_msg.Text = "Record saved successfully.";
                        lbl_msg.Visible = true;
                        txtRoutename.Text = "";
                        txtRouteCode.Text = "";
                        txtdescription.Text = "";
                        GridBind();
                        inputarea.Visible = false;
                        Pnlnew.Visible = false;
                        btnAddNew.Visible = true;
                        btnSave.Visible = false;
                        btnReset.Visible = false;
                        btnCancel.Visible = false;

                    }
                    else
                    {
                        lbl_msg.Text = "";
                        lbl_msg.Text = "Record not saved.";
                        lbl_msg.Visible = true;
                    }
                }
                else if (btnSave.Text == "Update")
                {
                    route.RouteName = txtRoutename.Text.Trim();
                    route.RouteCode = txtRouteCode.Text.Trim();
                    route.Description = txtdescription.Text.Trim();
                    route.RouteID = Convert.ToInt32(ViewState["Routet_ID"]);
                    route.OFlag = 2;

                    int val = proute.FuncInsertUpdateDeleteRoute(route);
                    if (val > 0)
                    {
                        lbl_msg.Text = "";
                        lbl_msg.Text = "Record updated successfully.";
                        lbl_msg.Visible = true;
                        txtRoutename.Text = "";
                        txtRouteCode.Text = "";
                        txtdescription.Text = "";
                        GridBind();
                        inputarea.Visible = false;
                        Pnlnew.Visible = false;
                        btnAddNew.Visible = true;
                        btnSave.Visible = false;
                        btnCancel.Visible = false;
                        btnReset.Visible = false;

                    }
                    else
                    {
                        lbl_msg.Text = "";
                        lbl_msg.Text = "Record not updated.";
                        lbl_msg.Visible = true;
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

        #endregion

        #region Grid Events

        #region Grid Bind
        private void GridBind()
        {
            try
            {
                route = new Route();
                route.OFlag = 4;
                DataTable dt = proute.GetRoutedescription(route);
                ViewState["Dt"] = dt;
                if (dt.Rows.Count > 0)
                {
                    grdrecord.DataSource = dt;
                    grdrecord.DataBind();
                    pnlrecord.Visible = true;

                }
                else
                {
                    lbl_msg.Text = "No Record found";
                    lbl_msg.Visible = true;
                    grdrecord.DataSource = null;
                    grdrecord.DataBind();
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

        #region grdrecord_RowCommand
        protected void grdrecord_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                lbl_msg.Visible = false;
                route = new Route();
                dt = (DataTable)ViewState["Dt"];
                if (e.CommandName == "GoToEdit")
                {

                    if (dt.Rows.Count > 0)
                    {
                        GridViewRow row = (GridViewRow)(((LinkButton)e.CommandSource).NamingContainer);
                        int i = row.RowIndex;
                        LinkButton btnLink = (LinkButton)row.FindControl("lnkBtnEdit");
                        ViewState["Routet_ID"] = (grdrecord.DataKeys[i].Value);
                        Label txtgrdRouteName = (Label)row.FindControl("txtgrdRouteName");
                        Label txtgrdRouteCode = (Label)row.FindControl("txtgrdRouteCode");
                        Label txtgrdDescription = (Label)row.FindControl("txtgrdDescription");

                        txtRoutename.Text = txtgrdRouteName.Text;
                        txtRouteCode.Text = txtgrdRouteCode.Text;
                        txtdescription.Text = txtgrdDescription.Text;
                    }

                    btnSave.Text = "Update";
                    btnSave.Visible = true;
                    Pnlnew.Visible = true;
                    inputarea.Visible = true;
                    pnlrecord.Visible = false;
                    btnAddNew.Visible = false;
                    btnCancel.Visible = true;
                    btnReset.Visible = true;


                }
                else if (e.CommandName == "GoToDelete")
                {

                    lbl_msg.Visible = false;
                    if (dt.Rows.Count > 0)
                    {
                        GridViewRow row = (GridViewRow)(((LinkButton)e.CommandSource).NamingContainer);
                        int i = row.RowIndex;
                        LinkButton btnLink = (LinkButton)row.FindControl("lnkBtnEdit");
                        ViewState["RouteID"] = (grdrecord.DataKeys[i].Value);
                    }
                    route.RouteID = Convert.ToInt32(ViewState["RouteID"]);
                    route.OFlag = 3;
                    int v = proute.FuncInsertUpdateDeleteRoute(route);
                    if (v > 0)
                    {
                        lbl_msg.Text = "";
                        lbl_msg.Text = "Record deleted successfully";
                        lbl_msg.Visible = true;
                        GridBind();
                    }
                    else
                    {
                        lbl_msg.Text = "Record not deleted successfully.";
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

        #region grdrecord_PageIndexChanging
        protected void grdrecord_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            try
            {
                grdrecord.PageIndex = e.NewPageIndex;
                grdrecord.DataSource = ViewState["Dt"];
                grdrecord.DataBind();
                lbl_msg.Visible = false;
            }
            catch (Exception ex)
            {

                lbl_msg.Visible = true;
                lbl_msg.Text = ex.ToString();
                lbl_msg.CssClass = "general";
            }


        }

        #endregion

        #endregion
    }
    
}