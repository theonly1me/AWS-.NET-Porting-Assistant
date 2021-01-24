<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="Operators.aspx.cs" Inherits="OnlineBusTicket.Masters.Operators" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <link href="../Styles/LSCSS.css" rel="stylesheet" type="text/css" />
    <script language="javascript" type="text/javascript">

        function ShowConfirm() {

            var obj = confirm("Are you sure want to delete.");
            if (obj == true) {
                return true;
            }
            else if (obj == false) {
                return false; ;
            }

        }
    
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:UpdatePanel ID="uptPnl" runat="server">
        <ContentTemplate>
            <table style="width: 100%" cellpadding="0px" cellspacing="0">
                <tr class="tr">
                    <td align="left" style="width: 30%" valign="middle" bgcolor="#336699">
                        <asp:Label ID="lbl_heading" runat="server" Text="Masters -&gt; Operators" CssClass="formheading"
                            Font-Bold="True" Font-Names="Calibri" ForeColor="White"></asp:Label>
                    </td>
                    <td align="right" colspan="4" valign="middle" bgcolor="#336699">
                        <asp:Button ID="btnAddNew" runat="server" Style="font-weight: 700" Text="Add New"
                            CssClass="button" CausesValidation="False" onclick="btnAddNew_Click" />
                        <asp:Button ID="btnSave" runat="server" CssClass="button" Text="Save" 
                            ValidationGroup="Save" onclick="btnSave_Click" />
                        <asp:Button ID="btnReset" runat="server" CssClass="button" Text="Reset" 
                            onclick="btnReset_Click" />
                        <asp:Button ID="btnCancel" runat="server" CausesValidation="False" CssClass="button"
                            Text="Cancel" onclick="btnCancel_Click" />
                    </td>
                </tr>
                <tr>
                    <td align="center" style="width: 100%;" valign="middle" colspan="5">
                        <asp:Label ID="lbl_msg" runat="server" CssClass="general" Font-Names="Calibri" ForeColor="Red"
                            Visible="False"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td align="left" colspan="5" valign="middle">
                        <asp:Panel ID="pnlrecord" runat="server">
                            <fieldset>
                                <legend class="legend">Existing Operators Information</legend>
                                <table width="100%">
                                    <tr>
                                        <td style="width: 100%;">
                                            <asp:GridView ID="grdrecord" runat="server" AllowPaging="True" DataKeyNames="Operator_ID"
                                                AutoGenerateColumns="False" CssClass="gridview" Width="100%" 
                                                onpageindexchanging="grdrecord_PageIndexChanging" 
                                                onrowcommand="grdrecord_RowCommand">
                                                <RowStyle CssClass="gridviewItemStyle" HorizontalAlign="center" />
                                                <AlternatingRowStyle CssClass="gridviewAlternatingStyle" HorizontalAlign="center" />
                                                <Columns>
                                                    <asp:TemplateField HeaderText="S.No." InsertVisible="False" ItemStyle-CssClass="gridviewColumnSNo">
                                                        <EditItemTemplate>
                                                            <asp:Label ID="lblSNo" runat="server"></asp:Label>
                                                        </EditItemTemplate>
                                                        <ItemTemplate>
                                                            <asp:Label ID="lblSNo" runat="server" Text="<%# Container.DataItemIndex + 1 %>"></asp:Label>
                                                        </ItemTemplate>
                                                        <ItemStyle CssClass="gridviewColumnSNo" />
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="Operator Name" ItemStyle-CssClass="gridviewColumnControls"
                                                        ItemStyle-Wrap="true" HeaderStyle-CssClass="gridview-header">
                                                        <ItemTemplate>
                                                            <asp:Label ID="txtgrdOperatorName" runat="server" Text='<% #Eval("Operator_Name") %>'
                                                                Enabled="false" Width="50%"></asp:Label>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="Operator Type" ItemStyle-CssClass="gridviewColumnControls"
                                                        ItemStyle-Wrap="true" HeaderStyle-CssClass="gridview-header">
                                                        <ItemTemplate>
                                                            <asp:Label ID="txtgrdOperatorType" runat="server" Text='<% #Eval("Name") %>'
                                                                Enabled="false" Width="50%"></asp:Label>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="Description" ItemStyle-CssClass="gridviewColumnControls"
                                                        ItemStyle-Wrap="true" HeaderStyle-CssClass="gridview-header">
                                                        <ItemTemplate>
                                                            <asp:Label ID="txtgrdDescription" runat="server" Text='<% #Eval("Operator_Desc") %>'
                                                                Enabled="false" Width="50%"></asp:Label>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="Edit" ItemStyle-CssClass="gridviewColumnControls"
                                                        HeaderStyle-CssClass="gridview-header">
                                                        <ItemTemplate>
                                                            <asp:LinkButton ID="lnkBtnEdit" runat="server" CommandName="GoToEdit">Edit</asp:LinkButton>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="Delete" ItemStyle-CssClass="gridviewColumnControls"
                                                        HeaderStyle-CssClass="gridview-header">
                                                        <ItemTemplate>
                                                            <asp:LinkButton ID="lnkBtnDelete" runat="server" CommandName="GoToDelete" OnClientClick=" return ShowConfirm();">Delete</asp:LinkButton>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                </Columns>
                                                <rowstyle cssclass="gridviewItemStyle_ml" horizontalalign="center" />
                                                <headerstyle cssclass="gridviewHeader_ml" horizontalalign="center" />
                                                <alternatingrowstyle cssclass="gridviewAlternatingStyle_ml" horizontalalign="center" />
                                            </asp:GridView>
                                        </td>
                                    </tr>
                                </table>
                            </fieldset>
                        </asp:Panel>
                    </td>
                </tr>
                <tr id="inputarea" runat="server" style="width: 100%">
                    <td align="left" colspan="5">
                        <fieldset>
                            <legend class="legend">Add New/Update</legend>
                            <asp:Panel ID="Pnlnew" runat="server" Width="100%">
                                <table width="100%">
                                    <tr>
                                        <td align="left" valign="top" colspan="2">
                                            [<b style="color: Red; vertical-align: text-top; font-size: large"> * </b>]&nbsp;&nbsp;
                                            <b style="color: Black; font-size: smaller; font-family: Calibri">Mandatory Field</b>
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
                                        </td>
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
                                        <td style="width: 20%" align="left">
                                            <asp:Label ID="lblOperatorname" runat="server" CssClass="labeltext_ml" Text="Operator Name"></asp:Label>
                                            <b style="color: Red; vertical-align: text-top; font-size: small">*</b>
                                        </td>
                                        <td style="width: 20%" align="left">
                                            <asp:TextBox ID="txtOperatorname" runat="server" CssClass="textboxmedium_ml"></asp:TextBox>
                                        </td>
                                        <td style="width: 20%">
                                        </td>
                                        <td style="width: 20%" align="left">
                                            <asp:Label ID="lblOperatorType" runat="server" CssClass="labeltext_ml" Text="Operator Type"></asp:Label>
                                            <b style="color: Red; vertical-align: text-top; font-size: small">*</b>
                                        </td>
                                        <td style="width: 20%" align="left">
                                            <asp:DropDownList ID="ddlOperatorType" runat="server" CssClass="ddlMedium_ml" AutoPostBack="True"
                                                CausesValidation="True">
                                            </asp:DropDownList>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="width: 20%">
                                        </td>
                                        <td style="width: 20%">
                                            <asp:RequiredFieldValidator ID="rfvOperatorName" runat="server" ControlToValidate="txtOperatorname"
                                                CssClass="valid" Display="Dynamic" ErrorMessage="Enter Operator Name" ValidationGroup="Save"></asp:RequiredFieldValidator>
                                        </td>
                                        <td style="width: 20%">
                                        </td>
                                        <td style="width: 20%">
                                        </td>
                                        <td style="width: 20%">
                                            <asp:RequiredFieldValidator ID="rfvOperatorType" runat="server" ControlToValidate="ddlOperatorType"
                                                CssClass="valid" Display="Dynamic" ErrorMessage="Select Operator Type" ValidationGroup="Save"></asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="width: 20%">
                                            <asp:Label ID="lbldescription" runat="server" CssClass="labeltext_ml" Text="Operator Description"></asp:Label>
                                        </td>
                                        <td style="width: 20%">
                                            <asp:TextBox ID="txtdescription" runat="server" CssClass="textboxmedium_ml" TextMode="MultiLine"></asp:TextBox>
                                        </td>
                                        <td style="width: 20%">
                                        </td>
                                        <td style="width: 20%">
                                        </td>
                                        <td style="width: 20%">
                                        </td>
                                    </tr>
                                    <%-- <tr>
                                        <td style="width: 20%">
                                        </td>
                                        <td style="width: 20%">
                                        </td>
                                        <td style="width: 20%">
                                        </td>
                                        <td style="width: 20%">
                                        </td>
                                        <td style="width: 20%">
                                        </td>
                                    </tr>--%>
                                </table>
                            </asp:Panel>
                        </fieldset>
                    </td>
                </tr>
            </table>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
