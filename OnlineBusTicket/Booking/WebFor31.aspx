<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFor31.aspx.cs" Inherits="OnlineBusTicket.Booking.WebFor31" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div id="wrapper">
        <div id="wrapper1">
            <div id="header">
                <div id="head-container">
                    <div class="head-left">
                        <a href="#">
                            <img src="images/logo.jpg" /></a></div>
                    <div class="head-right">
                        <ul>
                            <li><a href="#">Bookings or Sign-In</a></li>
                            <li>
                                <img src="images/logo-icon.jpg" />
                                &nbsp;<a href="#">Trip Rewards</a></li>
                            <li><a href="#">Register</a></li>
                            <li style="border: none;"><a href="#">Travel Acents</a></li>
                            <li style="border: none; padding: 0;">
                                <img src="images/world-wede.jpg" /></li>
                        </ul>
                        <div style="margin-top: 15px; text-align: right">
                            <img src="images/phone.jpg" /></div>
                    </div>
                </div>
            </div>
            <!-- end header part -->
            <div id="menu">
                <div class="nav-bg">
                    <ul>
                        <li><a href="#" class="cureent">Home</a></li>
                        <li><a href="#">Intra State Buses</a></li>
                        <li><a href="#">Inter State Buses</a></li>
                        <li><a href="#">Hotels</a></li>
                        <li><a href="#">Customer Support</a></li>
                    </ul>
                </div>
            </div>
            <!-- end menu part -->
            <div id="content">
                <div class="content-holder">
                    <div class="ch-left">
                        <div class="obtb-sec">
                            <div class="obtb-head">
                                ONLINE BUS TICKETS BOOKING</div>
                            <div>
                                <table width="100%">
                                    <tr>
                                        <td style="width: 50%;">
                                        </td>
                                        <td style="width: 50%;">
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="width: 50%;">
                                        </td>
                                         <td style="width: 50%;">
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="width: 50%;" align="center">
                                            <asp:Label ID="lbl_leavingFrom" runat="server" Text="Leaving From" CssClass="labeltext_ml"></asp:Label>
                                        </td>
                                         <td style="width: 50%;" align="center">
                                             <asp:Label ID="lbl_goingto" runat="server" Text="Going to" CssClass="labeltext_ml"></asp:Label>
                                        </td>
                                    </tr>
                                     <tr>
                                        <td style="width: 50%;" align="center">
                                            <asp:DropDownList ID="DropDownList1" runat="server" CssClass="ddlLarge_ml" 
                                                Width="90%">
                                            </asp:DropDownList>
                                        </td>
                                        <td style="width: 50%;" align="center">
                                            <asp:DropDownList ID="DropDownList2" runat="server" CssClass="ddlLarge_ml" 
                                                Width="90%">
                                            </asp:DropDownList>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="width: 50%;">
                                        </td>
                                         <td style="width: 50%;">
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="width: 50%;">
                                            <asp:Label ID="lbl_DepDate" runat="server" Text="Departure Date" 
                                                CssClass="labeltext_ml"></asp:Label>
                                        </td>
                                         <td style="width: 50%;">
                                        </td>
                                    </tr>
                                     <tr>
                                        <td style="width: 50%;">
                                            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                                            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Images/imgCalendar.png" />
                                        </td>
                                        <td style="width: 50%;">
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="width: 50%;">
                                        </td>
                                         <td style="width: 50%;">
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="width: 50%;">
                                        </td>
                                         <td style="width: 50%;">
                                        </td>
                                    </tr>
                                     <tr>
                                        <td style="width: 50%;">
                                        </td>
                                        <td style="width: 50%;">
                                            <asp:Button ID="Button1" runat="server"  Text="Button" 
                                                onclick="Button1_Click" />
                                         </td>
                                    </tr>
                                    <tr>
                                        <td style="width: 50%;">
                                        </td>
                                         <td style="width: 50%;">
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="width: 50%;">
                                        </td>
                                         <td style="width: 50%;">
                                        </td>
                                    </tr>
                                     <tr>
                                        <td style="width: 50%;">
                                        </td>
                                        <td style="width: 50%;">
                                        </td>
                                    </tr>
                                   
                                  
                                </table>
                            </div>
                        </div>
                        <!-- end obtb-sec part -->
                        <div class="mybb-sec">
                            <div class="mybb-head">
                                Manage Your Bus Booking</div>
                            <div class="mybb-text">
                                <table width="100%" border="0" cellspacing="0" cellpadding="0">
                                    <tr>
                                        <td>
                                            <img src="images/printer.png" />
                                        </td>
                                        <td>
                                            <a href="#">Print Ticket</a>
                                        </td>
                                        <td>
                                            <img src="images/cancle-ticket.png" />
                                        </td>
                                        <td>
                                            <a href="#">Cancel Ticket</a>
                                        </td>
                                    </tr>
                                </table>
                            </div>
                        </div>
                        <!-- end mybb-sec part -->
                        <div class="login-sec">
                            <div class="login-head">
                                Login</div>
                        </div>
                        <!-- end login-sec part -->
                    </div>
                    <!-- end ch-left part -->
                    <div class="ch-center">
                        <div>
                            <img src="images/banner.jpg" /></div>
                        <div class="mt">
                            <img src="images/customer-speak.jpg" width="522" height="119" /></div>
                        <div class="clear">
                        </div>
                        <div class="contentc">
                            <div class="contentc-head">
                                WHY FOR BOOKING BUS TICKETS ONLINE</div>
                            <ul>
                                <li>Book bus tickets for over 10,000 bus routes all across Nigeria</li>
                                <li>Choose from Volvo, AC/ Non-AC, Luxury, Sleeper Bus, and others </li>
                                <li>Choose from over 500 bus operators online</li>
                                <li>Compare fares, check for availability and book online in a few clicks</li>
                                <li>Multiple payment options</li>
                                <li>Get discounts and cash backs on confirmed bus reservations</li>
                                <li>Round the clock customer support</li>
                            </ul>
                        </div>
                    </div>
                    <!-- end ch-center part -->
                    <div class="ch-right">
                        <div>
                            <img src="images/right-banner1.jpg" /></div>
                        <div class="mt">
                            <img src="images/right-banner2.jpg" /></div>
                    </div>
                    <!-- end ch-left part -->
                </div>
                <!-- end content-holder part -->
            </div>
            <!-- end content part -->
            <div class="clear">
            </div>
            <div id="footer">
                <div class="ft-left">
                    © 2012 Bus Tickets Online Booking Pvt. Ltd.</div>
                <div class="ft-right">
                    <ul>
                        <li><a href="#">Home</a></li>
                        <li><a href="#">Privacy Statement</a></li>
                        <li><a href="#">Terms of Use</a></li>
                        <li><a href="#">XML</a></li>
                        <li style="border: none; padding: 0;"><a href="#">Sitemap</a></li>
                    </ul>
                </div>
            </div>
            <!-- end footer part -->
        </div>
        <!-- end wrapper1 part -->
    </div>
    </form>
</body>
</html>
