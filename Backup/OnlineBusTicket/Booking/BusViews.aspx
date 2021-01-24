<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="BusViews.aspx.cs" Inherits="OnlineBusTicket.BusViews" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <link href="../Styles/LSCSS.css" rel="stylesheet" type="text/css" />
    <title>Online Bus booking | Seat Selection Area</title>
    <script language="javascript" type="text/javascript">
        function NoResults() {

            alert("Unable to retrieve bus view -and Boarding point from the server. Please contact admin.");
            return false;

        }


        function NoFare() {

            alert("Unable to retrieve fare from the server. Please contact admin.");
            return false; 

            function NoBusView() {

            alert("Unable to retrieve bus seat view. Please contact admin.(Desc-Seats are not configured in BUS-Seat");
            return false;

        }
    </script>
    <script language="javascript" type="text/javascript">
        function SelectBoardingPoint() {
            var ddl = document.getElementById("<%=ddl_BoardingPoint.ClientID%>");
            if (ddl.value == -1) {

                alert("Please select boarding point");
                return false;
            }


        }

    </script>
    <script language="javascript" type="text/javascript">
        function NoBoardingPointsExits() {

            alert("Unable to retrieve Boarding Point for the selected bus on route. Please contact admin.");
            return false;

        }
    </script>
    <script language="javascript" type="text/javascript">
        function funcCount() {
            var cnt = document.getElementById("<%=hidfldCount.ClientID %>").value;
            if (cnt == null) {
                alert('Count Not Found')
                return false;
            }
            else if (cnt >= 1 && cnt <= 6) {
                return true;
            }
            else 
            {
                alert('Please select atleast 1 to 6 Passanger on a Single Ticket')
                return false;
            }
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:UpdatePanel ID="up" runat="server">
        <ContentTemplate>
            <table width="100%" border="1px" style="border: thin groove #003399">
                <tr>
                    <td style="width: 100%;" align="center">
                        <table style="width: 100%">
                            <tr>
                                <td style="width: 10%;" align="left" valign="top">
                                    <asp:Image ID="Image1" runat="server" Height="161px" ImageUrl="~/Images/FrontImage.png"
                                        Width="72px" />
                                </td>
                                <td style="width: 100%;" align="left">
                                    <table style="width: 100%" bgcolor="#E6E6E6">
                                        <tr style="height: 30px;">
                                            <td style="width: 2%;">
                                                <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Images/UnAllocatedSeat.png"
                                                    ToolTip="1" Width="31px" />
                                            </td>
                                            <td style="width: 2%;">
                                                <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/Images/UnAllocatedSeat.png"
                                                    Width="31px" ToolTip="2" />
                                            </td>
                                            <td style="width: 2%;">
                                                <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="~/Images/UnAllocatedSeat.png"
                                                    Width="31px" ToolTip="3" />
                                            </td>
                                            <td style="width: 2%;">
                                                <asp:ImageButton ID="ImageButton4" runat="server" ImageUrl="~/Images/UnAllocatedSeat.png"
                                                    Width="31px" ToolTip="4" />
                                            </td>
                                            <td style="width: 2%;">
                                                <asp:ImageButton ID="ImageButton5" runat="server" ImageUrl="~/Images/UnAllocatedSeat.png"
                                                    Width="31px" ToolTip="5" />
                                            </td>
                                            <td style="width: 2%;">
                                                <asp:ImageButton ID="ImageButton6" runat="server" ImageUrl="~/Images/UnAllocatedSeat.png"
                                                    Width="31px" ToolTip="6" />
                                            </td>
                                            <td style="width: 2%;">
                                                <asp:ImageButton ID="ImageButton7" runat="server" ImageUrl="~/Images/UnAllocatedSeat.png"
                                                    Width="31px" ToolTip="7" />
                                            </td>
                                            <td style="width: 2%;">
                                                <asp:ImageButton ID="ImageButton8" runat="server" ImageUrl="~/Images/UnAllocatedSeat.png"
                                                    Width="31px" ToolTip="8" />
                                            </td>
                                            <td style="width: 2%;">
                                                <asp:ImageButton ID="ImageButton9" runat="server" ImageUrl="~/Images/UnAllocatedSeat.png"
                                                    Width="31px" ToolTip="9" />
                                            </td>
                                            <td style="width: 2%;">
                                                <asp:ImageButton ID="ImageButton20" runat="server" ImageUrl="~/Images/UnAllocatedSeat.png"
                                                    Width="31px" ToolTip="20" />
                                            </td>
                                        </tr>
                                        <tr style="height: 30px;">
                                            <td style="width: 2%;">
                                                <asp:ImageButton ID="ImageButton10" runat="server" ImageUrl="~/Images/UnAllocatedSeat.png"
                                                    Width="31px" ToolTip="10" />
                                            </td>
                                            <td style="width: 2%;">
                                                <asp:ImageButton ID="ImageButton11" runat="server" ImageUrl="~/Images/UnAllocatedSeat.png"
                                                    Width="31px" ToolTip="11" />
                                            </td>
                                            <td style="width: 2%;">
                                                <asp:ImageButton ID="ImageButton12" runat="server" ImageUrl="~/Images/UnAllocatedSeat.png"
                                                    Width="31px" ToolTip="12" />
                                            </td>
                                            <td style="width: 2%;">
                                                <asp:ImageButton ID="ImageButton13" runat="server" ImageUrl="~/Images/UnAllocatedSeat.png"
                                                    Width="31px" ToolTip="13" />
                                            </td>
                                            <td style="width: 2%;">
                                                <asp:ImageButton ID="ImageButton14" runat="server" ImageUrl="~/Images/UnAllocatedSeat.png"
                                                    Width="31px" ToolTip="14" />
                                            </td>
                                            <td style="width: 2%;">
                                                <asp:ImageButton ID="ImageButton15" runat="server" ImageUrl="~/Images/UnAllocatedSeat.png"
                                                    Width="31px" ToolTip="15" />
                                            </td>
                                            <td style="width: 2%;">
                                                <asp:ImageButton ID="ImageButton16" runat="server" ImageUrl="~/Images/UnAllocatedSeat.png"
                                                    Width="31px" ToolTip="16" />
                                            </td>
                                            <td style="width: 2%;">
                                                <asp:ImageButton ID="ImageButton17" runat="server" ImageUrl="~/Images/UnAllocatedSeat.png"
                                                    Width="31px" ToolTip="17" />
                                            </td>
                                            <td style="width: 2%;">
                                                <asp:ImageButton ID="ImageButton18" runat="server" ImageUrl="~/Images/UnAllocatedSeat.png"
                                                    Width="31px" ToolTip="18" />
                                            </td>
                                            <td style="width: 2%;">
                                                <asp:ImageButton ID="ImageButton19" runat="server" ImageUrl="~/Images/UnAllocatedSeat.png"
                                                    Width="31px" ToolTip="19" />
                                            </td>
                                        </tr>
                                        <tr style="height: 30px;">
                                            <td colspan="9">
                                            </td>
                                            <td style="width: 2%;">
                                                <asp:ImageButton ID="ImageButton21" runat="server" ImageUrl="~/Images/UnAllocatedSeat.png"
                                                    Width="31px" ToolTip="21" />
                                            </td>
                                        </tr>
                                        <tr style="height: 30px;">
                                            <td style="width: 2%;">
                                                <asp:ImageButton ID="ImageButton40" runat="server" ImageUrl="~/Images/UnAllocatedSeat.png"
                                                    Width="31px" ToolTip="40" />
                                            </td>
                                            <td style="width: 2%;">
                                                <asp:ImageButton ID="ImageButton38" runat="server" ImageUrl="~/Images/UnAllocatedSeat.png"
                                                    Width="31px" ToolTip="38" />
                                            </td>
                                            <td style="width: 2%;">
                                                <asp:ImageButton ID="ImageButton37" runat="server" ImageUrl="~/Images/UnAllocatedSeat.png"
                                                    Width="31px" ToolTip="37" />
                                            </td>
                                            <td style="width: 2%;">
                                                <asp:ImageButton ID="ImageButton34" runat="server" ImageUrl="~/Images/UnAllocatedSeat.png"
                                                    Width="31px" ToolTip="34" />
                                            </td>
                                            <td style="width: 2%;">
                                                <asp:ImageButton ID="ImageButton33" runat="server" ImageUrl="~/Images/UnAllocatedSeat.png"
                                                    Width="31px" ToolTip="33" />
                                            </td>
                                            <td style="width: 2%;">
                                                <asp:ImageButton ID="ImageButton30" runat="server" ImageUrl="~/Images/UnAllocatedSeat.png"
                                                    Width="31px" ToolTip="30" />
                                            </td>
                                            <td style="width: 2%;">
                                                <asp:ImageButton ID="ImageButton29" runat="server" ImageUrl="~/Images/UnAllocatedSeat.png"
                                                    Width="31px" ToolTip="29" />
                                            </td>
                                            <td style="width: 2%;">
                                                <asp:ImageButton ID="ImageButton26" runat="server" ImageUrl="~/Images/UnAllocatedSeat.png"
                                                    Width="31px" ToolTip="26" />
                                            </td>
                                            <td style="width: 2%;">
                                                <asp:ImageButton ID="ImageButton25" runat="server" ImageUrl="~/Images/UnAllocatedSeat.png"
                                                    Width="31px" ToolTip="25" />
                                            </td>
                                            <td style="width: 2%;">
                                                <asp:ImageButton ID="ImageButton22" runat="server" ImageUrl="~/Images/UnAllocatedSeat.png"
                                                    Width="31px" ToolTip="22" />
                                            </td>
                                        </tr>
                                        <tr style="height: 30px;">
                                            <td style="width: 2%;">
                                                <asp:ImageButton ID="ImageButton41" runat="server" ImageUrl="~/Images/UnAllocatedSeat.png"
                                                    Width="31px" ToolTip="41" />
                                            </td>
                                            <td style="width: 2%;">
                                                <asp:ImageButton ID="ImageButton39" runat="server" ImageUrl="~/Images/UnAllocatedSeat.png"
                                                    Width="31px" ToolTip="39" />
                                            </td>
                                            <td style="width: 2%;">
                                                <asp:ImageButton ID="ImageButton36" runat="server" ImageUrl="~/Images/UnAllocatedSeat.png"
                                                    Width="31px" ToolTip="36" />
                                            </td>
                                            <td style="width: 2%;">
                                                <asp:ImageButton ID="ImageButton35" runat="server" ImageUrl="~/Images/UnAllocatedSeat.png"
                                                    Width="31px" ToolTip="35" />
                                            </td>
                                            <td style="width: 2%;">
                                                <asp:ImageButton ID="ImageButton32" runat="server" ImageUrl="~/Images/UnAllocatedSeat.png"
                                                    Width="31px" ToolTip="32" />
                                            </td>
                                            <td style="width: 2%;">
                                                <asp:ImageButton ID="ImageButton31" runat="server" ImageUrl="~/Images/UnAllocatedSeat.png"
                                                    Width="31px" ToolTip="31" />
                                            </td>
                                            <td style="width: 2%;">
                                                <asp:ImageButton ID="ImageButton28" runat="server" ImageUrl="~/Images/UnAllocatedSeat.png"
                                                    Width="31px" ToolTip="28" />
                                            </td>
                                            <td style="width: 2%;">
                                                <asp:ImageButton ID="ImageButton27" runat="server" ImageUrl="~/Images/UnAllocatedSeat.png"
                                                    Width="31px" ToolTip="27" />
                                            </td>
                                            <td style="width: 2%;">
                                                <asp:ImageButton ID="ImageButton24" runat="server" ImageUrl="~/Images/UnAllocatedSeat.png"
                                                    Width="31px" ToolTip="24" />
                                            </td>
                                            <td style="width: 2%;">
                                                <asp:ImageButton ID="ImageButton23" runat="server" ImageUrl="~/Images/UnAllocatedSeat.png"
                                                    Width="31px" ToolTip="23" />
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                        </table>
                    </td>
                    <td style="width: 40%;" align="center" valign="middle">
                        <asp:Image ID="Image2" runat="server" ImageUrl="~/Images/SeatsDesc.png" />
                    </td>
                </tr>
                <tr>
                    <td style="width: 70%;" align="right">
                        <table width="100%">
                            <tr>
                                <td style="width: 20%;" align="left">
                                    <asp:LinkButton ID="lnk_otherBus" runat="server" Text="Select Another Bus" OnClick="lnk_otherBus_Click"></asp:LinkButton>
                                </td>
                                <td style="width: 50%;" align="left">
                                    <asp:Label ID="lbl_selectedSeats" runat="server" ForeColor="#003366" Text="Selected Seats:"
                                        CssClass="labeltext_ml"></asp:Label>
                                    <asp:Label ID="lbl_SelectedValue" runat="server" Font-Names="Calibri" Font-Size="Small"
                                        ForeColor="Red" Style="font-weight: 700" Text=""></asp:Label>
                                </td>
                            </tr>
                        </table>
                    </td>
                    <td style="width: 40%;" rowspan="5" align="center" valign="middle">
                        <asp:Image ID="Image3" runat="server" ImageUrl="~/Images/SeatsDesc1.png" />
                    </td>
                </tr>
                <tr>
                    <td style="width: 70%;" align="right">
                    </td>
                </tr>
                <tr>
                    <td align="right" style="width: 25%;">
                        <table width="100%">
                            <tr>
                                <td style="width: 5%;" align="left">
                                    <asp:Label ID="lbl_BoardingPoint" runat="server" ForeColor="#003366" Text="Boarding Point"
                                        CssClass="labeltext_ml"></asp:Label>
                                </td>
                                <td style="width: 20%;" align="left">
                                    <asp:DropDownList ID="ddl_BoardingPoint" runat="server" CssClass="ddlLarge_ml" Width="90%"
                                        OnSelectedIndexChanged="ddl_BoardingPoint_SelectedIndexChanged" AutoPostBack="true">
                                    </asp:DropDownList>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td align="right" style="width: 25%;">
                        <table width="100%">
                            <tr>
                                <td style="width: 7%;" align="left">
                                    <asp:Label ID="lbl_TotalFare" runat="server" CssClass="labeltext_ml" ForeColor="#003366"
                                        Text="Fare from Boarding pt"></asp:Label>
                                </td>
                                <td style="width: 5%;" align="left">
                                    <asp:Image ID="img_rs" runat="server" ImageUrl="~/Images/RupeeSymbol.jpg" />
                                    <asp:Label ID="lbl_FareValue" runat="server" Font-Names="Calibri" Font-Size="Medium"
                                        ForeColor="Red" Style="font-weight: 700" Text="0" Width="80px"></asp:Label>
                                    &nbsp;&nbsp;&nbsp;&nbsp;
                                </td>
                                <td style="width: 13%;" align="left">
                                    <table width="100%">
                                        <tr>
                                            <td style="width: 50%;" align="left">
                                                <asp:Label ID="lbl_final_fare" runat="server" CssClass="labeltext_ml" ForeColor="#003366"
                                                    Text="Total Fare"></asp:Label>
                                            </td>
                                            <td style="width: 50%;" align="left">
                                                <asp:Image ID="img_rs1" runat="server" ImageUrl="~/Images/RupeeSymbol.jpg" />
                                                <asp:Label ID="lbl_final_fare_val" runat="server" Font-Names="Calibri" Font-Size="Medium"
                                                    ForeColor="Red" Style="font-weight: 700" Text="0" Width="80px"></asp:Label>
                                                &nbsp;&nbsp;&nbsp;&nbsp;
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
               
                <tr>
                    <td style="width: 70%;" align="center">
                        <asp:HiddenField ID="hidfldCount" runat="server" />
                        <asp:ImageButton ID="img_cont" runat="server" ImageUrl="~/Images/Continue.png" OnClick="img_cont_Click"  OnClientClick="return funcCount()"/>
                    </td>
                </tr>
                 <tr>
                    <td style="width: 70%;" align="left">
                        <asp:Label ID="lbl_note1" runat="server" Font-Names="Calibri" Font-Size="Small" ForeColor="Red"
                            Style="font-weight: 700" Text="* Boarding point will become source station in case if passenger doesn't wish to choose boarding point."></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td align="left">
                        <asp:Label ID="lbl_note" runat="server" Text="* The seat numbers are indicative and not guaranteed. The bus operator reserves the right to change the seat numbers"
                            Font-Names="Calibri" ForeColor="Red" Font-Bold="True" Font-Size="Small"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td style="width: 70%;" align="left">
                        <asp:Label ID="lbl_note2" runat="server" Font-Bold="True" Font-Names="Calibri" 
                            Font-Size="Small" ForeColor="Red" 
                            Text="* Maximum no of Passanger can be '6' on a Single Ticket"></asp:Label>
                    </td>
                </tr>
            </table>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
