using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using SISDAPPS.DataAccessBlock;
using System.Collections;

namespace BusinessBlock.Common
{
    public partial class CommonBlock
    {
        DataProvider dataprovider = new DataProvider();

        #region UnitDetailOnLogin
        public DataSet FillUnit(object[] obj)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_COMM_UnitLogin", obj);
            return ds;
        }
        #endregion

        #region Header
        public int insertHeaderDetails(object[] obj)
        {

            return dataprovider.ExecuteNonQuery("usp_COMM_Header", obj);
        }


        public DataTable FillHeaderInfoGrid(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_COMM_Header", objArr);
            return ds.Tables[0];
        }

        #endregion

        #region Portal Unit Details

        public int insertPortalUnitDetails(object[] obj)
        {
            return dataprovider.ExecuteNonQuery("usp_COMM_PortalConfig", obj);
        }

        public DataTable getPortalUnitDetails(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_COMM_PortalConfig", objArr);
            return ds.Tables[0];
        }

        public DataTable FillPortalUnitDetails(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_COMM_PortalConfig", objArr);
            return ds.Tables[0];
        }

        #endregion

        #region Holiday Calender
        public int insertHolidayCalenderDetails(object[] obj)
        {
            return dataprovider.ExecuteNonQuery("usp_HolidayCalendar", obj);
        }

        public DataTable getHolidayCalenderDetails(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HolidayCalendar", objArr);
            return ds.Tables[0];
        }

        public DataTable FillHolidayCalenderDetails(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HolidayCalendar", objArr);
            return ds.Tables[0];
        }

        #endregion

        #region NoticeBoard
        public int insertNoticeBoardDetails(object[] obj)
        {

            return dataprovider.ExecuteNonQuery("usp_COMM_NoticeBoard", obj);
        }

        public DataTable getNoticeBoardDetail(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_COMM_NoticeBoard", objArr);
            return ds.Tables[0];

        }


        public DataTable FillNoticeBoardInfoGrid(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_COMM_NoticeBoard", objArr);
            return ds.Tables[0];
        }

        #endregion

        #region Upcoming Events

        public int insertUpcomingEventDetails(object[] obj)
        {

            return dataprovider.ExecuteNonQuery("usp_COMM_UpcomingEvent", obj);
        }

        public DataTable getUpcomingEventDetail(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_COMM_UpcomingEvent", objArr);
            return ds.Tables[0];

        }

        public DataTable FillUpcomingEventInfoGrid(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_COMM_UpcomingEvent", objArr);
            return ds.Tables[0];
        }

        #endregion

        #region Social Calender

        public int insertSocialCalenderDetails(object[] obj)
        {

            return dataprovider.ExecuteNonQuery("usp_COMM_SocialCalender", obj);
        }

        public DataTable getSocialCalenderDetail(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_COMM_SocialCalender", objArr);
            return ds.Tables[0];

        }


        public DataTable FillSocialCalenderInfoGrid(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_COMM_SocialCalender", objArr);
            return ds.Tables[0];
        }

        #endregion

        #region LatestPIIDIDO

        public int insertLatestPIIDIDODetails(object[] obj)
        {

            return dataprovider.ExecuteNonQuery("usp_COMM_LatestPIIDIDO", obj);
        }


        public DataTable getLatestPIIDIDODetail(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_COMM_LatestPIIDIDO", objArr);
            return ds.Tables[0];

        }


        public DataTable FillLatestPIIDIDOInfoGrid(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_COMM_LatestPIIDIDO", objArr);
            return ds.Tables[0];
        }

        #endregion

        #region Humour

        public int insertHumourDetails(object[] obj)
        {

            return dataprovider.ExecuteNonQuery("usp_COMM_Humour", obj);
        }

        public DataTable getHumourDetail(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_COMM_Humour", objArr);
            return ds.Tables[0];

        }

        public DataTable FillHumourInfoGrid(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_COMM_Humour", objArr);
            return ds.Tables[0];
        }

        #endregion

        #region Thought

        public int insertThoughtDetails(object[] obj)
        {

            return dataprovider.ExecuteNonQuery("usp_COMM_ThoughtOfTheDay", obj);
        }

        public DataTable getThoughtDetail(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_COMM_ThoughtOfTheDay", objArr);
            return ds.Tables[0];

        }

        public DataTable FillThoughtInfoGrid(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_COMM_ThoughtOfTheDay", objArr);
            return ds.Tables[0];
        }

        #endregion

        #region Usefullinks

        public int insertUsefulDetails(object[] obj)
        {

            return dataprovider.ExecuteNonQuery("usp_COMM_UsefulLink", obj);
        }

        public DataTable getUsefulDetail(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_COMM_UsefulLink", objArr);
            return ds.Tables[0];

        }

        public DataTable FillUsefulInfoGrid(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_COMM_UsefulLink", objArr);
            return ds.Tables[0];
        }

        #endregion

        #region Calendar

        public DataSet FillCalendar1InfoGrid(object[] obj)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_HR_MST_HolidayCalendar", obj);
            return ds;
        }

        #endregion

        #region Window Part 2
        public int insertWelcomePartIIDetails(object[] obj)
        {

            return dataprovider.ExecuteNonQuery("usp_P2_Casualties_JCO_IA", obj);
        }

        public DataTable getWelcomePartIIDetail(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_P2_Casualties_JCO_IA", objArr);
            return ds.Tables[0];

        }

        public DataTable FillWelcomePartIIInfoGrid(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_P2_Casualties_JCO_IA", objArr);
            return ds.Tables[0];
        }

        #endregion
        #region[Image Detail1]
        public DataSet fillGridForApprovalRemovalAndAdd(object[] obj)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_COMM_ImageDetailAddView", obj);
            return ds;
        }
        public DataSet funcApproveRemove(object[] objArr)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_COMM_ImageDetailApproveRemove", objArr);
            return ds;
        }
        #endregion
    }
}