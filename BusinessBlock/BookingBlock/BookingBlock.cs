using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using SISDAPPS.DataAccessBlock;
using System.Collections;



namespace BusinessBlock.MasterBlock
{
   public partial class BookingBlock
    {
        #region Member Declaration

        DataProvider dataprovider = new DataProvider();
        #endregion

        #region GetBusesDetails
        public DataSet GetBusesDetails(object[] obj)
        {
            DataSet _BusSet = dataprovider.ExecuteDataSet("USP_FIND_BUSES_BETWEEN_STATIONS", obj);
            return _BusSet;
        }
        #endregion

        #region GeRouteDetails
        public DataSet GetRouteDetails(object[] obj)
        {
            DataSet _routeSet = dataprovider.ExecuteDataSet("USP_FIND_ROUTE_AGAINST_BUSID", obj);
            return _routeSet;
        }
        #endregion
       
        #region GetBookingDetails
        public DataSet GetBookingDetails(object[] obj)
        {
            DataSet ds = dataprovider.ExecuteDataSet("USP_BOOKING_DETAILS", obj);
            return ds;
        }
        #endregion

        #region GetBusView
        public DataSet GET_BUS_VIEW(object[] obj)
        {
            DataSet ds = dataprovider.ExecuteDataSet("USP_GET_BUS_VIEW", obj);
            return ds;
        }
        #endregion

        #region Calculate fare from the boarding point
        public DataSet GET_Fare_From_BoardingPoint(object[] obj)
        {
            DataSet ds = dataprovider.ExecuteDataSet("USP_GET_FARE_ON_BOARDING_POINT", obj);
            return ds;
        }
        #endregion

        #region AgentHistory
        public DataTable GetAgentHistoryDetails(object[] obj)
        {
            DataTable dt = dataprovider.ExecuteDataTable("usp_Eticket_Agent_History", obj);
            return dt;
        }

        #endregion

        #region Bus Fare
        public DataTable GetBusFareForBookingCounter(object[] obj)
        {
            DataTable dt = dataprovider.ExecuteDataTable("usp_getBusFare_BookingCounter", obj);
            return dt;
        }

        #endregion

        #region GET_FARE_ON_BOOKING_COUNTER_POINT
        public DataTable GET_FARE_ON_BOOKING_COUNTER_POINT(object[] obj)
        {
            DataTable dt = dataprovider.ExecuteDataTable("USP_GET_FARE_ON_BOOKING_COUNTER_POINT", obj);
            return dt;
        }

        #endregion

       
    }
}
