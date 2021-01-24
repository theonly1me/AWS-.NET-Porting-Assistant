<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="TicketBooking.aspx.cs" Inherits="OnlineBusTicket.Booking.TicketBooking" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <link href="../Styles/LSCSS.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width: 90%">
        <tr>
            <td>
                <fieldset>
                    <legend class="legend">Review Bus Details</legend>
                    <table style="width: 100%">
                        <tr>
                            <td>
                                <table style="width: 100%">
                                    <tr>
                                        <td colspan="2">
                                        </td>
                                        <td colspan="2">
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="width: 20%">
                                            <asp:Label ID="lbl1" runat="server" Text="Bus Operator" CssClass="labeltext_ml"></asp:Label>
                                        </td>
                                        <td style="width: 25%">
                                            :
                                            <asp:Label ID="lblBusOperator" runat="server" Width="85%"></asp:Label>
                                        </td>
                                        <td style="width: 20%">
                                         
                                        </td>
                                        <td style="width: 25%">
                                          
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="width: 20%">
                                            <asp:Label ID="Label18" runat="server" Text="Bus No" CssClass="labeltext_ml"></asp:Label>
                                        </td>
                                        <td style="width: 25%">
                                            :
                                            <asp:Label ID="lblBusNo" runat="server" Width="85%"></asp:Label>
                                        </td>
                                        <td style="width: 20%">
                                            <asp:Label ID="Label2" runat="server" Text="Bus Type" CssClass="labeltext_ml"></asp:Label>
                                        </td>
                                        <td style="width: 25%">
                                            :
                                            <asp:Label ID="lblBusType" runat="server" Width="85%"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="width: 20%">
                                            <asp:Label ID="lbl3" runat="server" Text="Departure time" CssClass="labeltext_ml"></asp:Label>
                                        </td>
                                        <td style="width: 25%">
                                            :
                                            <asp:Label ID="lblDepartureTime" runat="server" Width="85%"></asp:Label>
                                        </td>
                                        <td style="width: 20%">
                                            <asp:Label ID="Label3" runat="server" Text="Arrival Time" CssClass="labeltext_ml"></asp:Label>
                                        </td>
                                        <td style="width: 25%">
                                            :
                                            <asp:Label ID="lblArrivalTime" runat="server" Width="85%"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="width: 20%">
                                            <asp:Label ID="lbl2" runat="server" Text="Boarding Date" CssClass="labeltext_ml"></asp:Label>
                                        </td>
                                        <td style="width: 25%">
                                            :
                                            <asp:Label ID="lblBordingTime" runat="server" Width="85%"></asp:Label>
                                        </td>
                                        <td style="width: 20%">
                                            <asp:Label ID="Label1" runat="server" Text="No. of Passengers" CssClass="labeltext_ml"></asp:Label>
                                        </td>
                                        <td style="width: 25%">
                                            :
                                            <asp:Label ID="lblNoOfPassenger" runat="server" Width="85%"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="width: 20%">
                                        </td>
                                        <td style="width: 25%">
                                        </td>
                                        <td style="width: 20%">
                                        </td>
                                        <td style="width: 25%">
                                        </td>
                                    </tr>
                                   
                                </table>
                            </td>
                        </tr>
                        </table>
                </fieldset>
            </td>
        </tr>
        <tr>
            <td>
                <fieldset>
                    <legend class="legend">Traveller Details &amp; Contact Informationn</legend>
                    <table style="width: 100%">
                        <tr>
                            <td>
                                <table style="width: 100%">
                                    <tr>
                                        <td colspan="3">
                                        </td>
                                        <td colspan="5">
                                           
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="width: 15%">
                                        </td>
                                        <td style="width: 2%">
                                        </td>
                                        <td style="width: 15%">
                                            <asp:Label ID="lblPermitType" runat="server" CssClass="labeltext_ml" 
                                                Text="First Name" Width="80%"></asp:Label>
                                            <b style="color: Red; vertical-align: text-top; font-size: large">*</b>
                                        </td>
                                        <td style="width: 20%">
                                            <asp:Label ID="lblPermitType4" runat="server" CssClass="labeltext_ml" 
                                                Text="Middle Name"  Width="80%"></asp:Label>
                                         <b style="color: Red; vertical-align: text-top; font-size: large">*</b>
                                        </td>
                                        <td style="width: 15%">
                                            <asp:Label ID="lblPermitType0" runat="server" CssClass="labeltext_ml" Text="Last Name"  Width="80%"></asp:Label>
                                             <b style="color: Red; vertical-align: text-top; font-size: large">*</b>
                                        </td>
                                        <td style="width: 10%">
                                            <asp:Label ID="lblPermitType1" runat="server" CssClass="labeltext_ml" Text="Gender" Width="80%"></asp:Label>
                                         <b style="color: Red; vertical-align: text-top; font-size: large">*</b>
                                        </td>
                                        <td align="center" style="width: 15%">
                                            <asp:Label ID="lblPermitType2" runat="server" CssClass="labeltext_ml" Text="Seat No." Width="80%"></asp:Label>
                                        </td>
                                        <td align="left" style="width: 10%">
                                          
                                        </td>
                                    </tr>
                                    <tr id="tr1" runat="server">
                                        <td style="width: 20%" align="center">
                                            <asp:Label ID="Label9" runat="server" CssClass="labeltext_ml" 
                                                Text="Passenger 1 " Width="80%"></asp:Label>
                                                 <b style="color: Red; vertical-align: text-top; font-size: large">*</b>
                                        </td>
                                        <td style="width: 5%" align="left">
                                            <%--<b style="color: Red; vertical-align: text-top; font-size: small">*</b>--%>
                                        </td>
                                        <td style="width: 15%">
                                            <asp:TextBox ID="txtPas1FirstName" runat="server" CssClass="textboxmedium_ml" ValidationGroup="Bus"
                                                MaxLength="20" Width="100px" AutoCompleteType="Disabled"></asp:TextBox>
                                        </td>
                                        <td style="width: 20%">
                                            <asp:TextBox ID="txtPas1MidName" runat="server" CssClass="textboxmedium_ml" ValidationGroup="Bus"
                                                MaxLength="20" Width="120px" AutoCompleteType="Disabled"></asp:TextBox>
                                        </td>
                                        <td style="width: 15%">
                                            <asp:TextBox ID="txtPas1LastName" runat="server" CssClass="textboxmedium_ml" ValidationGroup="Bus"
                                                MaxLength="20" Width="100px" AutoCompleteType="Disabled"></asp:TextBox>
                                        </td>
                                        <td style="width: 10%">
                                            <asp:DropDownList ID="ddlPas1Gender" runat="server" CssClass="ddlMedium" ValidationGroup="Bus"
                                                Width="70px">
                                                <asp:ListItem Value="1">Male</asp:ListItem>
                                                <asp:ListItem Value="2">Female</asp:ListItem>
                                            </asp:DropDownList>
                                        </td>
                                        <td style="width: 15%" align="center">
                                            <asp:Label ID="lblPas1SeatNo" runat="server" CssClass="labeltext">0</asp:Label>
                                        </td>
                                        <td style="width: 10%" align="left">
                                            <asp:RequiredFieldValidator ID="reqpas1" runat="server" ControlToValidate="txtPas1FirstName"
                                                CssClass="valid" Display="Dynamic" ErrorMessage="*" Font-Names="Calibri" Font-Size="Small"
                                                ForeColor="Red" ValidationGroup="pasName"></asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr id="tr2" runat="server">
                                        <td style="width: 15%" align="center">
                                            <asp:Label ID="Label10" runat="server" CssClass="labeltext_ml" 
                                                Text="Passenger 2 " Width="80%"></asp:Label>
                                                 <b style="color: Red; vertical-align: text-top; font-size: large">*</b>
                                        </td>
                                        <td style="width: 5%" align="left">
                                            <%--  <b style="color: Red; vertical-align: text-top; font-size: small">*</b>--%>
                                        </td>
                                        <td style="width: 15%">
                                            <asp:TextBox ID="txtPas2FirstName" runat="server" CssClass="textboxmedium_ml" ValidationGroup="Bus"
                                                MaxLength="20" Width="100px" AutoCompleteType="Disabled"></asp:TextBox>
                                        </td>
                                        <td style="width: 20%">
                                            <asp:TextBox ID="txtPas2MidName" runat="server" CssClass="textboxmedium_ml" ValidationGroup="Bus"
                                                MaxLength="20" Width="120px" AutoCompleteType="Disabled"></asp:TextBox>
                                        </td>
                                        <td style="width: 15%">
                                            <asp:TextBox ID="txtPas2LastName" runat="server" CssClass="textboxmedium_ml" ValidationGroup="Bus"
                                                MaxLength="20" Width="100px" AutoCompleteType="Disabled"></asp:TextBox>
                                        </td>
                                        <td style="width: 10%">
                                            <asp:DropDownList ID="ddlPas2Gender" runat="server" CssClass="ddlMedium" ValidationGroup="Bus"
                                                Width="70px">
                                                <asp:ListItem Value="1">Male</asp:ListItem>
                                                <asp:ListItem Value="2">Female</asp:ListItem>
                                            </asp:DropDownList>
                                        </td>
                                        <td style="width: 15%" align="center">
                                            <asp:Label ID="lblPas2SeatNo" runat="server" CssClass="labeltext">0</asp:Label>
                                        </td>
                                        <td style="width: 10%" align="left">
                                            <asp:RequiredFieldValidator ID="reqPas2" runat="server" ControlToValidate="txtPas2FirstName"
                                                CssClass="valid" Display="Dynamic" ErrorMessage="*" Font-Names="Calibri" Font-Size="Small"
                                                ForeColor="Red" ValidationGroup="pasName"></asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr id="tr3" runat="server">
                                        <td style="width: 15%" align="center">
                                            <asp:Label ID="Label11" runat="server" CssClass="labeltext_ml" 
                                                Text="Passenger 3 " Width="80%"></asp:Label>
                                                 <b style="color: Red; vertical-align: text-top; font-size: large">*</b>
                                        </td>
                                        <td style="width: 5%">
                                        </td>
                                        <td style="width: 15%">
                                            <asp:TextBox ID="txtPas3FirstName" runat="server" CssClass="textboxmedium_ml" ValidationGroup="Bus"
                                                MaxLength="20" Width="100px" AutoCompleteType="Disabled"></asp:TextBox>
                                        </td>
                                        <td style="width: 20%">
                                            <asp:TextBox ID="txtPas3MidName" runat="server" CssClass="textboxmedium_ml" ValidationGroup="Bus"
                                                MaxLength="20" Width="120px" AutoCompleteType="Disabled"></asp:TextBox>
                                        </td>
                                        <td style="width: 15%">
                                            <asp:TextBox ID="txtPas3LastName" runat="server" CssClass="textboxmedium_ml" ValidationGroup="Bus"
                                                MaxLength="20" Width="100px" AutoCompleteType="Disabled"></asp:TextBox>
                                        </td>
                                        <td style="width: 10%">
                                            <asp:DropDownList ID="ddlPas3Gender" runat="server" CssClass="ddlMedium" ValidationGroup="Bus"
                                                Width="70px">
                                                <asp:ListItem Value="1">Male</asp:ListItem>
                                                <asp:ListItem Value="2">Female</asp:ListItem>
                                            </asp:DropDownList>
                                        </td>
                                        <td style="width: 15%" align="center">
                                            <asp:Label ID="lblPas3SeatNo" runat="server" CssClass="labeltext">0</asp:Label>
                                        </td>
                                        <td style="width: 10%" align="left">
                                            <asp:RequiredFieldValidator ID="reqPas3" runat="server" ControlToValidate="txtPas3FirstName"
                                                CssClass="valid" Display="Dynamic" ErrorMessage="*" Font-Names="Calibri" Font-Size="Small"
                                                ForeColor="Red" ValidationGroup="pasName"></asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr id="tr4" runat="server">
                                        <td style="width: 15%" align="center">
                                            <asp:Label ID="Label12" runat="server" CssClass="labeltext_ml" 
                                                Text="Passenger 4 " Width="80%"></asp:Label>
                                                 <b style="color: Red; vertical-align: text-top; font-size: large">*</b>
                                        </td>
                                        <td style="width: 5%">
                                        </td>
                                        <td style="width: 15%">
                                            <asp:TextBox ID="txtPas4FirstName" runat="server" CssClass="textboxmedium_ml" ValidationGroup="Bus"
                                                MaxLength="20" Width="100px" AutoCompleteType="Disabled"></asp:TextBox>
                                        </td>
                                        <td style="width: 20%">
                                            <asp:TextBox ID="txtPas4MidName" runat="server" CssClass="textboxmedium_ml" ValidationGroup="Bus"
                                                MaxLength="20" Width="120px" AutoCompleteType="Disabled"></asp:TextBox>
                                        </td>
                                        <td style="width: 15%">
                                            <asp:TextBox ID="txtPas4LastName" runat="server" CssClass="textboxmedium_ml" ValidationGroup="Bus"
                                                MaxLength="20" Width="100px" AutoCompleteType="Disabled"></asp:TextBox>
                                        </td>
                                        <td style="width: 10%">
                                            <asp:DropDownList ID="ddlPas4Gender" runat="server" CssClass="ddlMedium" ValidationGroup="Bus"
                                                Width="70px">
                                                <asp:ListItem Value="1">Male</asp:ListItem>
                                                <asp:ListItem Value="2">Female</asp:ListItem>
                                            </asp:DropDownList>
                                        </td>
                                        <td style="width: 15%" align="center">
                                            <asp:Label ID="lblPas4SeatNo" runat="server" CssClass="labeltext">0</asp:Label>
                                        </td>
                                        <td style="width: 10%" align="left">
                                            <asp:RequiredFieldValidator ID="reqPas4" runat="server" ControlToValidate="txtPas4FirstName"
                                                CssClass="valid" Display="Dynamic" ErrorMessage="*" Font-Names="Calibri" Font-Size="Small"
                                                ForeColor="Red" ValidationGroup="pasName"></asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr id="tr5" runat="server">
                                        <td style="width: 15%" align="center">
                                            <asp:Label ID="Label13" runat="server" CssClass="labeltext_ml" 
                                                Text="Passenger 5 " Width="80%"></asp:Label>
                                                 <b style="color: Red; vertical-align: text-top; font-size: large">*</b>
                                        </td>
                                        <td style="width: 5%">
                                            <%-- <b style="color: Red; vertical-align: text-top; font-size: small">*</b>--%>
                                        </td>
                                        <td style="width: 15%">
                                            <asp:TextBox ID="txtPas5FirstName" runat="server" CssClass="textboxmedium_ml" ValidationGroup="Bus"
                                                MaxLength="20" Width="100px" AutoCompleteType="Disabled"></asp:TextBox>
                                        </td>
                                        <td style="width: 20%">
                                            <asp:TextBox ID="txtPas5MidName" runat="server" CssClass="textboxmedium_ml" ValidationGroup="Bus"
                                                MaxLength="20" Width="120px" AutoCompleteType="Disabled"></asp:TextBox>
                                        </td>
                                        <td style="width: 15%">
                                            <asp:TextBox ID="txtPas5LastName" runat="server" CssClass="textboxmedium_ml" ValidationGroup="Bus"
                                                MaxLength="20" Width="100px" AutoCompleteType="Disabled"></asp:TextBox>
                                        </td>
                                        <td style="width: 10%">
                                            <asp:DropDownList ID="ddlPas5Gender" runat="server" CssClass="ddlMedium" ValidationGroup="Bus"
                                                Width="70px">
                                                <asp:ListItem Value="1">Male</asp:ListItem>
                                                <asp:ListItem Value="2">Female</asp:ListItem>
                                            </asp:DropDownList>
                                        </td>
                                        <td style="width: 25%" align="center">
                                            <asp:Label ID="lblPas5SeatNo" runat="server" CssClass="labeltext">0</asp:Label>
                                        </td>
                                        <td style="width: 10%" align="left">
                                            <asp:RequiredFieldValidator ID="reqPas5" runat="server" ControlToValidate="txtPas5FirstName"
                                                CssClass="valid" Display="Dynamic" ErrorMessage="*" Font-Names="Calibri" Font-Size="Small"
                                                ForeColor="Red" ValidationGroup="pasName"></asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr id="tr6" runat="server">
                                        <td style="width: 15%" align="center">
                                            <asp:Label ID="Label14" runat="server" CssClass="labeltext_ml" 
                                                Text="Passenger 6 " Width="80%"></asp:Label>
                                                 <b style="color: Red; vertical-align: text-top; font-size: large">*</b>
                                        </td>
                                        <td style="width: 5%">
                                            <%--<b style="color: Red; vertical-align: text-top; font-size: small">*</b>--%>
                                        </td>
                                        <td style="width: 15%">
                                            <asp:TextBox ID="txtPas6FirstName" runat="server" CssClass="textboxmedium_ml" ValidationGroup="Bus"
                                                MaxLength="20" Width="100px" AutoCompleteType="Disabled"></asp:TextBox>
                                        </td>
                                        <td style="width: 20%">
                                            <asp:TextBox ID="txtPas6MidName" runat="server" CssClass="textboxmedium_ml" ValidationGroup="Bus"
                                                MaxLength="20" Width="120px" AutoCompleteType="Disabled"></asp:TextBox>
                                        </td>
                                        <td style="width: 15%">
                                            <asp:TextBox ID="txtPas6LastName" runat="server" CssClass="textboxmedium_ml" ValidationGroup="Bus"
                                                MaxLength="20" Width="100px" AutoCompleteType="Disabled"></asp:TextBox>
                                        </td>
                                        <td style="width: 10%">
                                            <asp:DropDownList ID="ddlPas6Gender" runat="server" CssClass="ddlMedium" ValidationGroup="Bus"
                                                Width="70px">
                                                <asp:ListItem Value="1">Male</asp:ListItem>
                                                <asp:ListItem Value="2">Female</asp:ListItem>
                                            </asp:DropDownList>
                                        </td>
                                        <td style="width: 15%" align="center">
                                            <asp:Label ID="lblPas6SeatNo" runat="server" CssClass="labeltext">0</asp:Label>
                                        </td>
                                        <td style="width: 10%" align="left">
                                            <asp:RequiredFieldValidator ID="reqPas6" runat="server" ControlToValidate="txtPas6FirstName"
                                                CssClass="valid" Display="Dynamic" ErrorMessage="*" Font-Names="Calibri" Font-Size="Small"
                                                ForeColor="Red" ValidationGroup="pasName"></asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="width: 15%">
                                        </td>
                                        <td style="width: 5%">
                                        </td>
                                        <td style="width: 15%">
                                        </td>
                                        <td style="width: 20%">
                                        </td>
                                        <td style="width: 15%">
                                        </td>
                                        <td style="width: 10%">
                                        </td>
                                        <td style="width: 15%" align="center">
                                        </td>
                                        <td style="width: 10%">
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="width: 15%" align="center">
                                            <asp:Label ID="Label15" runat="server" CssClass="labeltext_ml" Text="E Mail Id" 
                                                Width="80%"></asp:Label>
                                                 <b style="color: Red; vertical-align: text-top; font-size: large">*</b>
                                        </td>
                                        <td style="width: 5%">
                                        </td>
                                        <td colspan="2">
                                            <asp:TextBox ID="txtEMailId" runat="server" CssClass="textboxmedium_ml" ValidationGroup="Bus"
                                                MaxLength="50" Width="80%" AutoCompleteType="Disabled"></asp:TextBox>
                                        </td>
                                        <td style="width: 15%" align="left">
                                        <asp:RequiredFieldValidator ID="reqMail" runat="server" ControlToValidate="txtEMailId"
                                                CssClass="valid" Display="Dynamic" ErrorMessage="*" Font-Names="Calibri" Font-Size="Small"
                                                ForeColor="Red" ValidationGroup="pasName"></asp:RequiredFieldValidator>
                                      
                                        </td>
                                        <td style="width: 10%">
                                        </td>
                                        <td style="width: 15%" align="center">
                                        </td>
                                        <td style="width: 10%">
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="width: 15%" align="center">
                                            <asp:Label ID="Label16" runat="server" CssClass="labeltext_ml" Text="Mobile No" 
                                                Width="80%"></asp:Label>
                                                 <b style="color: Red; vertical-align: text-top; font-size: large">*</b>
                                        </td>
                                        <td style="width: 5%">
                                        </td>
                                        <td colspan="2">
                                            <asp:TextBox ID="txtMobileNo" runat="server" CssClass="textboxmedium_ml" ValidationGroup="Bus"
                                                MaxLength="15" AutoCompleteType="Disabled"></asp:TextBox>
                                        </td>
                                        <td style="width: 15%">
                                        
                                        <asp:RequiredFieldValidator ID="reqMob" runat="server" ControlToValidate="txtMobileNo"
                                                CssClass="valid" Display="Dynamic" ErrorMessage="*" Font-Names="Calibri" Font-Size="Small"
                                                ForeColor="Red" ValidationGroup="pasName"></asp:RequiredFieldValidator>
                                        </td>
                                        <td style="width: 10%">
                                        </td>
                                        <td style="width: 15%" align="center">
                                        </td>
                                        <td style="width: 10%">
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="width: 15%" align="center">
                                            <asp:Label ID="Label17" runat="server" CssClass="labeltext_ml" 
                                                Text="Land Line No" Width="80%"></asp:Label>
                                                 <b style="color: Red; vertical-align: text-top; font-size: large">*</b>
                                        </td>
                                        <td style="width: 5%">
                                        </td>
                                        <td colspan="2">
                                            <asp:TextBox ID="txtLandLineNo" runat="server" CssClass="textboxmedium_ml" ValidationGroup="Bus"
                                                MaxLength="15" AutoCompleteType="Disabled"></asp:TextBox>
                                        </td>
                                        <td style="width: 15%" align="left">
                                        <asp:RequiredFieldValidator ID="reqlandline" runat="server" ControlToValidate="txtLandLineNo"
                                                CssClass="valid" Display="Dynamic" ErrorMessage="*" Font-Names="Calibri" Font-Size="Small"
                                                ForeColor="Red" ValidationGroup="pasName"></asp:RequiredFieldValidator>
                                        </td>
                                        <td style="width: 10%">
                                        </td>
                                        <td style="width: 15%" align="center">
                                        </td>
                                        <td style="width: 10%">
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="width: 25%" colspan="2">
                                        </td>
                                        <td colspan="2">
                                        </td>
                                        <td style="width: 15%">
                                        </td>
                                        <td style="width: 10%">
                                        </td>
                                        <td style="width: 15%" align="center">
                                          
                                        </td>
                                        <td style="width: 10%">
                                         
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td align="left">
                                <asp:CheckBox ID="chckAgree" runat="server" Text="I understand and agree with the Rules and Restrictions of this fare, the Privacy Policy and the Terms &amp; Conditions (User Agreement)"
                                    CssClass="linkgrid" Font-Size="X-Small" />
                            </td>
                        </tr>
                        <tr>
                            <td align="left">
                                        <%--<asp:RequiredFieldValidator ID="reqCheckBox" runat="server"
                                                CssClass="valid" Display="Dynamic" 
                                    ErrorMessage="Pleace Accept The Term &amp; Condition" Font-Names="Calibri" Font-Size="Small"
                                                ForeColor="Red" ValidationGroup="pasName"></asp:RequiredFieldValidator>--%>
                            </td>
                        </tr>
                        <tr>
                            <td align="center">
                                <asp:ImageButton ID="imgBtnPayBook" runat="server" ImageUrl="~/Images/pay-book.jpg"
                                    OnClick="imgBtnPayBook_Click1" ValidationGroup="pasName" />
                            </td>
                        </tr>
                    </table>
                </fieldset>
            </td>
        </tr>
        <tr>
            <td>
            </td>
        </tr>
    </table>
</asp:Content>
