using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineBusTicket
{
    public partial class SiteMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if(Request.QueryString["UT"] !=null)
                {
                   Session["User_Type"] = Request.QueryString["UT"];                   
                }
                if (Session["User_Type"].ToString()!="5")   //If Registered User In.  Not Guest User
                {
                  trViewAdmin.Visible = Session["User_Type"].ToString() == "4" ? true:false;
                  trViewDefault.Visible = (Session["User_Type"].ToString() == "2" || Session["User_Type"].ToString() == "1") ? true : false;
                  lnkLogin.Text = Session["Login"].ToString();
                  liReg.Visible = false;
                  liRegAgent.Visible = false;
                }
                else //Guest User
                {
                  trViewAdmin.Visible = false;
                  trViewDefault.Visible = false;
                  liReg.Visible = true;
                  liRegAgent.Visible = true;
                  lnkSignOut.Visible = false;
                }
            }
        }

        protected void lnkSignOut_Click(object sender, EventArgs e)
        {
            Session.Remove("Login");
            Session.Clear();
            Session.Abandon();
            Session["Login"] = null;
            Response.Redirect("~/Default.aspx");
        }

        protected void lnkLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
