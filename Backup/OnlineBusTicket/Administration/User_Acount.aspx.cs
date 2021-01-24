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
    public partial class User_Acount : System.Web.UI.Page
    {
        UserAcount oUserAcount;
        PUserAcount oPUserAcount;
        DataSet ds;
        protected void Page_Load(object sender, EventArgs e)
        {           
            ViewState["RegisterAs"] = Request.QueryString["R"];
            tblMsg.Visible = false;
            this.txtPassword.Attributes.Add("value", this.txtPassword.Text);
            this.txtConfirmPassword.Attributes.Add("value", this.txtConfirmPassword.Text);
            tblAgent.Visible = ViewState["RegisterAs"].ToString() == "1" ? false : true;
            HyperLink2.Text = Request.QueryString["R"] == "1" ? "Register as Travel Agent" : "Register as Normal User";
            HyperLink2.NavigateUrl = Request.QueryString["R"] == "1" ? "~/Administration/User_Acount.aspx?R=2" : "~/Administration/User_Acount.aspx?R=1";  
            if (!IsPostBack)
            {
                                           
            }
        }

        protected void BindUserType()
        {
            //rdBtnUserType.DataSource = Enum.GetValues(typeof(UserType));
            //rdBtnUserType.DataTextField = "";
            //rdBtnUserType.DataValueField = "";
            //rdBtnUserType.DataBind();
        }
        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (this.txtimgcode.Text == this.Session["CaptchaImageText"].ToString())
            {
                if (chkAgree.Checked)
                {
                    PrepareEntity(DMLFlags.Insert);
                }
                else
                {

                }
            }
            else
            {
                lblCaptchaMsg.Text = "image code is not valid.";
            }
            this.txtimgcode.Text = "";
           
        }
        protected void PrepareEntity(Enum Mode, string par = "")
        {
            int UserType = int.Parse(ViewState["RegisterAs"].ToString());
            oUserAcount = new UserAcount
            {
                Flag = 1,
                UserType = UserType,
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,               
                EMail = txtEmail.Text,
                Password = txtPassword.Text,
                MobileNo = Convert.ToDouble(txtMobileNo.Text),
                City = txtCity.Text, 
                Address1 =  txtAddress1.Text != string.Empty ? txtAddress1.Text : null,
                PinCode = txtPinCode.Text != string.Empty ? Convert.ToDouble(txtPinCode.Text) : (double?)null,
                PanNo  = txtPanNo.Text,
                FaxNo = txtFaxNo.Text != string.Empty ? Convert.ToDouble(txtFaxNo.Text) : (double?)null,
                OrganizationName = txtOrganizationName.Text,
                IsActive = UserType!=2 ? true : false
            };
            oPUserAcount = new PUserAcount();
            if (Mode.Equals(DMLFlags.Insert))
            {
               ds =  oPUserAcount.UserAcount(oUserAcount);             
            }
            msg.Text = ds.Tables[0].Rows[0][0].ToString();
            tblMain.Visible = false;
            tblSave.Visible = false;
            tblAgent.Visible = false;
            pMsgInfo.Visible = false;
            tblMsg.Visible = true;
            if (msg.Text.Contains("successfully"))
            {
                if (UserType == 2)
                {
                    msg.Text = msg.Text + " And submitted to site admin for approval.";
                }               
            }
        }

      

        protected void chkAgree_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAgree.Checked)
            {
                btnSave.Enabled = true;
            }
            else
            {
                btnSave.Enabled = false;
            }
        }

        protected void btnGenerate_Click(object sender, EventArgs e)
        {
            Session["CaptchaImageText"] = null;
            lblCaptchaMsg.Text = "Text does not Match with Image";
            txtimgcode.Text = "";
        }
    }
}