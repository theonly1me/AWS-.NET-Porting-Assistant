using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using SISDAPPS.DataAccessBlock;
using System.Collections;

namespace BusinessBlock.Accounts
{
    public partial class AccBlock
    {
        DataProvider dataprovider = new DataProvider();

        public DataTable getDDLData(string DataTextField, string DataValueField, string TableName, string WhereColumn, string Wherevalue)
        {
            DataTable dt = dataprovider.getDTForCombo(DataTextField, DataValueField, TableName, WhereColumn, Wherevalue);
            return dt;
        }

        public DataTable getDTForComboMultiWhere(string DataTextField, string DataValueField, string TableName, string varWhereClause)
        {
            DataTable dt = dataprovider.getDTForComboMultiWhere(DataTextField, DataValueField, TableName, varWhereClause);
            return dt;
        }

        public DataTable getMainAccounts()
        {
            DataTable dt = dataprovider.ExecuteDataTable("usp_ACC_getMainAccounts");
            return dt;
        }

        #region WelcomePage

        public DataTable getPendingcount(string armyNo, string FeatureId )
        {
            DataTable dt = dataprovider.ExecuteDataTable("USP_ACC_CheckUserStatus", armyNo, FeatureId);
            return dt;
        }

        #endregion


        #region MainAccount//

        public DataTable ManAccountdetails(object[] objArr)
        {
            DataTable dt = dataprovider.ExecuteDataTable("usp_ACC_MainAccount_Details", objArr);
            return dt;
        }

        public DataSet ManAccountdetailsView(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_ACC_MainAccount_Details", objArr);
            return ds;
        }

        public int MainAccDetailsOperatons(object[] objArr)
        {
            return dataprovider.ExecuteNonQuery("usp_ACC_MainAccount_Details", objArr);
        }

        public int OfficerHoldrDetailsOperatons(object[] objArr)
        {
            return dataprovider.ExecuteNonQuery("usp_ACC_OfficerHolder_Details", objArr);
        }

        public DataTable MainAct_ProfitHead(int MainAct_Id, int OFlag)
        {
            DataTable dt = dataprovider.ExecuteDataTable("usp_ACC_MainAct_ProfitHead", MainAct_Id, OFlag);
            return dt;
        }
        #endregion   

        #region AccountHead//

        public DataTable HeadDetails(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_ACC_Head_Details", objArr);
            return ds.Tables[0];
        }

        public int HeadDetailsOperatons(object[] objArr)
        {
            return dataprovider.ExecuteNonQuery("usp_ACC_Head_Details", objArr);
        }

        #endregion

        #region ChequeBook//

        public int ChqBkDetailsOperatons(object[] objArr)
        {
            return dataprovider.ExecuteNonQuery("usp_ACC_ChequeBook_Details", objArr);
        }


        public DataTable ChequeBookDetails(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_ACC_ChequeBook_Details", objArr);
            return ds.Tables[0];
        }
        #endregion

        #region Cheque//

        public int ChqDetailsOperatons(object[] objArr)
        {
            return dataprovider.ExecuteNonQuery("usp_ACC_Cheques_Details", objArr);
        }


        public DataTable ChequeDetails(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_ACC_Cheques_Details",objArr);
            return ds.Tables[0];
        }

        #endregion

        #region Bank//

        public int BankDetailsOperatons(object[] objArr)
        {
            return dataprovider.ExecuteNonQuery("usp_ACC_MST_Bank", objArr);
        }

        public DataSet BankDetails(object[] objArr)   
        {
            DataSet ds=dataprovider.ExecuteDataSet("usp_ACC_MST_Bank",objArr);
            return ds;
        }

        #endregion 

        #region Payment Sanction Authority

        public int PaymtSanctnAuthorityDetailsOperatons(object[] objArr)
        {
            return dataprovider.ExecuteNonQuery("usp_ACC_MST_PaymentSanctionAuthority_Details", objArr);
        }


        public DataTable PaymtSanctnAuthorityDetails(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_ACC_MST_PaymentSanctionAuthority_Details", objArr);
            return ds.Tables[0];
        }

        public DataTable GetNameFromArmyNo(String ArmyNo)
        {
            return dataprovider.ExecuteDataTable("usp_getNameFromArmyNo", ArmyNo);
        }

        #endregion

        #region  Voucher Configuration//

        public int VoucherConfiguratnDetailsOperatons(object[] objArr)
        {
            return dataprovider.ExecuteNonQuery("usp_ACC_MST_VoucherConfiguratn_Details", objArr);
        }

        public DataSet VoucherConfiguratnDetails(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_ACC_MST_VoucherConfiguratn_Details", objArr);
            return ds;
        }

        #endregion

        #region Quotation
        public int QuotationDetailsOperatons(object[] objArr)
        {
            return dataprovider.ExecuteNonQuery("usp_ACC_Local_Purchase_Insert", objArr);
        }

        public DataSet QuotationItemRateDetails(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_ACC_Local_Purchase_Vendor_Item_Rate_Select", objArr);
            return ds;//.Tables[0];
        }

        public int QuotationItemDetailsOperatons(object[] objArr)
        {
            return dataprovider.ExecuteNonQuery("usp_ACC_Local_Purchase_Details_Insert", objArr);
        }


        public int QuotationVendorDetailsOperatons(object[] objArr)
        {
            return dataprovider.ExecuteNonQuery("usp_ACC_Local_Purchase_Vendor_Insert", objArr);
        }

        public DataTable QuotationItemsFromLPO(int LpoNo)
        {
            return dataprovider.ExecuteDataTable("USP_ACC_Local_Purchase_LPO", LpoNo);
        }

        #endregion

        #region QuotationDetails
        //public int QuotationDetailsSearchOperatons(object[] objArr)
        //{
        //    return dataprovider.ExecuteNonQuery("usp_ACC_Local_Purchase_Select", objArr);
        //}
        public DataTable QuotationDetails(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_ACC_Local_Purchase_Insert", objArr);
            return ds.Tables[0];
        }
        public DataTable QuotationDetailsSearch(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_ACC_Local_Purchase_Select", objArr);
            return ds.Tables[0];
        }
        #endregion

        #region Bid for Quotation
        public int QuotationDetailsVendorRate(object[] objArr)
        {
            return dataprovider.ExecuteNonQuery("usp_ACC_Local_Purchase_Vendor_Rate_Insert", objArr);
        }

        public DataTable Quotation_Item_Vendor_Info(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_ACC_Local_Purchase_Vendor_Item_Select", objArr);
            return ds.Tables[0];
        }
        //public DataTable QuotationVendor(object[] objArr)
        //{
        //    DataSet ds = dataprovider.ExecuteDataSet("usp_ACC_Local_Purchase_Select", objArr);
        //    return ds.Tables[0];
        //}
        #endregion

        #region Comparative Statement & L1 Selection for Quotation
        public int QuotationL1Vendor(object[] objArr)
        {
            return dataprovider.ExecuteNonQuery("usp_ACC_Local_Purchase_L1_Selection", objArr);
        }

        public DataTable ComparativeStatementDetails(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_ACC_Local_Purchase_Comparative_Statement", objArr);
            return ds.Tables[0];
        }
        
        #endregion

        #region Supply Order
        public int insertsupplyOrderDetails(object[] obj)
        {

            return dataprovider.ExecuteNonQuery("usp_ACC_TRN_Local_Purchase_SupplyOrder", obj);
        }


        public DataTable FillSupplyOrderInfoGrid(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_ACC_TRN_Local_Purchase_SupplyOrder", objArr);
            return ds.Tables[0];
        }

        public DataSet FillSupplyOrderInfoEntry(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_ACC_TRN_Local_Purchase_SupplyOrderFill_Entry", objArr);
            return ds;
        }
        #endregion

        #region Consignment Opening Board
        public int insertConsignmentOpeningBoardDetails(object[] obj)
        {
            return dataprovider.ExecuteNonQuery("usp_ACC_TRN_ConsignmentOpBoard", obj);
        }
        public int updateConsignmentOpBoard(object[] obj)
        {
            return dataprovider.ExecuteNonQuery("usp_ACC_TRN_ConsignmentOpBoard_Update", obj);
        }
        public DataSet fillConsignment(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_ACC_TRN_ConsignmentOpBoard", objArr);
            return ds;
        }
        #endregion

        #region Close Quotation for Payment
        public int QuotationClose(object[] objArr)
        {
            return dataprovider.ExecuteNonQuery("usp_ACC_Local_Purchase_Close", objArr);
        }

        public DataTable QuotationL1Details(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_ACC_Local_Purchase_Close", objArr);
            return ds.Tables[0];
        }

        #endregion

        #region Property Taken Charges
        public int ProperyTakeChargeInsert(object[] objArr)
        {
            //return dataprovider.ExecuteNonQuery("usp_ACC_TRN_PropertyState", objArr);//usp_ACC_TRN_PropertyEntry
            return dataprovider.ExecuteNonQuery("usp_ACC_TRN_PropertyEntry", objArr);
        }

        public DataTable ProperyTakeChargeDetails(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_ACC_TRN_PropertyEntry", objArr);
            return ds.Tables[0];
        }
        #endregion

        #region Property Head
        public int PropertyHeadDetailsOperatons(object[] objArr)
        {
            return dataprovider.ExecuteNonQuery("usp_ACC_PropertyHead_Details", objArr);
        }


        public DataTable PropertyHeadDetails(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_ACC_PropertyHead_Details", objArr);
            return ds.Tables[0];
        }
        #endregion

        #region Property Item Initialization
        public int property_Purchased_TakenonChargeInsert(object[] objArr)
        {
            return dataprovider.ExecuteNonQuery("usp_ACC_PropertyItems_Insert", objArr);
        }


        //public DataTable getPropertyItemDetails(object[] objArr)
        //{
        //    DataSet ds = dataprovider.ExecuteDataSet("usp_ACC_PropertyHead_Details", objArr);
        //    return ds.Tables[0];
        //}
        #endregion

        #region Property Sub Head
        public int PropertySubHeadDetailsOperatons(object[] objArr)
        {
            return dataprovider.ExecuteNonQuery("usp_ACC_PropertySubHead_Details", objArr);
        }


        public DataTable PropertySubHeadDetails(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_ACC_PropertySubHead_Details", objArr);
            return ds.Tables[0];
        }
        #endregion

        #region Property Details
        public DataTable PropertyDetailsSearch(object[] objArr)
        {
           return dataprovider.ExecuteDataTable("usp_ACC_PropertyItems_Select", objArr);
        }
        #endregion

        #region Property Charge Off Details
        public int Property_ChargeOff(object[] objArr)
        {
            return dataprovider.ExecuteNonQuery("usp_ACC_Property_ChargeOff", objArr);
        }

        public DataTable getNotClosedMonthDDL_Property(int YearId, int MainAct_Id)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_ACC_getNotClosedMonthDDL_Property", YearId, MainAct_Id);
            return ds.Tables[0];
        }

        #endregion

        #region Property Appereciation Deperciation
        public int property_Appr_Depr(object[] objArr)
        {
            return dataprovider.ExecuteNonQuery("usp_ACC_Property_Appr_Depr", objArr);
        }

        // Close Month & Appereciation Deperciation
        public int Property_MonthClose(object[] objArr)
        {
            return dataprovider.ExecuteNonQuery("usp_ACC_TRN_Property_Close_Month", objArr);
        }
        #endregion

        #region DashBoard

        public DataTable DashBoardView()
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_ACC_DashBoard");
            return ds.Tables[0];
        }

        public DataTable DashBoardViewMainAct(int mainActId)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_ACC_DashBoardMainAct", mainActId);
            return ds.Tables[0];
        }

        #endregion

        #region SurpriseCheck

        public int SurpriseCheckOfficerDetails(object[] objArr)
        {
            return dataprovider.ExecuteNonQuery("usp_ACC_TRN_OFFICERS", objArr);
        }

        public int SurpriseCheckDetails(object[] objArr)
        {
            return dataprovider.ExecuteNonQuery("usp_ACC_TRN_SURPRISECHECK", objArr);
           
        }

        public DataTable GetQuarter(object[] objArr)
        {
            return dataprovider.ExecuteDataTable("usp_ACC_TRN_SURPRISECHECK_QUARTER", objArr);
        }

        public DataTable GetOfficerHolder(int mainAccountId)
        {
            return dataprovider.ExecuteDataTable("usp_ACC_OfficerHolderView", mainAccountId);
        }

        #endregion

        #region BankRecoReport
        public DataSet BankRecoReportDetails(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_ACC_BankRecoReport", objArr);
            return ds;
        }
        #endregion

        #region ProfitDistribution
        public DataTable GetHeads(Int32 mainActId)
        {
            return dataprovider.ExecuteDataTable("usp_ACC_HeadNames", mainActId);
        }

        public DataTable GetCheques(Int32 mainActId)
        {
            return dataprovider.ExecuteDataTable("usp_ACC_GetCheques", mainActId);
        }


        #endregion

        #region DirectVoucher
        public int DirectVoucherOperatons(object[] objArr)
        {
            return dataprovider.ExecuteNonQuery("usp_ACC_DirectVoucherSave", objArr);
        }
        #endregion

        #region Property State
        public DataSet PropertyStateDetails(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_ACC_PropertyState", objArr);
            return ds;
        }

        public DataTable getClosedMonthDDL_Property(int YearId, int MainAct_Id)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_ACC_getClosedMonthDDL_Property", YearId, MainAct_Id);
            return ds.Tables[0];
        }
        #endregion

        #region Officer Holder//
        public int OfficerHolderDetailsOperatons(object[] objArr)
        {
            return dataprovider.ExecuteNonQuery("usp_ACC_OfficerHolder", objArr);
        }


        public DataSet OfficerHolderDetails(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_ACC_OfficerHolder", objArr);
            return ds;
        }

        public DataTable getDDLOficerData(string DataTextField, string DataValueField, string TableName, string WhereColumn, string Wherevalue)
        {
            DataTable dt = dataprovider.getDTForCombo(DataTextField, DataValueField, TableName, WhereColumn, Wherevalue);
            return dt;
        }
        #endregion

        #region Print Surprice Check Certificate
        //public DataTable GetSurpriceCheckCertificate(object[] objArr)
        //{
        //    return dataprovider.ExecuteDataTable("usp_ACC_TRN_SURPRISECHECK_PRINT", objArr);
        //}
        //public DataTable SurpriceCheckCertificateDetail(object[] objArr)
        //{
        //    DataSet ds = dataprovider.ExecuteDataSet("usp_ACC_TRN_SURPRISECHECK_PRINT", objArr);
        //    return ds.Tables[0];
        //}



        public int GetSurpriceCheckCertificate(object[] objArr)
        {
            return dataprovider.ExecuteNonQuery("usp_ACC_TRN_SURPRISECHECK_PRINT", objArr);
        }


        public DataTable SurpriceCheckCertificateDetail(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_ACC_TRN_SURPRISECHECK_PRINT", objArr);
            return ds.Tables[0];
        }
        #endregion

        #region Comparative Statement
        public DataSet ComparativeStatementDetail(object[] objArr)
        {
           // DataSet ds = dataprovider.ExecuteDataSet("usp_ACC_Local_Purchase_Comparative_Statement_Sheet", objArr);
            DataSet ds = dataprovider.ExecuteDataSet("usp_ACC_Local_Purchase_Comparative_Sheet", objArr);
            return ds;
        }
        #endregion

        #region Call for Quotation
        public DataSet CallForQuotationDetails(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_ACC_CallForQuotaion", objArr);
            //DataSet ds = dataprovider.ExecuteDataSet("usp_ACC_CallForQuotaion_Print", objArr);
            return ds;
        }
        #endregion

        #region Call for Entry

        public int GetCallForEntry(object[] objArr)
        {
            return dataprovider.ExecuteNonQuery("usp_ACC_CallForEntry", objArr);
        }

        public DataSet CallForEntryDetail(object[] objArr)
        {
            //DataSet ds = dataprovider.ExecuteDataSet("usp_ACC_CallForEntry", objArr);
            DataSet ds = dataprovider.ExecuteDataSet("usp_ACC_CallForQuotaion_Print", objArr);
            return ds;
        }

        #endregion

        #region MonthClosing
        public DataTable MonthClosing_Fil(int mainAccId, int finYr)
        {
            DataTable dt = dataprovider.ExecuteDataTable("usp_ACC_MonthClosing_Fill", mainAccId, finYr);
            return dt;
        }

        public DataTable MonthClosing_GetUnverifdVouchrs(int mainAccId, int finYr, String lastClosingDate, String closingDate)
        {
            return dataprovider.ExecuteDataTable("usp_ACC_MonthClosing_GetUnverifdVouchrs", mainAccId, finYr, lastClosingDate, closingDate);
        }

        public DataSet MonthClosing_CheckVouchers(int mainAccId, int finYr, String lastClosingDate, String closingDate)
        {
            return dataprovider.ExecuteDataSet("usp_ACC_MonthClosing_Check", mainAccId, finYr, lastClosingDate, closingDate);
        }

        public int MonthClosing_Process(int mainAccId, int finYr, int monthId, String lastClosingDate, String closingDate, String ClosedBy,int FyClose)
        {
            return dataprovider.ExecuteNonQuery("usp_ACC_MonthClosing_Process", mainAccId, finYr, monthId, lastClosingDate, closingDate, ClosedBy, FyClose);
        }


        #endregion

        #region Financial Authority Sanction

        public int GetFinancialAuthoritySanction(object[] objArr)
        {
            return dataprovider.ExecuteNonQuery("usp_ACC_FinancialAuthoritySanction", objArr);
        }

        public DataSet FinancialAuthoritySanctionDetail(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_ACC_FinancialAuthoritySanction", objArr);
            return ds;
        }
        #endregion

        #region Distribution Templates
        public int InsertDistributionTemplates(object[] objArr)
        {
            return dataprovider.ExecuteNonQuery("Usp_Acc_Mst_NotingSheet_Distribution_Template", objArr);
        }

        public DataSet SelectDistributionTemplates(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("Usp_Acc_Mst_NotingSheet_Distribution_Template", objArr);
            return ds;
        }

        public DataTable GetDistributionTemplate(object[] objArr)
        {
            return dataprovider.ExecuteDataTable("Usp_Acc_Mst_NotingSheet_Distribution_Template", objArr);
        }

        public DataTable NotingSheet_Distribution_Template_Show(int MainAct_Id, int OFlag)
        {
            DataTable dt = dataprovider.ExecuteDataTable("Usp_Acc_Mst_NotingSheet_Distribution_Template_Show", MainAct_Id, OFlag);
            return dt;
        }
        #endregion

        #region Month Closing information//achla 1 dec
        public DataTable MonthClosingDetail(object[] objArr)
        {
            DataTable dt = dataprovider.ExecuteDataTable("usp_ACC_MonthClosing_information", objArr);
            return dt;
        }
        public DataTable getMonthDDL(int YearId, int MainAct_Id)
        {
            DataTable dt = dataprovider.ExecuteDataTable("usp_ACC_getMonthDDL", YearId, MainAct_Id);
            return dt;
        }
        #endregion

    }
}
