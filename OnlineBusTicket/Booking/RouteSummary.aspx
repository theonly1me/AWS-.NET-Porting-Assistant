<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RouteSummary.aspx.cs" Inherits="OnlineBusTicket.Booking.RouteSummary" %>
    <%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script language="javascript" type="text/javascript">
        function NoResults() {

            alert("No Buses found.");
            return false;

        }
    </script>
     
    <link href="../Styles/LSCSS.css" rel="stylesheet" type="text/css" />
    <title>Online Bus Reservation System | Route & Fare BreakUp</title>
</head>
<body>
    <form id="form1" runat="server">
      <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
    </asp:ToolkitScriptManager>
    <asp:UpdatePanel ID="up" runat="server">
        <ContentTemplate>

    <table width="100%">
        <tr>
            <td style="width: 80%;" class="header" bgcolor="#336699">
                <asp:Label ID="lbl_header" runat="server" Text="List of stations and fare breakup summary"
                    Font-Names="Calibri" Font-Size="Medium" ForeColor="White" Style="font-weight: 700"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 100%">
            </td>
        </tr>
        <tr>
            <td style="width: 100%">
                <asp:GridView ID="grd_routeDetails" runat="server" Width="100%" CssClass="gridview"
                    AutoGenerateColumns="false">
                    <Columns>
                        <asp:TemplateField HeaderText="BusNo">
                            <ItemTemplate>
                                <asp:Label ID="lbl_bus_id" runat="server" Text='<%#Eval("Bus_ID")%>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Location ID">
                            <ItemTemplate>
                                <asp:Label ID="lbl_Loc_Id" runat="server" Text='<%#Eval("Location_ID")%>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Station Code">
                            <ItemTemplate>
                                <asp:Label ID="lbl_Sta_code" runat="server" Text='<%#Eval("StationCode")%>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Station Name">
                            <ItemTemplate>
                                <asp:Label ID="lbl_Sta_name" runat="server" Text='<%#Eval("StationName")%>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Route No">
                            <ItemTemplate>
                                <asp:Label ID="lbl_Sta_routeNo" runat="server" Text='<%#Eval("RouteNo")%>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Route Name">
                            <ItemTemplate>
                                <asp:Label ID="lbl_Sta_routeName" runat="server" Text='<%#Eval("RouteName")%>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Route order">
                            <ItemTemplate>
                                <asp:Label ID="lbl_Sta_routeOrder" runat="server" Text='<%#Eval("RouteOrder")%>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Distance(Kms)">
                            <ItemTemplate>
                                <asp:Label ID="lbl_Sta_distance" runat="server" Text='<%#Eval("Distance_Kms")%>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Fare">
                            <ItemTemplate>
                                <asp:Label ID="lbl_Sta_fare" runat="server" Text='<%#Eval("FareBreakUp")%>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                    <RowStyle CssClass="gridviewItemStyle_ml" HorizontalAlign="center" />
                    <HeaderStyle CssClass="gridviewHeader_ml" HorizontalAlign="center" />
                    <AlternatingRowStyle CssClass="gridviewAlternatingStyle_ml" HorizontalAlign="center" />
                </asp:GridView>
            </td>
        </tr>
    </table>
    </ContentTemplate>
    </asp:UpdatePanel>
    </form>
</body>
</html>
