<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="OnlineBusTicket.Default" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Bus Tickets Online Booking</title>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link rel="shortcut icon" href="images/favicon.ico" type="image/x-icon" />
    <link href="css/style.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" language="JavaScript" src="js/menu.js"></script>
    <link href="Styles/LSCSS.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="js/mootools-1.2-core.js"></script>
    <script type="text/javascript" src="js/_class.noobSlide.packed.js"></script>
    <script language="javascript" type="text/javascript">


        function SomeProblemInBusView() {

            alert("Unable to retrieve bus view -and Boarding point from the server. Please contact admin.");
            return false;

        }

        function NoResults() {

            alert("No buses found on this route for selected date");
            return false;

        }

        function checkSourceDestination() {

            var depdate = document.getElementById("txt_dep_date").value;
            var source = document.getElementById("ddl_source").value;
            var Desti = document.getElementById("ddl_destin").value;

            if (source == "-1" && Desti == "-1") {
                alert("Please select source and destination.");
                return false;
            }

            if (source == Desti) {
                alert("Source & Destination cannot be same.");
                return false;
            }
            if (source == -1) {
                alert("Please select Source.");
                return false;
            }
            if (Desti == -1) {
                alert("Please select Destination.");
                return false;
            }
            if (depdate == "") {
                alert("Please select departure date.");
                return false;
            }


        }

    </script>
    <script type="text/javascript" language="javascript">
        function DisplayDateToday(sender, args) {
            if (sender._selectedDate == null) {
                sender._selectedDate = new Date();

            }
        }

    </script>
    <script type="text/javascript">
        function CheckDateEalier11(sender, args) {
            debugger
            if (sender._selectedDate < new Date()) {

                alert("You cannot select a day before todaykkhhhk!")

                var fdate = document.getElementById("txt_dep_date").value = "";

            }
        }


        function CheckDateEalier(sender, args) {

            var currentTime = new Date();
            if (sender._selectedDate < currentTime.getDateOnly()) {
                alert("You cannot select a day before  today!");

                sender._selectedDate = currentTime;
                // set the date back to the current date
                sender._textbox.set_Value(sender._selectedDate.format(sender._format))
            }
        }


    </script>
    <script type="text/javascript">
        window.addEvent('domready', function () {
            var handles8_more = $$('#handles8_more span');
            var nS8 = new noobSlide({
                box: $('box8'),
                items: $$('#box8 h3'),
                size: 500,
                handles: $$('#handles8 span'),
                addButtons: { previous: $('prev8'), play: $('play8'), stop: $('stop8'), playback: $('playback8'), next: $('next8') },
                onWalk: function (currentItem, currentHandle) {
                    //style for handles
                    $$(this.handles, handles8_more).removeClass('active');
                    $$(currentHandle, handles8_more[this.currentIndex]).addClass('active');
                    //text for "previous" and "next" default buttons
                    $('prev8').set('html', '&lt;&lt; ' + this.items[this.previousIndex].innerHTML);
                    $('next8').set('html', this.items[this.nextIndex].innerHTML + ' &gt;&gt;');
                }
            });
            //more "previous" and "next" buttons
            nS8.addActionButtons('previous', $$('#box8 .prev'));
            nS8.addActionButtons('next', $$('#box8 .next'));
            //more handle buttons
            nS8.addHandleButtons(handles8_more);
            //walk to item 3 witouth fx
            nS8.walk(3, false, true);

        });
    </script>
    <script src="Scripts/AC_RunActiveContent.js" type="text/javascript"></script>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
        </asp:ToolkitScriptManager>
        <asp:UpdatePanel ID="up" runat="server">
            <ContentTemplate>
                <div id="wrapper">
                    <div id="wrapper1">
                        <div id="header">
                            <div id="head-container">
                                <div class="head-left">
                                    <a href="#">
                                        <img src="images/logo.jpg" /></a>
                                </div>
                                <div class="head-right">
                                    <ul>
                                        <li id="liAcount" runat="server"><a href="Administration/UserProfile.aspx">My Acount</a></li>
                                        <li>
                                            <img src="images/logo-icon.jpg" />
                                            &nbsp;<a href="#">Trip Rewards</a></li>
                                        <li id="liReg" runat="server"><a href="Administration/User_Acount.aspx?UT=5&R=1">Register</a></li>
                                        <li id="liRegAgent" runat="server" style="border: none;"><a href="Administration/User_Acount.aspx?UT=5&R=2">Travel
                                        Agents</a></li>
                                        <li style="border: none; padding: 0;">
                                            <img src="images/world-wede.jpg" /></li>
                                    </ul>
                                    <div style="margin-top: 15px; text-align: right">
                                        <img src="images/phone.jpg" />
                                    </div>
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
                                    <li style="float: right">
                                        <asp:LinkButton ID="lnkSignOut" Text="Sign Out"
                                            runat="server" OnClick="lnkSignOut_Click1" /></li>
                                    <li style="float: right">
                                        <asp:LinkButton ID="lnkLogin" runat="server"></asp:LinkButton></li>
                                </ul>
                            </div>
                        </div>
                        <!-- end menu part -->
                        <div id="content">
                            <div class="content-holder">
                                <div class="ch-left">
                                    <div class="obtb-sec">
                                        <div class="obtb-head">
                                            ONLINE BUS TICKETS BOOKING
                                        </div>
                                        <div>
                                            <table width="100%" style="height: 86;">
                                                <tr>
                                                    <td style="width: 50%;" align="left">
                                                        <asp:Label ID="lbl_leavingFrom" runat="server" Text="Leaving From" CssClass="labeltext_ml"
                                                            Font-Size="Small"></asp:Label>
                                                    </td>
                                                    <td style="width: 50%;" align="left">
                                                        <asp:Label ID="lbl_goingto" runat="server" Text="Going to" CssClass="labeltext_ml"
                                                            Font-Size="Small"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style="width: 50%;" align="left">
                                                        <asp:DropDownList ID="ddl_source" runat="server" CssClass="ddlLarge_ml" Width="100%"
                                                            BackColor="#E6FFE6">
                                                        </asp:DropDownList>
                                                    </td>
                                                    <td style="width: 50%;" align="left">
                                                        <asp:DropDownList ID="ddl_destin" runat="server" CssClass="ddlLarge_ml" Width="100%"
                                                            BackColor="#E6FFE6">
                                                        </asp:DropDownList>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style="width: 50%;" align="left">
                                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Select Leaving From"
                                                            Font-Names="Calibri" Font-Size="Small" ForeColor="Red" ControlToValidate="ddl_source"
                                                            InitialValue="-1" ValidationGroup="srch"></asp:RequiredFieldValidator>
                                                    </td>
                                                    <td style="width: 50%;" align="left">
                                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Select Going to"
                                                            Font-Names="Calibri" Font-Size="Small" ForeColor="Red" ControlToValidate="ddl_destin"
                                                            InitialValue="-1" ValidationGroup="srch"></asp:RequiredFieldValidator>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style="width: 50%;">
                                                        <asp:Label ID="lbl_DepDate" runat="server" Text="Departure Date" CssClass="labeltext_ml"
                                                            Font-Size="Small"></asp:Label>
                                                    </td>
                                                    <td style="width: 50%;"></td>
                                                </tr>
                                                <tr>
                                                    <td style="width: 50%;">
                                                        <asp:TextBox ID="txt_dep_date" runat="server" Width="80%" BackColor="#E6FFE6"></asp:TextBox>
                                                        <asp:CalendarExtender ID="cal_dep" runat="server" TargetControlID="txt_dep_date"
                                                            Format="dd MMM yy" PopupButtonID="ImageButton1" OnClientShowing="DisplayDateToday"
                                                            OnClientDateSelectionChanged="CheckDateEalier">
                                                        </asp:CalendarExtender>
                                                        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Images/imgCalendar.png"
                                                            CausesValidation="False" ValidationGroup="srch" />
                                                    </td>
                                                    <td style="width: 50%;"></td>
                                                </tr>
                                                <tr>
                                                    <td style="width: 50%;" align="center">
                                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Select Departure Date"
                                                            Font-Names="Calibri" ValidationGroup="srch" Font-Size="Small" ForeColor="Red" ControlToValidate="txt_dep_date"></asp:RequiredFieldValidator>
                                                    </td>
                                                    <td style="width: 50%;" align="left">
                                                        <asp:UpdateProgress ID="UpdateProgress1" runat="server">
                                                            <ProgressTemplate>
                                                                <asp:Image ID="img_progress11111" runat="server" ImageUrl="~/Images/ajax-loader_2.gif"
                                                                    Width="110px" />
                                                            </ProgressTemplate>
                                                        </asp:UpdateProgress>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style="width: 50%;">
                                                        <asp:LinkButton ID="lnk_cnnot" runat="server" Text="Can't find a route?" ForeColor="#336699"
                                                            Font-Underline="True" CausesValidation="False" OnClick="lnk_cnnot_Click"></asp:LinkButton>
                                                    </td>
                                                    <td style="width: 58%;">
                                                        <asp:Button ID="Button1" runat="server" Text="Search" OnClick="Button1_Click" BackColor="#FFD542"
                                                            Font-Bold="True" ValidationGroup="srch" Font-Names="Calibri" Font-Size="Medium" ForeColor="Black" OnClientClick="return checkSourceDestination()"
                                                            Width="107px" />
                                                    </td>
                                                </tr>
                                            </table>
                                        </div>
                                    </div>
                                    <!-- end obtb-sec part -->
                                    <div class="mybb-sec">
                                        <div class="mybb-head">
                                            Manage Your Bus Booking
                                        </div>
                                        <div class="mybb-text">
                                            <table width="100%" border="0" cellspacing="0" cellpadding="0">
                                                <tr>
                                                    <td>
                                                        <img src="images/printer.png" />
                                                    </td>
                                                    <td>
                                                        <a href="Administration/BookingDetails.aspx?q=Print">Print Ticket</a>
                                                    </td>
                                                    <td>
                                                        <img src="images/cancle-ticket.png" />
                                                    </td>
                                                    <td>
                                                        <a href="Administration/BookingDetails.aspx?q=Cancel">Cancel Ticket</a>
                                                    </td>
                                                </tr>
                                            </table>
                                        </div>
                                    </div>
                                    <!-- end mybb-sec part -->
                                    <div class="login-sec" id="divImage" runat="server">
                                        <img src="Images/left-img.png" />
                                    </div>
                                    <div class="login-sec" id="tblLogin" runat="server">
                                        <div class="login-head">
                                            Login
                                        </div>
                                        <div>
                                            <table style="width: 100%">
                                                <tr>
                                                    <td colspan="2" align="center" valign="middle">
                                                        <asp:Label ID="lblFailureText" runat="server" Visible="false" CssClass="valid" Font-Size="9" />
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td width="5%"></td>
                                                    <td align="center" valign="middle" width="95%">
                                                        <table width="100%">
                                                            <tr>
                                                                <td align="left">
                                                                    <br />
                                                                    <asp:Label ID="UserNameLabel" runat="server" ForeColor="Black" CssClass="labeltext_ml"
                                                                        Font-Size="Small">E-Mail ID</asp:Label>
                                                                    <asp:TextBox ID="txtEMail" runat="server" CssClass="textEntry" BackColor="#E6FFE6"></asp:TextBox><br />
                                                                    <asp:RequiredFieldValidator ID="EMailRequired" runat="server" ControlToValidate="txtEMail"
                                                                        CssClass="valid" ErrorMessage="E-Mail ID is required." Font-Size="9" ToolTip="E-Mail ID is required."
                                                                        ValidationGroup="LoginUserValidationGroup"></asp:RequiredFieldValidator>
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td align="left">
                                                                    <asp:Label ID="PasswordLabel" runat="server" ForeColor="Black" CssClass="labeltext_ml"
                                                                        Font-Size="Small">Password</asp:Label>
                                                                    <asp:TextBox ID="txtPassword" runat="server" CssClass="passwordEntry" TextMode="Password"
                                                                        BackColor="#E6FFE6"></asp:TextBox>
                                                                    <br />
                                                                    <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ControlToValidate="txtPassword"
                                                                        CssClass="valid" ErrorMessage="Password is required." Font-Size="9" ToolTip="Password is required."
                                                                        ValidationGroup="LoginUserValidationGroup"></asp:RequiredFieldValidator>
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td align="left"></td>
                                                            </tr>
                                                            <tr>
                                                                <td align="left">
                                                                    <asp:Button ID="LoginButton" runat="server" CssClass="button" Text="Log In" Height="30"
                                                                        ValidationGroup="LoginUserValidationGroup" OnClick="LoginButton_Click"
                                                                        BackColor="#6A830A" ForeColor="White" />
                                                                    &nbsp;&nbsp;&nbsp;<asp:CheckBox ID="RememberMe" runat="server" Text="Stay logged in" />

                                                                    <asp:HyperLink ID="RegisterHyperLink" runat="server" EnableViewState="False"
                                                                        NavigateUrl="~/Administration/User_Acount.aspx?UT=5&R=1" Font-Bold="True"
                                                                        ForeColor="#6A830A">Create account</asp:HyperLink>
                                                                    &nbsp;&nbsp;&nbsp;&nbsp;
                                                                    <asp:LinkButton ID="lnkForgotPassword" runat="server" CssClass="inline" Text="Forgot Password?"
                                                                        Font-Size="9pt" Font-Bold="True" ForeColor="#6A830A" /></td>
                                                            </tr>
                                                        </table>
                                                    </td>
                                                </tr>
                                            </table>
                                        </div>
                                    </div>
                                    <!-- end login-sec part -->
                                </div>
                                <!-- end ch-left part -->
                                <div class="ch-center">
                                    <div class="contentc-head">
                                        TOURIST PLACES
                                    </div>
                                    <%--<div class="flash">
                                    <script type="text/javascript">
                                        AC_FL_RunContent('codebase', 'http://download.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=9,0,28,0', 'width', '522', 'height', '196', 'src', 'swf/banner', 'quality', 'high', 'pluginspage', 'http://www.adobe.com/shockwave/download/download.cgi?P1_Prod_Version=ShockwaveFlash', 'movie', 'swf/banner'); //end AC code
                                    </script>
                                    <noscript>
                                        <object classid="clsid:D27CDB6E-AE6D-11cf-96B8-444553540000" codebase="http://download.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=9,0,28,0"
                                            width="522" height="196">
                                            <param name="movie" value="swf/banner.swf" />
                                            <param name="quality" value="high" />
                                            <embed src="swf/banner.swf" quality="high" pluginspage="http://www.adobe.com/shockwave/download/download.cgi?P1_Prod_Version=ShockwaveFlash"
                                                type="application/x-shockwave-flash" width="522" height="196"></embed>
                                        </object>
                                    </noscript>
                                    <img src="images/tourist-place.gif" width="508px" height="150px" alt="Tourist Place" />
                                </div>--%>
                                    <img src="images/tourist-place.gif" width="508px" height="150px" alt="Tourist Place" />
                                    <div class="customer-feedback">
                                        <div class="cf-head">
                                            Coustomer Feedback
                                        </div>
                                        <div id="cont">
                                            <div class="mask1">
                                                <div id="box8">
                                                    <div class="div1">
                                                        <h3>Mr. Yogesh</h3>
                                                        <p>
                                                            <img src="images/customer-speak.jpg" align="left" />Unlike some booking websites
                                                        that show wrong information regarding seat availbility, Bus Teckets Online Booking
                                                        gives good information. I like booking through it and in fact I am using it whenever
                                                        I want go somewhere.
                                                        </p>
                                                        <p class="buttons">
                                                            <span class="prev">&lt;&lt; Previous</span> <span class="next">Next &gt;&gt;</span>
                                                        </p>
                                                    </div>
                                                    <div class="div1">
                                                        <h3>Abhinav Bhatnagar</h3>
                                                        <p>
                                                            <img src="images/customer-speak.jpg" align="left" />Unlike some booking websites
                                                        that show wrong information regarding seat availbility, Bus Teckets Online Booking
                                                        gives good information. I like booking through it and in fact I am using it whenever
                                                        I want go somewhere.
                                                        </p>
                                                        <p class="buttons">
                                                            <span class="prev">&lt;&lt; Previous</span> <span class="next">Next &gt;&gt;</span>
                                                        </p>
                                                    </div>
                                                    <div class="div1">
                                                        <h3>Ashish Saxena</h3>
                                                        <p>
                                                            <img src="images/customer-speak.jpg" align="left" />Unlike some booking websites
                                                        that show wrong information regarding seat availbility, Bus Teckets Online Booking
                                                        gives good information. I like booking through it and in fact I am using it whenever
                                                        I want go somewhere.
                                                        </p>
                                                        <p class="buttons">
                                                            <span class="prev">&lt;&lt; Previous</span> <span class="next">Next &gt;&gt;</span>
                                                        </p>
                                                    </div>
                                                    <div class="div1">
                                                        <h3>Himanshu Pathak</h3>
                                                        <p>
                                                            <img src="images/customer-speak.jpg" align="left" />Unlike some booking websites
                                                        that show wrong information regarding seat availbility, Bus Teckets Online Booking
                                                        gives good information. I like booking through it and in fact I am using it whenever
                                                        I want go somewhere.
                                                        </p>
                                                        <p class="buttons">
                                                            <span class="prev">&lt;&lt; Previous</span> <span class="next">Next &gt;&gt;</span>
                                                        </p>
                                                    </div>
                                                </div>
                                            </div>
                                            <p class="buttons" style="display: none">
                                                <span id="prev8">&lt;&lt; Previous</span> | <span id="next8">Next &gt;&gt;</span>
                                            </p>
                                            <p class="buttons" style="display: none">
                                                <span id="playback8"></span><span id="stop8"></span><span id="play8"></span>
                                            </p>
                                        </div>
                                    </div>
                                    <div class="clear">
                                    </div>
                                    <div class="contentc">
                                        <div class="contentc-head">
                                            We serve here
                                        </div>
                                        <div class="torist-place">
                                            <%--<img src="images/tourist-place.gif" width="508px" height="150px" alt="Tourist Place" />--%>

                                            <asp:GridView ID="grd_result" runat="server" AutoGenerateColumns="false" Width="100%"
                                                CssClass="gridview">
                                                <Columns>
                                                    <asp:TemplateField HeaderText="No" HeaderStyle-Width="50px" HeaderStyle-Font-Underline="true">
                                                        <ItemTemplate>
                                                            <asp:LinkButton ID="lnk_busno" runat="server" Text='<%#Eval("Location_ID")%>' CommandName="gotoedit"
                                                                ForeColor="#ff5050" ToolTip="Click to view Route & Fare" Font-Underline="True"></asp:LinkButton>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="Operators" HeaderStyle-Width="150px" HeaderStyle-Font-Underline="true">
                                                        <ItemTemplate>
                                                            <asp:Label ID="lbl_operators" runat="server" Text='<%#Eval("Location_Name")%>' ForeColor="#0066FF"></asp:Label>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="Type" ItemStyle-HorizontalAlign="Center" HeaderStyle-Font-Underline="true">
                                                        <ItemTemplate>
                                                            <table width="20%">
                                                                <tr>

                                                                    <td style="width: 5%;">
                                                                        <asp:Image ID="img_AC" runat="server" ImageUrl="~/Images/AC_Seats.png" ToolTip="Bus with AC" />
                                                                        <asp:HiddenField ID="hid_AC" runat="server" Value='AC' />
                                                                    </td>

                                                                    <td>
                                                                        <asp:Image ID="img_Volvo" runat="server" ImageUrl="~/Images/Volvo.png" ToolTip="This is volvo bus" />
                                                                        <asp:HiddenField ID="hid_VO" runat="server" Value='Volvo' />
                                                                    </td>

                                                                    <td>
                                                                        <asp:Image ID="img_SL" runat="server" ImageUrl="~/Images/Sleeper.png" ToolTip="Bus with Sleeper berths" />
                                                                        <asp:HiddenField ID="hid_SL" runat="server" Value='Bus_SL' />
                                                                    </td>

                                                                    <td>
                                                                        <asp:Image ID="img_Siting" runat="server" ImageUrl="~/Images/Sitting_Seats.png" ToolTip="Bus with seaters seats" />
                                                                        <asp:HiddenField ID="hid_ST" runat="server" Value='Bus_ST' />
                                                                    </td>

                                                                    <td></td>
                                                                </tr>
                                                            </table>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="DepTime" ItemStyle-HorizontalAlign="Center" HeaderStyle-Font-Underline="true">
                                                        <ItemTemplate>
                                                            <asp:Label ID="lbl_Departure" runat="server" Text='09:00 AM' ForeColor="#0066FF"></asp:Label>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="ArrTime" ItemStyle-HorizontalAlign="Center" HeaderStyle-Font-Underline="true">
                                                        <ItemTemplate>
                                                            <asp:Label ID="lbl_Arrival" runat="server" Text='10:00 AM' ForeColor="#0066FF"></asp:Label>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="Seats" HeaderStyle-Font-Underline="true">
                                                        <ItemTemplate>
                                                            <asp:Label ID="lbl_ava" runat="server" Text="Available" ForeColor="#00CC66"></asp:Label>
                                                            <asp:Label ID="lbl_AvailableSeats" runat="server" Text='10'
                                                                ForeColor="#000066" Font-Bold="True"></asp:Label>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField>
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
                                        </div>
                                        <!-- end torist-place part -->
                                    </div>
                                </div>
                                <!-- end ch-center part -->
                                <div class="ch-right">
                                    <div>
                                        <img src="images/right-banner1.jpg" />
                                    </div>
                                    <div class="mt">
                                        <img src="images/right-banner2.jpg" />
                                    </div>
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
                                © 2012 Bus Tickets Online Booking Pvt. Ltd.
                            </div>
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
            </ContentTemplate>
        </asp:UpdatePanel>
    </form>
</body>
</html>
