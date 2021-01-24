using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using DataTransmission;
using System.Data;
using SISDAPPS.DataAccessBlock;
using System.Collections;
using Microsoft.Data.SqlClient;

namespace BusinessBlock.HR
{
    public class HRUnit
    {
        DataProvider dataprovider = new DataProvider();
#region IncStrength
        public DataTable FillFromIncStrength(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_IncStrength", objArr);
            return ds.Tables[0];
        }

        public int UpdateFromIncStrength(object[] objArr)
        {
            int ds = dataprovider.ExecuteNonQuery("usp_HR_IncStrength", objArr);
            return ds;
        }

        //public DataTable UpdateFromIncStrength(object[] objArr)
        //{
        //    DataSet ds = dataprovider.ExecuteDataSet("usp_HR_IncStrength", objArr);
        //    return ds.Tables[0];
        //}
#endregion
#region INTRA UNIT Move
        public int insertIntraUnitMoveDetails(object[] obj)
        {
            return dataprovider.ExecuteNonQuery("usp_HR_IntraUnitMove", obj);
        }

        public DataTable FillIntraUnitMoveInfoGrid(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_IntraUnitMove", objArr);
            return ds.Tables[0];
        }

#endregion
#region Dynamic Query
        public int FillDynamicSch(object[] objArr)
        {
            int ds = dataprovider.ExecuteNonQuery("usp_DynamicQueryForSearch", objArr);
            return ds;
        }

#endregion
#region Military Training
        public DataSet GetTrgData(object[] objArr)
        {
            return dataprovider.ExecuteDataSet("usp_HR_TrgMil", objArr);
        }

        public DataSet UpdateTrgData(object[] obj)
        {
            return dataprovider.ExecuteDataSet("usp_HR_TrgMil", obj);
        }

#endregion
#region SportTraining
        public DataTable FillSportTraining(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_Sports", objArr);
            return ds.Tables[0];
        }

        public int insertSportTraining(object[] obj)
        {
            return dataprovider.ExecuteNonQuery("usp_HR_Sports", obj);
        }

#endregion
#region Former Service
        public int insertFormerServiceDetails(object[] obj)
        {
            return dataprovider.ExecuteNonQuery("usp_HR_FormerService", obj);
        }

        public DataTable FillFormerServiceInfoGrid(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_FormerService", objArr);
            return ds.Tables[0];
        }

#endregion
#region Qualifications
        public int insertQualificationsDetails(object[] obj)
        {
            return dataprovider.ExecuteNonQuery("usp_HR_QualificationNew", obj);
        }

        public DataTable FillQualificationsInfoGrid(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_QualificationNew", objArr);
            return ds.Tables[0];
        }

#endregion
#region PartIIDraft
        public int insertPartToDraftDetails(object[] obj)
        {
            return dataprovider.ExecuteNonQuery("usp_HR_PtoJCOsDraft", obj);
        }

        public DataTable FillPartToDraftInfoGrid(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_PtoJCOsDraft", objArr);
            return ds.Tables[0];
        }

#endregion
#region LanguagesPInfo
        public int insertLanguagesPInfoDetails(object[] obj)
        {
            return dataprovider.ExecuteNonQuery("usp_HR_Languages", obj);
        }

#region ArmyCourses
        public int insertArmyCoursesDetails(object[] obj)
        {
            return dataprovider.ExecuteNonQuery("usp_HR_ArmyCourses", obj);
        }

        public DataTable FillArmyCoursesInfoGrid(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_ArmyCourses", objArr);
            return ds.Tables[0];
        }

#endregion
        public DataTable FillLanguagesPInfoInfoGrid(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_Languages", objArr);
            return ds.Tables[0];
        }

#endregion
#region LeaveConfiguration
        public int insertLeaveConfigurationDetails(object[] obj)
        {
            return dataprovider.ExecuteNonQuery("usp_HR_LeaveConfiguration", obj);
        }

        public DataTable FillLeaveConfigurationInfoGrid(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_LeaveConfiguration", objArr);
            return ds.Tables[0];
        }

#endregion
#region LeaveApplication
#region Approve_Leave
        public int insertApproveLeaveDetails(object[] obj)
        {
            return dataprovider.ExecuteNonQuery("usp_HR_LeaveApplication1", obj);
        }

        public DataTable FillApproveLeaveInfoGrid(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_LeaveApplication1", objArr);
            return ds.Tables[0];
        }

#endregion
        //public int insertLeaveAppDetails(object[] obj)
        //{
        //    return dataprovider.ExecuteNonQuery("usp_HR_LeaveApplication", obj);
        //}
        //public DataTable FillLeaveAppGrid(object[] objArr)
        //{
        //    DataTable dt = dataprovider.ExecuteDataTable("usp_HR_LeaveApplication", objArr);
        //    return dt;
        //}
        public int insertLeaveAppDetails(object[] obj)
        {
            return dataprovider.ExecuteNonQuery("usp_HR_LeaveMerged", obj);
        }

        public DataTable FillLeaveAppGrid(object[] objArr)
        {
            DataTable dt = dataprovider.ExecuteDataTable("usp_HR_LeaveMerged", objArr);
            return dt;
        }

#endregion
#region LeaveCertificate
        public int insertLeaveCertiDetails(object[] obj)
        {
            return dataprovider.ExecuteNonQuery("usp_HR_LeaveCertificate", obj);
        }

        public DataSet FillLeaveCertiGrid(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_LeaveCertificate", objArr);
            return ds;
        }

        public DataSet FillLeaveAppCertiGrid(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_LeaveAppCertificate", objArr);
            return ds;
        }

#endregion
#region LvCertiRlyWrt
        public int insertRTUDetails(object[] obj)
        {
            return dataprovider.ExecuteNonQuery("usp_HR_RTUStrength", obj);
        }

        public int insertLvRlyWrtDetails(object[] obj)
        {
            return dataprovider.ExecuteNonQuery("usp_HR_LvCertiRlyWrt", obj);
        }

        public DataTable FillLvCertRlyWrtInfoGrid(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_LvCertiRlyWrt", objArr);
            return ds.Tables[0];
        }

        // End Function
#endregion
#region Ration
        public int insertRationDetails(object[] obj)
        {
            return dataprovider.ExecuteNonQuery("usp_HR_Ration", obj);
        }

        public DataTable FillRationDetails(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_Ration", objArr);
            return ds.Tables[0];
        }

#endregion
#region Will
        public int insertWillDetails(object[] obj)
        {
            return dataprovider.ExecuteNonQuery("usp_HR_Will", obj);
        }

        public DataTable FillWillDetails(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_Will", objArr);
            return ds.Tables[0];
        }

#endregion
#region Authority Offc
        public DataTable FillAuthorityInfoGrid(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_Authority_PII_Off", objArr);
            return ds.Tables[0];
        }

        public int insertAuthorityDetails(object[] obj)
        {
            return dataprovider.ExecuteNonQuery("usp_HR_Authority_PII_Off", obj);
        }

#endregion
#region Remarks Offc
        public DataTable FillRemarksInfoGrid(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_RemarksOffc", objArr);
            return ds.Tables[0];
        }

#endregion
#region Notes Offc
        public DataTable FillNotesInfoGrid(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_NotesOffc", objArr);
            return ds.Tables[0];
        }

#endregion
#region CertificatP2JCO
        public DataTable FillCertificatP2JCOInfoGrid(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_CertificatesPIIJCOOR", objArr);
            return ds.Tables[0];
        }

#endregion
#region CertificatP2JCO
        public int insertCertificatP2JCODetails(object[] obj)
        {
            return dataprovider.ExecuteNonQuery("usp_HR_CertificatesPIIJCOOR", obj);
        }

#endregion
#region CasualityOfficer
        public DataTable FillCasualityOfficerInfoGrid(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("USP_HR_PIICasualtyOff", objArr);
            return ds.Tables[0];
        }

#endregion
#region Certificate OFF
        public int insertCertificateDetails(object[] obj)
        {
            return dataprovider.ExecuteNonQuery("usp_HR_CertificatesPIIOff", obj);
        }

        public DataTable FillCertificateInfoGrid(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_CertificatesPIIOff", objArr);
            return ds.Tables[0];
        }

#endregion
#region TradeMaster
        public int insertTradeDetails(object[] obj)
        {
            return dataprovider.ExecuteNonQuery("usp_HR_MTrade", obj);
        }

        public DataTable FillTradeDetails(object[] obArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_MTrade", obArr);
            return ds.Tables[0];
        }

#endregion
#region ERE
        public int insertEREDetails(object[] obj)
        {
            return dataprovider.ExecuteNonQuery("usp_HR_ToERE", obj);
        }

        public DataTable FillEREDetails(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_ToERE", objArr);
            return ds.Tables[0];
        }

#endregion
        //#region AppoinmentServices
        //public int insertAppoinmentDetails(object[] obj)
        //{
        //    return dataprovider.ExecuteNonQuery("usp_HR_Appoinment", obj);
        //}
        //public DataTable FillAppoinmentInfoGrid(object[] objArr)
        //{
        //    DataSet ds = dataprovider.ExecuteDataSet("usp_HR_Appoinment", objArr);
        //    return ds.Tables[0];
        //}
        //#endregion
#region AppoinmentServices
        public int insertAppoinmentDetails(object[] obj)
        {
            return dataprovider.ExecuteNonQuery("usp_HR_AppoinmentServices", obj);
        }

        public DataTable FillAppoinmentInfoGrid(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_AppoinmentServices", objArr);
            return ds.Tables[0];
        }

#endregion
#region Language
        public DataTable getLanguageDetail(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_mLanguage", objArr);
            return ds.Tables[0];
        }

        public int insertLanguageDetails(object[] obj)
        {
            return dataprovider.ExecuteNonQuery("usp_HR_mLanguage", obj);
        }

        public DataTable FillLanguageInfoGrid(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_mLanguage", objArr);
            return ds.Tables[0];
        }

#endregion
#region Religion
        public DataTable getReligionDetail(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_mReligion", objArr);
            return ds.Tables[0];
        }

        public int insertReligionDetails(object[] obj)
        {
            return dataprovider.ExecuteNonQuery("usp_HR_mReligion", obj);
        }

        public DataTable FillReligionInfoGrid(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_mReligion", objArr);
            return ds.Tables[0];
        }

#endregion
#region Sport
        public DataTable getSportDetail(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_mSport", objArr);
            return ds.Tables[0];
        }

        public DataTable FillSportInfoGrid(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_mSport", objArr);
            return ds.Tables[0];
        }

        public int insertSportDetails(object[] obj)
        {
            return dataprovider.ExecuteNonQuery("usp_HR_mSport", obj);
        }

#endregion
#region Country
        public DataTable getCountryDetail(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_mCountry", objArr);
            return ds.Tables[0];
        }

        public int insertCountryDetails(object[] obj)
        {
            return dataprovider.ExecuteNonQuery("usp_HR_mCountry", obj);
        }

        public DataTable FillCountryInfoGrid(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_mCountry", objArr);
            return ds.Tables[0];
        }

#endregion
#region State
        public DataTable getStateDetail(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_StateDetails", objArr);
            return ds.Tables[0];
        }

        public DataTable FillStateInfoGrid(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_mState", objArr);
            return ds.Tables[0];
        }

        public int insertStateDetails(object[] obj)
        {
            return dataprovider.ExecuteNonQuery("usp_HR_mState", obj);
        }

#endregion
#region District
        public DataTable getDistrictDetail(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_mDistrict", objArr);
            return ds.Tables[0];
        }

        public DataTable FillDistrictInfoGrid(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_mDistrict", objArr);
            return ds.Tables[0];
        }

        public int insertDistrictDetails(object[] obj)
        {
            return dataprovider.ExecuteNonQuery("usp_HR_mDistrict", obj);
        }

#endregion
#region Smart Search added by Jatinder 230511
        public DataTable FillSmartSrchGrid(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_SmartSearch", objArr);
            return ds.Tables[0];
        }

#endregion
#region PostingOut
        public int insertPostingOutDetails(object[] obj)
        {
            return dataprovider.ExecuteNonQuery("usp_HR_PostingOut", obj);
        }

        public DataTable FillPostingOutDetails(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_GetPosout", objArr);
            return ds.Tables[0];
        }

#endregion
#region ToCourse
        public int insertToCourseDetails(object[] obj)
        {
            return dataprovider.ExecuteNonQuery("usp_HR_TOCourse", obj);
        }

        public DataTable FillToCourseInfoGrid(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_TOCourse", objArr);
            return ds.Tables[0];
        }

#endregion
#region Pending Move Out
        public DataTable fillStrTillDateGrid()
        {
            DataSet ds = dataprovider.ExecuteDataSet("fillStrTillDateGrid");
            return ds.Tables[0];
        }

#endregion
#region Get Strength Increased Till Input Date
        public DataTable fillStrTillDateGrid(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_StrengthASonDate", objArr);
            return ds.Tables[0];
        }

#endregion
#region Get Strength Decreased Till Today's Date
        public DataTable fillStrDecTillDateGrid()
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_StrengthDecTillDate");
            return ds.Tables[0];
        }

#endregion
#region Course
        public DataSet FillCourseGrid1(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_TrgCourse", objArr);
            return ds;
        }

        public DataTable FillCourseLetterGrid(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_CourseLetterDetails", objArr);
            return ds.Tables[0];
        }

        public DataTable FillInstituteDetail(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_InstituteConductingCourse", objArr);
            return ds.Tables[0];
        }

        public DataTable FillCourseDetailmentDetail(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_NominatedPers", objArr);
            return ds.Tables[0];
        }

        public DataTable FillQualificationReqdDetail(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_QualificationReqd", objArr);
            return ds.Tables[0];
        }

        public int insertCourseDetails(object[] obj)
        {
            return dataprovider.ExecuteNonQuery("usp_HR_TrgCourse", obj);
        }

        public DataTable FillCourseNominationDetail(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_CourseNominations", objArr);
            return ds.Tables[0];
        }

        public int insertNominees(object[] obj)
        {
            return dataprovider.ExecuteNonQuery("usp_HR_CourseNominations", obj);
        }

#endregion
#region FromStation
        public DataTable FillStnGrid(object[] objArr)
        {
            DataTable dt = dataprovider.ExecuteDataTable("usp_HR_GetStn", objArr);
            return dt;
        }

        public int insertStrengthStn(object[] obj)
        {
            return dataprovider.ExecuteNonQuery("usp_HR_Stn", obj);
        }

#endregion
#region signatories
        public DataTable getsignatoriesDetail(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_Signatories", objArr);
            return ds.Tables[0];
        }

        public int insertsignatoriesDetails(object[] obj)
        {
            return dataprovider.ExecuteNonQuery("usp_HR_Signatories", obj);
        }

#endregion
        public DataTable getUnitDetail(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_UnitDetails", objArr);
            return ds.Tables[0];
        }

        public int insertUnitDetails(object[] obj)
        {
            return dataprovider.ExecuteNonQuery("usp_HR_UnitDetails", obj);
        }

        public int insertApptDetails(object[] obj)
        {
            return dataprovider.ExecuteNonQuery("usp_HR_Appointments", obj);
        }

        public int insertFormationDetails(object[] obj)
        {
            return dataprovider.ExecuteNonQuery("usp_HR_FormationType", obj);
        }

        public DataTable FillFormationInfoGrid(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_FormationType", objArr);
            return ds.Tables[0];
        }

        public int insertMRankDetails(object[] obj)
        {
            return dataprovider.ExecuteNonQuery("usp_HR_mrank", obj);
        }

        public int insertRankOffDetails(object[] obj)
        {
            return dataprovider.ExecuteNonQuery("usp_HR_RankOfficers", obj);
        }

        public DataTable FillRankInfoGrid(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_RankOfficers", objArr);
            return ds.Tables[0];
        }

        //public DataSet getUnitDetails()
        //{
        //    DataSet ds = dataprovider.ExecuteDataSet("getUnitDetail");
        //    return ds;
        //}
        public DataTable FillApptInfoGrid(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_Appointments", objArr);
            return ds.Tables[0];
        }

        public DataTable FillDuesInGrid(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_DuesInPersonnel1", objArr);
            return ds.Tables[0];
        }

        //public DataSet FillApptInfoGrid()
        //{
        //    DataSet ds = dataprovider.ExecuteDataSet("usp_HR_Appointments");
        //    return ds;
        //}
        public DataTable getCity(string DataTextField, string DataValueField, string TableName, string WhereColumn, string Wherevalue)
        {
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[2]{new DataColumn("Location_ID", typeof(int)), new DataColumn("Location_Name", typeof(string))});
            dt.Rows.Add(1, "Noida");
            dt.Rows.Add(2, "Delhi");
            dt.Rows.Add(3, "Mumbai");
            //DataTable dt = dataprovider.getDTForCombo(DataTextField, DataValueField, TableName, WhereColumn, Wherevalue);
            return dt;
        }

        public DataTable getDDLData(string DataTextField, string DataValueField, string TableName, string WhereColumn, string Wherevalue)
        {
            DataTable dt = dataprovider.getDTForCombo(DataTextField, DataValueField, TableName, WhereColumn, Wherevalue);
            return dt;
        }

        public int insertCommandDetails(object[] obj)
        {
            return dataprovider.ExecuteNonQuery("usp_HR_Command", obj);
        }

        public DataTable FillCommandInfoGrid(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_Command", objArr);
            return ds.Tables[0];
        }

        public int insertCampaignDetails(object[] obj)
        {
            return dataprovider.ExecuteNonQuery("usp_HR_Campaign", obj);
        }

        public DataTable FillCampaignInfoGrid(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_Campaign", objArr);
            return ds.Tables[0];
        }

        public int duesInDetails(object[] obj)
        {
            return dataprovider.ExecuteNonQuery("usp_HR_DuesInPersonnel1", obj);
        }

        public int insertWEPEAuthorizationDetails(object[] obj)
        {
            return dataprovider.ExecuteNonQuery("uspHRMasterWEPEAuthType", obj);
        }

        public DataTable FillWEPEAuthorizationInfoGrid(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("uspHRMasterWEPEAuthType", objArr);
            return ds.Tables[0];
        }

        public DataTable getPersinfofromBasicHRData(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("ImportandMapBasicDetails", objArr);
            return ds.Tables[0];
        }

        public Int32 InsertBasicHRPersonalData(object[] objArr)
        {
            return dataprovider.ExecuteNonQuery("ImportandMapBasicDetails", objArr);
        }

#region ASAuthorization
        public int insertASAuthorizationDetails(object[] obj)
        {
            return dataprovider.ExecuteNonQuery("uspHRMasterAuthorizationType", obj);
        }

        public DataTable FillASAuthorizationInfoGrid(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("uspHRMasterAuthorizationType", objArr);
            return ds.Tables[0];
        }

#endregion
#region LanguageProficiencyMaster
        public int insertLangProficiencyDetails(object[] obj)
        {
            return dataprovider.ExecuteNonQuery("usp_HR_LanguageProficiency", obj);
        }

        public DataTable FillLangProficiencyInfoGrid(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_LanguageProficiency", objArr);
            return ds.Tables[0];
        }

#endregion
#region CommisionInstitution
        public int insertCommisionInstDetails(object[] obj)
        {
            return dataprovider.ExecuteNonQuery("usp_HR_ComissionInstitution", obj);
        }

        public DataTable FillCommisionInstGrid(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_ComissionInstitution", objArr);
            return ds.Tables[0];
        }

#endregion
#region DuesOut
        public DataTable FillDuesOutGrid(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_DuesOutPersonnel", objArr);
            return ds.Tables[0];
        }

        public int DuesOutDetails(object[] obj)
        {
            return dataprovider.ExecuteNonQuery("usp_HR_DuesOutPersonnel", obj);
        }

#endregion
#region PersonalInfo
        public DataSet getPersonalInfo()
        {
            DataSet ds = dataprovider.ExecuteDataSet("getPersonalInfo");
            return ds;
        }

#endregion
#region GeneralDetails
        public int insertGeneralDetails(object[] obj)
        {
            return dataprovider.ExecuteNonQuery("usp_HR_ArmyPersonnelDetail", obj);
        }

        public DataTable FillGeneralGrid(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_ArmyPersonnelDetail", objArr);
            return ds.Tables[0];
        }

#endregion
        //public DataTable fillStrTillDateGrid()
        //{
        //    DataSet ds = dataprovider.ExecuteDataSet("usp_HR_StrengthIncrTillDate");
        //    return ds.Tables[0];
        //}
#region strength decrease
        public int insertStrengthDecrease(object[] objArr)
        {
            return dataprovider.ExecuteNonQuery("usp_HR_Strength", objArr);
        }

        public DataTable FillRTUInfoGrid(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_Strength", objArr);
            return ds.Tables[0];
        }

        public DataTable FillRTUGrid(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_RTUStrength", objArr);
            return ds.Tables[0];
        }

        public int decreaseFromStrength(object[] objArr)
        {
            return dataprovider.ExecuteNonQuery("usp_HR_DeleteFromStrength", objArr);
        }

        public int decreaseFromStrengthInc(object[] objArr)
        {
            return dataprovider.ExecuteNonQuery("usp_HR_DeleteFromStrengthInc", objArr);
        }

#endregion
#region Banker
        //public int insertBanker
#endregion
#region Deduction Offc
        public DataTable FillDeducTypeInfoGrid(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_DeductionOffc", objArr);
            return ds.Tables[0];
        }

#endregion
#region Deduction Offc
        public int insertDeducTypeDetails(object[] obj)
        {
            return dataprovider.ExecuteNonQuery("usp_HR_DeductionOffc", obj);
        }

#endregion
#region LeaveType
        public int insertLeaveTypeDetails(object[] obj)
        {
            return dataprovider.ExecuteNonQuery("usp_HR_LeaveType", obj);
        }

#endregion
#region LeaveType
        public DataTable FillLeaveTypeInfoGrid(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_LeaveType", objArr);
            return ds.Tables[0];
        }

#endregion
#region FROM_ADM
        public DataTable FillAdmGrid(object[] objArr)
        {
            DataTable ds = dataprovider.ExecuteDataTable("usp_HR_GetAdm", objArr);
            return ds;
        }

        public int insertStrengthAdm(object[] obj)
        {
            return dataprovider.ExecuteNonQuery("usp_HR_Adm", obj);
        }

#endregion
#region PostingIn
        public int insertStrength(object[] obj)
        {
            return dataprovider.ExecuteNonQuery("usp_HR_PostingIn", obj);
        }

#endregion
#region FromCourse
        public DataTable FillCourseGrid(object[] objArr)
        {
            DataTable dt = dataprovider.ExecuteDataTable("usp_HR_GetCourse", objArr);
            return dt;
        }

        public int InsertFromCourse(object[] obj)
        {
            return dataprovider.ExecuteNonQuery("usp_HR_Course", obj);
        }

        //public int updateHospital(object[] obj)
        //{
        //    return dataprovider.ExecuteNonQuery("usp_HR_FromCourse", obj);
        //}
#endregion
#region Hospital
        public int insertToHospital(object[] obj)
        {
            return dataprovider.ExecuteNonQuery("usp_HR_SelectAndUpdateFromHospital", obj);
        }

        public DataTable FillFromHospital(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_SelectAndUpdateFromHospital", objArr);
            return ds.Tables[0];
        }

        // End Function
#endregion
#region PersonalAditional
        public int insertAditionalDetail(object[] obj)
        {
            return dataprovider.ExecuteNonQuery("usp_HR_ArmyPersAdditional", obj);
        }

        public DataTable FillAditionalDetail(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_ArmyPersAdditional", objArr);
            return ds.Tables[0];
        }

#endregion
#region Banker
        public int insertBankerDetail(object[] obj)
        {
            return dataprovider.ExecuteNonQuery("usp_HR_ArmyPersBankers", obj);
        }

        public DataTable FillBankDetails(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_ArmyPersBankers", objArr);
            return ds.Tables[0];
        }

#endregion
#region CommissionPersonal
        public int insertCommPersonal(object[] obj)
        {
            return dataprovider.ExecuteNonQuery("usp_HR_PersCommission", obj);
        }

        public DataTable FillCommPersonal(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_PersCommission", objArr);
            return ds.Tables[0];
        }

#endregion
#region IdentityPersonal
        public int insertIdentityPersonal(object[] obj)
        {
            return dataprovider.ExecuteNonQuery("usp_HR_ArmyPersIdentity", obj);
        }

        public DataTable FillIdentityPersonal(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_ArmyPersIdentity", objArr);
            return ds.Tables[0];
        }

#endregion
#region FamilyPersonal
        public int insertFamily(object[] obj)
        {
            return dataprovider.ExecuteNonQuery("usp_HR_ArmyPersFamily", obj);
        }

        public DataTable FillFamilyDetails(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_ArmyPersFamily", objArr);
            return ds.Tables[0];
        }

#endregion
#region ArmyPersAddress
        public int insertPersonalAdress(object[] obj)
        {
            return dataprovider.ExecuteNonQuery("usp_HR_ArmyPersAddress", obj);
        }

        public DataTable FillPersonalAdress(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_ArmyPersAddress", objArr);
            return ds.Tables[0];
        }

#endregion
#region ArmyPersFundPolicy
        public int insertPersonalFundPolicy(object[] obj)
        {
            return dataprovider.ExecuteNonQuery("usp_HR_ArmyPersFundPolicy", obj);
        }

        public DataTable FillPersonalFundPolicy(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_ArmyPersFundPolicy", objArr);
            return ds.Tables[0];
        }

#endregion
#region ArmyPersHospitalRecord
        public int insertHospitalRecord(object[] obj)
        {
            return dataprovider.ExecuteNonQuery("usp_HR_ArmyPersHospRecords", obj);
        }

        public DataTable FillHospitalRecord(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_ArmyPersHospRecords", objArr);
            return ds.Tables[0];
        }

#endregion
#region ArmyPersMedCatDetail
        public int insertMedCatDetail(object[] obj)
        {
            return dataprovider.ExecuteNonQuery("usp_HR_ArmyPersMedCatDetail", obj);
        }

        public DataTable FillMedCatDetail(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_ArmyPersMedCatDetail", objArr);
            return ds.Tables[0];
        }

#endregion
#region ArmyPersMedExamDetail
        public int insertMedExamDetail(object[] obj)
        {
            return dataprovider.ExecuteNonQuery("usp_HR_ArmyPersnlMedExam", obj);
        }

        public DataTable FillMedExamDetail(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_ArmyPersnlMedExam", objArr);
            return ds.Tables[0];
        }

#endregion
#region AuthorizationArmService
        public DataSet insertAuthorizationArmService(object[] obj)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_MST_AuthOffcrsJCOsORs", obj);
            return ds;
        }

        public DataSet FillAuthorizationArmService(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_MST_AuthOffcrsJCOsORs", objArr);
            return ds;
        }

#endregion
#region Distribution
        public DataSet insertDistribution(object[] obj)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_Distribution", obj);
            return ds;
        }

        public DataSet FillDistribution(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_Distribution", objArr);
            return ds;
        }

#endregion
#region PTORecordOffice
        public int insertPTORecordOffice(object[] obj)
        {
            return dataprovider.ExecuteNonQuery("usp_HR_PTO_RecordOffice", obj);
        }

        public DataTable FillPTORecordOffice(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_PTO_RecordOffice", objArr);
            return ds.Tables[0];
        }

#endregion
#region LeaveStatus
        public int insertLeaveStatus(object[] obj)
        {
            return dataprovider.ExecuteNonQuery("usp_HR_LeaveStatus", obj);
        }

        public DataSet FillLeaveStatus(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_LeaveStatus", objArr);
            return ds;
        }

#endregion
        //#region strength decrease
        //public int insertStrengthDecrease(object[] objArr)
        //{
        //    return dataprovider.ExecuteNonQuery("usp_HR_Strength", objArr);
        //}
        //#endregion
#region OnAttachment
        public DataTable FillOnAttGrid(object[] objArr)
        {
            DataTable ds = dataprovider.ExecuteDataTable("usp_HR_OnAtt", objArr);
            return ds;
        }

        public int OnAttDetail(object[] obj)
        {
            return dataprovider.ExecuteNonQuery("usp_HR_OnAtt", obj);
        }

#endregion
#region OnTD
        public DataTable FillOnTDGrid(object[] objArr)
        {
            DataTable ds = dataprovider.ExecuteDataTable("usp_HR_OnTD", objArr);
            return ds;
        }

        public int OnTDDetail(object[] obj)
        {
            return dataprovider.ExecuteNonQuery("usp_HR_OnTD", obj);
        }

#endregion
#region ARO
        public DataTable getBRODetail(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_mbro", objArr);
            return ds.Tables[0];
        }

        public int insertBRODetails(object[] obj)
        {
            return dataprovider.ExecuteNonQuery("usp_HR_mbro", obj);
        }

        public DataTable FillBROInfoGrid(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_mbro", objArr);
            return ds.Tables[0];
        }

#endregion
#region Note
        public DataTable getNoteJCODetail(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_NotesPIIJCOOR", objArr);
            return ds.Tables[0];
        }

        public int insertNoteJCODetails(object[] obj)
        {
            return dataprovider.ExecuteNonQuery("usp_HR_NotesPIIJCOOR", obj);
        }

        public DataTable FillNoteJCOInfoGrid(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_NotesPIIJCOOR", objArr);
            return ds.Tables[0];
        }

#endregion
#region Remarks
        public DataTable getRemarksJCODetail(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_RemarksPIIJCOOR", objArr);
            return ds.Tables[0];
        }

        public int insertRemarksJCODetails(object[] obj)
        {
            return dataprovider.ExecuteNonQuery("usp_HR_RemarksPIIJCOOR", obj);
        }

        public DataTable FillRemarksJCOInfoGrid(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_RemarksPIIJCOOR", objArr);
            return ds.Tables[0];
        }

#endregion
#region REJOIN
        public DataTable FillrejGrid(object[] objArr)
        {
            DataTable ds = dataprovider.ExecuteDataTable("usp_HR_Rejoin", objArr);
            return ds;
        }

        public int insertRejDetail(object[] obj)
        {
            return dataprovider.ExecuteNonQuery("usp_HR_Rejoin", obj);
        }

#endregion
        //for welcome table , added by shilpi
#region LeaveDetails
        public DataTable GetleaveDetails(String armyNo)
        {
            DataTable dt = dataprovider.ExecuteDataTable("usp_HR_TotalAndAvailedLeave", armyNo);
            return dt;
        }

#endregion
#region "UnitHierarchy Tree Details Admin"
        public DataSet Select_UnitHierarchyTree(object[] objArr)
        {
            return dataprovider.ExecuteDataSet("usp_HR_TRN_Insert1_Node_UnitHierarchyTemplates", objArr);
        }

        public int update_UnitHierarchy(object[] objArr)
        {
            //DataSet ds1;
            return dataprovider.ExecuteNonQuery("usp_HR_TRN_Insert1_Node_UnitHierarchyTemplates", objArr);
        }

        public int Insert_UnitHierarchy(object[] objArr)
        {
            //DataSet ds1;
            return dataprovider.ExecuteNonQuery("usp_HR_TRN_Insert1_Node_UnitHierarchyTemplates", objArr);
        }

        public int Delete_UnitHierarchy(object[] objArr)
        {
            //DataSet ds1;
            return dataprovider.ExecuteNonQuery("usp_HR_TRN_Insert1_Node_UnitHierarchyTemplates", objArr);
        }

#endregion
#region FundPolicyMaster
        public int insertFundPolicyDetails(object[] obj)
        {
            return dataprovider.ExecuteNonQuery("usp_HR_FundPolicy", obj);
        }

        public DataTable FillFundPolicyInfoGrid(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_FundPolicy", objArr);
            return ds.Tables[0];
        }

#endregion
#region CommisionDetails
        public int insertCommisionDetails(object[] obj)
        {
            return dataprovider.ExecuteNonQuery("usp_HR_ComissionType", obj);
        }

        public DataTable FillCommisionDetailGrid(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_ComissionType", objArr);
            return ds.Tables[0];
        }

#endregion
#region AssingmenrPurposeMaster
        public DataTable getAssingmenrPurposeMasterDetail(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_AssignmentPurposeMaster", objArr);
            return ds.Tables[0];
        }

        public int insertAssingmenrPurposeMasterDetails(object[] obj)
        {
            return dataprovider.ExecuteNonQuery("usp_HR_AssignmentPurposeMaster", obj);
        }

        public DataTable FillAssingmenrPurposeMasterInfoGrid(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_AssignmentPurposeMaster", objArr);
            return ds.Tables[0];
        }

#endregion
#region SportLevel
        public DataTable getSportLevelDetail(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_mSportLevel", objArr);
            return ds.Tables[0];
        }

        public DataTable FillSportLevelInfoGrid(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_mSportLevel", objArr);
            return ds.Tables[0];
        }

        public int insertSportLevelDetails(object[] obj)
        {
            return dataprovider.ExecuteNonQuery("usp_HR_mSportLevel", obj);
        }

#endregion
#region MedalsDecoration
        public DataTable getMedalsDecorationDetail(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_mMedel", objArr);
            return ds.Tables[0];
        }

        public DataTable FillMedalDecorationInfoGrid(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_mMedel", objArr);
            return ds.Tables[0];
        }

        public int insertMedalDecorationDetails(object[] obj)
        {
            return dataprovider.ExecuteNonQuery("usp_HR_mMedel", obj);
        }

#endregion
#region LanguageProficiency
        public DataTable getLanguageProficiencyDetail(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_LanguageProficiency", objArr);
            return ds.Tables[0];
        }

        public DataTable FillLanguageProficiencyInfoGrid(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_LanguageProficiency", objArr);
            return ds.Tables[0];
        }

        public int insertLanguageProficiencyDetails(object[] obj)
        {
            return dataprovider.ExecuteNonQuery("usp_HR_LanguageProficiency", obj);
        }

#endregion
#region QualificationName
        public DataTable getQualificationNameDetail(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_mQualificationName", objArr);
            return ds.Tables[0];
        }

        public int insertQualificationNameDetails(object[] obj)
        {
            return dataprovider.ExecuteNonQuery("usp_HR_mQualificationName", obj);
        }

        public DataTable FillQualificationNameInfoGrid(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_mQualificationName", objArr);
            return ds.Tables[0];
        }

#endregion
#region LeaveTypePInfo
        public DataTable getLeaveTypePInfoDetail(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_LeaveTypePInfo", objArr);
            return ds.Tables[0];
        }

        public int insertLeaveTypePInfoDetails(object[] obj)
        {
            return dataprovider.ExecuteNonQuery("usp_HR_LeaveTypePInfo", obj);
        }

        public DataTable FillLeaveTypePInfoInfoGrid(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_LeaveTypePInfo", objArr);
            return ds.Tables[0];
        }

#endregion
#region Deduction type
        public DataTable FillDeductionTypeInfoGrid(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_DeductionType", objArr);
            return ds.Tables[0];
        }

        public int insertDeductionTypeDetails(object[] obj)
        {
            return dataprovider.ExecuteNonQuery("usp_HR_DeductionType", obj);
        }

#endregion
#region ACR
        public int insertACRDetails(object[] obj)
        {
            return dataprovider.ExecuteNonQuery("usp_HR_ACR", obj);
        }

        public DataTable FillACRInfoGrid(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_ACR", objArr);
            return ds.Tables[0];
        }

#endregion
        //#region AppoinmentServices
        //public int insertAppoinmentDetails(object[] obj)
        //{
        //    return dataprovider.ExecuteNonQuery("usp_HR_AppoinmentServices", obj);
        //}
        //public DataTable FillAppoinmentInfoGrid(object[] objArr)
        //{
        //    DataSet ds = dataprovider.ExecuteDataSet("usp_HR_AppoinmentServices", objArr);
        //    return ds.Tables[0];
        //}
        //#endregion
#region Medal And Decore
        public int insertMedalsAndDecorationDetails(object[] obj)
        {
            return dataprovider.ExecuteNonQuery("usp_HR_Decoration_Medals", obj);
        }

        public DataTable FillMedalsAndDecorationInfoGrid(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_Decoration_Medals", objArr);
            return ds.Tables[0];
        }

#endregion
#region PromotionExam
        public int insertPromotionExamDetails(object[] obj)
        {
            return dataprovider.ExecuteNonQuery("usp_HR_PROMOTIONEXAM", obj);
        }

        public DataTable FillPromotionExamInfoGrid(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_PROMOTIONEXAM", objArr);
            return ds.Tables[0];
        }

#endregion
#region Promotions
        public int insertPromotionsDetails(object[] obj)
        {
            return dataprovider.ExecuteNonQuery("usp_HR_ROUTINEPROMOTION", obj);
        }

        public DataTable FillPromotionsInfoGrid(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_ROUTINEPROMOTION", objArr);
            return ds.Tables[0];
        }

#endregion
#region Discpline
        public int insertDiscplineDetails(object[] obj)
        {
            return dataprovider.ExecuteNonQuery("usp_HR_OffenceDiscpline", obj);
        }

        public DataTable FillDiscplineInfoGrid(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_OffenceDiscpline", objArr);
            return ds.Tables[0];
        }

#endregion
#region ForeignVisit
        public int insertForeignVisitDetails(object[] obj)
        {
            return dataprovider.ExecuteNonQuery("usp_HR_ForeignVisit", obj);
        }

#endregion
#region ForeignVisit
        public DataTable FillForeignVisitInfoGrid(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_ForeignVisit", objArr);
            return ds.Tables[0];
        }

#endregion
#region LICPersonal
        public int insertLIC(object[] obj)
        {
            return dataprovider.ExecuteNonQuery("usp_HR_ArmyPersLIC", obj);
        }

        public DataTable FillLIC(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_ArmyPersLIC", objArr);
            return ds.Tables[0];
        }

#endregion
#region ORtoJCO
        public DataSet insertORtoJCO(object[] obj)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_ORtoJCO", obj);
            return ds;
        }

        public DataSet fillORtoJCO(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_ORtoJCO", objArr);
            return ds;
        }
#endregion
    }
}