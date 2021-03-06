﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PrintTicket.aspx.cs" Inherits="OnlineBusTicket.Administration.PrintTicket" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <link href="../Styles/HRCSS.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .@dispNone
        {
            display: none;
        }
        *
        {
            padding: 0;
            margin: 0;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table id="tblPrint" runat="server" cellspacing="0" border="1" cellpadding="0" style="width: 60%">
            <tr align="center" id="trMsg" runat="server" visible="true">
                <td align="left" colspan="2">
                    <asp:Image ID="Image3" runat="server" ImageUrl="~/Images/e-ticketing.jpg" ClientIDMode="AutoID"
                        Width="100%" Height="140px" />
                </td>
            </tr>
            <tr align="center">
                <td class="style1" colspan="2">
                    <asp:Label ID="lblMsg" runat="server" CssClass="alert" Text="Invalid Ticket No."
                        Visible="False"></asp:Label>
                </td>
            </tr>
            <tr align="center">
                <td class="style1" colspan="2">
                    <fieldset>
                        <legend class="legend">Booking Details</legend>
                        <table style="width: 100%">
                            <tr>
                                <td>
                                    <table style="width: 100%">
                                        <tr>
                                            <td colspan="2">
                                            </td>
                                            <td colspan="2">
                                                &nbsp;</td>
                                        </tr>
                                                 <tr>
                                            <td style="width: 20%" align="left">
                                                <asp:Label ID="lbl6" runat="server" Text="Ticket No" CssClass="labeltext_ml"></asp:Label>
                                            </td>
                                            <td style="width: 25%" align="left">
                                                :
                                                <asp:Label ID="lblTicketNo" runat="server" CssClass="alert"></asp:Label>
                                            </td>
                                            <td style="width: 20%" align="left">
                                                <asp:Label ID="lbl9" runat="server" Text="Quota" CssClass="labeltext_ml"></asp:Label>
                                            </td>
                                            <td style="width: 25%" align="left">
                                               :
                                                <asp:Label ID="lblQuota" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="width: 20%" align="left">
                                                <asp:Label ID="lbl1" runat="server" Text="Bus Operator" CssClass="labeltext_ml"></asp:Label>
                                            </td>
                                            <td align="left" colspan="3">
                                                :
                                                <asp:Label ID="lblBusOperator" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="width: 20%" align="left">
                                                <asp:Label ID="Label15" runat="server" Text="Bus No" CssClass="labeltext_ml"></asp:Label>
                                            </td>
                                            <td style="width: 25%" align="left">
                                                :
                                                <asp:Label ID="lblBusNo" runat="server"></asp:Label>
                                            </td>
                                            <td style="width: 20%" align="left">
                                                <asp:Label ID="Label6" runat="server" Text="Bus Type" CssClass="labeltext_ml"></asp:Label>
                                            </td>
                                            <td style="width: 25%" align="left">
                                               :
                                                <asp:Label ID="lblBusType" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="width: 20%" align="left">
                                                <asp:Label ID="lbl4" runat="server" Text="From" CssClass="labeltext_ml"></asp:Label>
                                            </td>
                                            <td style="width: 25%" align="left">
                                                :
                                                 <asp:Label ID="lblBusSource" runat="server"></asp:Label>
                                            </td>
                                            <td style="width: 20%" align="left">
                                                <asp:Label ID="lbl5" runat="server" Text="To" CssClass="labeltext_ml"></asp:Label>
                                            </td>
                                            <td style="width: 25%" align="left">
                                                :
                                                <asp:Label ID="lblBusUpto" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="width: 20%" align="left">
                                                <asp:Label ID="Label7" runat="server" Text="Boarding Date" 
                                                    CssClass="labeltext_ml"></asp:Label>
                                            </td>
                                            <td style="width: 25%" align="left">
                                                :
                                                <asp:Label ID="lblBoardingDate" runat="server"></asp:Label>
                                            </td>
                                            <td style="width: 20%" align="left">
                                                &nbsp;</td>
                                            <td style="width: 25%" align="left">
                                                &nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td style="width: 20%" align="left">
                                                <asp:Label ID="lbl3" runat="server" Text="Departure time" CssClass="labeltext_ml"></asp:Label>
                                            </td>
                                            <td style="width: 25%" align="left">
                                                :
                                                <asp:Label ID="lblDepartureTime" runat="server"></asp:Label>
                                            </td>
                                            <td style="width: 20%" align="left">
                                                <asp:Label ID="Label4" runat="server" Text="Arrival Time" CssClass="labeltext_ml"></asp:Label>
                                            </td>
                                            <td style="width: 25%" align="left">
                                                :
                                                <asp:Label ID="lblArrivalTime" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="width: 20%" align="left">
                                                <asp:Label ID="lbl8" runat="server" Text="Total Fair" CssClass="labeltext_ml"></asp:Label>
                                            </td>
                                            <td style="width: 25%" align="left">
                                                :
                                                <asp:Label ID="lbltotalFare" runat="server"></asp:Label>
                                            </td>
                                            <td style="width: 20%" align="left">
                                                <asp:Label ID="Label5" runat="server" Text="No. of Passengers" CssClass="labeltext_ml">
                                                </asp:Label>
                                            </td>
                                            <td style="width: 25%" align="left">
                                                :
                                                <asp:Label ID="lblNoOfPassenger" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td align="left" 
                                    style="font-size: small; font-family: Calibri; color: #FF0000;">
                                    *Please reach your boarding point 45 minutes before the scheduled time
                                </td>
                            </tr>
                        </table>
                    </fieldset>
                </td>
            </tr>
            <tr align="center">
                <td class="style1" colspan="2">
                    <fieldset>
                        <legend class="legend">Passenger Details</legend>
                        <table style="width: 100%">
                            <tr>
                                <td>
                                    <table style="width: 100%">
                                        <tr>
                                            <td style="width: 5%">
                                            </td>
                                            <td style="width: 25%">
                                            </td>
                                            <td style="width: 15%">
                                            </td>
                                            <td style="width: 15%">
                                            </td>
                                            <td style="width: 15%">
                                            </td>
                                            <td align="center" colspan="2" style="width: 25%">
                                                <asp:Label ID="lblPermitType2" runat="server" CssClass="labeltext_ml" Text="Seat No.">
                                                </asp:Label>
                                            </td>
                                        </tr>
                                        <tr id="tr1" runat="server">
                                            <td style="width: 5%">
                                            </td>
                                            <td style="width: 25%">
                                                <asp:Label ID="Label9" runat="server" CssClass="labeltext_ml" Text="Passenger 1 "></asp:Label>
                                            </td>
                                            <td colspan="3" align="left">
                                                :
                                                <asp:Label ID="txtPas1Name" runat="server"></asp:Label>
                                            </td>
                                            <td style="width: 10%" align="center">
                                                <asp:Label ID="lblPas1SeatNo" runat="server" CssClass="labeltext">0</asp:Label>
                                            </td>
                                            <td style="width: 5%">
                                            </td>
                                        </tr>
                                        <tr id="tr2" runat="server">
                                            <td style="width: 5%">
                                            </td>
                                            <td style="width: 25%">
                                                <asp:Label ID="Label10" runat="server" CssClass="labeltext_ml" Text="Passenger 2 "></asp:Label>
                                            </td>
                                            <td colspan="3" align="left">
                                                :
                                                <asp:Label ID="txtPas2Name" runat="server"></asp:Label>
                                            </td>
                                            <td style="width: 10%" align="center">
                                                <asp:Label ID="lblPas2SeatNo" runat="server" CssClass="labeltext">0</asp:Label>
                                            </td>
                                            <td style="width: 5%">
                                            </td>
                                        </tr>
                                        <tr id="tr3" runat="server">
                                            <td style="width: 5%">
                                            </td>
                                            <td style="width: 25%">
                                                <asp:Label ID="Label1" runat="server" CssClass="labeltext_ml" Text="Passenger 3 "></asp:Label>
                                            </td>
                                            <td colspan="3" align="left">
                                                :
                                                <asp:Label ID="txtPas3Name" runat="server"></asp:Label>
                                            </td>
                                            <td style="width: 10%" align="center">
                                                <asp:Label ID="lblPas3SeatNo" runat="server" CssClass="labeltext">0</asp:Label>
                                            </td>
                                            <td style="width: 5%">
                                            </td>
                                        </tr>
                                        <tr id="tr4" runat="server">
                                            <td style="width: 5%">
                                            </td>
                                            <td style="width: 25%">
                                                <asp:Label ID="Label12" runat="server" CssClass="labeltext_ml" Text="Passenger 4 "></asp:Label>
                                            </td>
                                            <td colspan="3" align="left">
                                                :
                                                <asp:Label ID="txtPas4Name" runat="server"></asp:Label>
                                            </td>
                                            <td style="width: 10%" align="center">
                                                <asp:Label ID="lblPas4SeatNo" runat="server" CssClass="labeltext">0</asp:Label>
                                            </td>
                                            <td style="width: 5%">
                                            </td>
                                        </tr>
                                        <tr id="tr5" runat="server">
                                            <td style="width: 5%">
                                            </td>
                                            <td style="width: 25%">
                                                <asp:Label ID="Label13" runat="server" CssClass="labeltext_ml" Text="Passenger 5 "></asp:Label>
                                            </td>
                                            <td colspan="3" align="left">
                                                :
                                                <asp:Label ID="txtPas5Name" runat="server"></asp:Label>
                                            </td>
                                            <td style="width: 10%" align="center">
                                                <asp:Label ID="lblPas5SeatNo" runat="server" CssClass="labeltext">0</asp:Label>
                                            </td>
                                            <td style="width: 5%">
                                            </td>
                                        </tr>
                                        <tr id="tr6" runat="server">
                                            <td style="width: 5%">
                                            </td>
                                            <td style="width: 25%">
                                                <asp:Label ID="Label14" runat="server" CssClass="labeltext_ml" Text="Passenger 6 "></asp:Label>
                                            </td>
                                            <td colspan="3" align="left">
                                                :
                                                <asp:Label ID="txtPas6Name" runat="server"></asp:Label>
                                            </td>
                                            <td style="width: 10%" align="center">
                                                <asp:Label ID="lblPas6SeatNo" runat="server" CssClass="labeltext">0</asp:Label>
                                            </td>
                                            <td style="width: 5%">
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="width: 5%">
                                            </td>
                                            <td style="width: 25%">
                                            </td>
                                            <td colspan="2">
                                            </td>
                                            <td style="width: 15%">
                                            </td>
                                            <td style="width: 25%">
                                            </td>
                                            <td style="width: 5%">
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td align="left" style="font-size: small">
                                    &nbsp;</td>
                            </tr>
                        </table>
                    </fieldset>
                </td>
            </tr>
            <tr align="center">
                <td class="style1" colspan="2">
                    <fieldset>
                        <legend class="legend">Boarding Point Details</legend>
                        <table class="contenttemplate">
                            <tr>
                                <td style="width: 30%">
                                </td>
                                <td style="width: 70%">
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 30%">
                                    <asp:Label ID="lbl2" runat="server" Text="Boarding Time" CssClass="labeltext_ml"></asp:Label>
                                </td>
                                <td align="left" style="width: 70%">
                                    :&nbsp;
                                    <asp:Label ID="lblBordingTime" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 30%">
                                    <asp:Label ID="lbl7" runat="server" Text="Boarding Point" CssClass="labeltext_ml"></asp:Label>
                                </td>
                                <td align="left" style="width: 70%">
                                    :&nbsp;
                                    <asp:Label ID="lblBordingFrom" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td align="left" colspan="2" style="font-size: small">
                                    Bus Operator Contact Number : 020-26121549/9325378164 /
                                </td>
                            </tr>
                            <tr>
                                <td align="left" colspan="2" style="font-size: small">
                                    ( Please use the Ticket Number : &quot;
                                    <asp:Label ID="lblTicketNoHeading" runat="server"></asp:Label>
                                    &nbsp;&quot; as reference for interaction with the bus operator )
                                </td>
                            </tr>
                        </table>
                    </fieldset>
                </td>
            </tr>

            <tr>
                <td colspan="2" align="center">
                    <asp:Button ID="btnPrint" runat="server" Text="Print" Width="70px" CssClass="@dispNone"
                        OnClientClick="window.print(); return false;" />
                    &nbsp;<asp:Button ID="btnToPDF" runat="server" Text="Download PDF" CssClass="@dispNone"
                         OnClientClick="window.open('D:\\ticket.pdf'); return false;" 
                        onclick="btnToPDF_Click" />
                    &nbsp;
                    <asp:Button ID="btn_Replan" runat="server" Text="New Booking" Width="100px" CssClass="@dispNone"
                        OnClick="btn_Replan_Click" />
                    <input type="hidden" id="hdnUserName" runat="server" />
                    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Home" />
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
