<%@ Page Title="OnLine Bus Reservation" Language="C#" MasterPageFile="~/Site.Master"
    AutoEventWireup="true" CodeBehind="UserProfile.aspx.cs" Inherits="OnlineBusTicket.Administration.UserProfile" %>

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
            <h2>
                Profile
            </h2>
            <div align="right">
                <asp:Label ID="lblmsg" runat="server" Text=" " Font-Bold="true" ForeColor="Red"></asp:Label>
                <asp:Button ID="btnSave" runat="server" CausesValidation="true" CssClass="button"
                    Width="120" Text="Update Profile" OnClick="btnSave_Click" ValidationGroup="Save" />
                <asp:Button ID="btnCancel" runat="server" CausesValidation="false" CssClass="button"
                    Width="80" Text="Cancel" OnClick="btnCancel_Click" />
            </div>
            <fieldset>
                <legend class="legend">
                    <asp:Label ID="lblProfile" runat="server" Text="Profile"></asp:Label></legend>
                <table style="width: 100%" cellspacing="0" cellpadding="0">
                    <tr>
                        <td align="center">
                            <table style="width: 100%" cellspacing="10" id="tblMain" runat="server">
                                <tr>
                                    <td colspan="2" align="left" class="infoRow">
                                        <asp:Label ID="lblHeader1" runat="server" Text="Basic Info" Font-Size="12" Font-Bold="true"
                                            Font-Names="Calibri" />
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right" style="width: 25%">
                                        <label class="labeltext">
                                            First Name <b id="msign1" runat="server" class="mndSign">*</b></label>
                                    </td>
                                    <td colspan="2" align="left">
                                        <asp:TextBox ID="txtFirstName" runat="server" CssClass="textboxmedium_ml" MaxLength="20" />
                                        <asp:RequiredFieldValidator ID="rfvFirstName" runat="server" ControlToValidate="txtFirstName"
                                            CssClass="valid" Display="Dynamic" ErrorMessage="Enter First Name" ValidationGroup="Save" />
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        <label class="labeltext">
                                            Last Name <b id="msign2" runat="server" class="mndSign">*</b></label>
                                    </td>
                                    <td align="left">
                                        <asp:TextBox ID="txtLastName" runat="server" CssClass="textboxmedium_ml" MaxLength="20" />
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtLastName"
                                            CssClass="valid" Display="Dynamic" ErrorMessage="Enter Last Name" ValidationGroup="Save" />
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        <label class="labeltext">
                                            E-Mail ID
                                        </label>
                                    </td>
                                    <td align="left">
                                        <asp:TextBox ID="txtEmail" runat="server" CssClass="textboxmedium_ml" ReadOnly="true" />
                                        <%-- <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtEmail"
                            CssClass="valid" Display="Dynamic" ErrorMessage="Enter E-Mail" ValidationGroup="Save" />
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1"  CssClass="valid" Display="Dynamic"
                        ControlToValidate="txtEmail" runat="server" ErrorMessage="Invalid Email ID" 
                        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"/>--%>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" 
                                            ControlToValidate="txtEmail" CssClass="valid" Display="Dynamic" 
                                            ErrorMessage="Enter Email Id" ValidationGroup="Save" />
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        <label class="labeltext">
                                            Mobile No. <b id="msign4" runat="server" class="mndSign">*</b></label>
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
                                    <td align="right">
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
                            <table id="tblAgent" runat="server" style="width: 100%" cellspacing="10">
                                <tr>
                                    <td colspan="2" align="left" class="infoRow">
                                        <asp:Label ID="Label1" runat="server" Text="Additional Info" Font-Size="12" Font-Bold="true"
                                            Font-Names="Calibri" />
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right" style="width: 25%">
                                        <label class="labeltext">
                                            Address1 <b id="msign5" runat="server" class="mndSign">*</b></label>
                                    </td>
                                    <td align="left">
                                        <asp:TextBox ID="txtAddress1" runat="server" CssClass="textboxmedium_ml" MaxLength="20" />
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtAddress1"
                                            CssClass="valid" Display="Dynamic" ErrorMessage="Enter Address1" ValidationGroup="Save" />
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        <label class="labeltext">
                                            Pin Code <b id="msign6" runat="server" class="mndSign">*</b></label>
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
                                    <td align="right">
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
                                    <td align="right">
                                        <label class="labeltext">
                                            Pan No. <b id="msign7" runat="server" class="mndSign">*</b></label>
                                    </td>
                                    <td align="left">
                                        <asp:TextBox ID="txtPanNo" runat="server" CssClass="textboxmedium_ml" MaxLength="20" />
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="txtPanNo"
                                            CssClass="valid" Display="Dynamic" ErrorMessage="Enter Pan No." ValidationGroup="Save" />
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right">
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
                </table>
            </fieldset>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
