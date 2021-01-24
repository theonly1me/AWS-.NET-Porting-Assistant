<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="BookingCounter.aspx.cs" Inherits="OnlineBusTicket.BookingCounter" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <link href="../css/style.css" rel="stylesheet" type="text/css" />
    <link href="../Styles/LSCSS.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" language="javascript">
        function DisplayDateToday(sender, args) {
            if (sender._selectedDate == null) {
                sender._selectedDate = new Date();

            }
        }      

    </script>
    <script type="text/javascript">
        //        function CheckDateEalier(sender, args) {


        //            if (sender._selectedDate < new Date()) {

        //                alert("You cannot select a day before today!")

        //                var fdate = document.getElementById("<%=txt_DateofVisit.ClientID%>").value = "";

        //            }
        //        }

        function CheckDateEalier(sender, args) {

            var currentTime = new Date();
            if (sender._selectedDate < currentTime.getDateOnly()) {
                alert("You cannot select a day before  today!");

                sender._selectedDate = currentTime;
                // set the date back to the current date
                sender._textbox.set_Value(sender._selectedDate.format(sender._format))
            }
        }

        function DefaultFare() {
            alert("Fare details for this route is not available.You can book ticket with minimun fare which is Rs.100 ");
            return false;

        }


        function checkSourceDestination() {

            var depdate = document.getElementById("<%=txt_DateofVisit.ClientID%>").value;
            var source = document.getElementById("<%=ddl_source.ClientID%>").value;
            var Desti = document.getElementById("<%=ddl_destin.ClientID%>").value;
            var noofpers = document.getElementById("<%=txt_ind_male_no.ClientID%>").value;

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
            if (noofpers == "") {
                alert("Please Fill No of Passenger.");
                return false;
            }
            if (noofpers == "0") {
                alert("Please Fill No of Passenger other then 0");
                return false;
            }
            if (noofpers.indexOf(' ')>-1) {
                            alert("Please Do not Put Space");
                            return false;
            }
        }
        function FareCalculation(sender, args) {

            var hid_fare = document.getElementById("<%=hid_fare.ClientID%>").value;
            var NoOfPas = document.getElementById("<%=txt_ind_male_no.ClientID%>").value;
            var faretxt = document.getElementById("<%=txt_ind_fare.ClientID%>");

            faretxt.value = (hid_fare * NoOfPas);




        }
     

    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:UpdatePanel ID="UP" runat="server">
        <ContentTemplate>
            <table width="100%">
                <tr>
                    <td style="width: 100%;" align="left" valign="middle" bgcolor="#336699">
                        <asp:Label ID="lbl_pageHeader" runat="server" Text="Ticket booking by POS user(Counter Ticket)"
                            Font-Bold="True" Font-Names="Calibri" ForeColor="White"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td style="width: 100%;" align="center" valign="middle">
                        <asp:Label ID="lbl_msg" runat="server" Font-Names="Calibri" ForeColor="Red" CssClass="general"
                            Visible="False"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td style="width: 100%;" align="left" valign="middle">
                        <table width="100%">
                            <tr id="searchArea" runat="server">
                                <td align="left" valign="middle" colspan="4">
                                    <fieldset>
                                        <legend class="legend">Choose your search criteria</legend>
                                        <table width="100%">
                                            <tr>
                                                <td style="width: 16%;" align="left" valign="middle">
                                                </td>
                                                <td style="width: 30%;" align="left" valign="middle">
                                                </td>
                                                <td style="width: 25%;" align="left" valign="middle">
                                                </td>
                                                <td style="width: 29%;" align="left" valign="middle">
                                                </td>
                                            </tr>
                                            <tr id="advance_circle" runat="server">
                                                <td align="left" valign="middle" colspan="4">
                                                    <table width="100%">
                                                        <tr>
                                                            <td style="width: 25%;" align="left" valign="middle">
                                                                &nbsp;<asp:Label ID="lbl_operator" runat="server" Text="Select Operator" Width="95px"
                                                                    CssClass="active"></asp:Label>
                                                                <b style="color: Red; vertical-align: text-top; font-size: small">*</b>&nbsp;
                                                            </td>
                                                            <td style="width: 30%;" align="left" valign="middle">
                                                                <asp:DropDownList ID="ddlOperator" runat="server" CssClass="ddlMedium_ml" AutoPostBack="True"
                                                                    Width="100%" OnSelectedIndexChanged="ddlOperator_SelectedIndexChanged" BackColor="#E6FFE6">
                                                                </asp:DropDownList>
                                                            </td>
                                                            <td style="width: 25%;" align="left" valign="middle">
                                                            </td>
                                                            <td style="width: 25%;" align="left" valign="middle">
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td style="width: 25%;" align="left" valign="middle">
                                                            </td>
                                                            <td style="width: 30%;" align="left" valign="middle">
                                                                <asp:RequiredFieldValidator ID="reqddlCircle" runat="server" ControlToValidate="ddlOperator"
                                                                    Display="Dynamic" ErrorMessage="Select Operator " Font-Names="Calibri" Font-Size="Small"
                                                                    ForeColor="Red" InitialValue="0" Style="float: left"></asp:RequiredFieldValidator>
                                                            </td>
                                                            <td style="width: 25%;" align="left" valign="middle">
                                                            </td>
                                                            <td style="width: 29%;" align="left" valign="middle">
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td style="width: 25%;" align="left" valign="middle">
                                                                <asp:Label ID="lbl_selectBus" runat="server" Text="Select Bus" Width="87px"></asp:Label>
                                                                <b style="color: Red; vertical-align: text-top; font-size: small">*</b>&nbsp;
                                                            </td>
                                                            <td style="width: 30%;" align="left" valign="middle">
                                                                <asp:DropDownList ID="ddl_bus" runat="server" CssClass="ddlMedium_ml" Width="100%"
                                                                    AutoPostBack="True" OnSelectedIndexChanged="ddl_bus_SelectedIndexChanged" BackColor="#E6FFE6">
                                                                </asp:DropDownList>
                                                            </td>
                                                            <td style="width: 25%;" align="left" valign="middle">
                                                                <asp:Label ID="lbl_Perkm" runat="server" Width="87px" ForeColor="Red" Visible="False"></asp:Label>
                                                            </td>
                                                            <td style="width: 29%;" align="left" valign="middle">
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td style="width: 25%;" align="left" valign="middle">
                                                            </td>
                                                            <td style="width: 30%;" align="left" valign="middle">
                                                                <asp:RequiredFieldValidator ID="reqddl_monument" runat="server" ControlToValidate="ddl_bus"
                                                                    Display="Dynamic" ErrorMessage="Select Bus " Font-Names="Calibri" Font-Size="Small"
                                                                    ForeColor="Red" InitialValue="0" Style="float: left"></asp:RequiredFieldValidator>
                                                            </td>
                                                            <td style="width: 25%;" align="left" valign="middle">
                                                            </td>
                                                            <td style="width: 29%;" align="left" valign="middle">
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td style="width: 16%;" align="left" valign="middle">
                                                </td>
                                                <td style="width: 30%;" align="left" valign="middle">
                                                </td>
                                                <td style="width: 25%;" align="left" valign="middle">
                                                </td>
                                                <td style="width: 29%;" align="left" valign="middle">
                                                </td>
                                            </tr>
                                        </table>
                                    </fieldset>
                                </td>
                            </tr>
                            <tr id="visitorArea" runat="server">
                                <td align="left" valign="middle" colspan="4">
                                    <fieldset>
                                        <legend class="legend">Visitors Details</legend>
                                        <table width="100%">
                                            <tr>
                                                <td align="left" style="width: 15%;" valign="middle">
                                                    <asp:Label ID="lblSource" runat="server" CssClass="labeltext_ml" Text="Leaving From"
                                                        Width="90%"></asp:Label>
                                                    <b style="color: Red; vertical-align: text-top; font-size: small">*</b>&nbsp;
                                                </td>
                                                <td align="left" style="width: 30%;" valign="middle">
                                                    <asp:DropDownList ID="ddl_source" runat="server" CssClass="ddlLarge_ml" Width="100%"
                                                        BackColor="#E6FFE6" OnSelectedIndexChanged="ddl_source_SelectedIndexChanged"
                                                        AutoPostBack="True">
                                                    </asp:DropDownList>
                                                </td>
                                                <td align="left" style="width: 25%;" valign="middle">
                                                    <asp:Label ID="lblgoing" runat="server" CssClass="labeltext_ml" Text="Going to" 
                                                        Width="90%"></asp:Label>
                                                </td>
                                                <td align="left" style="width: 30%;" valign="middle">
                                                    <asp:DropDownList ID="ddl_destin" runat="server" CssClass="ddlLarge_ml" Width="100%"
                                                        BackColor="#E6FFE6" OnSelectedIndexChanged="ddl_destin_SelectedIndexChanged"
                                                        AutoPostBack="True">
                                                    </asp:DropDownList>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="left" style="width: 15%;" valign="middle">
                                                </td>
                                                <td align="left" style="width: 30%;" valign="middle">
                                                    <asp:RequiredFieldValidator ID="reqDateofVisit0" runat="server" ControlToValidate="txt_DateofVisit"
                                                        Display="Dynamic" ErrorMessage="Enter Date of Visit" Font-Names="Calibri" Font-Size="Small"
                                                        ForeColor="Red" Style="float: left" ValidationGroup="con"></asp:RequiredFieldValidator>
                                                </td>
                                                <td align="left" style="width: 25%;" valign="middle">
                                                </td>
                                                <td align="left" style="width: 30%;" valign="middle">
                                                    <asp:RequiredFieldValidator ID="reqDateofVisit1" runat="server" ControlToValidate="txt_DateofVisit"
                                                        Display="Dynamic" ErrorMessage="Enter Date of Visit" Font-Names="Calibri" Font-Size="Small"
                                                        ForeColor="Red" Style="float: left" ValidationGroup="con"></asp:RequiredFieldValidator>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="left" style="width: 15%;" valign="middle">
                                                    <asp:Label ID="lbl_DateofVisit0" runat="server" CssClass="labeltext_ml" Text="Date of Visit"
                                                        Width="77px"></asp:Label>
                                                    <b style="color: Red; vertical-align: text-top; font-size: small">*</b>&nbsp;
                                                </td>
                                                <td align="left" style="width: 30%;" valign="middle">
                                                    <asp:TextBox ID="txt_DateofVisit" runat="server" CssClass="textboxmedium_ml" BackColor="#E6FFE6"></asp:TextBox>
                                                    <asp:CalendarExtender ID="cal_visit" runat="server" Format="dd MMM yy" OnClientDateSelectionChanged="CheckDateEalier"
                                                        OnClientShowing="DisplayDateToday" TargetControlID="txt_DateofVisit">
                                                    </asp:CalendarExtender>
                                                </td>
                                                <td align="left" style="width: 25%;" valign="middle">
                                                    <asp:Label ID="lbl_booking" runat="server" CssClass="labeltext_ml" 
                                                        Text="Booking Date" Width="90%"></asp:Label>
                                                </td>
                                                <td align="left" style="width: 30%;" valign="middle">
                                                    <asp:Label ID="lbl_bookingDate" runat="server" CssClass="readonlytext" Text="DD MMM YYYY"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td style="width: 15%;" align="left" valign="middle">
                                                </td>
                                                <td style="width: 30%;" align="left" valign="middle">
                                                    <asp:RequiredFieldValidator ID="reqDateofVisit" runat="server" ControlToValidate="txt_DateofVisit"
                                                        Display="Dynamic" ErrorMessage="Enter Date of Visit" Font-Names="Calibri" Font-Size="Small"
                                                        ForeColor="Red" Style="float: left" ValidationGroup="con"></asp:RequiredFieldValidator>
                                                </td>
                                                <td style="width: 25%;" align="left" valign="middle">
                                                </td>
                                                <td style="width: 30%;" align="left" valign="middle">
                                                </td>
                                            </tr>
                                        </table>
                                    </fieldset>
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 25%;" align="left" valign="middle">
                                </td>
                                <td style="width: 25%;" align="left" valign="middle">
                                </td>
                                <td style="width: 25%;" align="left" valign="middle">
                                </td>
                                <td style="width: 25%;" align="left" valign="middle">
                                </td>
                            </tr>
                            <tr>
                                <td align="left" style="width: 25%;" valign="middle">
                                </td>
                                <td align="center" colspan="2" valign="middle">
                                    <asp:Button ID="btn_cal" runat="server" CssClass="button2" Height="30px" Text="Get Details"
                                        OnClientClick="return checkSourceDestination();" OnClick="btn_cal_Click" />
                                    &nbsp;<asp:Button ID="btn_res" runat="server" CssClass="button2" Height="30px" Text="Reset"
                                        OnClick="btn_res_Click" />
                                </td>
                                <td align="left" style="width: 25%;" valign="middle">
                                    <asp:HiddenField ID="hid_fare" runat="server" />
                                </td>
                            </tr>
                            <tr>
                                <td align="left" style="width: 25%;" valign="middle">
                                </td>
                                <td align="left" style="width: 25%;" valign="middle">
                                </td>
                                <td align="left" style="width: 25%;" valign="middle">
                                </td>
                                <td align="left" style="width: 25%;" valign="middle">
                                </td>
                            </tr>
                            <tr id="grd" runat="server">
                                <td align="left" valign="middle" colspan="4">
                                    <asp:GridView ID="grd_fare_breakup" CssClass="gridview" runat="server" Width="100%"
                                        AutoGenerateColumns="true">
                                        <RowStyle CssClass="gridviewItemStyle_ml" HorizontalAlign="center" />
                                        <HeaderStyle CssClass="gridviewHeader_ml" HorizontalAlign="center" />
                                        <AlternatingRowStyle CssClass="gridviewAlternatingStyle_ml" HorizontalAlign="center" />
                                    </asp:GridView>
                                </td>
                            </tr>
                            <tr id="passArea" runat="server">
                                <td align="left" valign="middle" colspan="4" style="width: 15%;">
                                    <table width="100%">
                                        <tr>
                                            <td style="width: 70%;" align="left" valign="top" class="readonlytext">
                                                <table border="1" width="100%">
                                                    <tr id="indian_Row" runat="server">
                                                        <td align="left" style="width: 10%;" valign="middle">
                                                            <asp:Label ID="lbl_noadults" runat="server" CssClass="labeltext_ml" Text="Adults"
                                                                Height="17px" Width="56px"></asp:Label>
                                                            <b style="color: Red; vertical-align: text-top; font-size: small">*</b>
                                                        </td>
                                                        <td align="left" style="width: 5%;" valign="middle">
                                                            <asp:TextBox ID="txt_ind_male_no" runat="server" CssClass="textboxmedium_ml" Width="100%"
                                                                BackColor="#E6FFE6" onblur="return FareCalculation();"></asp:TextBox>
                                                        </td>
                                                        <td align="left" style="width: 20%;" valign="middle">
                                                            <asp:Label ID="lbl_children" runat="server" CssClass="labeltext_ml" Text="Infants"
                                                                Width="70px"></asp:Label>
                                                            <b style="color: Red; vertical-align: text-top; font-size: small">*</b>
                                                        </td>
                                                        <td align="left" style="width: 5%;" valign="middle">
                                                            <asp:TextBox ID="txt_ind_children" runat="server" CssClass="textboxmedium_ml" Width="100%"
                                                                BackColor="#E6FFE6">0</asp:TextBox>
                                                        </td>
                                                        <td align="center" style="width: 10%;" valign="middle">
                                                            <asp:LinkButton ID="lnk_ind_fare" runat="server" Text="Fare" CssClass="labeltext_ml"></asp:LinkButton>
                                                        </td>
                                                        <td align="left" style="width: 7%;" valign="middle">
                                                            <asp:TextBox ID="txt_ind_fare" runat="server" CssClass="textboxmedium_ml" Enabled="False"
                                                                Font-Bold="True" ForeColor="Black" Width="100%" BackColor="#E6FFE6"></asp:TextBox>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                            <tr id="controw" runat="server">
                                <td style="width: 25%;" align="left" valign="middle">
                                </td>
                                <td align="center" valign="middle" colspan="2">
                                    <asp:Button ID="btn_cont" runat="server" CssClass="button2" Height="30px" Text="Print"
                                        OnClick="btn_cont_Click" OnClientClick="return checkSourceDestination();" />
                                </td>
                                <td style="width: 25%;" align="left" valign="middle">
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 25%;" align="left" valign="middle">
                                </td>
                                <td style="width: 25%;" align="left" valign="middle">
                                </td>
                                <td style="width: 25%;" align="left" valign="middle">
                                </td>
                                <td style="width: 25%;" align="left" valign="middle">
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 25%;" align="left" valign="middle">
                                </td>
                                <td style="width: 25%;" align="left" valign="middle">
                                </td>
                                <td style="width: 25%;" align="left" valign="middle">
                                </td>
                                <td style="width: 25%;" align="left" valign="middle">
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
