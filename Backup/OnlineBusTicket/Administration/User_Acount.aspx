<%@ Page Title="OnLine Bus Reservation" Language="C#" MasterPageFile="~/Site.Master"
    MaintainScrollPositionOnPostback="true" AutoEventWireup="true" CodeBehind="User_Acount.aspx.cs"
    Inherits="OnlineBusTicket.Administration.User_Acount" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <link href="../Styles/LSCSS.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .mndSign
        {
            color: Red;
            vertical-align: text-top;
            font-size: small;
        }
        .infoRow
        {
            color: Navy;
            background-color: AliceBlue;
            color: Black;
            vertical-align: text-top;
            font-size: 14;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:UpdatePanel ID="up" runat="server">
        <ContentTemplate>
            <h2 style="height: 20px">
                Create a New Account
            </h2>
            <p id="pMsgInfo" runat="server" style="height: 20px">
                Use the form below to create a new account.
                <asp:HyperLink ID="RegisterHyperLink" runat="server" EnableViewState="false" NavigateUrl="~/Default.aspx">Login</asp:HyperLink>&nbsp;
                if already registerd.
                <asp:HyperLink ID="HyperLink2" runat="server" EnableViewState="false" NavigateUrl="~/Administration/User_Acount.aspx?UT=2"
                    Text=""> </asp:HyperLink>
            </p>
            <fieldset>
                <legend class="legend"><b>Acount Creation</b></legend>
                <table style="width: 100%" cellspacing="0" cellpadding="0">
                    <tr>
                        <td align="center">
                            <table style="width: 100%" cellspacing="10" id="tblMain" runat="server" border="0">
                                <tr>
                                    <td colspan="2" align="left" class="infoRow">
                                        <asp:Label ID="lblHeader1" runat="server" Text="Basic Info" Font-Size="12" Font-Bold="true"
                                            Font-Names="Calibri" />
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right" style="width: 25%" valign="top">
                                        <label class="labeltext">
                                            First Name <b class="mndSign">*</b></label>
                                    </td>
                                    <td align="left" style="width: 75%">
                                        <asp:TextBox ID="txtFirstName" runat="server" CssClass="textboxmedium_ml" MaxLength="20" />
                                        <asp:RequiredFieldValidator ID="rfvFirstName" runat="server" ControlToValidate="txtFirstName"
                                            CssClass="valid" Display="Dynamic" ErrorMessage="Enter First Name" ValidationGroup="Save" />
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right" valign="top">
                                        <label class="labeltext">
                                            Last Name <b class="mndSign">*</b></label>
                                    </td>
                                    <td align="left">
                                        <asp:TextBox ID="txtLastName" runat="server" CssClass="textboxmedium_ml" MaxLength="20" />
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtLastName"
                                            CssClass="valid" Display="Dynamic" ErrorMessage="Enter Last Name" ValidationGroup="Save" />
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right" valign="top">
                                        <label class="labeltext">
                                            E-Mail ID <b class="mndSign">*</b></label>
                                    </td>
                                    <td align="left">
                                        <asp:TextBox ID="txtEmail" runat="server" CssClass="textboxmedium_ml" MaxLength="30" />
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtEmail"
                                            CssClass="valid" Display="Dynamic" ErrorMessage="Enter E-Mail" ValidationGroup="Save" />
                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" CssClass="valid"
                                            Display="Dynamic" ControlToValidate="txtEmail" runat="server" ErrorMessage="Invalid Email ID"
                                            ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" />
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right" valign="top">
                                        <label class="labeltext">
                                            Password <b class="mndSign">*</b></label>
                                    </td>
                                    <td align="left">
                                        <asp:TextBox ID="txtPassword" runat="server" CssClass="textboxmedium_ml" MaxLength="10"
                                            TextMode="Password" />
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtPassword"
                                            CssClass="valid" Display="Dynamic" ErrorMessage="Enter Password" ValidationGroup="Save" />
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right" valign="top">
                                        <label class="labeltext">
                                            Confirm Password <b class="mndSign">*</b></label>
                                    </td>
                                    <td align="left">
                                        <asp:TextBox ID="txtConfirmPassword" runat="server" CssClass="textboxmedium_ml" MaxLength="10"
                                            TextMode="Password" />
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtConfirmPassword"
                                            CssClass="valid" Display="Dynamic" ErrorMessage="Enter Password to confirm" ValidationGroup="Save" />
                                        <asp:CompareValidator ID="CompareValidator1" CssClass="valid" runat="server" ControlToValidate="txtConfirmPassword"
                                            ControlToCompare="txtPassword" Display="Dynamic" ErrorMessage="Password does not match." />
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right" valign="top">
                                        <label class="labeltext">
                                            Mobile No. <b class="mndSign">*</b></label>
                                    </td>
                                    <td align="left">
                                        <asp:TextBox ID="txtMobileNo" runat="server" CssClass="textboxmedium_ml" MaxLength="15" />
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtMobileNo"
                                            CssClass="valid" Display="Dynamic" ErrorMessage="Enter Mobile No." ValidationGroup="Save" />
                                        <asp:FilteredTextBoxExtender ID="FilteredTextBoxExtender1" runat="server" FilterType="Numbers"
                                            TargetControlID="txtMobileNo">
                                        </asp:FilteredTextBoxExtender>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right" valign="top">
                                        <label class="labeltext">
                                            City Of Residence</label>
                                    </td>
                                    <td align="left">
                                        <asp:TextBox ID="txtCity" runat="server" CssClass="textboxmedium_ml" MaxLength="20" />
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td align="center">
                            <table id="tblAgent" runat="server" style="width: 100%" cellspacing="10" border="0">
                                <tr>
                                    <td colspan="2" align="left" class="infoRow">
                                        <asp:Label ID="Label1" runat="server" Text="Additional Info" Font-Size="12" Font-Bold="true"
                                            Font-Names="Calibri" />
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right" style="width: 25%" valign="top">
                                        <label class="labeltext">
                                            Address1 <b class="mndSign">*</b></label>
                                    </td>
                                    <td align="left">
                                        <asp:TextBox ID="txtAddress1" runat="server" CssClass="textboxmedium_ml" MaxLength="20" />
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtAddress1"
                                            CssClass="valid" Display="Dynamic" ErrorMessage="Enter Address1" ValidationGroup="Save" />
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right" valign="top">
                                        <label class="labeltext">
                                            Pin Code <b class="mndSign">*</b></label>
                                    </td>
                                    <td align="left">
                                        <asp:TextBox ID="txtPinCode" runat="server" CssClass="textboxmedium_ml" MaxLength="10" />
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="txtPinCode"
                                            CssClass="valid" Display="Dynamic" ErrorMessage="Enter Pin Code" ValidationGroup="Save" />
                                        <asp:FilteredTextBoxExtender ID="txtContactNo_FilteredTextBoxExtender" runat="server"
                                            FilterType="Numbers" TargetControlID="txtPinCode">
                                        </asp:FilteredTextBoxExtender>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right" valign="top">
                                        <label class="labeltext">
                                            Fax No.</label>
                                    </td>
                                    <td align="left">
                                        <asp:TextBox ID="txtFaxNo" runat="server" CssClass="textboxmedium_ml" MaxLength="10" />
                                        <asp:FilteredTextBoxExtender ID="FilteredTextBoxExtender2" runat="server" FilterType="Numbers"
                                            TargetControlID="txtFaxNo">
                                        </asp:FilteredTextBoxExtender>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right" valign="top">
                                        <label class="labeltext">
                                            Pan No. <b class="mndSign">*</b></label>
                                    </td>
                                    <td align="left">
                                        <asp:TextBox ID="txtPanNo" runat="server" CssClass="textboxmedium_ml" MaxLength="20" />
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="txtPanNo"
                                            CssClass="valid" Display="Dynamic" ErrorMessage="Enter Pan No." ValidationGroup="Save" />
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right" valign="top">
                                        <label class="labeltext">
                                            Organization Name</label>
                                    </td>
                                    <td align="left">
                                        <asp:TextBox ID="txtOrganizationName" runat="server" CssClass="textboxmedium_ml"
                                            MaxLength="50" Width="275" />
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td align="center">
                            <table style="width: 100%" id="tblSave" runat="server" cellspacing="10" border="0">
                                <tr>
                                    <td style="width: 25%" align="right" valign="top">
                                        <label class="labeltext">
                                            Image Code<b class="mndSign">*</b></label>
                                    </td>
                                    <td align="left" valign="top">
                                        <asp:TextBox ID="txtimgcode" runat="server" CssClass="textboxmedium_ml" Width="100"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="txtimgcode"
                                            CssClass="valid" Display="Dynamic" ErrorMessage="Enter Image Code" ValidationGroup="Save" />
                                        <asp:Label ID="lblCaptchaMsg" runat="server" CssClass="valid" Text=""></asp:Label>
                                        <asp:Button ID="btnGenerate" runat="server" CssClass="button" 
                                            OnClick="btnGenerate_Click" Text="Generate" ValidationGroup="Gen" />
                                        <br />
                                        <asp:Image ID="imgCaptcha" runat="server" ImageUrl="~/Administration/CImage.aspx"
                                            Height="60" Width="220" />
                                        <br />
                                        (If unable to read.
                                        <asp:LinkButton ID="lnkRfresh" runat="server" Text="Refresh" />
                                        to generate a new one.)
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right" style="width: 25%">
                                        <asp:CheckBox ID="chkAgree" runat="server" Text=" " AutoPostBack="true" OnCheckedChanged="chkAgree_CheckedChanged" />
                                    </td>
                                    <td colspan="2" align="left">
                                        <label>
                                            I agree to the Terms of Use and Privacy Policy.</label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                    </td>
                                    <td align="left">
                                        <asp:Button ID="btnSave" runat="server" CausesValidation="true" CssClass="button"
                                            Width="80" Text="Register" OnClick="btnSave_Click" ValidationGroup="Save" Enabled="false" />
                                    </td>
                                    <td>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <table cellpadding="20" id="tblMsg" runat="server" visible="false" border="0">
                                <tr>
                                    <td>
                                        <br />
                                        <asp:Label runat="server" ID="msg" Text="" Font-Bold="true" ForeColor="Red" /><br />
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:HyperLink ID="HyperLink1" runat="server" EnableViewState="false" NavigateUrl="~/Default.aspx"> Login </asp:HyperLink>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
            </fieldset>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
