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
    
    public partial class UserProfile : System.Web.UI.Page
    {
        UserAcount oUserAcount;
        PUserAcount oPUserAcount;
        DataSet ds;
        protected void Page_Load(object sender, EventArgs e)
        {
           
                //Session["User_ID"] = "2";
                //Session["User_Type"] = "2";
                lblmsg.Visible = false;
                tblAgent.Visible = (Session["User_Type"].ToString() == "1" || Session["User_Type"].ToString() == "4") ? false : true;
                btnCancel.Visible = false;
                if (!IsPostBack)
                {
                    ShowProfile();
                    SetProperties("Show");
                }
            
        }

        private void SetProperties(string mode)
        {
            if (mode == "Show")
            {
                msign1.Visible = false;
                msign2.Visible = false;             
                msign4.Visible = false;
                msign5.Visible = false;
                msign6.Visible = false;
                msign7.Visible = false;
                txtFirstName.ReadOnly = true;
                txtLastName.ReadOnly = true;
                txtEmail.ReadOnly = true;
                txtCity.ReadOnly = true;
                txtMobileNo.ReadOnly = true;
                txtOrganizationName.ReadOnly = true;
                txtPinCode.ReadOnly = true;
                txtPanNo.ReadOnly = true;
                txtFaxNo.ReadOnly = true;
                txtAddress1.ReadOnly = true;
                btnCancel.Visible = false;
                btnSave.Text = "Update Profile";
            }
            else if (mode == "Edit")
            {
                msign1.Visible = true;
                msign2.Visible = true;               
                msign4.Visible = true;
                msign5.Visible = true;
                msign6.Visible = true;
                msign7.Visible = true;
                txtFirstName.ReadOnly = false;
                txtLastName.ReadOnly = false;               
                txtCity.ReadOnly = false;
                txtMobileNo.ReadOnly = false;
                txtOrganizationName.ReadOnly = false;
                txtPinCode.ReadOnly = false;
                txtPanNo.ReadOnly = false;
                txtFaxNo.ReadOnly = false;
                txtAddress1.ReadOnly = false;
                btnSave.Text = "Save Changes";
                btnCancel.Visible = true;
            }
        }
        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.Text == "Update Profile")
            {
                SetProperties("Edit");
               
            }
            else
            {
                EditProfile();              
                SetProperties("Show");
            }
            Response.Redirect("Default.aspx");  
        }

        protected void ShowProfile()
        {            
            oUserAcount = new UserAcount
            {
                Flag = 5,
                UserID = Convert.ToInt32(Session["User_ID"].ToString())
            };
            oPUserAcount = new PUserAcount();
            ds = oPUserAcount.UserAcount(oUserAcount);


            txtFirstName.Text = ds.Tables[0].Rows[0]["FirstName"].ToString();
            txtLastName.Text = ds.Tables[0].Rows[0]["LastName"].ToString();
            txtEmail.Text = ds.Tables[0].Rows[0]["EMail"].ToString();
            txtCity.Text = ds.Tables[0].Rows[0]["City"]!= null ? ds.Tables[0].Rows[0]["City"].ToString():string.Empty;
            txtMobileNo.Text = ds.Tables[0].Rows[0]["MobileNo"].ToString();
            txtOrganizationName.Text = ds.Tables[0].Rows[0]["OrganizationName"] != null ? ds.Tables[0].Rows[0]["OrganizationName"].ToString() : string.Empty;
            txtPinCode.Text =  ds.Tables[0].Rows[0]["PinCode"] != null ? ds.Tables[0].Rows[0]["PinCode"].ToString(): string.Empty;
            txtPanNo.Text = ds.Tables[0].Rows[0]["PanNo"] != null ? ds.Tables[0].Rows[0]["PanNo"].ToString() : string.Empty;
            txtFaxNo.Text = ds.Tables[0].Rows[0]["FaxNo"] != null ? ds.Tables[0].Rows[0]["FaxNo"].ToString() : string.Empty;
            txtAddress1.Text = ds.Tables[0].Rows[0]["Address1"] != null ? ds.Tables[0].Rows[0]["Address1"].ToString() : string.Empty;                 
        }

        protected void EditProfile()
        {
           
            oUserAcount = new UserAcount
            {
                Flag = 6,
                UserID = Convert.ToDouble(Session["User_ID"].ToString()),
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,               
                MobileNo = Convert.ToDouble(txtMobileNo.Text),
                City = txtCity.Text,
                Address1 = txtAddress1.Text != string.Empty ? txtAddress1.Text : null,
                PinCode = txtPinCode.Text != string.Empty ? Convert.ToDouble(txtPinCode.Text) : (double?)null,
                PanNo = txtPanNo.Text,
                FaxNo = txtFaxNo.Text != string.Empty ? Convert.ToDouble(txtFaxNo.Text) : (double?)null,
                OrganizationName = txtOrganizationName.Text,               
            };
            oPUserAcount = new PUserAcount();           
            ds = oPUserAcount.UserAcount(oUserAcount);
            lblmsg.Visible = true;
            lblmsg.Text = ds.Tables[0].Rows[0][0].ToString();          
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            SetProperties("Show");            
        }
    }
}