using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataTransmission;
using System.Data;
namespace OnlineBusTicket.Administration
{
    public partial class AgentApprove : System.Web.UI.Page
    {
        UserAcount oUserAcount;
        PUserAcount oPUserAcount;
        DataSet ds;
        protected void Page_Load(object sender, EventArgs e)
        {
            lblMsg.Visible = false;
            if (!IsPostBack)
            {
                Bind();
            }
        }
        protected void Bind()
        {          
            oUserAcount = new UserAcount
            {
                Flag = 3,
                IsActive = false
            };
            oPUserAcount = new PUserAcount();
            ds = oPUserAcount.UserAcount(oUserAcount);
            grdAgent.DataSource = ds;
            grdAgent.DataBind();
        }
        protected void Approve()
        {
            System.Text.StringBuilder strUserIds = new System.Text.StringBuilder();
            foreach (GridViewRow i in grdAgent.Rows)
            {
                CheckBox c1 = (CheckBox)i.FindControl("chkSelect");
                if (c1.Checked == true)
                {
                    string UserId = grdAgent.DataKeys[i.RowIndex].Values[0].ToString() + ",";
                    strUserIds.Append(UserId);
                }
            }
            if (strUserIds.Length > 0)
            {
                strUserIds.Remove(strUserIds.Length - 1, 1);
                oUserAcount = new UserAcount
                {
                    Flag = 4,
                    UserIds = strUserIds.ToString(),  
                    IsActive = true
                };
                oPUserAcount = new PUserAcount();
                ds = oPUserAcount.UserAcount(oUserAcount);
                lblMsg.Visible = true;
                lblMsg.Text = ds.Tables[0].Rows[0][0].ToString();
                Bind();
            }
            else
            {
                lblMsg.Visible = true;
                lblMsg.Text = "No agent is selected.";
                lblMsg.CssClass = "valid";
                return;
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            Approve();
           
        }
        protected void grdAgent_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdAgent.PageIndex = e.NewPageIndex;
            Bind();
        }

      
    }
}