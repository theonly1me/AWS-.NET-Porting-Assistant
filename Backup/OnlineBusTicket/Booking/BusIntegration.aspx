<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="BusIntegration.aspx.cs" Inherits="OnlineBusTicket.BusIntegration" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <link href="../Styles/LSCSS.css" rel="stylesheet" type="text/css" />
    <script language="javascript" type="text/javascript">
        function NoResults() {

            alert("No Buses found.");
            return false;

        }

        function OpenDialog() {

            var dialogResult = window.showModalDialog('RouteSummary.aspx', 'name', 'dialogWidth:1000px;dialogHeight:800px');
            if ((dialogResult == undefined) || (dialogResult == '')) {
                // No results sent or user clicked the 'X' closer...
            }
            else {
                // dialogResult is the value returned from the dialog...
                __doPostBack('PostBackFromDialog', dialogResult);
            }

        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:UpdatePanel ID="up" runat="server">
        <ContentTemplate>
            <table width="100%">
                <tr>
                    <td style="width: 80%;" class="header">
                        <asp:Label ID="lbl_header" runat="server" Text="List of Buses between the stations"
                            Font-Names="Calibri" Font-Size="Medium" ForeColor="White"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <table width="100%">
                            <tr>
                                <td style="width: 60%;" align="left">
                                    <asp:Image ID="img_dsp" runat="server" ImageUrl="~/Images/DisplayIMage.png" />
                                </td>
                                <td style="width: 40%;" align="right">
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td style="width: 60%;" align="center">
                                    <asp:Label ID="lbl_Results" runat="server" Font-Bold="True" Font-Names="Calibri"
                                        ForeColor="Black" Text="Please contact admin"
                                        Font-Size="Medium"></asp:Label>
                                </td>
                                <td style="width: 40%;" align="center">
                                    &nbsp;</td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td style="width: 100%;">
                    <fieldset>
                    <legend class="legend">Bus Details</legend>

                        <asp:GridView ID="grd_result" runat="server" AutoGenerateColumns="false" Width="100%"
                            CssClass="gridview" OnRowCommand="grd_result_RowCommand" 
                            onrowdatabound="grd_result_RowDataBound">
                            <Columns>
                                <asp:TemplateField HeaderText="No" HeaderStyle-Width="50px" HeaderStyle-Font-Underline="true">
                                    <ItemTemplate>
                                        <asp:LinkButton ID="lnk_busno" runat="server" Text='<%#Eval("Bus_ID")%>' CommandName="gotoedit"
                                            ForeColor="#ff5050" ToolTip="Click to view Route & Fare" Font-Underline="True"></asp:LinkButton>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Operators" HeaderStyle-Width="150px" HeaderStyle-Font-Underline="true">
                                    <ItemTemplate>
                                        <asp:Label ID="lbl_operators" runat="server" Text='<%#Eval("Operator_Name")%>' ForeColor="#0066FF"></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                 <asp:TemplateField HeaderText="Route" HeaderStyle-Width="150px" HeaderStyle-Font-Underline="true" Visible="false">
                                    <ItemTemplate>
                                        <asp:Label ID="lbl_RouteID" runat="server" Text='<%#Eval("Route_ID")%>' ForeColor="#0066FF"></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                  <asp:TemplateField HeaderText="Bus No" HeaderStyle-Width="150px" HeaderStyle-Font-Underline="true" Visible="false">
                                    <ItemTemplate>
                                        <asp:Label ID="lbl_Busno_actual" runat="server" Text='<%#Eval("Bus_No")%>' ForeColor="#0066FF"></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                  <asp:TemplateField HeaderText="Route" HeaderStyle-Width="150px" HeaderStyle-Font-Underline="true">
                                    <ItemTemplate>
                                        <asp:Label ID="lbl_RouteName" runat="server" Text='<%#Eval("Route_Name")%>' ForeColor="#0066FF"></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Name" HeaderStyle-Width="150px" HeaderStyle-Font-Underline="true">
                                    <ItemTemplate>
                                        <asp:Label ID="lbl_busName" runat="server" Text='<%#Eval("Bus_Name")%>' ForeColor="#0066FF"></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Type" ItemStyle-HorizontalAlign="Center" HeaderStyle-Font-Underline="true">
                                    <ItemTemplate>
                                        <table width="20%">
                                            <tr>

                                                <td style="width: 5%;">
                                                    <asp:Image ID="img_AC" runat="server" ImageUrl="~/Images/AC_Seats.png" ToolTip="Bus with AC" />
                                                    <asp:HiddenField ID="hid_AC" runat="server" Value='<%#Eval("Bus_AC")%>' />   
                                                </td>
                                              
                                                <td>
                                                    <asp:Image ID="img_Volvo" runat="server" ImageUrl="~/Images/Volvo.png" ToolTip="This is volvo bus" />
                                                     <asp:HiddenField ID="hid_VO" runat="server" Value='<%#Eval("Bus_Volvo")%>'  />   
                                                </td>
                                                
                                                <td>
                                                    <asp:Image ID="img_SL" runat="server" ImageUrl="~/Images/Sleeper.png" ToolTip="Bus with Sleeper berths" />
                                                     <asp:HiddenField ID="hid_SL" runat="server" Value='<%#Eval("Bus_SL")%>'  />   
                                                </td>
                                                
                                                <td>
                                                    <asp:Image ID="img_Siting" runat="server" ImageUrl="~/Images/Sitting_Seats.png" ToolTip="Bus with seaters seats" />
                                                     <asp:HiddenField ID="hid_ST" runat="server" Value='<%#Eval("Bus_ST")%>' />   
                                                </td>
                                               
                                                <td>
                                                </td>
                                            </tr>
                                        </table>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="DepTime" ItemStyle-HorizontalAlign="Center" HeaderStyle-Font-Underline="true">
                                    <ItemTemplate>
                                        <asp:Label ID="lbl_Departure" runat="server" Text='<%#Eval("Dep")%>' ForeColor="#0066FF"></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="ArrTime" ItemStyle-HorizontalAlign="Center" HeaderStyle-Font-Underline="true">
                                    <ItemTemplate>
                                        <asp:Label ID="lbl_Arrival" runat="server" Text='<%#Eval("Arr")%>' ForeColor="#0066FF"></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Seats" HeaderStyle-Font-Underline="true">
                                    <ItemTemplate>
                                        <asp:Label ID="lbl_ava" runat="server" Text="Available" ForeColor="#00CC66"></asp:Label>
                                        <asp:Label ID="lbl_AvailableSeats" runat="server" Text='<%#Eval("AvailableSeats")%>'
                                            ForeColor="#000066" Font-Bold="True"></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField >
                                    <ItemTemplate>
                                        <asp:ImageButton ID="img_select" runat="server" ImageUrl="~/Images/Select Seats.png"
                                            CommandName="Select" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                            <RowStyle CssClass="gridviewItemStyle_ml" HorizontalAlign="center" />
                            <HeaderStyle CssClass="gridviewHeader_ml" HorizontalAlign="center" />
                            <AlternatingRowStyle CssClass="gridviewAlternatingStyle_ml" HorizontalAlign="center" />
                        </asp:GridView>
                        </fieldset>
                    </td>
                </tr>
            </table>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
