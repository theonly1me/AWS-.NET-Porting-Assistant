<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="Bus_Description.aspx.cs" Inherits="OnlineBusTicket.Masters.Bus_Description" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <link href="../Styles/LSCSS.css" rel="stylesheet" type="text/css" />
      <script language="javascript" type="text/javascript">
     function allownumbers(e) {
            var key = window.event ? e.keyCode : e.which;
            var keychar = String.fromCharCode(key);
            var reg = new RegExp("[0-9]")
            if (key == 8) {
                keychar = String.fromCharCode(key);
            }
            if (key == 13) {
                key = 8;
                keychar = String.fromCharCode(key);
            }
            return reg.test(keychar);
        }


        function DisableRightClick(event) {
            //For mouse right click
            if (event.button == 2) {
                alert("Right Clicking is not allowed!");
            }
        }
        function DisableCtrlKey(e) {
            var code = (document.all) ? event.keyCode : e.which;
            var message = "Ctrl key functionality is disabled!";
            // look for CTRL key press
            if (parseInt(code) == 17) {
                alert(message);
                window.event.returnValue = false;
            }
        }
               </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width: 100%">
        <tr id="trBtn" runat="server">
            <td style="width: 50%">
            </td>
            <td align="right" style="width: 50%">
                <asp:Button ID="btnAddNew" runat="server" Style="font-weight: 700" Text="Add New"
                    CssClass="button" CausesValidation="False" OnClick="btnAddNew_Click" />
                <asp:Button ID="btnSave" runat="server" CssClass="button" Text="Save" ValidationGroup="Bus"
                    OnClick="btnSave_Click" />
                <asp:Button ID="btnReset" runat="server" CssClass="button" Text="Reset" OnClick="btnReset_Click" />
                <asp:Button ID="btnCancel" runat="server" CausesValidation="False" CssClass="button"
                    Text="Cancel" OnClick="btnCancel_Click" />
            </td>
        </tr>
        <tr id="trGrid" runat="server">
            <td colspan="2">
                <fieldset>
                    <legend class="legend">Bus Detail</legend>
                    <table width="100%">
                        <tr>
                            <td style="width: 100%;">
                                <asp:GridView ID="grdBus" runat="server" AllowPaging="True" AutoGenerateColumns="False"
                                    CssClass="gridview"  DataKeyNames="Bus_ID" EmptyDataText="No BUS Details Found" OnPageIndexChanging="grdBus_PageIndexChanging"
                                    OnRowCommand="grdBus_RowCommand" PageSize="5" ShowHeaderWhenEmpty="True" Width="100%">
                                    <RowStyle CssClass="gridviewItemStyle" HorizontalAlign="center" />
                                    <AlternatingRowStyle CssClass="gridviewAlternatingStyle" HorizontalAlign="center" />
                                    <Columns>
                                        <asp:TemplateField HeaderText="S.No." InsertVisible="False" ItemStyle-CssClass="gridviewColumnSNo">
                                            <EditItemTemplate>
                                                <asp:Label ID="lblSNo" runat="server"></asp:Label>
                                            </EditItemTemplate>
                                            <ItemTemplate>
                                                <asp:Label ID="lblSNo0" runat="server" Text="<%# Container.DataItemIndex + 1 %>"></asp:Label>
                                            </ItemTemplate>
                                            <ItemStyle CssClass="gridviewColumnSNo" />
                                        </asp:TemplateField>
                                        <asp:BoundField DataField="Bus_Name" HeaderText="Bus Name" ItemStyle-CssClass="gridviewColumnText">
                                            <ItemStyle CssClass="gridviewColumnText" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="Bus_No" HeaderText="Bus No" ItemStyle-CssClass="gridviewColumnText"
                                            ItemStyle-Wrap="true">
                                            <ItemStyle CssClass="gridviewColumnText" Wrap="True" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="Operator_Name" HeaderText="Operator Name" ItemStyle-CssClass="gridviewColumnText">
                                            <ItemStyle CssClass="gridviewColumnText" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="Route_Name" HeaderText="Route Name" ItemStyle-CssClass="gridviewColumnText">
                                            <ItemStyle CssClass="gridviewColumnText" />
                                        </asp:BoundField>
                                        <%--<asp:BoundField DataField="Bus_Desc" HeaderText="Bus Desc" ItemStyle-CssClass="gridviewColumnText">
                                            <ItemStyle CssClass="gridviewColumnText" />
                                        </asp:BoundField>--%>
                                         <asp:BoundField DataField="Bus_Seater" HeaderText="Seat" ItemStyle-CssClass="gridviewColumnText">
                                            <ItemStyle CssClass="gridviewColumnText" />
                                        </asp:BoundField>
                                        <asp:TemplateField HeaderText="Volvo" ItemStyle-CssClass="gridviewColumnControls">
                                            <ItemTemplate>
                                                <asp:CheckBox ID="chckBoxVolvo" runat="server" Checked='<%#Eval("Bus_Volvo")%>' Enabled="false" />
                                            </ItemTemplate>
                                            <ItemStyle CssClass="gridviewColumnControls" />
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="AC" ItemStyle-CssClass="gridviewColumnControls">
                                            <ItemTemplate>
                                                <asp:CheckBox ID="chckBoxAC" runat="server" Checked='<%#Eval("Bus_AC")%>' Enabled="false" />
                                            </ItemTemplate>
                                            <ItemStyle CssClass="gridviewColumnControls" />
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="SL" ItemStyle-CssClass="gridviewColumnControls">
                                            <ItemTemplate>
                                                <asp:CheckBox ID="chckBoxSL" runat="server" Checked='<%#Eval("Bus_SL")%>' Enabled="false" />
                                            </ItemTemplate>
                                            <ItemStyle CssClass="gridviewColumnControls" />
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="ST" ItemStyle-CssClass="gridviewColumnControls">
                                            <ItemTemplate>
                                                <asp:CheckBox ID="chckBoxST" runat="server" Checked='<%#Eval("Bus_ST")%>' Enabled="false" />
                                            </ItemTemplate>
                                            <ItemStyle CssClass="gridviewColumnControls" />
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Edit" ItemStyle-CssClass="gridviewColumnControls">
                                            <ItemTemplate>
                                                <asp:LinkButton ID="lnkBtnEdit" runat="server" CommandArgument='<%#Eval("Bus_ID")%>'
                                                    CommandName="GoToEdit">Edit</asp:LinkButton>
                                            </ItemTemplate>
                                            <ItemStyle CssClass="gridviewColumnControls" />
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Delete" ItemStyle-CssClass="gridviewColumnControls">
                                            <ItemTemplate>
                                                <asp:LinkButton ID="lnkBtnDelete" runat="server" CommandArgument='<%#Eval("Bus_ID")%>'
                                                    CommandName="GoToDelete">Delete</asp:LinkButton>
                                            </ItemTemplate>
                                            <ItemStyle CssClass="gridviewColumnControls" />
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="" Visible="false" >
                                            <ItemTemplate>
                                                <asp:Label ID="lblOprId" runat="server" Text='<%# Bind("Bus_Operator_ID") %>' ></asp:Label>
                                                 <asp:Label ID="lblRouteId" runat="server" Text='<%# Bind("Routet_ID") %>' ></asp:Label>
                                                  <asp:Label ID="lblDesc" runat="server" Text='<%# Bind("Bus_Desc") %>' ></asp:Label>
                                                  <asp:Label ID="lblCharge" runat="server" Text='<%# Bind("Charges") %>' ></asp:Label>
                                            </ItemTemplate>
                                            <ItemStyle CssClass="gridviewColumnControls" />
                                        </asp:TemplateField>
                                    </Columns>
                                    <EditRowStyle CssClass="general" />
                                    <EmptyDataRowStyle CssClass="general" />
                                    <HeaderStyle CssClass="gridviewHeader" HorizontalAlign="center" />
                                    <RowStyle CssClass="gridviewItemStyle" HorizontalAlign="center" />
                                </asp:GridView>
                            </td>
                        </tr>
                    </table>
                </fieldset>
            </td>
        </tr>
        <tr id="trAddEdit" runat="server">
            <td colspan="2">
                <fieldset>
                    <legend class="legend">Add New/Update </legend>
                    <table style="width: 100%">
                        <tr>
                            <td style="width: 20%">
                            </td>
                            <td style="width: 20%">
                            </td>
                            <td style="width: 20%">
                            </td>
                            <td style="width: 20%">
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 20%">
                                <b style="color: Red; vertical-align: text-top; font-size: small" __designer:mapid="bc">
                                    *<asp:Label ID="lblPermitType" runat="server" Text="Operator :" 
                                    CssClass="labeltext" Width="90%"></asp:Label>
                                    *</b>
                            </td>
                            <td style="width: 20%">
                                <asp:DropDownList ID="ddlOperator" runat="server" CssClass="ddlLarge" 
                                    ValidationGroup="Bus" >
                                </asp:DropDownList>
                            </td>
                            <td style="width: 20%">
                                <b style="color: Red; vertical-align: text-top; font-size: small" __designer:mapid="bc">
                                    <asp:Label ID="lblPermitType0" runat="server" Text="Bus Route :" 
                                    CssClass="labeltext"></asp:Label>
                                    </b>
                            </td>
                            <td style="width: 20%">
                                <asp:DropDownList ID="ddlBusRoute" runat="server" CssClass="ddlLarge" 
                                    ValidationGroup="Bus" >
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 20%">
                                &nbsp;</td>
                            <td style="width: 20%">
                                            <asp:RequiredFieldValidator ID="rfvBusOpr" runat="server" ControlToValidate="ddlOperator"
                                                CssClass="valid" Display="Dynamic" ErrorMessage="Select Bus Operator" 
                                                ValidationGroup="Bus" InitialValue="Select Operator"></asp:RequiredFieldValidator>
                            </td>
                            <td style="width: 20%">
                                &nbsp;</td>
                            <td style="width: 20%">
                                            <asp:RequiredFieldValidator ID="rfvBusRoute" runat="server" ControlToValidate="ddlBusRoute"
                                                CssClass="valid" Display="Dynamic" ErrorMessage="Select Bus Route" 
                                                ValidationGroup="Bus" InitialValue="Select Route"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 20%">
                                <b style="color: Red; vertical-align: text-top; font-size: small" __designer:mapid="bc">
                                    <asp:Label ID="lblBusName" runat="server" Text="Bus Name :" CssClass="labeltext"></asp:Label>
                                    *</b>
                            </td>
                            <td style="width: 20%">
                                <asp:TextBox ID="txtBusName" runat="server" CssClass="textboxmedium_ml" 
                                    ValidationGroup="Bus"></asp:TextBox>
                            </td>
                            <td style="width: 20%">
                                <b style="color: Red; vertical-align: text-top; font-size: small" __designer:mapid="bc">
                                    <asp:Label ID="lblBusName0" runat="server" Text="Bus No :" CssClass="labeltext"></asp:Label>
                                    *</b>
                            </td>
                            <td style="width: 20%">
                                <asp:TextBox ID="txtBusNo" runat="server" CssClass="textboxmedium_ml" 
                                    ValidationGroup="Bus"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 20%">
                                &nbsp;</td>
                            <td style="width: 20%">
                                            <asp:RequiredFieldValidator ID="rfvBusName" runat="server" ControlToValidate="txtBusName"
                                                CssClass="valid" Display="Dynamic" ErrorMessage="Enter Bus Name" 
                                                ValidationGroup="Bus"></asp:RequiredFieldValidator>
                            </td>
                            <td style="width: 20%">
                                &nbsp;</td>
                            <td style="width: 20%">
                                            <asp:RequiredFieldValidator ID="rfvBusNo" runat="server" ControlToValidate="txtBusNo"
                                                CssClass="valid" Display="Dynamic" ErrorMessage="Enter Bus No" 
                                                ValidationGroup="Bus"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 20%">
                                <b style="color: Red; vertical-align: text-top; font-size: small" __designer:mapid="bc">
                                    <asp:Label ID="lblSeats" runat="server" Text="Total Seats :" 
                                    CssClass="labeltext"></asp:Label>
                                    *</b>
                            </td>
                            <td style="width: 20%">
                                <asp:DropDownList ID="ddlNoOfSeats" runat="server" CssClass="ddlMedium" 
                                    ValidationGroup="Bus">
                                </asp:DropDownList>
                            </td>
                            <td style="width: 20%">
                                <b style="color: Red; vertical-align: text-top; font-size: small" __designer:mapid="bc">
                                    <asp:Label ID="lblClassification" runat="server" Text="Classification :" CssClass="labeltext"></asp:Label>
                                    *
                                </b>
                            </td>
                            <td style="width: 20%">
                                <asp:CheckBox ID="chckVolvo" runat="server" Text="Volvo" />
                                <asp:CheckBox ID="chckAC" runat="server" Text="AC" />
                                <asp:CheckBox ID="chckSL" runat="server" Text="SL" />
                                <asp:CheckBox ID="chckST" runat="server" Text="ST" />
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 20%">
                                &nbsp;</td>
                            <td style="width: 20%">
                                            <asp:RequiredFieldValidator ID="rfvNoOfSeats" runat="server" ControlToValidate="ddlNoOfSeats"
                                                CssClass="valid" Display="Dynamic" ErrorMessage="Select No Of Seats" 
                                                ValidationGroup="Bus" InitialValue="0"></asp:RequiredFieldValidator>
                            </td>
                            <td style="width: 20%">
                                &nbsp;</td>
                            <td style="width: 20%">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td style="width: 20%">
                                <b style="color: Red; vertical-align: text-top; font-size: small" __designer:mapid="bc">
                                    <asp:Label ID="lblPSOMnthlyLimit1" runat="server" CssClass="labeltext" Text="Description"></asp:Label>
                                </b>
                            </td>
                            <td>
                                <asp:TextBox ID="txtDescription" runat="server" CssClass="textboxmedium" TextMode="MultiLine"></asp:TextBox>
                            </td>
                            <td style="width: 20%">
                                <b style="color: Red; vertical-align: text-top; font-size: small" __designer:mapid="bc">
                                    <asp:Label ID="lblBusName1" runat="server" Text="Fare Per KM :" 
                                    CssClass="labeltext"></asp:Label>
                                    </b>
                            </td>
                            <td style="width: 20%">
                                <asp:TextBox ID="txtChargPerKm" runat="server" CssClass="textboxmedium_ml" 
                                    ValidationGroup="Bus"  onKeyDown="return DisableCtrlKey(event)" 
                                    onMouseDown="DisableRightClick(event)" MaxLength="5"
                                 ></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 20%">
                            </td>
                            <td style="width: 20%">
                            </td>
                            <td style="width: 20%">
                            </td>
                            <td style="width: 20%">
                                            <asp:RequiredFieldValidator ID="rfvBusNo0" runat="server" ControlToValidate="txtChargPerKm"
                                                CssClass="valid" Display="Dynamic" ErrorMessage="Enter Fare" 
                                                ValidationGroup="Bus"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 20%">
                                &nbsp;</td>
                            <td style="font-size: small; color: #FF0000;" colspan="3">
                                *10% of Total Seats are automatically alloted to Agents</td>
                        </tr>
                    </table>
                </fieldset>
            </td>
        </tr>
    </table>
</asp:Content>
