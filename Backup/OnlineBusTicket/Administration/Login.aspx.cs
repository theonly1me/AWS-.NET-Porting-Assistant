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
    public partial class Login : System.Web.UI.Page
    {
        UserAcount oUserAcount;
        PUserAcount oPUserAcount;
        DataSet ds;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
               
            }
        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            UserAuthentication();
        }

        protected void UserAuthentication()
        {
            oUserAcount = new UserAcount
            {
                Flag = 2,
                EMail = txtEMail.Text,
                Password = txtPassword.Text,              
            };
            oPUserAcount = new PUserAcount();           
            ds = oPUserAcount.UserAcount(oUserAcount);
            string s = ds.Tables[0].Rows[0][0].ToString();
            string[] Param = s.Split(new string[] { "*" }, StringSplitOptions.None);
            if (Param.Length==3)
            {
                Session["User_ID"] = Param[0];
                Session["User_Type"] = Param[1];
                Session["Login"] = Param[2];
               
                if (Param[1] == "4")
                {
                    Response.Redirect("~/Administration/AgentApprove.aspx");
                }
            }
            else
            {
                lblFailureText.Visible = true;
                lblFailureText.Text = s;
            }
           
        }
      
    }
}