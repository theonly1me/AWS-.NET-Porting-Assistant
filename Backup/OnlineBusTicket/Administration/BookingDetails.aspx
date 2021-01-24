<%@ Page Title="OnLine Bus Reservation" Language="C#" MasterPageFile="~/Site.Master"
    MaintainScrollPositionOnPostback="true" AutoEventWireup="true" CodeBehind="BookingDetails.aspx.cs"
    Inherits="OnlineBusTicket.Administration.BookingDetails" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <link href="../Styles/LSCSS.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" language="javascript">
        function DisplayDateToday(sender, args) {
            if (sender._selectedDate == null) {
                sender._selectedDate = new Date();

            }
        }      

    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:UpdatePanel ID="up" runat="server">
        <ContentTemplate>
            <h2 style="height: 35">
                <asp:Label ID="lblHead" runat="server" Text="Booking Details"></asp:Label>
            </h2>
            <fieldset>
                <legend class="legend">
                    <asp:Label ID="lblLegend" runat="server" Text="Booking Details"></asp:Label>
                </legend>
                <table style="width: 100%" cellspacing="10" id="tblMain" runat="server">
                    <tr>
                        <td>
                            <asp:Label ID="lblMsg" runat="server" Text=" " Font-Bold="true" ForeColor="Red" Visible="false"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="left">
                            <table width="70%">
                                <tr>
                                    <td align="left" valign="top">
                                        <asp:Label ID="lblBookingId" runat="server" Text="Ticket No."></asp:Label>
                                        <asp:TextBox ID="txtBookingId" runat="server" CssClass="textbox_medium_ml" AutoPostBack="true"
                                            OnTextChanged="txtBookingId_TextChanged"></asp:TextBox>
                                        <asp:FilteredTextBoxExtender ID="FilteredTextBoxExtender1" runat="server" FilterType="Numbers"
                                            TargetControlID="txtBookingId">
                                        </asp:FilteredTextBoxExtender>
                                    </td>
                                    <td align="left" valign="top">
                                        <asp:Label ID="lblBookingDate" runat="server" Text="Booking Date"></asp:Label>
                                        <asp:TextBox ID="txtBookingDate" runat="server" CssClass="textbox_medium_ml" Width="80"></asp:TextBox>
                                        <asp:CalendarExtender ID="cal_dep" runat="server" TargetControlID="txtBookingDate"
                                            Format="dd MMM yy" PopupButtonID="ImageButton1" OnClientShowing="DisplayDateToday">
                                        </asp:CalendarExtender>
                                        <asp:ImageButton ID="ImageButton1" runat="server" ImageAlign="Bottom" ImageUrl="~/Images/imgCalendar.png"
                                            CausesValidation="False" />
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td align="left">
                            <asp:GridView ID="grdBookingDetails" runat="server" PageSize="15" ForeColor="Black"
                                AutoGenerateColumns="False" EmptyDataText="No records found" AllowPaging="true"
                                OnPageIndexChanging="grdBookingDetails_PageIndexChanging" DataKeyNames="Booking_Id"
                                HeaderStyle-BackColor="#3A4F63" HeaderStyle-BorderColor="Navy" HeaderStyle-ForeColor="White"
                                ShowHeaderWhenEmpty="True" Width="100%">
                                <Columns>
                                    <asp:BoundField DataField="Booking_Id" HeaderText="Ticket No." />
                                    <asp:BoundField DataField="Ticket_Type" HeaderText="Ticket Type" />
                                    <asp:BoundField DataField="Bus_No" HeaderText="Bus" />
                                    <asp:BoundField DataField="Route_Desc" HeaderText="Route" />
                                    <asp:BoundField DataField="Booking_Date" HeaderText="Bording Date" />
                                    <asp:BoundField DataField="BordingPoint" HeaderText="Bording Point" />
                                    <asp:BoundField DataField="DestinationPoint" HeaderText="Destination Point" />
                                    <asp:BoundField DataField="Mobile_Primary_Passenger" HeaderText="Mobile No." />
                                    <asp:TemplateField HeaderText="Select">
                                        <ItemTemplate>
                                            <center>
                                                <asp:RadioButton ID="rbSelector" runat="server" OnCheckedChanged="rbSelector_CheckedChanged"
                                                    AutoPostBack="true" />
                                            </center>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                            </asp:GridView>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" id="trPassenger" runat="server" visible="false">
                            <fieldset>
                                <legend class="legend">Passenger Details</legend>
                                <br />
                                <asp:GridView ID="grdPassengerDetails" runat="server" ForeColor="Black" AutoGenerateColumns="False"
                                    EmptyDataText="No records found" DataKeyNames="Passenger_ID" HeaderStyle-BackColor="#3A4F63"
                                    HeaderStyle-BorderColor="Navy" HeaderStyle-ForeColor="White" ShowHeaderWhenEmpty="True"
                                    Width="100%">
                                    <Columns>
                                        <asp:BoundField DataField="NAME" HeaderText="Name" />
                                        <asp:BoundField DataField="Gender" HeaderText="Gender" />
                                        <asp:BoundField DataField="Seat_No" HeaderText="Seat No" />
                                    </Columns>
                                </asp:GridView>
                            </fieldset>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" id="TdPayment" runat="server" visible="false">
                            <fieldset>
                                <legend class="legend">Payment Details</legend>
                                <br />
                                <asp:GridView ID="grdPaymentDetails" runat="server" ForeColor="Black" AutoGenerateColumns="False"
                                    EmptyDataText="No records found" DataKeyNames="Payment_ID" HeaderStyle-BackColor="#3A4F63"
                                    HeaderStyle-BorderColor="Navy" HeaderStyle-ForeColor="White" ShowHeaderWhenEmpty="True"
                                    Width="100%">
                                    <Columns>
                                        <asp:BoundField DataField="Payment_Mode" HeaderText="Payment Mode" />
                                        <asp:BoundField DataField="TotalAmount" HeaderText="Total Amount" />
                                        <asp:BoundField DataField="Transaction_Type" HeaderText="Transaction Type" />
                                    </Columns>
                                </asp:GridView>
                            </fieldset>
                        </td>
                    </tr>
                    <tr id="trSave" runat="server" visible="false">
                        <td>
                            <asp:Button ID="btnSave" runat="server" CausesValidation="true" CssClass="button"
                                Text="Print Tickets" Width="150" Enabled="false" OnClick="btnSave_Click" />
                        </td>
                    </tr>
                </table>
            </fieldset>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
