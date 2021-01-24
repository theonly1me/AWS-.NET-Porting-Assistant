<%@ Page Title="OnLine Bus Reservation" Language="C#" MasterPageFile="~/Site.Master"
    AutoEventWireup="true" CodeBehind="AgentApprove.aspx.cs" Inherits="OnlineBusTicket.Administration.AgentApprove" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <link href="../Styles/LSCSS.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:UpdatePanel ID="up" runat="server">
        <ContentTemplate>
            <h2>
                Approve Agent Acounts
            </h2>
            <p>
                Use the form below to approve agent acounts.
            </p>
            <fieldset>
                <legend class="legend">Agent Approval</legend>
                <table style="width: 100%" cellspacing="10" id="tblMain" runat="server">
                    <tr>
                        <td>
                            <asp:Label ID="lblMsg" runat="server" Text=" " ForeColor="Red" Font-Bold="true" Visible="false"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="left">
                            <asp:GridView ID="grdAgent" runat="server" PageSize="15" ForeColor="Black" AutoGenerateColumns="False"
                                EmptyDataText="No records found" AllowPaging="true" OnPageIndexChanging="grdAgent_PageIndexChanging"
                                DataKeyNames="UserId" HeaderStyle-BackColor="#3A4F63" HeaderStyle-BorderColor="Navy"
                                HeaderStyle-ForeColor="White" ShowHeaderWhenEmpty="True" Width="100%">
                                <Columns>
                                    <asp:TemplateField HeaderText="Select">
                                        <ItemTemplate>
                                            <center>
                                                <asp:CheckBox ID="chkSelect" runat="server" CausesValidation="false"></asp:CheckBox>
                                            </center>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:BoundField DataField="Name" HeaderText="Name"></asp:BoundField>
                                    <asp:BoundField DataField="MobileNo" HeaderText="Mobile No." />
                                    <asp:BoundField DataField="EMail" HeaderText="E-Mail ID" />
                                    <asp:BoundField DataField="City" HeaderText="City" />
                                </Columns>
                            </asp:GridView>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button ID="btnSave" runat="server" CausesValidation="true" CssClass="button"
                                Width="180" Text="Approve Selected Agents" ValidationGroup="Save" OnClick="btnSave_Click" />
                        </td>
                    </tr>
                </table>
            </fieldset>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
