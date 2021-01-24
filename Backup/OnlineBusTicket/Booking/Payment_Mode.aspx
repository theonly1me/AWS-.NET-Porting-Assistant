<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="Payment_Mode.aspx.cs" Inherits="OnlineBusTicket.Booking.Payment_Mode" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <link href="../Styles/HRCSS.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .mainHeadSelected
        {
            background-color: #59b1e8;
            width: auto;
            border-bottom: 1px solid #fff;
            font: bold 12px arial;
            color: #fff;
            padding: 4px 0 4px 8px;
            cursor: pointer;
        }
        
        .Accordationnavi
        {
            width: auto;
        }
        .change
        {
            background-color: #deebf7;
        }
        .mainHead
        {
            width: auto;
            border-bottom: 1px solid #fff;
            font: bold 12px arial;
            color: #fff;
            background-color: #2781ba;
            padding: 4px 0 4px 8px;
            cursor: pointer;
        }
        .headingbl
        {
            width: auto;
            border-bottom: 1px solid #fff;
            font: bold 10px arial;
            color: #2781ba;
            padding: 4px 0 4px 8px;
            cursor: pointer;
        }
        
        .tabs
        {
            height: 46px;
            width: auto;
        }
        .cont
        {
            font: bold 14px arial;
            text-align: left;
            padding-left: 5px;
            color: #666666;
            border-bottom: 1px solid #CCCCCC;
            height: 44px;
        }
        .footerborder
        {
            border-top: 1px solid #CECFCE;
            width: 100%;
            margin-right: 5px;
            margin-left: 0px;
        }
        #footerlogo ul
        {
            margin: 0;
            padding: 0;
        }
        #footerlogo ul li
        {
            margin: 0;
            padding: 0;
            float: left;
            display: inline;
        }
        .footerlink
        {
            float: right;
            width: 37%;
            border: 0px solid #000;
            margin-top: 5px;
            font: 11px arial;
            color: #666;
            text-align: center;
            padding: 9px 0 0 0;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:UpdatePanel ID="updParent" runat="server">
        <ContentTemplate>
            <cc1:TabContainer ID="TabConPaymentMode" runat="server" ActiveTabIndex="0" 
                Width="99%">
                <cc1:TabPanel ID="creCrd" runat="server">
                    <HeaderTemplate>Credit Cards</HeaderTemplate>
                    <ContentTemplate>
                        <table style="width: 100%">
                            <tr style="width: 100%">
                                <td style="width: 100%">
                                    <table align="center" border="0" cellpadding="0" cellspacing="0" style="border-bottom: 0px;
                                        border-left: #ccc 1px solid; border-top: #ccc 1px solid; border-right: #ccc 1px solid">
                                        <tr>
                                            <td>
                                                <table align="center" border="0" cellpadding="0" cellspacing="0" style="font: bold 13px calibri"
                                                    width="90%">
                                                    <tr>
                                                        <td style="text-align: left; padding-bottom: 3px; padding-left: 6px; padding-right: 6px;
                                                            color: #fe830b; padding-top: 3px">
                                                            Note: If for any reason, the reservation output details are not displayed on your
                                                            screen after you have made payments, please check the details in &quot;Booked Tickets&quot;
                                                            under &quot;Booking History&quot; in left navigation bar. You may also check your
                                                            mail for the details of your booking.
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td style="text-align: left; padding-bottom: 3px; padding-left: 6px; padding-right: 6px;
                                                            color: #fe830b; padding-top: 3px">
                                                            <div id="deb">
                                                                All VISA/MASTER debit cards (If enabled by card issuer) can also be used for ticket
                                                                booking through any of the VISA/MASTER credit card payment gateways (ICICI PG, HDFC
                                                                PG, AXIS PG, CITI PG). <a href="#?BV_SessionID=@@@@1685528140.1328177340@@@@&amp;BV_EngineID=ccceadfflefejmecefecehidfgmdfkn.0"
                                                                    onclick="window.open('/banklist.html','help','width=500,height=600,scrollbars=yes');return false;">Click Here</a> For List of Banks
                                                            </div>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td style="text-align: left; padding-bottom: 3px; padding-left: 6px; padding-right: 6px;
                                                            color: #fe830b; padding-top: 3px">
                                                            <a href="#?BV_SessionID=@@@@1685528140.1328177340@@@@&amp;BV_EngineID=ccceadfflefejmecefecehidfgmdfkn.0"
                                                                onclick="window.open('/payment.html','help','width=500,height=800,scrollbars=yes');return false;">Click Here</a> For Bank Transaction Charges
                                                        </td>
                                                    </tr>
                                                </table>
                                                <fieldset>
                                                    <table id="bnkArea" align="center" border="0" cellpadding="0" cellspacing="0" runat="server"
                                                        width="100%"><tr id="Tr1" runat="server"><td id="Td1" class="cont" width="33%" runat="server">
                                                                <asp:RadioButton ID="rbICICI" runat="server" AutoPostBack="True" class="headingbl"
                                                                    OnCheckedChanged="rbICICI_CheckedChanged" Font-Size="X-Small" />



                                                                <strong><span class="headingbl">Visa/Master
                                                                <span class="desctext">(By ICICI Bank) </span></span>
                                                                </strong>
                                                            </td>
<td id="Td2" class="cont" width="33%" runat="server">
                                                                <asp:RadioButton 
        ID="rbHDFC" runat="server" AutoPostBack="True" class="headingbl"
                                                                    
        OnCheckedChanged="rbHDFC_CheckedChanged" Font-Size="X-Small" />



                                                                <strong><span class="headingbl">Visa/Master
                                                                <span class="desctext">(By HDFC Bank)</span> </span>
                                                                </strong>
                                                            </td>
</tr>
<tr id="Tr2" runat="server"><td id="Td3" runat="server">
                                                            </td>
</tr>
<tr id="Tr3" runat="server"><td id="Td4" class="cont" width="33%" runat="server">
                                                                <asp:RadioButton 
        ID="rbAXIS" runat="server" AutoPostBack="True" class="headingbl"
                                                                    
        OnCheckedChanged="rbAXIS_CheckedChanged" Font-Size="X-Small" />



                                                                <strong><span class="headingbl">Visa/Master
                                                                <span class="desctext">(By AXIS Bank) </span></span>
                                                                </strong>
                                                            </td>
<td id="Td5" class="cont" width="33%" runat="server">
                                                                <asp:RadioButton 
        ID="rbCITI" runat="server" AutoPostBack="True" class="headingbl"
                                                                    
        OnCheckedChanged="rbCITI_CheckedChanged" Font-Size="X-Small" />



                                                                <strong><span class="headingbl">Visa/Master
                                                                <span class="desctext">(By CITI Bank) </span>
                                                                <span class="imgil"></span></span></strong>
                                                            </td>
</tr>
<tr id="Tr4" runat="server"><td id="Td6" runat="server">
                                                            </td>
</tr>
<tr id="Tr5" runat="server"><td id="Td7" class="cont" width="33%" runat="server">
                                                                <asp:RadioButton 
        ID="rbAmcnExp" runat="server" AutoPostBack="True" class="headingbl"
                                                                    
        OnCheckedChanged="rbAmcnExp_CheckedChanged" Font-Size="X-Small" />



                                                                <strong><span class="headingbl">American
                                                                        Express </span></strong>
                                                            </td>
<td id="Td8" class="cont" runat="server">
                                                                &nbsp;
                                                            </td>
</tr>
</table>



                                                </fieldset> &nbsp;
                                                <table id="5" align="center" border="0" cellpadding="0" cellspacing="0" style="display: none"
                                                    width="100%">
                                                    <tr>
                                                        <td class="cont" width="33%">
                                                            <input name="gatewayIDV" onclick="setBank(3,0,1)" type="radio" value="6" /><strong><span
                                                                class="headingbl">ICICI Bank <a href=""></a></span></strong>
                                                        </td>
                                                        <td class="cont" width="33%">
                                                            <input name="gatewayIDV" onclick="setBank(2,0,1)" type="radio" value="7" /><strong><span
                                                                class="headingbl">HDFC Bank <a href=""></a></span></strong>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td class="cont" width="33%">
                                                            <input name="gatewayIDV" onclick="setBank(10,0,1)" type="radio" value="8" /><strong><span
                                                                class="headingbl">AXIS Bank <a href=""></a>
                                                            <br /></span></strong>
                                                        </td>
                                                        <td class="cont" width="33%">
                                                            <input name="gatewayIDV" onclick="setBank(4,0,1)" type="radio" value="9" /><strong><span
                                                                class="headingbl">IDBI Bank <a href=""></a></span></strong>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td class="cont" width="33%">
                                                            <input name="gatewayIDV" onclick="setBank(11,0,1)" type="radio" value="10" /><strong><span
                                                                class="headingbl">SBI - Internet Banking <a href=""></a></span></strong>
                                                        </td>
                                                        <td class="cont" width="33%">
                                                            <input name="gatewayIDV" onclick="setBank(12,0,1)" type="radio" value="11" /><strong><span
                                                                class="headingbl">Punjab National Bank <a href=""></a></span></strong>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td class="cont" width="33%">
                                                            <input name="gatewayIDV" onclick="setBank(16,0,1)" type="radio" value="12" /><strong><span
                                                                class="headingbl">Federal Bank <a href=""></a></span></strong>
                                                        </td>
                                                        <td class="cont" width="33%">
                                                            <input name="gatewayIDV" onclick="setBank(18,0,1)" type="radio" value="13" /><strong><span
                                                                class="headingbl">Syndicate Bank <a href=""></a></span></strong>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td class="cont" width="33%">
                                                            <input name="gatewayIDV" onclick="setBank(23,0,1)" type="radio" value="14" /><strong><span
                                                                class="headingbl">Indusind Bank <a href=""></a></span></strong>
                                                        </td>
                                                        <td class="cont" width="33%">
                                                            <input name="gatewayIDV" onclick="setBank(28,0,1)" type="radio" value="15" /><strong><span
                                                                class="headingbl">Karnataka Bank <a href=""></a></span></strong>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td class="cont" width="33%">
                                                            <input name="gatewayIDV" onclick="setBank(30,0,1)" type="radio" value="16" /><strong><span
                                                                class="headingbl">Andhra Bank <a href=""></a></span></strong>
                                                        </td>
                                                        <td class="cont" width="33%">
                                                            <input name="gatewayIDV" onclick="setBank(8,0,1)" type="radio" value="17" /><strong><span
                                                                class="headingbl">Oriental Bank Of Commerce
                                                            <a href=""></a></span></strong>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td class="cont" width="33%">
                                                            <input name="gatewayIDV" onclick="setBank(15,0,1)" type="radio" value="18" /><strong><span
                                                                class="headingbl">Corporation Bank <a href=""></a></span></strong>
                                                        </td>
                                                        <td class="cont" width="33%">
                                                            <input name="gatewayIDV" onclick="setBank(34,0,1)" type="radio" value="19" /><strong><span
                                                                class="headingbl">Bank Of India <a href=""></a></span></strong>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td class="cont" width="33%">
                                                            <input name="gatewayIDV" onclick="setBank(45,0,1)" type="radio" value="20" /><strong><span
                                                                class="headingbl">Indian Bank<a href=""></a></span></strong>
                                                        </td>
                                                        <td class="cont" width="33%">
                                                            <input name="gatewayIDV" onclick="setBank(42,0,1)" type="radio" value="21" /><strong><span
                                                                class="headingbl">SBI Associate Bank&#39;s <a href=""></a></span></strong>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td class="cont" width="33%">
                                                            <input name="gatewayIDV" onclick="setBank(19,0,1)" type="radio" value="22" /><strong><span
                                                                class="headingbl">Union Bank Of India <a href=""></a></span></strong>
                                                        </td>
                                                        <td class="cont" width="33%">
                                                            <input name="gatewayIDV" onclick="setBank(48,0,1)" type="radio" value="23" /><span
                                                                class="headingbl"><strong>Bank of Baroda<a href=""></a></strong><a href=""> </a></span>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                        </td>
                                                    </tr>
                                                </table>
                                                <table id="3" border="0" cellpadding="0" cellspacing="0" style="display: none" width="100%">
                                                    <tr>
                                                        <td class="cont" width="33%">
                                                            <input name="gatewayIDV" onclick="setBank(20,0,1)" type="radio" value="24" /><strong><span
                                                                class="headingbl">ICICI Bank EMI
                                                            <span class="desctext">(For ICICI Credit Cards only)
                                                            </span><span class="imgil"></span><a href=""></a></span></strong>
                                                        </td>
                                                        <td class="cont" width="33%">
                                                            <input name="gatewayIDV" onclick="setBank(17,0,0)" type="radio" value="25" /><strong><span
                                                                class="headingbl">CITI Bank EMI
                                                            <span class="desctext">(For CITI Credit Cards only)
                                                            </span><span class="imgil"></span><a href=""></a></span></strong>
                                                        </td>
                                                    </tr>
                                                </table>
                                                <table id="2" border="0" cellpadding="0" cellspacing="0" style="display: none" width="100%">
                                                    <tr>
                                                        <td class="cont" width="33%">
                                                            <input name="gatewayIDV" onclick="setBank(12,0,1)" type="radio" value="28" /><strong><span
                                                                class="headingbl">Punjab National Bank <a href=""></a></span></strong>
                                                        </td>
                                                        <td class="cont" width="33%">
                                                            <input name="gatewayIDV" onclick="setBank(30,0,1)" type="radio" value="29" /><strong><span
                                                                class="headingbl">Andhra Bank <a href=""></a></span></strong>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td class="cont" width="33%">
                                                            <input name="gatewayIDV" onclick="setBank(7,0,1)" type="radio" value="26" /><strong><span
                                                                class="headingbl">CITI Bank <a href=""></a></span></strong>
                                                        </td>
                                                        <td class="cont" width="33%">
                                                            <input name="gatewayIDV" onclick="setBank(25,0,1)" type="radio" value="27" /><strong><span
                                                                class="headingbl">SBI ATM-cum-Debit Card <a href=""></a></span></strong>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td class="cont" width="33%">
                                                            <input name="gatewayIDV" onclick="setBank(19,0,1)" type="radio" value="32" /><strong><span
                                                                class="headingbl">Union Bank Of India <a href=""></a></span></strong>
                                                        </td>
                                                        <td class="cont" width="33%">
                                                            <input name="gatewayIDV" onclick="setBank(44,0,1)" type="radio" value="33" /><strong><span
                                                                class="headingbl">Canara Bank <a href=""></a></span></strong>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td class="cont" width="33%">
                                                            <input name="gatewayIDV" onclick="setBank(34,0,1)" type="radio" value="30" /><strong><span
                                                                class="headingbl">Bank Of India <a href=""></a></span></strong>
                                                        </td>
                                                        <td class="cont" width="33%">
                                                            <input name="gatewayIDV" onclick="setBank(45,0,1)" type="radio" value="31" /><strong><span
                                                                class="headingbl">Indian Bank<a href=""></a></span></strong>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan="2" style="text-align: left; padding-bottom: 3px; padding-left: 6px;
                                                            padding-right: 6px; font: bold 12px calibri; color: #ff0000; padding-top: 3px">
                                                            If you have any Visa/Master Debit card not listed above,any of the below Visa/Master
                                                            Payment Gateways can be used for ticketbooking (If enabled by card issuer).<a href="#?BV_SessionID=@@@@1685528140.1328177340@@@@&amp;BV_EngineID=ccceadfflefejmecefecehidfgmdfkn.0"
                                                                onclick="window.open('/banklist.html','help','width=500,height=600,scrollbars=yes');return false;">Click
                                                                Here</a> For List of Banks
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td style="text-align: left; padding-bottom: 3px; padding-left: 6px; padding-right: 6px;
                                                            font: bold 13px calibri; color: #fe830b; padding-top: 3px">
                                                            PAYMENT GATEWAYS
                                                        </td>
                                                        <td>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td class="cont" width="33%">
                                                            <input name="gatewayIDV" onclick="setBank(0,0,1)" type="radio" value="34" /><strong><span
                                                                class="headingbl">Visa/Master <span class="desctext">(Powered by ICICI Bank) </span><a href=""></a></span></strong>
                                                        </td>
                                                        <td class="cont" width="33%">
                                                            <input name="gatewayIDV" onclick="setBank(39,0,0)" type="radio" value="35" /><strong><span
                                                                class="headingbl">Visa/Master <span class="desctext">(Powered by HDFC Bank)</span> <a href=""></a></span></strong>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td class="cont" width="33%">
                                                            <input name="gatewayIDV" onclick="setBank(54,0,0)" type="radio" value="36" /><strong><span
                                                                class="headingbl">Visa/Master <span class="desctext">(Powered by AXIS Bank) </span><a href=""></a></span></strong>
                                                        </td>
                                                        <td class="cont" width="33%">
                                                            <input name="gatewayIDV" onclick="setBank(1,0,1)" type="radio" value="37" /><strong><span
                                                                class="headingbl">Visa/Master <span class="desctext">(Powered by CITI Bank) </span><span class="imgil"></span><a href=""></a></span>
                                                            </strong>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                        </td>
                                                    </tr>
                                                    <!-- Prashant changes for PG options in Debit Card Tab starts -->
                                                </table>
                                                <table id="4" border="0" cellpadding="0" cellspacing="0" style="display: none" width="100%">
                                                    <tr>
                                                        <!--rajiv jha added oosrds start-->
                                                        <!--rajiv jha added oosrds end-->
                                                        <!--rajiv jha added oosrds start-->
                                                        <!--rajiv jha added oosrds end-->
                                                        <!--rajiv jha added oosrds start-->
                                                        <!--rajiv jha added oosrds end-->
                                                        <!--rajiv jha added oosrds start-->
                                                        <!--rajiv jha added oosrds end-->
                                                        <!--rajiv jha added oosrds start-->
                                                        <!--rajiv jha added oosrds end-->
                                                        <!--rajiv jha added oosrds start-->
                                                        <!--rajiv jha added oosrds end-->
                                                        <!--rajiv jha added oosrds start-->
                                                        <!--rajiv jha added oosrds end-->
                                                        <!--rajiv jha added oosrds start-->
                                                        <!--rajiv jha added oosrds end-->
                                                        <!--rajiv jha added oosrds start-->
                                                        <!--rajiv jha added oosrds end-->
                                                        <!--rajiv jha added oosrds start-->
                                                        <!--rajiv jha added oosrds end-->
                                                        <!--rajiv jha added oosrds start-->
                                                        <!--rajiv jha added oosrds end-->
                                                        <!--rajiv jha added oosrds start-->
                                                        <!--rajiv jha added oosrds end-->
                                                        <!--rajiv jha added oosrds start-->
                                                        <td class="cont" width="33%">
                                                            <input name="gatewayIDV" onclick="setBank(9,0,1)" type="radio" value="38" /><strong><span
                                                                class="headingbl">ITZ Cash Card <a href=""></a></span></strong>
                                                        </td>
                                                        <!--rajiv jha added oosrds end-->
                                                        <td class="cont" width="33%">
                                                            <strong class="headingbl">
                                                            <input name="gatewayIDV" onclick="setBank(31,0,1)" type="radio" value="39" /><span
                                                                    class="headingbl">Done Cash Card <a href="" o></a></span></strong>
                                                        </td>
                                                        <!--rajiv jha added oosrds start-->
                                                    </tr>
                                                    <tr>
                                                        <td class="cont" width="33%">
                                                            <strong class="headingbl">
                                                            <input name="gatewayIDV" onclick="setBank(24,0,1)" type="radio" value="40" /><span
                                                                    class="headingbl">I Cash Card <a href=""></a></span></strong>
                                                        </td>
                                                        <!--rajiv jha added oosrds start-->
                                                        <!--rajiv jha added oosrds end-->
                                                        <!--rajiv jha added oosrds start-->
                                                        <!--rajiv jha added oosrds end-->
                                                        <!--rajiv jha added oosrds start-->
                                                        <!--rajiv jha added oosrds end-->
                                                        <!--rajiv jha added oosrds start-->
                                                        <!--rajiv jha added oosrds end-->
                                                        <td class="cont" width="33%">
                                                            <strong class="headingbl">
                                                            <input name="gatewayIDV" onclick="setBank(51,0,1)" type="radio" value="41" /><span
                                                                    class="headingbl">Oxi Cash <a href=""></a></span></strong>
                                                        </td>
                                                        <!--rajiv jha added oosrds start-->
                                                    </tr>
                                                    <tr>
                                                        <!--rajiv jha added oosrds start-->
                                                    </tr>
                                                </table>
                                                <!-- Prashant added oosrds start-->
                                            </td>
                                        </tr>
                                    </table>
                                    <!-- Ajay Changes Start for BTBPO -->
                                    <!-- Ajay Changes Start for BTBPO -->
                                    <script language="JavaScript">

function setBank(gatewayID,payMode,pgType)
{
	//alert(&quot;111&quot;);
    document.BookTicketForm.paymentMode.value=payMode;
    // alert(&quot;22&quot;);
    document.BookTicketForm.pgType.value=pgType;
   //alert(&quot;33&quot;+pgType);
    document.BookTicketForm.gatewayID.value=gatewayID;
  // alert(&quot;44&quot;+document.BookTicketForm.gatewayID.value);
    document.BookTicketForm.buyTicket.value=&quot;0&quot;;
   // alert(&quot;55&quot;);
    document.BookTicketForm.screen.value=&quot;paymnt&quot;;
  //  alert(&quot;66&quot;);
    if(document.BookTicketForm.TatkalOpt.value==&quot;Y&quot;)
	{
		document.BookTicketForm.TatkalOpt.value=&quot;Y&quot;;
		document.BookTicketForm.CKFARE.value=&quot;CKFARE&quot;;

	}

    document.BookTicketForm.submitClicks.value=parseInt(document.BookTicketForm.submitClicks.value)+1;


   document.BookTicketForm.submit();
    return true;

}

function openWin(url,name,w,h)
{
	 var att = &quot;width=&quot;+ w +&quot;,height=&quot;+ h +&quot;left=0,top=100,toolbar=yes,menubar=yes,scrollbars=yes,status=no,resizable=yes,location=yes&quot;
	 window.open(url,&#39;&#39;,att)
	 return false;
}

function displayBankSoft(idType)
{
    for(var i=6;i&lt;=7;i++)
    {if(idType==i){
        document.getElementById(&quot;tab&quot;+i).style.display=&#39;&#39;;
        }else {
            document.getElementById(&quot;tab&quot;+i).style.display=&#39;none&#39;;
        }
    }
}

function displayBank(idType)
{
    for(var i=1;i&lt;=5;i++)
    {
        if(idType==i)
        {
        document.getElementById(i).style.display=&#39;&#39;;
		//Prashant changes for PG options in Debit Card Tab starts
		if(idType==2)
		{
		document.getElementById(&quot;deb&quot;).style.display =&#39;none&#39;;
		}
		else
			{
			document.getElementById(&quot;deb&quot;).style.display =&#39;&#39;;
		}
		//Prashant changes for PG options in Debit Card Tab ends
        if(document.getElementById(&quot;tab&quot;+i)!=null){
           document.getElementById(&quot;tab&quot;+i).style.backgroundImage=&quot;url(/beta_images/payment-back-or.jpg)&quot;;
		   document.getElementById(&quot;tab&quot;+i).style.backgroundRepeat=&quot;repeat-x&quot;;
          }
        }else {
            document.getElementById(i).style.display=&#39;none&#39;;
          if(document.getElementById(&quot;tab&quot;+i)!=null){
           document.getElementById(&quot;tab&quot;+i).style.backgroundImage=&quot;url(/beta_images/payment-back-st.jpg)&quot;;
		   document.getElementById(&quot;tab&quot;+i).style.backgroundRepeat=&quot;repeat-x&quot;;
          }
        }
    }
}
                                    </script>
                                </td>
                            </tr>
                        </table>
                    
</ContentTemplate>
                </cc1:TabPanel>
                <cc1:TabPanel ID="NetBnk" runat="server"  Visible="false">
                     <HeaderTemplate>Net Banking</HeaderTemplate>
                      <ContentTemplate>
                        <table style="width:100%">
                            <tr style="width:100%">
                                <td style="width:100%">
                                    <input name="BV_SessionID" type="hidden" 
                                    value="@@@@1685528140.1328177340@@@@" />
                                    <input name="BV_EngineID" type="hidden" 
                                    value="ccceadfflefejmecefecehidfgmdfkn.0" />
                                    <input name="deliveryMode" type="hidden" value="1" />
                                    <input name="submitClicks" type="hidden" value="4" />
                                    <input name="CurrentMonth" type="hidden" value="1" />
                                    <input name="CurrentDate" type="hidden" value="2" />
                                    <input name="CurrentYear" type="hidden" value="2012" />
                                    <input name="pgType" type="hidden" />
                                    <input name="paymentMode" type="hidden" />
                                    <input name="gatewayID" type="hidden" />
                                    <input name="screen" type="hidden" />
                                    <input name="CKFARE" type="hidden" />
                                    <input name="TatkalOpt" type="hidden" />
                                    <input name="hiddenSubmit" type="hidden" 
                                    value="validate" />
                                    <input name="buyTicket" type="hidden" />
                                    <input name="Submit" type="hidden" />
                                    <link 
                                   
                                    rel="stylesheet" type="text/css" />
                                    <table align="center" border="0" cellpadding="0" cellspacing="0" width="80%">
                                        <tr>
                                            <td bgcolor="#ffffff" height="400" valign="top">
                                                <table border="0" width="100%">
                                                    <tr>
                                                        <td valign="top" width="74%">
                                                            <table align="right" border="0" width="99%">
                                                                <tr>
                                                                    <td>
                                                                        <style type="text/css">


body{margin:0; padding:0;}
#main{border:1px solid #ccc; border-bottom:0px solid #ccc; text-align:center;}
.tabs{height:46px; width:auto;}
.tabsSoft{height:46px; width:auto;}
.tabsSoft a{padding:14px 100px; border-left:1px solid #ccc; font:bold 13px arial; color:#666666; display:inline; float:left; 
text-decoration:none;
    }
.tabs a{padding:14px 24px; border-left:1px solid #ccc; font:bold 13px arial; color:#666666; display:inline; float:left; 
text-decoration:none;
    }
.tabs a:focus{-moz-outline-style: none; border:0px;}
.tabs a:active{outline: none;}


.tabsGR{
    }
.tabsOR{
    }
/* For IE Versions - tabs a:hover{background:url(/beta_images/payment-back-or.jpg) repeat-x;}*/
.tabs a:active{
    }
/* For Other Browser*/
.tabs a:focus{
    }
.cont{font:bold 14px arial; text-align:left; padding-left:5px; color:#666666; border-bottom:1px solid #CCCCCC; height:44px;}
.tabcont{border:1px solid #FE9F0F; border-top:0px; background-color:#FBDCAE; text-align:left; font:12px arial; padding:2px;}
</style>
                                                                        <TEMP:INSERT template="/common/displayError.jsp" />
                                                                        <!-- Prashant added oosrds start-->
                                                                        <table align="center" border="0" cellpadding="0" cellspacing="0" 
                                                                        style="BORDER-BOTTOM: 0px; BORDER-LEFT: #ccc 1px solid; BORDER-TOP: #ccc 1px solid; BORDER-RIGHT: #ccc 1px solid">
                                                                            <tr>
                                                                                <td>
                                                                                    <table align="center" border="0" cellpadding="0" cellspacing="0" 
                                                                                    style="FONT: bold 13px calibri" width="90%">
                                                                                        <tr>
                                                                                            <td style="TEXT-ALIGN: left; PADDING-BOTTOM: 3px; PADDING-LEFT: 6px; PADDING-RIGHT: 6px; COLOR: #fe830b; PADDING-TOP: 3px">
                                                                                                Note: If for any reason, the reservation output details are not displayed on your screen after you have made payments, please check the details in &quot;Booked Tickets&quot; under &quot;Booking History&quot; in left navigation bar. You may also check your mail for the details of your booking.
                                                                                            </td>
                                                                                        </tr>
                                                                                        <tr>
                                                                                            <td style="TEXT-ALIGN: left; PADDING-BOTTOM: 3px; PADDING-LEFT: 6px; PADDING-RIGHT: 6px; COLOR: #fe830b; PADDING-TOP: 3px">
                                                                                                <div ID="deb0">
                                                                                                    All VISA/MASTER debit cards (If enabled by card issuer) can also be used for ticket booking through any of the VISA/MASTER credit card payment gateways (ICICI PG, HDFC PG, AXIS PG, CITI PG). <a href="#?BV_SessionID=@@@@1685528140.1328177340@@@@&amp;BV_EngineID=ccceadfflefejmecefecehidfgmdfkn.0" 
                                                                                                    onclick="window.open('/banklist.html','help','width=500,height=600,scrollbars=yes');return false;">Click Here</a> For List of Banks
                                                                                                </div>
                                                                                            </td>
                                                                                        </tr>
                                                                                        <tr>
                                                                                            <td style="TEXT-ALIGN: left; PADDING-BOTTOM: 3px; PADDING-LEFT: 6px; PADDING-RIGHT: 6px; COLOR: #fe830b; PADDING-TOP: 3px">
                                                                                                <a href="#?BV_SessionID=@@@@1685528140.1328177340@@@@&amp;BV_EngineID=ccceadfflefejmecefecehidfgmdfkn.0" 
                                                                                                onclick="window.open('/payment.html','help','width=500,height=800,scrollbars=yes');return false;">Click Here</a> For Bank Transaction Charges
                                                                                            </td>
                                                                                        </tr>
                                                                                    </table>
                                                                                    <table ID="10" align="center" border="0" cellpadding="0" cellspacing="0" 
                                                                                    style="DISPLAY: none" width="100%">
                                                                                        <tr>
                                                                                            <td class="cont" width="33%">
                                                                                                <input checked="checked" name="gatewayIDV" onclick="setBank(0,0,1)" 
                                                                                                    type="radio" value="1" /><strong><span class="headingbl">Visa/Master <span 
                                                                                                    class="desctext">(Powered by ICICI Bank)
                                                                                                </span>
                                                                                                <a href=""></a></span></strong>
                                                                                            </td>
                                                                                            <td class="cont" width="33%">
                                                                                                <input name="gatewayIDV" onclick="setBank(39,0,0)" type="radio" value="2" /><strong><span 
                                                                                                    class="headingbl">Visa/Master <span class="desctext">(Powered by HDFC Bank)</span>
                                                                                                <a href=""></a></span></strong>
                                                                                            </td>
                                                                                        </tr>
                                                                                        <tr>
                                                                                            <td>
                                                                                            </td>
                                                                                        </tr>
                                                                                        <tr>
                                                                                            <td class="cont" width="33%">
                                                                                                <input name="gatewayIDV" onclick="setBank(54,0,0)" type="radio" value="3" /><strong><span 
                                                                                                    class="headingbl">Visa/Master
                                                                                                <span class="desctext">(Powered by AXIS Bank) </span>
                                                                                                <a href=""></a></span></strong>
                                                                                            </td>
                                                                                            <td class="cont" width="33%">
                                                                                                <input name="gatewayIDV" onclick="setBank(1,0,1)" type="radio" value="4" /><strong><span 
                                                                                                    class="headingbl">Visa/Master <span class="desctext">(Powered by CITI Bank)
                                                                                                </span>
                                                                                                <span class="imgil"></span>
                                                                                                <a href=""></a></span></strong>
                                                                                            </td>
                                                                                        </tr>
                                                                                        <tr>
                                                                                            <td>
                                                                                            </td>
                                                                                        </tr>
                                                                                        <tr>
                                                                                            <td 
                                                    class="cont" width="33%">
                                                                                                <input name="gatewayIDV" onclick="setBank(13,0,0)" type="radio" value="5" /><strong><span 
                                                                                                    class="headingbl">American Express
                                                                                                <a href=""></a></span></strong>
                                                                                            </td>
                                                                                            <td class="cont">
                                                                                                &nbsp;</td>
                                                                                        </tr>
                                                                                    </table>
                                                                                    <table ID="BnkAreaB" runat="server" align="center" border="0" cellpadding="0" cellspacing="0" 
                                                                                    width="100%"><tr id="Tr6" runat="server"><td id="Td9" 
                                                        runat="server" class="cont" width="33%">
                                                                                                <asp:RadioButton ID="rbICICIB" 
                                                        runat="server" AutoPostBack="True" class="headingbl" 
                                                        oncheckedchanged="rbICICIB_CheckedChanged" Font-Size="X-Small" />









                                                                                                &nbsp;<strong><span 
                                                        class="headingbl">ICICI Bank </span></strong>
                                                                                            </td>
<td id="Td10" 
                                                        runat="server" class="cont" width="33%">
                                                                                                <asp:RadioButton ID="rbHDFCB" 
                                                            runat="server" 
        AutoPostBack="True" class="headingbl" 
                                                            
        oncheckedchanged="rbHDFCB_CheckedChanged" Font-Size="X-Small" />









                                                                                                &nbsp;<strong><span 
                                                            class="headingbl">HDFC Bank </span></strong>
                                                                                            </td>
</tr>
<tr id="Tr7" runat="server"><td id="Td11" 
                                                        runat="server">
                                                                                            </td>
</tr>
<tr id="Tr8" runat="server"><td id="Td12" runat="server" class="cont" 
                                                        width="33%">
                                                                                                <asp:RadioButton 
        ID="rbAXISB" runat="server" 
                                                        AutoPostBack="True" class="headingbl" 
                                                        
        oncheckedchanged="rbAXISB_CheckedChanged" Font-Size="X-Small" />









                                                                                                &nbsp;<strong><span 
                                                        class="headingbl">AXIS Bank&nbsp;
                                                                                                <br /></span></strong>
                                                                                            </td>
<td id="Td13" 
                                                        runat="server" class="cont" width="33%">
                                                                                                <asp:RadioButton ID="rbIDBIB" 
                                                            runat="server" 
        AutoPostBack="True" class="headingbl" 
                                                            
        oncheckedchanged="rbIDBIB_CheckedChanged" Font-Size="X-Small" />









                                                                                                &nbsp;<strong><span 
                                                            class="headingbl">IDBI Bank </span></strong>
                                                                                            </td>
</tr>
<tr id="Tr9" runat="server"><td id="Td14" runat="server">
                                                                                            </td>
</tr>
<tr id="Tr10" runat="server"><td id="Td15" 
                                                    runat="server" class="cont" width="33%">
                                                                                                <asp:RadioButton ID="rbSBIB" 
                                                    runat="server" 
        AutoPostBack="True" class="headingbl" 
                                                    
        oncheckedchanged="rbSBIB_CheckedChanged" Font-Size="X-Small" />









                                                                                                &nbsp;<strong><span class="headingbl">SBI - Internet Banking </span></strong>
                                                                                            </td>
<td id="Td16" 
                                                    runat="server" class="cont" width="33%">
                                                                                                <asp:RadioButton ID="rbPNBB" 
                                                        runat="server" 
        AutoPostBack="True" class="headingbl" 
                                                        
        oncheckedchanged="rbPNBB_CheckedChanged" Font-Size="X-Small" />









                                                                                                &nbsp;<strong><span class="headingbl">Punjab National Bank </span></strong>
                                                                                            </td>
</tr>
<tr id="Tr11" runat="server"><td id="Td17" 
                                                        runat="server">
                                                                                            </td>
</tr>
<tr id="Tr12" runat="server"><td id="Td18" runat="server" class="cont" 
                                                        width="33%">
                                                                                                <asp:RadioButton 
        ID="rbFBB" runat="server" AutoPostBack="True" 
                                                        class="headingbl" 
        oncheckedchanged="rbFBB_CheckedChanged" Font-Size="X-Small" />









                                                                                                &nbsp;<strong><span 
                                                        class="headingbl">Federal Bank </span></strong>
                                                                                            </td>
<td id="Td19" 
                                                        runat="server" class="cont" width="33%">
                                                                                                <asp:RadioButton ID="rbSBB" 
                                                            runat="server" 
        AutoPostBack="True" class="headingbl" 
                                                            
        oncheckedchanged="rbSBB_CheckedChanged" Font-Size="X-Small" />









                                                                                                &nbsp;<strong><span class="headingbl">Syndicate Bank </span></strong>
                                                                                            </td>
</tr>
<tr id="Tr13" runat="server"><td id="Td20" runat="server">
                                                                                            </td>
</tr>
<tr id="Tr14" runat="server"><td id="Td21" class="cont" width="33%" runat="server">
                                                                                                <asp:RadioButton 
        ID="rbIBB" runat="server" 
        AutoPostBack="True" 
                                                                                                
        class="headingbl" oncheckedchanged="rbIBB_CheckedChanged" Font-Size="X-Small" />









                                                                                                &nbsp;<strong><span class="headingbl">Indusind Bank </span></strong>
                                                                                            </td>
<td id="Td22" class="cont" width="33%" runat="server">
                                                                                                <asp:RadioButton 
        ID="rbKBB" runat="server" 
        AutoPostBack="True" 
                                                                                                
        class="headingbl" oncheckedchanged="rbKBB_CheckedChanged" Font-Size="X-Small" />









                                                                                                &nbsp;<strong><span class="headingbl">Karnataka Bank </span></strong>
                                                                                            </td>
</tr>
<tr id="Tr15" runat="server"><td id="Td24" 
                                                        runat="server">
                                                                                            </td>
</tr>
<tr id="Tr16" runat="server"><td id="Td25" class="cont" width="33%" runat="server">
                                                                                                <asp:RadioButton 
        ID="rbABB" runat="server" 
        AutoPostBack="True" 
                                                                                                
        class="headingbl" oncheckedchanged="rbABB_CheckedChanged" Font-Size="X-Small" />









                                                                                                &nbsp;<strong><span class="headingbl">Andhra Bank </span></strong>
                                                                                            </td>
<td id="Td26" class="cont" width="33%" runat="server">
                                                                                                <asp:RadioButton 
        ID="rbOBCB" runat="server" 
        AutoPostBack="True" 
                                                                                                
        class="headingbl" oncheckedchanged="rbOBCB_CheckedChanged" 
        Font-Size="X-Small" />









                                                                                                &nbsp;<strong><span class="headingbl">Oriental Bank Of Commerce </span></strong>
                                                                                            </td>
</tr>
<tr id="Tr17" runat="server"><td id="Td27" runat="server">
                                                                                            </td>
</tr>
<tr id="Tr18" runat="server"><td id="Td28" class="cont" width="33%" runat="server">
                                                                                                <asp:RadioButton 
        ID="rbCBB" runat="server" 
        AutoPostBack="True" 
                                                                                                
        class="headingbl" oncheckedchanged="rbCBB_CheckedChanged" Font-Size="X-Small" />









                                                                                                &nbsp;<strong><span class="headingbl">Corporation Bank </span></strong>
                                                                                            </td>
<td id="Td29" class="cont" width="33%" runat="server">
                                                                                                <asp:RadioButton 
        ID="rbBIB" runat="server" 
        AutoPostBack="True" 
                                                                                                
        class="headingbl" oncheckedchanged="rbBIB_CheckedChanged" Font-Size="X-Small" />









                                                                                                &nbsp;<strong><span class="headingbl">Bank Of India </span></strong>
                                                                                            </td>
</tr>
<tr id="Tr19" runat="server"><td id="Td30" 
                                                        runat="server">
                                                                                            </td>
</tr>
<tr id="Tr20" runat="server"><td id="Td31" class="cont" width="33%" runat="server">
                                                                                                <asp:RadioButton 
        ID="rbIBBI" runat="server" 
        AutoPostBack="True" 
                                                                                                
        class="headingbl" oncheckedchanged="rbIBBI_CheckedChanged" 
        Font-Size="X-Small" />









                                                                                                &nbsp;<strong><span class="headingbl">Indian Bank</span></strong>
                                                                                            </td>
<td id="Td32" class="cont" width="33%" runat="server">
                                                                                                <asp:RadioButton 
        ID="rbSBIABB" runat="server" 
        AutoPostBack="True" 
                                                                                                
        class="headingbl" oncheckedchanged="rbSBIABB_CheckedChanged" 
        Font-Size="X-Small" />









                                                                                                &nbsp;<strong><span class="headingbl">SBI Associate Bank&#39;s </span></strong>
                                                                                            </td>
</tr>
<tr id="Tr21" runat="server"><td id="Td33" runat="server">
                                                                                            </td>
</tr>
<tr id="Tr22" runat="server"><td id="Td34" class="cont" width="33%" runat="server">
                                                                                                <asp:RadioButton 
        ID="rbUBIBB" runat="server" 
        AutoPostBack="True" 
                                                                                                
        class="headingbl" oncheckedchanged="rbUBIBB_CheckedChanged" 
        Font-Size="X-Small" />









                                                                                                &nbsp;<strong><span class="headingbl">Union Bank Of India </span></strong>
                                                                                            </td>
<td id="Td35" class="cont" width="33%" runat="server">
                                                                                                <asp:RadioButton 
        ID="rbBOBB" runat="server" 
        AutoPostBack="True" 
                                                                                                
        class="headingbl" oncheckedchanged="rbBOBB_CheckedChanged" 
        Font-Size="X-Small" />









                                                                                                &nbsp;<span class="headingbl"><strong>Bank of Baroda</strong><a href="" 
                                                                                                > </a></span>
                                                                                            </td>
</tr>
</table>









                                                                                    <table ID="30" border="0" cellpadding="0" cellspacing="0" style="DISPLAY: none" 
                                                                                    width="100%">
                                                                                        <tr>
                                                                                            <td class="cont" width="33%">
                                                                                                <input name="gatewayIDV" onclick="setBank(20,0,1)" 
                                                                                                type="radio" value="24" /><strong><span class="headingbl">ICICI Bank EMI
                                                                                                <span class="desctext">(For ICICI Credit Cards only)
                                                                                                </span><span class="imgil"></span>
                                                                                                <a href="" 
                                                                                                ></a></span></strong>
                                                                                            </td>
                                                                                            <td class="cont" width="33%">
                                                                                                <input name="gatewayIDV" onclick="setBank(17,0,0)" 
                                                                                                type="radio" value="25" /><strong><span class="headingbl">CITI Bank EMI
                                                                                                <span class="desctext">(For CITI Credit Cards only)
                                                                                                </span><span class="imgil"></span>
                                                                                                <a href="" 
                                                                                                ></a></span></strong>
                                                                                            </td>
                                                                                        </tr>
                                                                                    </table>
                                                                                    <table ID="20" border="0" cellpadding="0" cellspacing="0" style="DISPLAY: none" 
                                                                                    width="100%">
                                                                                        <tr>
                                                                                            <td class="cont" width="33%">
                                                                                                <input name="gatewayIDV" onclick="setBank(7,0,1)" type="radio" value="26" /><strong><span 
                                                                                                    class="headingbl">CITI Bank
                                                                                                <a href=""></a></span></strong>
                                                                                            </td>
                                                                                            <td class="cont" width="33%">
                                                                                                <input name="gatewayIDV" onclick="setBank(25,0,1)" type="radio" value="27" /><strong><span 
                                                                                                    class="headingbl">SBI ATM-cum-Debit Card
                                                                                                <a href=""></a></span></strong>
                                                                                            </td>
                                                                                        </tr>
                                                                                        <tr>
                                                                                            <td class="cont" width="33%">
                                                                                                <input name="gatewayIDV" onclick="setBank(12,0,1)" type="radio" value="28" /><strong><span 
                                                                                                    class="headingbl">Punjab National Bank
                                                                                                <a href=""></a></span></strong>
                                                                                            </td>
                                                                                            <td class="cont" width="33%">
                                                                                                <input name="gatewayIDV" onclick="setBank(30,0,1)" type="radio" value="29" /><strong><span 
                                                                                                    class="headingbl">Andhra Bank
                                                                                                <a href=""></a></span></strong>
                                                                                            </td>
                                                                                        </tr>
                                                                                        <tr>
                                                                                            <td class="cont" width="33%">
                                                                                                <input name="gatewayIDV" onclick="setBank(34,0,1)" type="radio" value="30" /><strong><span 
                                                                                                    class="headingbl">Bank Of India
                                                                                                <a href=""></a></span></strong>
                                                                                            </td>
                                                                                            <td class="cont" width="33%">
                                                                                                <input name="gatewayIDV" onclick="setBank(45,0,1)" type="radio" value="31" /><strong><span 
                                                                                                    class="headingbl">Indian Bank<a href=""></a></span></strong>
                                                                                            </td>
                                                                                        </tr>
                                                                                        <tr>
                                                                                            <td 
                                                    class="cont" width="33%">
                                                                                                <input name="gatewayIDV" onclick="setBank(19,0,1)" 
                                                                                                type="radio" value="32" /><strong><span 
                                                    class="headingbl">Union Bank Of India
                                                                                                <a 
                                                    href=""></span></strong>
                                                                                            </td>
                                                                                            <td 
                                                    class="cont" width="33%">
                                                                                                <input name="gatewayIDV" onclick="setBank(44,0,1)" 
                                                                                                type="radio" value="33" /><strong><span 
                                                        class="headingbl">Canara Bank
                                                                                                <a href="" 
                                                        ></a></span></strong>
                                                                                            </td>
                                                                                        </tr>
                                                                                        <!-- Prashant changes for PG options in Debit Card Tab starts -->
                                                                                        <tr>
                                                                                            <td colspan="2" 
                                                                                                style="TEXT-ALIGN: left; PADDING-BOTTOM: 3px; PADDING-LEFT: 6px; PADDING-RIGHT: 6px; FONT: bold 12px calibri; COLOR: #ff0000; PADDING-TOP: 3px">
                                                                                                If you have any Visa/Master Debit card not listed above,any of the below Visa/Master Payment Gateways can be used for ticketbooking (If enabled by card issuer).<a 
                                                                                                    href="#?BV_SessionID=@@@@1685528140.1328177340@@@@&amp;BV_EngineID=ccceadfflefejmecefecehidfgmdfkn.0" 
                                                                                                    onclick="window.open('/banklist.html','help','width=500,height=600,scrollbars=yes');return false;">Click Here</a> For List of Banks
                                                                                            </td>
                                                                                        </tr>
                                                                                        <tr>
                                                                                            <td 
                                                                                                style="TEXT-ALIGN: left; PADDING-BOTTOM: 3px; PADDING-LEFT: 6px; PADDING-RIGHT: 6px; FONT: bold 13px calibri; COLOR: #fe830b; PADDING-TOP: 3px">
                                                                                                PAYMENT GATEWAYS
                                                                                            </td>
                                                                                            <td>
                                                                                            </td>
                                                                                        </tr>
                                                                                        <tr>
                                                                                            <td class="cont" width="33%">
                                                                                                <input name="gatewayIDV" onclick="setBank(0,0,1)" 
                                                                                                type="radio" value="34" /><strong><span class="headingbl">Visa/Master <span class="desctext">(Powered by ICICI Bank) </span>
                                                                                                <a href="" 
                                                                                                ></a></span></strong>
                                                                                            </td>
                                                                                            <td class="cont" width="33%">
                                                                                                <input name="gatewayIDV" onclick="setBank(39,0,0)" 
                                                                                                type="radio" value="35" /><strong><span class="headingbl">Visa/Master <span class="desctext">(Powered by HDFC Bank)</span>
                                                                                                <a href="" 
                                                                                                ></a></span></strong>
                                                                                            </td>
                                                                                        </tr>
                                                                                        <tr>
                                                                                            <td>
                                                                                            </td>
                                                                                        </tr>
                                                                                        <tr>
                                                                                            <td class="cont" width="33%">
                                                                                                <input name="gatewayIDV" onclick="setBank(54,0,0)" type="radio" value="36" /><strong><span 
                                                                                                    class="headingbl">Visa/Master <span class="desctext">(Powered by AXIS Bank)
                                                                                                </span>
                                                                                                <a </a="" href=""></a></span></strong>
                                                                                            </td>
                                                                                            <td class="cont" width="33%">
                                                                                                <input name="gatewayIDV" onclick="setBank(1,0,1)" type="radio" value="37" /><strong><span 
                                                                                                    class="headingbl">Visa/Master <span class="desctext">(Powered by CITI Bank)
                                                                                                </span>
                                                                                                <span class="imgil"></span>
                                                                                                <a href=""></a></span></strong>
                                                                                            </td>
                                                                                        </tr>
                                                                                        <tr>
                                                                                            <td>
                                                                                            </td>
                                                                                        </tr>
                                                                                        <!-- Prashant changes for PG options in Debit Card Tab ends -->
                                                                                    </table>
                                                                                    <table ID="40" border="0" cellpadding="0" cellspacing="0" style="DISPLAY: none" 
                                                                                    width="100%">
                                                                                        <tr>
                                                                                            <!--rajiv jha added oosrds start--><!--rajiv jha added oosrds end--><!--rajiv jha added oosrds start--><!--rajiv jha added oosrds end--><!--rajiv jha added oosrds start--><!--rajiv jha added oosrds end--><!--rajiv jha added oosrds start--><!--rajiv jha added oosrds end--><!--rajiv jha added oosrds start--><!--rajiv jha added oosrds end--><!--rajiv jha added oosrds start--><!--rajiv jha added oosrds end--><!--rajiv jha added oosrds start--><!--rajiv jha added oosrds end--><!--rajiv jha added oosrds start--><!--rajiv jha added oosrds end--><!--rajiv jha added oosrds start--><!--rajiv jha added oosrds end--><!--rajiv jha added oosrds start--><!--rajiv jha added oosrds end--><!--rajiv jha added oosrds start--><!--rajiv jha added oosrds end--><!--rajiv jha added oosrds start--><!--rajiv jha added oosrds end--><!--rajiv jha added oosrds start--><!--rajiv jha added oosrds end--><!--rajiv jha added oosrds start--><!--rajiv jha added oosrds end--><!--rajiv jha added oosrds start--><!--rajiv jha added oosrds end--><!--rajiv jha added oosrds start--><!--rajiv jha added oosrds end--><!--rajiv jha added oosrds start--><!--rajiv jha added oosrds end--><!--rajiv jha added oosrds start--><!--rajiv jha added oosrds end--><!--rajiv jha added oosrds start--><!--rajiv jha added oosrds end--><!--rajiv jha added oosrds start--><!--rajiv jha added oosrds end--><!--rajiv jha added oosrds start--><!--rajiv jha added oosrds end--><!--rajiv jha added oosrds start--><!--rajiv jha added oosrds end--><!--rajiv jha added oosrds start--><!--rajiv jha added oosrds end--><!--rajiv jha added oosrds start--><!--rajiv jha added oosrds end--><!--rajiv jha added oosrds start--><!--rajiv jha added oosrds end-->
                                                                                            <td class="cont" width="33%">
                                                                                                <input name="gatewayIDV" onclick="setBank(9,0,1)" type="radio" value="38" /><strong><span class="headingbl">ITZ Cash Card
                                                                                                <a href="" 
                                                                                               ></a></span></strong>
                                                                                            </td>
                                                                                            <!--rajiv jha added oosrds start--><!--rajiv jha added oosrds end-->
                                                                                            <td class="cont" width="33%">
                                                                                                <strong class="headingbl">
                                                                                                <input name="gatewayIDV" onclick="setBank(31,0,1)" 
                                                                                                type="radio" value="39" /><span class="headingbl">Done Cash Card
                                                                                                <a href="" 
                                                                                                ></a></span></strong>
                                                                                            </td>
                                                                                            <!--rajiv jha added oosrds start--><!--rajiv jha added oosrds end-->
                                                                                        </tr>
                                                                                        <tr>
                                                                                            <td class="cont" width="33%">
                                                                                                <strong class="headingbl">
                                                                                                <input name="gatewayIDV" onclick="setBank(24,0,1)" type="radio" value="40" /><span 
                                                                                                    class="headingbl">I Cash Card
                                                                                                <a href=""></a></span></strong>
                                                                                            </td>
                                                                                            <!--rajiv jha added oosrds start--><!--rajiv jha added oosrds end--><!--rajiv jha added oosrds start--><!--rajiv jha added oosrds end--><!--rajiv jha added oosrds start--><!--rajiv jha added oosrds end--><!--rajiv jha added oosrds start--><!--rajiv jha added oosrds end--><!--rajiv jha added oosrds start--><!--rajiv jha added oosrds end--><!--rajiv jha added oosrds start--><!--rajiv jha added oosrds end--><!--rajiv jha added oosrds start--><!--rajiv jha added oosrds end--><!--rajiv jha added oosrds start--><!--rajiv jha added oosrds end-->
                                                                                            <td class="cont" width="33%">
                                                                                                <strong class="headingbl">
                                                                                                <input name="gatewayIDV" onclick="setBank(51,0,1)" type="radio" value="41" /><span 
                                                                                                    class="headingbl">Oxi Cash
                                                                                                <a href=""></a></span></strong>
                                                                                            </td>
                                                                                            <!--rajiv jha added oosrds start--><!--rajiv jha added oosrds end-->
                                                                                        </tr>
                                                                                        <tr>
                                                                                            <!--rajiv jha added oosrds start--><!--rajiv jha added oosrds end-->
                                                                                        </tr>
                                                                                    </table>
                                                                                </td>
                                                                            </tr>
                                                                        </table>
                                                                        <!-- Prashant added oosrds ends--><!-- Ajay Changes Start for BTBPO --><!-- Ajay Changes Start for BTBPO --><script language="JavaScript">

function setBank(gatewayID,payMode,pgType)
{
	//alert(&quot;111&quot;);
    document.BookTicketForm.paymentMode.value=payMode;
    // alert(&quot;22&quot;);
    document.BookTicketForm.pgType.value=pgType;
   //alert(&quot;33&quot;+pgType);
    document.BookTicketForm.gatewayID.value=gatewayID;
  // alert(&quot;44&quot;+document.BookTicketForm.gatewayID.value);
    document.BookTicketForm.buyTicket.value=&quot;0&quot;;
   // alert(&quot;55&quot;);
    document.BookTicketForm.screen.value=&quot;paymnt&quot;;
  //  alert(&quot;66&quot;);
    if(document.BookTicketForm.TatkalOpt.value==&quot;Y&quot;)
	{
		document.BookTicketForm.TatkalOpt.value=&quot;Y&quot;;
		document.BookTicketForm.CKFARE.value=&quot;CKFARE&quot;;

	}

    document.BookTicketForm.submitClicks.value=parseInt(document.BookTicketForm.submitClicks.value)+1;


   document.BookTicketForm.submit();
    return true;

}

function openWin(url,name,w,h)
{
	 var att = &quot;width=&quot;+ w +&quot;,height=&quot;+ h +&quot;left=0,top=100,toolbar=yes,menubar=yes,scrollbars=yes,status=no,resizable=yes,location=yes&quot;
	 window.open(url,&#39;&#39;,att)
	 return false;
}

function displayBankSoft(idType)
{
    for(var i=6;i&lt;=7;i++)
    {if(idType==i){
        document.getElementById(&quot;tab&quot;+i).style.display=&#39;&#39;;
        }else {
            document.getElementById(&quot;tab&quot;+i).style.display=&#39;none&#39;;
        }
    }
}

function displayBank(idType)
{
    for(var i=1;i&lt;=5;i++)
    {
        if(idType==i)
        {
        document.getElementById(i).style.display=&#39;&#39;;
		//Prashant changes for PG options in Debit Card Tab starts
		if(idType==2)
		{
		document.getElementById(&quot;deb&quot;).style.display =&#39;none&#39;;
		}
		else
			{
			document.getElementById(&quot;deb&quot;).style.display =&#39;&#39;;
		}
		//Prashant changes for PG options in Debit Card Tab ends
        if(document.getElementById(&quot;tab&quot;+i)!=null){
           document.getElementById(&quot;tab&quot;+i).style.backgroundImage=&quot;url(/beta_images/payment-back-or.jpg)&quot;;
		   document.getElementById(&quot;tab&quot;+i).style.backgroundRepeat=&quot;repeat-x&quot;;
          }
        }else {
            document.getElementById(i).style.display=&#39;none&#39;;
          if(document.getElementById(&quot;tab&quot;+i)!=null){
           document.getElementById(&quot;tab&quot;+i).style.backgroundImage=&quot;url(/beta_images/payment-back-st.jpg)&quot;;
		   document.getElementById(&quot;tab&quot;+i).style.backgroundRepeat=&quot;repeat-x&quot;;
          }
        }
    }
}
</script>
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </td>
                                        </tr>
                                    </table>
                                    <script language="JavaScript">	
         document.getElementById(&quot;testdiv&quot;).style.display = &#39;none&#39;;
        function test()
        {

            alert(&quot;aaaaa&quot;);
            window.history.forward(1);
            alert(&quot;qqqqq&quot;);
        }

            function setFocus()
			{					  	
				
					//Renu /09-12-05 Passenger list modification for accrual starts
     		  
		
					
			//renu added and commented for class validation on 24-Jul-06 starts
			}

        </script>
                                </td>
                            </tr>
                        </table>
                    
</ContentTemplate>
                 </cc1:TabPanel>
                <cc1:TabPanel ID="DebtCrd" runat="server"  Visible="False">
                    <HeaderTemplate> Debit Cards</HeaderTemplate>
                      <ContentTemplate>
                        <table style="width: 100%">
                            <tr style="width: 100%">
                                <td style="width: 100%">
                                    <input name="BV_SessionID" type="hidden" value="@@@@1685528140.1328177340@@@@" /><input
                                        name="BV_EngineID" type="hidden" value="ccceadfflefejmecefecehidfgmdfkn.0" /><input
                                            name="deliveryMode" type="hidden" value="1" /><input name="submitClicks" type="hidden"
                                                value="4" /><input name="CurrentMonth" type="hidden" value="1" /><input name="CurrentDate"
                                                    type="hidden" value="2" /><input name="CurrentYear" type="hidden" value="2012" /><input
                                                        name="pgType" type="hidden" /><input name="paymentMode" type="hidden" /><input name="gatewayID"
                                                            type="hidden" /><input name="screen" type="hidden" /><input name="CKFARE" type="hidden" /><input
                                                                name="TatkalOpt" type="hidden" /><input name="hiddenSubmit" type="hidden" value="validate" /><input
                                                                    name="buyTicket" type="hidden" /><input name="Submit" type="hidden" /><link rel="stylesheet"
                                                                        type="text/css" /><table align="center" border="0" cellpadding="0" cellspacing="0"
                                                                            width="80%">
                                                                            <tr>
                                                                                <td bgcolor="#ffffff" height="400" valign="top">
                                                                                    <table border="0" width="100%">
                                                                                        <tr>
                                                                                            <td valign="top" width="74%">
                                                                                                <table align="right" border="0" width="99%">
                                                                                                    <tr>
                                                                                                        <td>
                                                                                                            <style type="text/css">


body{margin:0; padding:0;}
#main{border:1px solid #ccc; border-bottom:0px solid #ccc; text-align:center;}
.tabs{height:46px; width:auto;}
.tabsSoft{height:46px; width:auto;}
.tabsSoft a{padding:14px 100px; border-left:1px solid #ccc; font:bold 13px arial; color:#666666; display:inline; float:left; 
text-decoration:none;
    }
.tabs a{padding:14px 24px; border-left:1px solid #ccc; font:bold 13px arial; color:#666666; display:inline; float:left;
text-decoration:none;
    }
.tabs a:focus{-moz-outline-style: none; border:0px;}
.tabs a:active{outline: none;}


.tabsGR{
    }
.tabsOR{
    }
/* For IE Versions - tabs a:hover{background:url(/beta_images/payment-back-or.jpg) repeat-x;}*/
.tabs a:active{
/* For Other Browser*/
.tabs a:focus{
    }
.cont{font:bold 14px arial; text-align:left; padding-left:5px; color:#666666; border-bottom:1px solid #CCCCCC; height:44px;}
.tabcont{border:1px solid #FE9F0F; border-top:0px; background-color:#FBDCAE; text-align:left; font:12px arial; padding:2px;}
</style>
                                                                                                            <temp:insert template="/common/displayError.jsp" />
                                                                                                            <!-- Prashant added oosrds start-->
                                                                                                            <table align="center" border="0" cellpadding="0" cellspacing="0">
                                                                                                                <tr>
                                                                                                                    <td>
                                                                                                                        <table align="center" border="0" cellpadding="0" cellspacing="0" width="90%">
                                                                                                                            <tr>
                                                                                                                                <td style="text-align: left; padding-bottom: 3px; padding-left: 6px; padding-right: 6px;
                                                                                                                                    color: #fe830b; padding-top: 3px">
                                                                                                                                    Note: If for any reason, the reservation output details are not displayed on your
                                                                                                                                    screen after you have made payments, please check the details in &quot;Booked Tickets&quot;
                                                                                                                                    under &quot;Booking History&quot; in left navigation bar. You may also check your
                                                                                                                                    mail for the details of your booking.
                                                                                                                                </td>
                                                                                                                            </tr>
                                                                                                                            <tr>
                                                                                                                                <td style="text-align: left; padding-bottom: 3px; padding-left: 6px; padding-right: 6px;
                                                                                                                                    color: #fe830b; padding-top: 3px">
                                                                                                                                    <a href="#?BV_SessionID=@@@@1685528140.1328177340@@@@&amp;BV_EngineID=ccceadfflefejmecefecehidfgmdfkn.0"
                                                                                                                                        onclick="window.open('/payment.html','help','width=500,height=800,scrollbars=yes');return false;">
                                                                                                                                        Click Here</a> For Bank Transaction Charges
                                                                                                                                </td>
                                                                                                                            </tr>
                                                                                                                        </table>
                                                                                                                        <table id="21" border="0" cellpadding="0" cellspacing="0" width="100%">
                                                                                                                            <tr>
                                                                                                                                <td class="cont" width="33%">
                                                                                                                                    <input name="gatewayIDV" onclick="setBank(7,0,1)" type="radio" value="26" /><strong><span
                                                                                                                                        class="headingbl">CITI Bank </span></strong>
                                                                                                                                </td>
                                                                                                                                <td class="cont" width="33%">
                                                                                                                                    <input name="gatewayIDV" onclick="setBank(25,0,1)" type="radio" value="27" /><strong><span
                                                                                                                                        class="headingbl">SBI ATM-cum-Debit Card </span></strong>
                                                                                                                                </td>
                                                                                                                            </tr>
                                                                                                                            <tr>
                                                                                                                                <td class="cont" width="33%">
                                                                                                                                    <input name="gatewayIDV" onclick="setBank(12,0,1)" type="radio" value="28" /><strong><span
                                                                                                                                        class="headingbl">Punjab National Bank </span></strong>
                                                                                                                                </td>
                                                                                                                                <td class="cont" width="33%">
                                                                                                                                    <input name="gatewayIDV" onclick="setBank(30,0,1)" type="radio" value="29" /><strong><span
                                                                                                                                        class="headingbl">Andhra Bank </span></strong>
                                                                                                                                </td>
                                                                                                                            </tr>
                                                                                                                            <tr>
                                                                                                                                <td class="cont" width="33%">
                                                                                                                                    <input name="gatewayIDV" onclick="setBank(34,0,1)" type="radio" value="30" /><strong><span
                                                                                                                                        class="headingbl">Bank Of India </span></strong>
                                                                                                                                </td>
                                                                                                                                <td class="cont" width="33%">
                                                                                                                                    <input name="gatewayIDV" onclick="setBank(45,0,1)" type="radio" value="31" /><strong><span
                                                                                                                                        class="headingbl">Indian Bank</span></strong>
                                                                                                                                </td>
                                                                                                                            </tr>
                                                                                                                            <tr>
                                                                                                                                <td class="cont" width="33%">
                                                                                                                                    <input name="gatewayIDV" onclick="setBank(19,0,1)" type="radio" value="32" /><strong><span
                                                                                                                                        class="headingbl">Union Bank Of India </span></strong>
                                                                                                                                </td>
                                                                                                                                <td class="cont" width="33%">
                                                                                                                                    <input name="gatewayIDV" onclick="setBank(44,0,1)" type="radio" value="33" /><strong><span
                                                                                                                                        class="headingbl">Canara Bank </span></strong>
                                                                                                                                </td>
                                                                                                                            </tr>
                                                                                                                            <!-- Prashant changes for PG options in Debit Card Tab starts -->
                                                                                                                            <tr>
                                                                                                                                <td colspan="2" style="text-align: left; padding-bottom: 3px; padding-left: 6px;
                                                                                                                                    padding-right: 6px; font: bold 12px calibri; color: #ff0000; padding-top: 3px">
                                                                                                                                    If you have any Visa/Master Debit card not listed above,any of the below Visa/Master
                                                                                                                                    Payment Gateways can be used for ticketbooking (If enabled by card issuer).<a href="#?BV_SessionID=@@@@1685528140.1328177340@@@@&amp;BV_EngineID=ccceadfflefejmecefecehidfgmdfkn.0"
                                                                                                                                        onclick="window.open('/banklist.html','help','width=500,height=600,scrollbars=yes');return false;">Click
                                                                                                                                        Here</a> For List of Banks
                                                                                                                                </td>
                                                                                                                            </tr>
                                                                                                                            <tr>
                                                                                                                                <td style="text-align: left; padding-bottom: 3px; padding-left: 6px; padding-right: 6px;
                                                                                                                                    font: bold 13px calibri; color: #fe830b; padding-top: 3px">
                                                                                                                                    PAYMENT GATEWAYS
                                                                                                                                </td>
                                                                                                                                <td>
                                                                                                                                </td>
                                                                                                                            </tr>
                                                                                                                            <tr>
                                                                                                                                <td class="cont" width="33%">
                                                                                                                                    <input name="gatewayIDV" onclick="setBank(0,0,1)" type="radio" value="34" /><strong><span
                                                                                                                                        class="headingbl">Visa/Master <span class="desctext">(Powered by ICICI Bank) </span>
                                                                                                                                    </span></strong>
                                                                                                                                </td>
                                                                                                                                <td class="cont" width="33%">
                                                                                                                                    <input name="gatewayIDV" onclick="setBank(39,0,0)" type="radio" value="35" /><strong><span
                                                                                                                                        class="headingbl">Visa/Master <span class="desctext">(Powered by HDFC Bank)</span>
                                                                                                                                    </span></strong>
                                                                                                                                </td>
                                                                                                                            </tr>
                                                                                                                            <tr>
                                                                                                                                <td>
                                                                                                                                </td>
                                                                                                                            </tr>
                                                                                                                            <tr>
                                                                                                                                <td class="cont" width="33%">
                                                                                                                                    <input name="gatewayIDV" onclick="setBank(54,0,0)" type="radio" value="36" /><strong><span
                                                                                                                                        class="headingbl">Visa/Master <span class="desctext">(Powered by AXIS Bank) </span>
                                                                                                                                    </span></strong>
                                                                                                                                </td>
                                                                                                                                <td class="cont" width="33%">
                                                                                                                                    <input name="gatewayIDV" onclick="setBank(1,0,1)" type="radio" value="37" /><strong><span
                                                                                                                                        class="headingbl">Visa/Master <span class="desctext">(Powered by CITI Bank) </span>
                                                                                                                                        <span class="imgil"></span></span></strong>
                                                                                                                                </td>
                                                                                                                            </tr>
                                                                                                                            <tr>
                                                                                                                                <td>
                                                                                                                                </td>
                                                                                                                            </tr>
                                                                                                                            <!-- Prashant changes for PG options in Debit Card Tab ends -->
                                                                                                                        </table>
                                                                                                                    </td>
                                                                                                                </tr>
                                                                                                            </table>
                                                                                                            <!-- Prashant added oosrds ends-->
                                                                                                            <!-- Ajay Changes Start for BTBPO -->
                                                                                                            <!-- Ajay Changes Start for BTBPO -->
                                                                                                            <script language="JavaScript">

function setBank(gatewayID,payMode,pgType)
{
	//alert(&quot;111&quot;);
    document.BookTicketForm.paymentMode.value=payMode;
    // alert(&quot;22&quot;);
    document.BookTicketForm.pgType.value=pgType;
   //alert(&quot;33&quot;+pgType);
    document.BookTicketForm.gatewayID.value=gatewayID;
  // alert(&quot;44&quot;+document.BookTicketForm.gatewayID.value);
    document.BookTicketForm.buyTicket.value=&quot;0&quot;;
   // alert(&quot;55&quot;);
    document.BookTicketForm.screen.value=&quot;paymnt&quot;;
  //  alert(&quot;66&quot;);
    if(document.BookTicketForm.TatkalOpt.value==&quot;Y&quot;)
	{
		document.BookTicketForm.TatkalOpt.value=&quot;Y&quot;;
		document.BookTicketForm.CKFARE.value=&quot;CKFARE&quot;;

	}

    document.BookTicketForm.submitClicks.value=parseInt(document.BookTicketForm.submitClicks.value)+1;


   document.BookTicketForm.submit();
    return true;

}

function openWin(url,name,w,h)
{
	 var att = &quot;width=&quot;+ w +&quot;,height=&quot;+ h +&quot;left=0,top=100,toolbar=yes,menubar=yes,scrollbars=yes,status=no,resizable=yes,location=yes&quot;
	 window.open(url,&#39;&#39;,att)
	 return false;
}

function displayBankSoft(idType)
{
    for(var i=6;i&lt;=7;i++)
    {if(idType==i){
        document.getElementById(&quot;tab&quot;+i).style.display=&#39;&#39;;
        }else {
            document.getElementById(&quot;tab&quot;+i).style.display=&#39;none&#39;;
        }
    }
}

function displayBank(idType)
{
    for(var i=1;i&lt;=5;i++)
    {
        if(idType==i)
        {
        document.getElementById(i).style.display=&#39;&#39;;
		//Prashant changes for PG options in Debit Card Tab starts
		if(idType==2)
		{
		document.getElementById(&quot;deb&quot;).style.display =&#39;none&#39;;
		}
		else
			{
			document.getElementById(&quot;deb&quot;).style.display =&#39;&#39;;
		}
		//Prashant changes for PG options in Debit Card Tab ends
        if(document.getElementById(&quot;tab&quot;+i)!=null){
           document.getElementById(&quot;tab&quot;+i).style.backgroundImage=&quot;url(/beta_images/payment-back-or.jpg)&quot;;
		   document.getElementById(&quot;tab&quot;+i).style.backgroundRepeat=&quot;repeat-x&quot;;
          }
        }else {
            document.getElementById(i).style.display=&#39;none&#39;;
          if(document.getElementById(&quot;tab&quot;+i)!=null){
           document.getElementById(&quot;tab&quot;+i).style.backgroundImage=&quot;url(/beta_images/payment-back-st.jpg)&quot;;
		   document.getElementById(&quot;tab&quot;+i).style.backgroundRepeat=&quot;repeat-x&quot;;
          }
        }
    }
}
                                                                                                            </script>
                                                                                                        </td>
                                                                                                    </tr>
                                                                                                </table>
                                                                                            </td>
                                                                                        </tr>
                                                                                    </table>
                                                                                </td>
                                                                            </tr>
                                                                        </table>
                                    <script language="JavaScript">	
         document.getElementById(&quot;testdiv&quot;).style.display = &#39;none&#39;;
        function test()
        {

            alert(&quot;aaaaa&quot;);
            window.history.forward(1);
            alert(&quot;qqqqq&quot;);
        }

            function setFocus()
			{					  	
				
					//Renu /09-12-05 Passenger list modification for accrual starts
     		  
		
					
			//renu added and commented for class validation on 24-Jul-06 starts
			}

                                    	
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; document.getElementById(&quot;testdiv&quot;).style.display = &#39;none&#39;;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; function test()
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; {

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; alert(&quot;aaaaa&quot;);
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; window.history.forward(1);
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; alert(&quot;qqqqq&quot;);
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; function setFocus()
			{					&nbsp; 	
				
					//Renu /09-12-05 Passenger list modification for accrual starts
&nbsp;&nbsp;&nbsp;&nbsp; 		&nbsp; 
		
					
			//renu added and commented for class validation on 24-Jul-06 starts
			}

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </script>
                                </td>
                            </tr>
                        </table>
                    
</ContentTemplate>
                </cc1:TabPanel>
                <cc1:TabPanel ID="CshCrd" runat="server"  Visible="False">
                    <HeaderTemplate> Cash Cards</HeaderTemplate>
                     <ContentTemplate>
                        <table style="width: 100%">
                            <tr style="width: 100%">
                                <td style="width: 100%">
                                    <input name="BV_SessionID" type="hidden" value="@@@@1685528140.1328177340@@@@" /><input
                                        name="BV_EngineID" type="hidden" value="ccceadfflefejmecefecehidfgmdfkn.0" /><input
                                            name="deliveryMode" type="hidden" value="1" /><input name="submitClicks" type="hidden"
                                                value="4" /><input name="CurrentMonth" type="hidden" value="1" /><input name="CurrentDate"
                                                    type="hidden" value="2" /><input name="CurrentYear" type="hidden" value="2012" /><input
                                                        name="pgType" type="hidden" /><input name="paymentMode" type="hidden" /><input name="gatewayID"
                                                            type="hidden" /><input name="screen" type="hidden" /><input name="CKFARE" type="hidden" /><input
                                                                name="TatkalOpt" type="hidden" /><input name="hiddenSubmit" type="hidden" value="validate" /><input
                                                                    name="buyTicket" type="hidden" /><input name="Submit" type="hidden" /><link rel="stylesheet"
                                                                        type="text/css" /><table align="center" border="0" cellpadding="0" cellspacing="0"
                                                                            width="80%">
                                                                            <tr>
                                                                                <td bgcolor="#ffffff" height="400" valign="top">
                                                                                    <table border="0" width="100%">
                                                                                        <tr>
                                                                                            <td valign="top" width="74%">
                                                                                                <table align="right" border="0" width="99%">
                                                                                                    <tr>
                                                                                                        <td>
                                                                                                            <style type="text/css">
                                                                                                                body
                                                                                                                {
                                                                                                                    margin: 0;
                                                                                                                    padding: 0;
                                                                                                                }
                                                                                                                #main
                                                                                                                {
                                                                                                                    border: 1px solid #ccc;
                                                                                                                    border-bottom: 0px solid #ccc;
                                                                                                                    text-align: center;
                                                                                                                }
                                                                                                                .tabs
                                                                                                                {
                                                                                                                    height: 46px;
                                                                                                                    width: auto;
                                                                                                                }
                                                                                                                .tabsSoft
                                                                                                                {
                                                                                                                    height: 46px;
                                                                                                                    width: auto;
                                                                                                                }
                                                                                                                .tabsSoft a
                                                                                                                {
                                                                                                                    padding: 14px 100px;
                                                                                                                    border-left: 1px solid #ccc;
                                                                                                                    font: bold 13px arial;
                                                                                                                    color: #666666;
                                                                                                                    display: inline;
                                                                                                                    float: left;
                                                                                                                    text-decoration: none;
                                                                                                                }
                                                                                                                .tabs a
                                                                                                                {
                                                                                                                    padding: 14px 24px;
                                                                                                                    border-left: 1px solid #ccc;
                                                                                                                    font: bold 13px arial;
                                                                                                                    color: #666666;
                                                                                                                    display: inline;
                                                                                                                    float: left;
                                                                                                                    text-decoration: none;
                                                                                                                }
                                                                                                                .tabs a:focus
                                                                                                                {
                                                                                                                    -moz-outline-style: none;
                                                                                                                    border: 0px;
                                                                                                                }
                                                                                                                .tabs a:active
                                                                                                                {
                                                                                                                    outline: none;
                                                                                                                }
                                                                                                                
                                                                                                                
                                                                                                                .tabsGR
                                                                                                                {
                                                                                                                }
                                                                                                                .tabsOR
                                                                                                                {
                                                                                                                }
                                                                                                                /* For IE Versions - tabs a:hover{background:url(/beta_images/payment-back-or.jpg) repeat-x;}*/
                                                                                                                .tabs a:active
                                                                                                                {
                                                                                                                }
                                                                                                                /* For Other Browser*/
                                                                                                                .tabs a:focus
                                                                                                                {
                                                                                                                }
                                                                                                                .cont
                                                                                                                {
                                                                                                                    font: bold 14px arial;
                                                                                                                    text-align: left;
                                                                                                                    padding-left: 5px;
                                                                                                                    color: #666666;
                                                                                                                    border-bottom: 1px solid #CCCCCC;
                                                                                                                    height: 44px;
                                                                                                                }
                                                                                                                .tabcont
                                                                                                                {
                                                                                                                    border: 1px solid #FE9F0F;
                                                                                                                    border-top: 0px;
                                                                                                                    background-color: #FBDCAE;
                                                                                                                    text-align: left;
                                                                                                                    font: 12px arial;
                                                                                                                    padding: 2px;
                                                                                                                }
                                                                                                            </style>
                                                                                                            <temp:insert template="/common/displayError.jsp" />
                                                                                                            <!-- Prashant added oosrds start-->
                                                                                                            <table align="center" border="0" cellpadding="0" cellspacing="0">
                                                                                                                <tr>
                                                                                                                    <td>
                                                                                                                        <table align="center" border="0" cellpadding="0" cellspacing="0" width="90%">
                                                                                                                            <tr>
                                                                                                                                <td style="text-align: left; padding-bottom: 3px; padding-left: 6px; padding-right: 6px;
                                                                                                                                    color: #fe830b; padding-top: 3px">
                                                                                                                                    Note: If for any reason, the reservation output details are not displayed on your
                                                                                                                                    screen after you have made payments, please check the details in &quot;Booked Tickets&quot;
                                                                                                                                    under &quot;Booking History&quot; in left navigation bar. You may also check your
                                                                                                                                    mail for the details of your booking.
                                                                                                                                </td>
                                                                                                                            </tr>
                                                                                                                            <tr>
                                                                                                                                <td style="text-align: left; padding-bottom: 3px; padding-left: 6px; padding-right: 6px;
                                                                                                                                    color: #fe830b; padding-top: 3px">
                                                                                                                                    <div id="deb2">
                                                                                                                                        All VISA/MASTER debit cards (If enabled by card issuer) can also be used for ticket
                                                                                                                                        booking through any of the VISA/MASTER credit card payment gateways (ICICI PG, HDFC
                                                                                                                                        PG, AXIS PG, CITI PG). <a href="#?BV_SessionID=@@@@1685528140.1328177340@@@@&amp;BV_EngineID=ccceadfflefejmecefecehidfgmdfkn.0"
                                                                                                                                            onclick="window.open('/banklist.html','help','width=500,height=600,scrollbars=yes');return false;">
                                                                                                                                            Click Here</a> For List of Banks
                                                                                                                                    </div>
                                                                                                                                </td>
                                                                                                                            </tr>
                                                                                                                            <tr>
                                                                                                                                <td style="text-align: left; padding-bottom: 3px; padding-left: 6px; padding-right: 6px;
                                                                                                                                    color: #fe830b; padding-top: 3px">
                                                                                                                                    <a href="#?BV_SessionID=@@@@1685528140.1328177340@@@@&amp;BV_EngineID=ccceadfflefejmecefecehidfgmdfkn.0"
                                                                                                                                        onclick="window.open('/payment.html','help','width=500,height=800,scrollbars=yes');return false;">
                                                                                                                                        Click Here</a> For Bank Transaction Charges
                                                                                                                                </td>
                                                                                                                            </tr>
                                                                                                                        </table>
                                                                                                                        <table id="42" border="0" cellpadding="0" cellspacing="0" width="100%">
                                                                                                                            <tr>
                                                                                                                                <td class="cont" width="33%">
                                                                                                                                    <input name="gatewayIDV" onclick="setBank(9,0,1)" type="radio" value="38" /><strong><span
                                                                                                                                        class="headingbl">ITZ Cash Card </span></strong>
                                                                                                                                </td>
                                                                                                                                <td class="cont" width="33%">
                                                                                                                                    <strong class="headingbl">
                                                                                                                                        <input name="gatewayIDV" onclick="setBank(31,0,1)" type="radio" value="39" /><span
                                                                                                                                            class="headingbl">Done Cash Card </span></strong>
                                                                                                                                </td>
                                                                                                                            </tr>
                                                                                                                            <tr>
                                                                                                                                <td class="cont" width="33%">
                                                                                                                                    <strong class="headingbl">
                                                                                                                                        <input name="gatewayIDV" onclick="setBank(24,0,1)" type="radio" value="40" /><span
                                                                                                                                            class="headingbl">I Cash Card </span></strong>
                                                                                                                                </td>
                                                                                                                                <!--rajiv jha added oosrds start-->
                                                                                                                                <!--rajiv jha added oosrds end-->
                                                                                                                                <!--rajiv jha added oosrds start-->
                                                                                                                                <!--rajiv jha added oosrds end-->
                                                                                                                                <!--rajiv jha added oosrds start-->
                                                                                                                                <!--rajiv jha added oosrds end-->
                                                                                                                                <!--rajiv jha added oosrds start-->
                                                                                                                                <!--rajiv jha added oosrds end-->
                                                                                                                                <!--rajiv jha added oosrds start-->
                                                                                                                                <!--rajiv jha added oosrds end-->
                                                                                                                                <!--rajiv jha added oosrds start-->
                                                                                                                                <!--rajiv jha added oosrds end-->
                                                                                                                                <!--rajiv jha added oosrds start-->
                                                                                                                                <!--rajiv jha added oosrds end-->
                                                                                                                                <!--rajiv jha added oosrds start-->
                                                                                                                                <!--rajiv jha added oosrds end-->
                                                                                                                                <td class="cont" width="33%">
                                                                                                                                    <strong class="headingbl">
                                                                                                                                        <input name="gatewayIDV" onclick="setBank(51,0,1)" type="radio" value="41" /><span
                                                                                                                                            class="headingbl">Oxi Cash </span></strong>
                                                                                                                                </td>
                                                                                                                                <!--rajiv jha added oosrds start-->
                                                                                                                                <!--rajiv jha added oosrds end-->
                                                                                                                            </tr>
                                                                                                                            <tr>
                                                                                                                                <!--rajiv jha added oosrds start-->
                                                                                                                                <!--rajiv jha added oosrds end-->
                                                                                                                            </tr>
                                                                                                                        </table>
                                                                                                                        <!-- Prashant added oosrds start-->
                                                                                                                        <!-- Prashant added oosrds ends-->
                                                                                                                    </td>
                                                                                                                </tr>
                                                                                                            </table>
                                                                                                            <!-- Prashant added oosrds ends-->
                                                                                                            <!-- Ajay Changes Start for BTBPO -->
                                                                                                            <!-- Ajay Changes Start for BTBPO -->
                                                                                                        </td>
                                                                                                    </tr>
                                                                                                </table>
                                                                                            </td>
                                                                                        </tr>
                                                                                    </table>
                                                                                </td>
                                                                                <td width="19">
                                                                                    &nbsp;
                                                                                </td>
                                                                            </tr>
                                                                            <tr>
                                                                                <td width="19">
                                                                                    &nbsp;
                                                                                </td>
                                                                            </tr>
                                                                        </table>
                                    <script language="JavaScript">	
         document.getElementById(&quot;testdiv&quot;).style.display = &#39;none&#39;;
        function test()
        {

            alert(&quot;aaaaa&quot;);
            window.history.forward(1);
            alert(&quot;qqqqq&quot;);
        }

            function setFocus()
			{					  	
				
					//Renu /09-12-05 Passenger list modification for accrual starts
     		  
		
					
			//renu added and commented for class validation on 24-Jul-06 starts
			}

                                    </script>
                                </td>
                            </tr>
                        </table>
                    
</ContentTemplate>
                </cc1:TabPanel>
                <cc1:TabPanel ID="EmiOptin" runat="server" Visible="False">
                    <HeaderTemplate>EMI Option</HeaderTemplate>
                      <ContentTemplate>
                        <table style="width: 100%">
                            <tr style="width: 100%">
                                <td style="width: 100%">
                                    <input name="BV_SessionID" type="hidden" value="@@@@1685528140.1328177340@@@@" /><input
                                        name="BV_EngineID" type="hidden" value="ccceadfflefejmecefecehidfgmdfkn.0" /><input
                                            name="deliveryMode" type="hidden" value="1" /><input name="submitClicks" type="hidden"
                                                value="4" /><input name="CurrentMonth" type="hidden" value="1" /><input name="CurrentDate"
                                                    type="hidden" value="2" /><input name="CurrentYear" type="hidden" value="2012" /><input
                                                        name="pgType" type="hidden" /><input name="paymentMode" type="hidden" /><input name="gatewayID"
                                                            type="hidden" /><input name="screen" type="hidden" /><input name="CKFARE" type="hidden" /><input
                                                                name="TatkalOpt" type="hidden" /><input name="hiddenSubmit" type="hidden" value="validate" /><input
                                                                    name="buyTicket" type="hidden" /><input name="Submit" type="hidden" /><link rel="stylesheet"
                                                                        type="text/css" /><table align="center" border="0" cellpadding="0" cellspacing="0"
                                                                            width="80%">
                                                                            <tr>
                                                                                <td bgcolor="#ffffff" height="400" valign="top">
                                                                                    <table border="0" width="100%">
                                                                                        <tr>
                                                                                            <td valign="top" width="74%">
                                                                                                <table align="right" border="0" width="99%">
                                                                                                    <tr>
                                                                                                        <td>
                                                                                                            <style type="text/css">



body{margin:0; padding:0;}
#main{border:1px solid #ccc; border-bottom:0px solid #ccc; text-align:center;}
.tabs{height:46px; width:auto;}
.tabsSoft{height:46px; width:auto;}
.tabsSoft a{padding:14px 100px; border-left:1px solid #ccc; font:bold 13px arial; color:#666666; display:inline; float:left; 
text-decoration:none;
    }
.tabs a{padding:14px 24px; border-left:1px solid #ccc; font:bold 13px arial; color:#666666; display:inline; float:left; 
text-decoration:none;
    }
.tabs a:focus{-moz-outline-style: none; border:0px;}
.tabs a:active{outline: none;}


.tabsGR{
    }
.tabsOR{
    }
/* For IE Versions - tabs a:hover{background:url(/beta_images/payment-back-or.jpg) repeat-x;}*/
.tabs a:active{
    }
/* For Other Browser*/
.tabs a:focus{
.cont{font:bold 14px arial; text-align:left; padding-left:5px; color:#666666; border-bottom:1px solid #CCCCCC; height:44px;}
.tabcont{border:1px solid #FE9F0F; border-top:0px; background-color:#FBDCAE; text-align:left; font:12px arial; padding:2px;}
</style>
                                                                                                            <temp:insert template="/common/displayError.jsp" />
                                                                                                            <!-- Prashant added oosrds start-->
                                                                                                            <table align="center" border="0" cellpadding="0" cellspacing="0">
                                                                                                                <tr>
                                                                                                                    <td>
                                                                                                                        <table align="center" border="0" cellpadding="0" cellspacing="0" width="90%">
                                                                                                                            <tr>
                                                                                                                                <td style="text-align: left; padding-bottom: 3px; padding-left: 6px; padding-right: 6px;
                                                                                                                                    color: #fe830b; padding-top: 3px">
                                                                                                                                    Note: If for any reason, the reservation output details are not displayed on your
                                                                                                                                    screen after you have made payments, please check the details in &quot;Booked Tickets&quot;
                                                                                                                                    under &quot;Booking History&quot; in left navigation bar. You may also check your
                                                                                                                                    mail for the details of your booking.
                                                                                                                                </td>
                                                                                                                            </tr>
                                                                                                                            <tr>
                                                                                                                                <td style="text-align: left; padding-bottom: 3px; padding-left: 6px; padding-right: 6px;
                                                                                                                                    color: #fe830b; padding-top: 3px">
                                                                                                                                    <div id="deb3">
                                                                                                                                        All VISA/MASTER debit cards (If enabled by card issuer) can also be used for ticket
                                                                                                                                        booking through any of the VISA/MASTER credit card payment gateways (ICICI PG, HDFC
                                                                                                                                        PG, AXIS PG, CITI PG). <a href="#?BV_SessionID=@@@@1685528140.1328177340@@@@&amp;BV_EngineID=ccceadfflefejmecefecehidfgmdfkn.0"
                                                                                                                                            onclick="window.open('/banklist.html','help','width=500,height=600,scrollbars=yes');return false;">
                                                                                                                                            Click Here</a> For List of Banks
                                                                                                                                    </div>
                                                                                                                                </td>
                                                                                                                            </tr>
                                                                                                                            <tr>
                                                                                                                                <td style="text-align: left; padding-bottom: 3px; padding-left: 6px; padding-right: 6px;
                                                                                                                                    color: #fe830b; padding-top: 3px">
                                                                                                                                    <a href="#?BV_SessionID=@@@@1685528140.1328177340@@@@&amp;BV_EngineID=ccceadfflefejmecefecehidfgmdfkn.0"
                                                                                                                                        onclick="window.open('/payment.html','help','width=500,height=800,scrollbars=yes');return false;">
                                                                                                                                        Click Here</a> For Bank Transaction Charges
                                                                                                                                </td>
                                                                                                                            </tr>
                                                                                                                        </table>
                                                                                                                        <table id="32" border="0" cellpadding="0" cellspacing="0" width="100%">
                                                                                                                            <tr>
                                                                                                                                <td class="cont" width="33%">
                                                                                                                                    <input name="gatewayIDV" onclick="setBank(20,0,1)" type="radio" value="24" /><strong><span
                                                                                                                                        class="headingbl">ICICI Bank EMI <span class="desctext">(For ICICI Credit Cards only)
                                                                                                                                        </span><span class="imgil"></span></span></strong>
                                                                                                                                </td>
                                                                                                                                <td class="cont" width="33%">
                                                                                                                                    <input name="gatewayIDV" onclick="setBank(17,0,0)" type="radio" value="25" /><strong><span
                                                                                                                                        class="headingbl">CITI Bank EMI <span class="desctext">(For CITI Credit Cards only)
                                                                                                                                        </span><span class="imgil"></span></span></strong>
                                                                                                                                </td>
                                                                                                                            </tr>
                                                                                                                        </table>
                                                                                                                    </td>
                                                                                                                </tr>
                                                                                                            </table>
                                                                                                            <!-- Prashant added oosrds ends-->
                                                                                                            <!-- Ajay Changes Start for BTBPO -->
                                                                                                            <!-- Ajay Changes Start for BTBPO -->
                                                                                                            <script language="JavaScript">


function setBank(gatewayID,payMode,pgType)
{
	//alert(&quot;111&quot;);
    document.BookTicketForm.paymentMode.value=payMode;
    // alert(&quot;22&quot;);
    document.BookTicketForm.pgType.value=pgType;
   //alert(&quot;33&quot;+pgType);
    document.BookTicketForm.gatewayID.value=gatewayID;
  // alert(&quot;44&quot;+document.BookTicketForm.gatewayID.value);
    document.BookTicketForm.buyTicket.value=&quot;0&quot;;
   // alert(&quot;55&quot;);
    document.BookTicketForm.screen.value=&quot;paymnt&quot;;
  //  alert(&quot;66&quot;);
    if(document.BookTicketForm.TatkalOpt.value==&quot;Y&quot;)
	{
		document.BookTicketForm.TatkalOpt.value=&quot;Y&quot;;
		document.BookTicketForm.CKFARE.value=&quot;CKFARE&quot;;

	}

    document.BookTicketForm.submitClicks.value=parseInt(document.BookTicketForm.submitClicks.value)+1;


   document.BookTicketForm.submit();
    return true;

}

function openWin(url,name,w,h)
{
	 var att = &quot;width=&quot;+ w +&quot;,height=&quot;+ h +&quot;left=0,top=100,toolbar=yes,menubar=yes,scrollbars=yes,status=no,resizable=yes,location=yes&quot;
	 window.open(url,&#39;&#39;,att)
	 return false;
}

function displayBankSoft(idType)
{
    for(var i=6;i&lt;=7;i++)
    {if(idType==i){
        document.getElementById(&quot;tab&quot;+i).style.display=&#39;&#39;;
        }else {
            document.getElementById(&quot;tab&quot;+i).style.display=&#39;none&#39;;
        }
    }
}

function displayBank(idType)
{
    for(var i=1;i&lt;=5;i++)
    {
        if(idType==i)
        {
        document.getElementById(i).style.display=&#39;&#39;;
		//Prashant changes for PG options in Debit Card Tab starts
		if(idType==2)
		{
		document.getElementById(&quot;deb&quot;).style.display =&#39;none&#39;;
		}
		else
			{
			document.getElementById(&quot;deb&quot;).style.display =&#39;&#39;;
		}
		//Prashant changes for PG options in Debit Card Tab ends
        if(document.getElementById(&quot;tab&quot;+i)!=null){
           document.getElementById(&quot;tab&quot;+i).style.backgroundImage=&quot;url(/beta_images/payment-back-or.jpg)&quot;;
		   document.getElementById(&quot;tab&quot;+i).style.backgroundRepeat=&quot;repeat-x&quot;;
          }
        }else {
            document.getElementById(i).style.display=&#39;none&#39;;
          if(document.getElementById(&quot;tab&quot;+i)!=null){
           document.getElementById(&quot;tab&quot;+i).style.backgroundImage=&quot;url(/beta_images/payment-back-st.jpg)&quot;;
		   document.getElementById(&quot;tab&quot;+i).style.backgroundRepeat=&quot;repeat-x&quot;;
          }
        }
    }
}
                                                                                                            </script>
                                                                                                        </td>
                                                                                                    </tr>
                                                                                                </table>
                                                                                            </td>
                                                                                        </tr>
                                                                                    </table>
                                                                                </td>
                                                                            </tr>
                                                                        </table>
                                    <script language="JavaScript">	
         document.getElementById(&quot;testdiv&quot;).style.display = &#39;none&#39;;
        function test()
        {

            alert(&quot;aaaaa&quot;);
            window.history.forward(1);
            alert(&quot;qqqqq&quot;);
        }

            function setFocus()
			{					  	
				
					//Renu /09-12-05 Passenger list modification for accrual starts
     		  
		
					
			//renu added and commented for class validation on 24-Jul-06 starts
			}

                                    </script>
                                </td>
                            </tr>
                        </table>
                    
</ContentTemplate>
                </cc1:TabPanel>
             </cc1:TabContainer>
              <fieldset>
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <table runat="server" id="crdNoArea" style="width: 100%">
                            <tr style="width: 100%">
                                <td colspan="2">
                                    <asp:Label runat="server" Text="Card Holder Name" CssClass="labeltext" 
                                        ID="lblCrdHolder" Width="130px"></asp:Label>
                                    <b style="color: Red; vertical-align: text-top; font-size: large">*</b>
                                </td>
                                <td style="width: 20%">
                                    <asp:TextBox runat="server" CssClass="textbox" ID="txtCardHold" 
                                        AutoCompleteType="Disabled"></asp:TextBox>
                                </td>
                                <td>
                                    <asp:RequiredFieldValidator runat="server" ControlToValidate="txtCardHold" ErrorMessage="Please Card Holder Name"
                                        ID="rfvCardExp0" Font-Size="X-Small" ForeColor="Red"></asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr style="width: 100%">
                                <td style="width: 20%">
                                </td>
                                <td style="width: 20%">
                                </td>
                                <td style="width: 20%">
                                </td>
                                <td style="width: 40%">
                                </td>
                            </tr>
                            <tr style="width: 100%">
                                <td colspan="2">
                                    <asp:Label runat="server" Text="Card No." CssClass="labeltext" ID="lblCrdNo" 
                                        Width="60px"></asp:Label>
                                    <b style="color: Red; vertical-align: text-top; font-size: large">*</b>
                                </td>
                                <td style="width: 20%">
                                    <asp:TextBox runat="server" Width="50px" ID="txtCardNo" 
                                        AutoCompleteType="Disabled"></asp:TextBox>
                                    <asp:TextBox runat="server" Width="50px" ID="txtCardNo0" 
                                        AutoCompleteType="Disabled"></asp:TextBox>
                                    <asp:TextBox runat="server" Width="50px" ID="txtCardNo1"></asp:TextBox>
                                    <asp:TextBox runat="server" Width="50px" ID="txtCardNo2" 
                                        AutoCompleteType="Disabled"></asp:TextBox>
                                </td>
                                <td style="width: 40%">
                                    <asp:RequiredFieldValidator runat="server" ControlToValidate="txtCardNo" ErrorMessage="Please Enter Card No"
                                        ID="rfvCardNo" Font-Names="Calibri" Font-Size="Small" ForeColor="Red"></asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr style="width: 100%">
                                <td colspan="2">
                                    &nbsp;
                                </td>
                                <td style="width: 20%">
                                    &nbsp;
                                </td>
                                <td style="width: 40%">
                                    &nbsp;
                                </td>
                            </tr>
                            <tr style="width: 100%">
                                <td colspan="2">
                                    <asp:Label ID="lblCrdExp" runat="server" CssClass="labeltext" 
                                        Text="Card Expiry Date" Width="120px"></asp:Label>
                                    &nbsp;<b style="color: Red; vertical-align: text-top; font-size: large">*</b>
                                </td>
                                <td style="width: 20%">
                                    <asp:DropDownList ID="ddlMonth" runat="server">
                                        <asp:ListItem Text="Jan" Value="1"></asp:ListItem>
                                        <asp:ListItem Text="Feb" Value="2"></asp:ListItem>
                                        <asp:ListItem Text="Mar" Value="3"></asp:ListItem>
                                        <asp:ListItem Text="Apr" Value="4"></asp:ListItem>
                                        <asp:ListItem Text="May" Value="5"></asp:ListItem>
                                        <asp:ListItem Text="Jun" Value="6"></asp:ListItem>
                                        <asp:ListItem Text="Jul" Value="7"></asp:ListItem>
                                        <asp:ListItem Text="Aug" Value="8"></asp:ListItem>
                                        <asp:ListItem Text="Sep" Value="9"></asp:ListItem>
                                        <asp:ListItem Text="Oct" Value="10"></asp:ListItem>
                                        <asp:ListItem Text="Nov" Value="11"></asp:ListItem>
                                        <asp:ListItem Text="Dec" Value="12"></asp:ListItem>
                                    </asp:DropDownList>
                                    &nbsp;
                                    <asp:DropDownList ID="ddlYear" runat="server">
                                        <asp:ListItem Text="2000" Value="1"></asp:ListItem>
                                        <asp:ListItem Text="2001" Value="2"></asp:ListItem>
                                        <asp:ListItem Text="2002" Value="3"></asp:ListItem>
                                        <asp:ListItem Text="2003" Value="4"></asp:ListItem>
                                        <asp:ListItem Text="2004" Value="5"></asp:ListItem>
                                        <asp:ListItem Text="2005" Value="6"></asp:ListItem>
                                        <asp:ListItem Text="2006" Value="7"></asp:ListItem>
                                        <asp:ListItem Text="2007" Value="8"></asp:ListItem>
                                        <asp:ListItem Text="2008" Value="9"></asp:ListItem>
                                        <asp:ListItem Text="2009" Value="10"></asp:ListItem>
                                        <asp:ListItem Text="2010" Value="11"></asp:ListItem>
                                        <asp:ListItem Text="2011" Value="12"></asp:ListItem>
                                        <asp:ListItem Text="2012" Value="13"></asp:ListItem>
                                        <asp:ListItem Text="2013" Value="14"></asp:ListItem>
                                        <asp:ListItem Text="2014" Value="15"></asp:ListItem>
                                        <asp:ListItem Text="2015" Value="16"></asp:ListItem>
                                        <asp:ListItem Text="2016" Value="17"></asp:ListItem>
                                        <asp:ListItem Text="2017" Value="18"></asp:ListItem>
                                        <asp:ListItem Text="2018" Value="19"></asp:ListItem>
                                        <asp:ListItem Text="2019" Value="20"></asp:ListItem>
                                        <asp:ListItem Text="2020" Value="20"></asp:ListItem>
                                        <asp:ListItem Text="2021" Value="21"></asp:ListItem>
                                        <asp:ListItem Text="2022" Value="22"></asp:ListItem>
                                        <asp:ListItem Text="2023" Value="23"></asp:ListItem>
                                        <asp:ListItem Text="2024" Value="24"></asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                                <td style="width: 40%">
                                    &nbsp;
                                </td>
                            </tr>
                            <tr style="width: 100%">
                                <td colspan="2">
                                    &nbsp;
                                </td>
                                <td style="width: 20%">
                                    &nbsp;
                                </td>
                                <td style="width: 40%">
                                    &nbsp;
                                </td>
                            </tr>
                            <tr style="width: 100%">
                                <td style="width: 20%">
                                </td>
                                <td style="width: 20%">
                                </td>
                                <td style="width: 20%">
                                </td>
                                <td style="width: 40%">
                                </td>
                            </tr>
                            <tr style="width: 100%">
                                <td style="width: 20%">
                                    <asp:Label runat="server" Text="CVV" CssClass="labeltext" ID="lblPin" 
                                        Width="40px"></asp:Label>
                                    <b style="color: Red; vertical-align: text-top; font-size: large">*</b>
                                </td>
                                <td style="width: 20%">
                                    &nbsp;
                                </td>
                                <td style="width: 20%">
                                    <asp:TextBox runat="server" CssClass="textbox" ID="txtPin" MaxLength="4" TextMode="Password"
                                        Width="50px" AutoCompleteType="Disabled"></asp:TextBox>
                                </td>
                                <td style="width: 40%">
                                    <asp:RequiredFieldValidator runat="server" ControlToValidate="txtPin" ErrorMessage="Please Enter Pin"
                                        ID="rfvCardPin" Font-Names="Calibri" Font-Size="Small" ForeColor="Red"></asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 20%">
                                    &nbsp;
                                </td>
                                <td colspan="2" align="center">
                                    <asp:Button runat="server" Text="Buy" CssClass="button" ID="lblSubmit" OnClick="lblSubmit_Click">
                                    </asp:Button>
                                </td>
                                <td runat="server" id="Td23" style="width: 40%">
                                    &nbsp;
                                </td>
                            </tr>
                        </table>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </fieldset>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
