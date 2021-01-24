<%@ Page Title="OnLine Bus Reservation" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="OnlineBusTicket.Administration.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
<link href="../Styles/LSCSS.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
  <h2>
        Log In
    </h2>
    <p>
        Please enter your username and password.
        <asp:HyperLink ID="RegisterHyperLink" runat="server" EnableViewState="false" NavigateUrl="~/Administration/User_Acount.aspx">Register</asp:HyperLink> if you don't have an account.
    </p>
                <span class="failureNotification">
                <asp:Label ID="lblFailureText" runat="server" Visible="false" CssClass="valid" />
            </span>
            <asp:ValidationSummary ID="LoginUserValidationSummary" runat="server" CssClass="valid" 
                 ValidationGroup="LoginUserValidationGroup"/>
            <div class="accountInfo">
                <fieldset class="login">
                    <legend>Account Information</legend>
                    <p>
                        <asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="txtEMail">E-Mail ID:</asp:Label>
                        <asp:TextBox ID="txtEMail" runat="server" CssClass="textEntry"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="EMailRequired" runat="server" ControlToValidate="txtEMail" 
                             CssClass="failureNotification" ErrorMessage="E-Mail ID is required." ToolTip="E-Mail ID is required." 
                             ValidationGroup="LoginUserValidationGroup">*</asp:RequiredFieldValidator>
                    </p>
                    <p>
                        <asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="txtPassword">Password:</asp:Label>
                        <asp:TextBox ID="txtPassword" runat="server" CssClass="passwordEntry" TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ControlToValidate="txtPassword" 
                             CssClass="failureNotification" ErrorMessage="Password is required." ToolTip="Password is required." 
                             ValidationGroup="LoginUserValidationGroup">*</asp:RequiredFieldValidator>
                    </p>
                    <p>
                        <asp:CheckBox ID="RememberMe" runat="server"/>
                        <asp:Label ID="RememberMeLabel" runat="server" AssociatedControlID="RememberMe" CssClass="inline">Keep me logged in</asp:Label>
                    </p>
                     <p>                       
                        <asp:LinkButton ID="lnkForgotPassword" runat="server" CssClass="inline" Text="Forgot Password?" />
                    </p>
                     <p class="submitButton">
                    <asp:Button ID="LoginButton" runat="server" CssClass="button" Text="Log In" 
                             ValidationGroup="LoginUserValidationGroup" onclick="LoginButton_Click"/>
                </p>
                </fieldset>
               
            </div>
       
</asp:Content>
