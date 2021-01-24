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
    public partial class Operators : System.Web.UI.Page
    {
        #region Declaration
        Operator operat;
        POperator poperator = new POperator();
        DataTable dt = new DataTable();
        int routeid;
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
                    #region Making DropDown Select as first entry
                    ddlOperatorType.Items.Insert(0, new ListItem("--Select Operator--", "-1"));

                    BindOperatorDropDown();
                    #endregion
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
                ddlOperatorType.SelectedIndex = -1;
                


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
                DataTable dtROperat = new DataTable();
                operat = new Operator();
                if (btnSave.Text == "Save")
                {
                    operat.OperatorName = txtOperatorname.Text.Trim();
                    operat.OperatorTypeID = Convert.ToInt32(ddlOperatorType.SelectedValue);
                    operat.Description = txtdescription.Text.Trim();
                    operat.OFlag = 1;
                    int val = poperator.FuncInsertUpdateDeleteOperator(operat);
                    if (val > 0)
                    {
                        lbl_msg.Text = "";
                        lbl_msg.Text = "Record saved successfully.";
                        lbl_msg.Visible = true;
                        txtOperatorname.Text = "";
                        
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
                    operat.OperatorID = Convert.ToInt32(ViewState["Operator_ID"]);
                    operat.OperatorName = txtOperatorname.Text.Trim();
                    operat.OperatorTypeID = Convert.ToInt32(ddlOperatorType.SelectedValue);
                    operat.Description = txtdescription.Text.Trim();
                    operat.updatedBy = "HCL";
                  
                    operat.OFlag = 2;

                    int val = poperator.FuncInsertUpdateDeleteOperator(operat);
                    if (val > 0)
                    {
                        lbl_msg.Text = "";
                        lbl_msg.Text = "Record updated successfully.";
                        lbl_msg.Visible = true;
                        txtOperatorname.Text = "";
                        
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
                txtOperatorname.Text = string.Empty;
                ddlOperatorType.SelectedIndex = -1;
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
                Response.Redirect("Operators.aspx");
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
                operat = new Operator();
                operat.OFlag = 4;
                DataTable dt = poperator.GetOperatordescription(operat);
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
                operat = new Operator();
                dt = (DataTable)ViewState["Dt"];
                if (e.CommandName == "GoToEdit")
                {

                    if (dt.Rows.Count > 0)
                    {
                        GridViewRow row = (GridViewRow)(((LinkButton)e.CommandSource).NamingContainer);
                        int i = row.RowIndex;
                        LinkButton btnLink = (LinkButton)row.FindControl("lnkBtnEdit");
                        ViewState["Operator_ID"] = (grdrecord.DataKeys[i].Value);
                        Label txtgrdOperatorName = (Label)row.FindControl("txtgrdOperatorName");
                        Label txtgrdOperatorType = (Label)row.FindControl("txtgrdOperatorType");
                        Label txtgrdDescription = (Label)row.FindControl("txtgrdDescription");

                        txtOperatorname.Text = txtgrdOperatorName.Text;
                        ddlOperatorType.SelectedItem.Text = txtgrdOperatorType.Text;
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
                        ViewState["Operator_ID"] = (grdrecord.DataKeys[i].Value);
                    }
                    operat.OperatorID = Convert.ToInt32(ViewState["Operator_ID"]);
                    operat.OFlag = 3;
                    int v = poperator.FuncInsertUpdateDeleteOperator(operat);
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

        #region BindDropdownList
        public void BindOperatorDropDown()
        {
            try
            {

                CommonUtility.getDDLData(ddlOperatorType, "Type_Name", "Operator_Type_ID", "Eticket_LKP_OperatorType", "", "");
                ddlOperatorType.Items.Insert(0, new ListItem("--Select--", "-1"));

               
            }
            catch (Exception ex)
            {

                lbl_msg.Visible = true;
                lbl_msg.Text = ex.ToString();
                lbl_msg.CssClass = "general";
            }

        }
        #endregion

        

        

    }
}