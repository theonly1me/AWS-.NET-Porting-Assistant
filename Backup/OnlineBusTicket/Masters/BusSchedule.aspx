<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="BusSchedule.aspx.cs" Inherits="OnlineBusTicket.Masters.BusSchedule" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <link href="../Styles/LSCSS.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:UpdatePanel ID="uptPnl" runat="server">
        <ContentTemplate>
            <table style="width: 100%" cellpadding="0px" cellspacing="0">
                <tr class="tr">
                    <td align="left" style="width: 30%" valign="middle" bgcolor="#336699">
                        <asp:Label ID="lbl_heading" runat="server" Text="Bus Schedule" CssClass="formheading"
                            Font-Bold="True" Font-Names="Calibri" ForeColor="White"></asp:Label>
                    </td>
                    <td align="right" colspan="4" valign="middle" bgcolor="#336699">
                    </td>
                </tr>
                <tr>
                    <td align="center" style="width: 100%;" valign="middle" colspan="5">
                        <asp:Label ID="lbl_msg" runat="server" CssClass="general" Font-Names="Calibri" ForeColor="Red"
                            Visible="False"></asp:Label>
                    </td>
                </tr>
                <tr id="inputarea" runat="server" style="width: 100%">
                    <td align="left" colspan="5">
                        <fieldset>
                            <legend class="legend">Bus Schedule Details</legend>
                            <asp:Panel ID="Pnlnew" runat="server" Width="100%">
                                <table width="100%">
                                    <tr>
                                        <td align="left" valign="top" colspan="2">
                                            [<b style="color: Red; vertical-align: text-top; font-size: large"> * </b>]&nbsp;&nbsp;
                                            <b style="color: Black; font-size: smaller; font-family: Calibri">Mandatory Field</b>
                                        </td>
                                        <td style="width: 20%">
                                        </td>
                                        <td style="width: 20%">
                                        </td>
                                        <td style="width: 20%">
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="width: 20%">
                                            <asp:Label ID="lblMonth" runat="server" CssClass="labeltext_ml" Text="Month"></asp:Label>
                                            <b style="color: Red; vertical-align: text-top; font-size: small">*</b>
                                        </td>
                                        <td style="width: 20%">
                                            <asp:Label ID="lblMon" runat="server" CssClass="readonlytext" Text="Month"></asp:Label>
                                        </td>
                                        <td style="width: 20%">
                                        </td>
                                        <td style="width: 20%">
                                            <asp:Label ID="lblYear" runat="server" CssClass="labeltext_ml" Text="Year"></asp:Label>
                                            <b style="color: Red; vertical-align: text-top; font-size: small">*</b>
                                        </td>
                                        <td style="width: 20%">
                                            <asp:Label ID="lblY" runat="server" CssClass="readonlytext" Text="Year"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="width: 20%" align="left">
                                            &nbsp;
                                        </td>
                                        <td style="width: 20%" align="left">
                                        </td>
                                        <td style="width: 20%">
                                            &nbsp;
                                        </td>
                                        <td style="width: 20%" align="left">
                                            &nbsp;
                                        </td>
                                        <td style="width: 20%" align="left">
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="left" style="width: 20%">
                                            <asp:Label ID="lblBusOperator" runat="server" CssClass="labeltext_ml" Text="Bus Operator"></asp:Label>
                                            <b style="color: Red; vertical-align: text-top; font-size: small">*</b>
                                        </td>
                                        <td align="left" style="width: 20%">
                                            <asp:DropDownList ID="ddlBusOperator" runat="server" AutoPostBack="True" CausesValidation="True"
                                                CssClass="ddlMedium_ml" 
                                                onselectedindexchanged="ddlBusOperator_SelectedIndexChanged">
                                            </asp:DropDownList>
                                        </td>
                                        <td style="width: 20%">
                                        </td>
                                        <td align="left" style="width: 20%">
                                            <asp:Label ID="lblBusName" runat="server" CssClass="labeltext_ml" Text="Bus Name"></asp:Label>
                                            <b style="color: Red; vertical-align: text-top; font-size: small">*</b>
                                        </td>
                                        <td align="left" style="width: 20%">
                                            <asp:DropDownList ID="ddlBusName" runat="server" AutoPostBack="True" CausesValidation="True"
                                                CssClass="ddlMedium_ml">
                                            </asp:DropDownList>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="width: 20%">
                                        </td>
                                        <td style="width: 20%">
                                            <asp:RequiredFieldValidator ID="reqBusOperator" runat="server" ControlToValidate="ddlBusOperator"
                                                Display="Dynamic" ErrorMessage="Select Bus Operator" Font-Names="Calibri" Font-Size="Small"
                                                ForeColor="Red" InitialValue="-1" Style="float: left" ValidationGroup="all"></asp:RequiredFieldValidator>
                                        </td>
                                        <td style="width: 20%">
                                        </td>
                                        <td style="width: 20%">
                                        </td>
                                        <td style="width: 20%">
                                            <asp:RequiredFieldValidator ID="reqBusName" runat="server" ControlToValidate="ddlBusName"
                                                Display="Dynamic" ErrorMessage="Select Bus Name" Font-Names="Calibri" Font-Size="Small"
                                                ForeColor="Red" InitialValue="-1" Style="float: left" ValidationGroup="all"></asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="width: 20%">
                                            <asp:Label ID="lblSelectDay" runat="server" CssClass="labeltext_ml" Text="Select Days"></asp:Label>
                                            <b style="color: Red; vertical-align: text-top; font-size: small">*</b>
                                        </td>
                                        <td colspan="3">
                                            <asp:RadioButtonList ID="rbDays" runat="server" AutoPostBack="True" CssClass="readonlytext"
                                                RepeatDirection="Horizontal" OnSelectedIndexChanged="rbDays_SelectedIndexChanged">
                                                <asp:ListItem Text="Grouped days" Value="1"></asp:ListItem>
                                                <asp:ListItem Text="Custom dates" Value="2"></asp:ListItem>
                                            </asp:RadioButtonList>
                                        </td>
                                        <td style="width: 20%">
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="width: 20%">
                                        </td>
                                        <td style="width: 20%">
                                        </td>
                                        <td style="width: 20%">
                                        </td>
                                        <td style="width: 20%">
                                        </td>
                                        <td style="width: 20%">
                                        </td>
                                    </tr>
                                    <tr id="trDays" runat="server">
                                        <td style="width: 20%">
                                        </td>
                                        <td colspan="2">
                                            <asp:RadioButtonList ID="rbPlan" runat="server" AutoPostBack="True" 
                                                CssClass="readonlytext" OnSelectedIndexChanged="rbPlan_SelectedIndexChanged" 
                                                RepeatDirection="Horizontal">
                                                <asp:ListItem Text="Plan 7 Days" Value="7"></asp:ListItem>
                                                <asp:ListItem Text="Plan 15 Days" Value="15"></asp:ListItem>
                                                <asp:ListItem Text="1 month" Value="0"></asp:ListItem>
                                            </asp:RadioButtonList>
                                        </td>
                                        <td style="width: 20%">
                                        </td>
                                        <td style="width: 20%">
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="width: 20%">
                                        </td>
                                        <td style="width: 20%">
                                        </td>
                                        <td style="width: 20%">
                                        </td>
                                        <td style="width: 20%">
                                        </td>
                                        <td style="width: 20%">
                                        </td>
                                    </tr>
                                   <%-- <tr id="trDays" runat="server">
                                        <td style="width: 20%" align="left">
                                        </td>
                                        <td colspan="3">
                                            <asp:CheckBox ID="chckSevenDay" runat="server" CssClass="readonlytext" Enabled="True"
                                                AutoPostBack="true" Text="1-7 days" OnCheckedChanged="chckSevenDay_CheckedChanged" />
                                            &nbsp;&nbsp;
                                            <asp:CheckBox ID="chckFifteen" runat="server" CssClass="readonlytext" Enabled="True"
                                                AutoPostBack="true" Text="1-15 days" OnCheckedChanged="chckFifteen_CheckedChanged" />
                                            &nbsp;&nbsp;
                                            <asp:CheckBox ID="chckThirty" runat="server" CssClass="readonlytext" AutoPostBack="true"
                                                Enabled="True" Text="1 Month" OnCheckedChanged="chckThirty_CheckedChanged" />
                                        </td>
                                        <td style="width: 20%">
                                        </td>
                                    </tr>--%>
                                    <%--<tr>
                                        <td style="width: 20%">
                                        </td>
                                        <td colspan="2">
                                            <asp:CheckBoxList ID="chckClick" runat="server" CssClass="readonlytext" 
                                                onselectedindexchanged="chckClick_SelectedIndexChanged" 
                                                RepeatDirection="Horizontal" Width="100%">
                                                <asp:ListItem Value="6">first 7 Days</asp:ListItem>
                                                <asp:ListItem Value="14">first 15 Days</asp:ListItem>
                                                <asp:ListItem Value="31">1 Month</asp:ListItem>
                                            </asp:CheckBoxList>
                                        </td>
                                        <td style="width: 20%">
                                        </td>
                                        <td style="width: 20%">
                                        </td>
                                    </tr>--%>
                                    <tr id="trCheck" runat="server">
                                        <td colspan="5">
                                            <asp:CheckBoxList ID="chckCustom" runat="server" CssClass="readonlytext" Width="100%"
                                                RepeatDirection="Horizontal">
                                            </asp:CheckBoxList>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="width: 20%">
                                        </td>
                                        <td style="width: 20%">
                                        </td>
                                        <td style="width: 20%">
                                        </td>
                                        <td style="width: 20%">
                                        </td>
                                        <td style="width: 20%">
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="width: 20%">
                                        </td>
                                        <td style="width: 20%">
                                        </td>
                                        <td style="width: 20%">
                                        </td>
                                        <td style="width: 20%">
                                        </td>
                                        <td style="width: 20%">
                                        </td>
                                    </tr>
                                    <tr id="trButton" runat="server">
                                        <td colspan="3">
                                            <asp:Button ID="btnSave" runat="server" Text="Save" CssClass="button" CausesValidation="False"
                                                Width="15%" OnClick="btnSave_Click" />
                                            &nbsp;
                                            <asp:Button ID="btnReset" runat="server" Text="Reset" CssClass="button" CausesValidation="False"
                                                Width="15%" OnClick="btnReset_Click" />
                                            &nbsp;<asp:Button ID="btnCancel" runat="server" Text="Cancel" CssClass="button" CausesValidation="False"
                                                Width="15%" OnClick="btnCancel_Click" />
                                        </td>
                                        <td style="width: 20%">
                                        </td>
                                        <td style="width: 20%">
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="width: 20%">
                                        </td>
                                        <td style="width: 20%">
                                        </td>
                                        <td style="width: 20%">
                                        </td>
                                        <td style="width: 20%">
                                        </td>
                                        <td style="width: 20%">
                                        </td>
                                    </tr>
                                </table>
                            </asp:Panel>
                        </fieldset>
                    </td>
                </tr>
            </table>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
