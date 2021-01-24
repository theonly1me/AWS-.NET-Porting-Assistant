<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="Agent_History.aspx.cs" Inherits="OnlineBusTicket.Booking.Agent_History" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <link href="../Styles/LSCSS.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:UpdatePanel ID="UP" runat="server">
        <ContentTemplate>
            <table width="100%" cellpadding="0px" cellspacing="0">
                <tr class="tr">
                    <td align="left" style="width: 30%" valign="middle" bgcolor="#336699">
                        <asp:Label ID="lbl_heading" runat="server" Text="Agent History" CssClass="formheading"
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
                <tr id="inputarea" runat="server">
                    <td style="width: 100%;" colspan="2">
                        <fieldset>
                            <legend class="legend">search criteria</legend>
                            <asp:Panel ID="Panel2" runat="server" Width="100%">
                                <table width="100%">
                                    <tr>
                                        <td align="left" style="width: 28%;" valign="top">
                                        </td>
                                        <td align="left" valign="top" colspan="3">
                                        </td>
                                        <td align="left" style="width: 20%;" valign="top">
                                            &nbsp;
                                        </td>
                                    </tr>
                                    <tr id="trTicket" runat="server">
                                        <td align="left" style="width: 20%;" valign="top">
                                            <asp:Label ID="lblTicketNo" runat="server" CssClass="labeltext_ml" Text="Ticket No."></asp:Label>
                                        </td>
                                        <td align="left" style="width: 20%;" valign="top">
                                            <asp:TextBox ID="txtTicketNo" runat="server" CssClass="textboxmedium_ml"></asp:TextBox>
                                        </td>
                                        <td align="left" style="width: 20%;" valign="top">
                                            &nbsp;<asp:Button ID="btnSearch" runat="server" CssClass="button" Text="Search" ValidationGroup="VTicket"
                                                OnClick="btnSearch_Click" />
                                        </td>
                                        <td align="left" style="width: 20%;" valign="top">
                                        </td>
                                        <td align="left" style="width: 20%;" valign="top">
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="right" valign="top">
                                        </td>
                                        <td align="left" valign="top">
                                        </td>
                                        <td align="left" valign="top">
                                        </td>
                                        <td align="right" valign="top">
                                        </td>
                                        <td align="left" valign="top">
                                        </td>
                                    </tr>
                                </table>
                            </asp:Panel>
                        </fieldset>
                    </td>
                </tr>
                <tr id="grdArea" runat="server">
                    <td style="width: 100%;" colspan="2">
                        <fieldset>
                            <legend class="legend">Agent History Details</legend>
                            <table width="100%">
                                <tr>
                                    <td style="width: 100%;">
                                        <asp:GridView ID="grdAgentHistory" runat="server" Width="100%" AutoGenerateColumns="False"
                                            CssClass="gridview" EmptyDataText="No Agent History Details Found" ShowHeaderWhenEmpty="True"
                                            DataKeyNames="Booking_ID">
                                            <RowStyle CssClass="gridviewItemStyle" HorizontalAlign="center" />
                                            <AlternatingRowStyle CssClass="gridviewAlternatingStyle" HorizontalAlign="center" />
                                            <Columns>
                                                <asp:TemplateField HeaderText="S.No." InsertVisible="False" ItemStyle-CssClass="gridviewColumnSNo">
                                                    <EditItemTemplate>
                                                        <asp:Label ID="lblSNo" runat="server"></asp:Label>
                                                    </EditItemTemplate>
                                                    <ItemTemplate>
                                                        <asp:Label ID="lblSNo" runat="server" Text='<%# Container.DataItemIndex + 1 %>'></asp:Label>
                                                    </ItemTemplate>
                                                    <ItemStyle CssClass="gridviewColumnSNo" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Booking ID" ItemStyle-CssClass="gridviewColumnText"
                                                    HeaderStyle-CssClass="gridview-header">
                                                    <ItemTemplate>
                                                        <center>
                                                            <asp:Label ID="lblBooking_ID" runat="server" Text='<%#Bind("Booking_ID")%>'>
                                                            </asp:Label></center>
                                                        </center>
                                                    </ItemTemplate>
                                                    <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle"></HeaderStyle>
                                                </asp:TemplateField>
                              <%--                  <asp:TemplateField HeaderText="Agent Name" ItemStyle-CssClass="gridviewColumnText"
                                                    HeaderStyle-CssClass="gridview-header">
                                                    <ItemTemplate>
                                                        <center>
                                                            <asp:Label ID="lblAgent_Id" runat="server" Text='<%#Bind("FirstName")%>'>
                                                            </asp:Label></center>
                                                        </center>
                                                    </ItemTemplate>
                                                    <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle"></HeaderStyle>
                                                </asp:TemplateField>--%>
                                                <asp:TemplateField HeaderText="Commision" ItemStyle-CssClass="gridviewColumnText"
                                                    HeaderStyle-CssClass="gridview-header">
                                                    <ItemTemplate>
                                                        <center>
                                                            <asp:Label ID="lblCommision" runat="server" Text='<%#Bind("Commision")%>'>
                                                            </asp:Label></center>
                                                        </center>
                                                    </ItemTemplate>
                                                    <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle"></HeaderStyle>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Booking Date" ItemStyle-CssClass="gridviewColumnText"
                                                    HeaderStyle-CssClass="gridview-header">
                                                    <ItemTemplate>
                                                        <center>
                                                            <asp:Label ID="lblBookingDate" runat="server" Text='<%#Bind("Booking_Date")%>'>
                                                            </asp:Label></center>
                                                        </center>
                                                    </ItemTemplate>
                                                    <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle"></HeaderStyle>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="UserType" ItemStyle-CssClass="gridviewColumnText"
                                                    HeaderStyle-CssClass="gridview-header" Visible="false">
                                                    <ItemTemplate>
                                                        <center>
                                                            <asp:Label ID="lblUser_Type" runat="server" Text='<%#Bind("User_Type")%>'>
                                                            </asp:Label></center>
                                                        </center>
                                                    </ItemTemplate>
                                                    <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle"></HeaderStyle>
                                                </asp:TemplateField>
                                            </Columns>
                                            <RowStyle CssClass="gridviewItemStyle_ml" HorizontalAlign="center" />
                                            <HeaderStyle CssClass="gridviewHeader_ml" HorizontalAlign="center" />
                                            <AlternatingRowStyle CssClass="gridviewAlternatingStyle_ml" HorizontalAlign="center" />
                                        </asp:GridView>
                                    </td>
                                </tr>
                            </table>
                        </fieldset>
                    </td>
                </tr>
            </table>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
