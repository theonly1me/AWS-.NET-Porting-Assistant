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
using DataTransmission.Booking;




namespace OnlineBusTicket.Booking
{
    public partial class Agent_History : System.Web.UI.Page
    {
        #region Declaration
        PAgent pagent = new PAgent();
        #endregion

        #region PageLoad
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    bindAgentHistory();
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

        #region bindAgentHistory
        public void bindAgentHistory()
        {
            try
            {
                object[] obj = new object[1];

                obj[0] = Convert.ToInt32(Session["User_ID"]); //OFlag

                DataTable dt = pagent.GetAgentHistoryDetails(obj);
                grdAgentHistory.DataSource = dt;
                grdAgentHistory.DataBind();
                ViewState["ViewHistory"] = dt;
               
            }
            catch (Exception ex)
            {
                lbl_msg.Visible = true;
                lbl_msg.Text = ex.ToString();
                lbl_msg.CssClass = "general";
            }

        }
        #endregion

        #region btnSearch_Click
        protected void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string filter = "Booking_ID = '" + txtTicketNo.Text + "'";
                DataTable dt = new DataTable();
                dt = (DataTable)ViewState["ViewHistory"];
                DataView dv = dt.DefaultView;

                dv.RowFilter = filter;
                DataTable searchdt = new DataTable();
                searchdt = dv.ToTable();
                grdAgentHistory.DataSource = searchdt;
                grdAgentHistory.DataBind();

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