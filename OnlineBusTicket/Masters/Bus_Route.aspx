<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="Bus_Route.aspx.cs" Inherits="OnlineBusTicket.Masters.Bus_Route" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <link href="../Styles/LSCSS.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <table style="width: 100%">
                <tr>
                    <td colspan="2">
                        <table class="contenttemplate">
                            <tr>
                                <td align="center" colspan="4">
                                    <asp:Label ID="lbl_msg" runat="server" CssClass="general" Font-Names="Calibri" 
                                        ForeColor="Red" Visible="False"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 5%">
                                    &nbsp;
                                </td>
                                <td style="width: 15%">
                                    <b style="color: Red; vertical-align: text-top; font-size: small">
                                    <asp:Label ID="lblRouteName" runat="server" CssClass="labeltext" 
                                        Text="Route Name :"></asp:Label>
                                    *</b>
                                </td>
                                <td style="width: 30%">
                                    <asp:DropDownList ID="ddlRouteName" runat="server" AutoPostBack="True" 
                                        CssClass="ddlLarge" OnSelectedIndexChanged="ddlRouteName_SelectedIndexChanged" 
                                        ValidationGroup="Bus">
                                    </asp:DropDownList>
                                </td>
                                <td style="width: 50%">
                                    &nbsp;
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 5%">
                                    &nbsp;
                                </td>
                                <td style="width: 15%">
                                    &nbsp;
                                </td>
                                <td style="width: 30%">
                                    &nbsp;
                                </td>
                                <td style="width: 50%">
                                    &nbsp;
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 5%">
                                    &nbsp;
                                </td>
                                <td style="width: 15%">
                                    <b style="color: Red; vertical-align: text-top; font-size: small">
                                        <asp:Label ID="lblBusName" runat="server" Text="Bus Name :" CssClass="labeltext"></asp:Label>
                                        *</b>
                                </td>
                                <td style="width: 30%">
                                    <asp:DropDownList ID="ddlBusName" runat="server" CssClass="ddlLarge" ValidationGroup="Bus"
                                        AutoPostBack="True" OnSelectedIndexChanged="ddlBusName_SelectedIndexChanged">
                                    </asp:DropDownList>
                                </td>
                                <td style="width: 50%">
                                    &nbsp;
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr id="trGrid" runat="server">
                    <td colspan="2">
                        <fieldset>
                            <legend class="legend">Bus Detail</legend>
                            <table class="contenttemplate">
                                <tr>
                                    <td style="width: 40%">
                                        <div id="divGridLeft" style="overflow: auto; height: 150px">
                                            <asp:GridView ID="grdLocTotal" runat="server" AutoGenerateColumns="False" CssClass="gridview"
                                                DataKeyNames="Location_ID" EmptyDataText="Location Not Found" ShowHeaderWhenEmpty="True"
                                                Width="100%" OnSelectedIndexChanging="grdLocTotal_SelectedIndexChanging">
                                                <RowStyle CssClass="gridviewItemStyle" HorizontalAlign="center" />
                                                <AlternatingRowStyle CssClass="gridviewAlternatingStyle" HorizontalAlign="center" />
                                                <Columns>
                                                    <asp:TemplateField HeaderText="S.No." InsertVisible="False" ItemStyle-CssClass="gridviewColumnSNo">
                                                        <EditItemTemplate>
                                                            <asp:Label ID="lblSNo" runat="server"></asp:Label>
                                                        </EditItemTemplate>
                                                        <ItemTemplate>
                                                            <asp:Label ID="lblSNo0" runat="server" Text="<%# Container.DataItemIndex + 1 %>"></asp:Label>
                                                            <asp:Label ID="lblLocId" runat="server" Text='<%# Bind("Location_ID") %>' Visible="False"></asp:Label>
                                                        </ItemTemplate>
                                                        <ItemStyle CssClass="gridviewColumnSNo" />
                                                    </asp:TemplateField>
                                                  <asp:TemplateField HeaderText="Location Name" InsertVisible="False" ItemStyle-CssClass="gridviewColumnControls">
                                                        <ItemTemplate>
                                                         <asp:Label ID="lblLocation" runat="server" Text='<%# Bind("Location_Name") %>' Visible="true" ItemStyle-CssClass="gridviewColumnText"></asp:Label>
                                                    
                                                        </ItemTemplate>
                                                    </asp:TemplateField>

                                                    <asp:CommandField ButtonType="Button" HeaderText="Move" SelectText="&gt;&gt;" ShowSelectButton="True"
                                                        ItemStyle-CssClass="gridviewColumnControls" />
                                                </Columns>
                                                <EditRowStyle CssClass="general" />
                                                <EmptyDataRowStyle CssClass="general" />
                                                <HeaderStyle CssClass="gridviewHeader" HorizontalAlign="center" />
                                                <RowStyle CssClass="gridviewItemStyle" HorizontalAlign="center" />
                                            </asp:GridView>
                                        </div>
                                    </td>
                                    <td style="width: 60%">
                                        <div id="divGridRight" style="overflow: auto; height: 150px">
                                            <asp:GridView ID="grdLocAlloted" runat="server" AutoGenerateColumns="False" CssClass="gridview"
                                                DataKeyNames="Location_ID" EmptyDataText="Location Not Maped" ShowHeaderWhenEmpty="True"
                                                Width="100%" OnSelectedIndexChanging="grdLocAlloted_SelectedIndexChanging">
                                                <RowStyle CssClass="gridviewItemStyle" HorizontalAlign="center" />
                                                <AlternatingRowStyle CssClass="gridviewAlternatingStyle" HorizontalAlign="center" />
                                                <Columns>
                                                    <asp:TemplateField HeaderText="S.No." InsertVisible="False" ItemStyle-CssClass="gridviewColumnSNo">
                                                        <EditItemTemplate>
                                                            <asp:Label ID="lblSNo1" runat="server"></asp:Label>
                                                        </EditItemTemplate>
                                                        <ItemTemplate>
                                                            <asp:Label ID="lblSNo2" runat="server" Text="<%# Container.DataItemIndex + 1 %>"></asp:Label>
                                                            <asp:Label ID="lblLocId" runat="server" Text='<%# Bind("Location_ID") %>' Visible="false"></asp:Label>
                                                        </ItemTemplate>
                                                        <ItemStyle CssClass="gridviewColumnSNo" />
                                                    </asp:TemplateField>
                                                  
                                                    <asp:TemplateField HeaderText="Location Name" InsertVisible="False" ItemStyle-CssClass="gridviewColumnControls">
                                                        <ItemTemplate>
                                                            <asp:Label ID="lblLocation" runat="server" Text='<%# Bind("Location_Name") %>' Visible="true" ItemStyle-CssClass="gridviewColumnText"></asp:Label>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="Arr.Time" InsertVisible="False" ItemStyle-CssClass="gridviewColumnControls">
                                                        <ItemTemplate>
                                                            <asp:TextBox ID="txtArrival" runat="server" Text='<%# Bind("ArrivalTime") %>' Width="80px"
                                                                MaxLength="20"></asp:TextBox>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="Dep.Time" InsertVisible="False" ItemStyle-CssClass="gridviewColumnControls">
                                                        <ItemTemplate>
                                                            <asp:TextBox ID="txtDeparture" runat="server" Text='<%# Bind("DepartureTime") %>' Width="80px"
                                                               MaxLength="20"></asp:TextBox>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="Distance" InsertVisible="False" ItemStyle-CssClass="gridviewColumnControls">
                                                        <ItemTemplate>
                                                            <asp:TextBox ID="txtDistance" runat="server" Text='<%# Bind("Dist") %>' Width="60px"
                                                                MaxLength="4"></asp:TextBox>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:CommandField ButtonType="Button" HeaderText="Move" SelectText="&lt;&lt;" ShowSelectButton="True"
                                                        ItemStyle-CssClass="gridviewColumnControls" />
                                                </Columns>
                                                <EditRowStyle CssClass="general" />
                                                <EmptyDataRowStyle CssClass="general" />
                                                <HeaderStyle CssClass="gridviewHeader" HorizontalAlign="center" />
                                                <RowStyle CssClass="gridviewItemStyle" HorizontalAlign="center" />
                                            </asp:GridView>
                                        </div>
                                    </td>
                                </tr>
                            </table>
                        </fieldset>
                    </td>
                </tr>
                <tr id="trBtn" runat="server">
                    <td style="width: 50%">
                        <asp:Button ID="btnSave" runat="server" CssClass="button" 
                            OnClick="btnSave_Click" Text="Save" ValidationGroup="Bus" />
                        <asp:Button ID="btncancel" runat="server" CssClass="button" 
                            OnClick="btncancel_Click" Text="Cancel" ValidationGroup="Bus" />
                    </td>
                    <td align="right" style="width: 50%">
                    </td>
                </tr>
            </table>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
