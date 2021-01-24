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
    public partial class Locations : System.Web.UI.Page
    {
        #region Declaration
        Location location;
        PLocation plocation = new PLocation();
        DataTable dt = new DataTable();
        int locationid;
        #endregion

        #region PageLoad
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

        #region Grid Events

        #region Grid Bind
        private void GridBind()
        {
            try
            {
                location = new Location();
                location.OFlag = 4;
                DataTable dt = plocation.GetLocationdescription(location);
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
                location = new Location();
                dt = (DataTable)ViewState["Dt"];
                if (e.CommandName == "GoToEdit")
                {

                    if (dt.Rows.Count > 0)
                    {
                        GridViewRow row = (GridViewRow)(((LinkButton)e.CommandSource).NamingContainer);
                        int i = row.RowIndex;
                        LinkButton btnLink = (LinkButton)row.FindControl("lnkBtnEdit");
                        ViewState["Location_ID"] = (grdrecord.DataKeys[i].Value);
                        Label txtgrdLocationName = (Label)row.FindControl("txtgrdLocationName");
                        Label txtgrdLocationCode = (Label)row.FindControl("txtgrdLocationCode");
                        Label txtgrdDescription = (Label)row.FindControl("txtgrdDescription");

                        txtLocationname.Text = txtgrdLocationName.Text;
                        txtLocationCode.Text = txtgrdLocationCode.Text;
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
                        ViewState["Location_ID"] = (grdrecord.DataKeys[i].Value);
                    }
                    location.LocationID = Convert.ToInt32(ViewState["Location_ID"]);
                    location.OFlag = 3;
                    int v = plocation.FuncInsertUpdateDeleteLocation(location);
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

        #region btnSave_Click
        protected void btnSave_Click(object sender, EventArgs e)
        {
             try
            {
                DataTable dtLocation = new DataTable();
                location = new Location();
                if (btnSave.Text == "Save")
                {
                    location.LocationCode = txtLocationCode.Text.Trim();
                    location.LocationName = txtLocationname.Text.Trim();
                    location.Description = txtdescription.Text.Trim();
                    location.OFlag = 1;
                    int val = plocation.FuncInsertUpdateDeleteLocation(location);
                    if (val > 0)
                    {
                        lbl_msg.Text = "";
                        lbl_msg.Text = "Record saved successfully.";
                        lbl_msg.Visible = true;
                        txtLocationCode.Text = "";
                        txtLocationname.Text = "";
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
                    location.LocationCode = txtLocationCode.Text.Trim();
                    location.LocationName = txtLocationname.Text.Trim();
                    location.Description = txtdescription.Text.Trim();
                    location.LocationID = Convert.ToInt32(ViewState["Location_ID"]);
                    location.OFlag = 2;

                    int val = plocation.FuncInsertUpdateDeleteLocation(location);
                    if (val > 0)
                    {
                        lbl_msg.Text = "";
                        lbl_msg.Text = "Record updated successfully.";
                        lbl_msg.Visible = true;
                        txtLocationCode.Text = "";
                        txtLocationname.Text = "";
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

        #region btnReset_Click
        protected void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                txtLocationname.Text = string.Empty;
                txtLocationCode.Text = string.Empty;
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
                Response.Redirect("Locations.aspx");
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