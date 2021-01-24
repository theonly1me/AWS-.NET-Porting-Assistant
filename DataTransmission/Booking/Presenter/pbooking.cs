using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessBlock;
using BusinessBlock.MasterBlock;
using System.Data;
using System.IO;
using System.Reflection;
using System.Collections;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataTransmission;


namespace DataTransmission
{
  public class pbooking
    {
        #region Declaration

      BookingBlock _CallBus = new BookingBlock();
        #endregion

      #region Insert GetBusesDetails
      public DataSet GetBusesDetails(object[] obj)
        {
            DataSet _BusSet = _CallBus.GetBusesDetails(obj);
            return _BusSet;
        }
        #endregion

      #region Insert GetRouteDetails
      public DataSet GetRouteDetails(object[] obj)
        {
            DataSet _RouteSet = _CallBus.GetRouteDetails(obj);
            return _RouteSet;
        }
       #endregion

      #region  GetBookingDetails
      public DataSet GetBookingDetails(object[] obj)
      {
          DataSet ds = _CallBus.GetBookingDetails(obj);
          return ds;
      }
      #endregion

      #region  GetBookingDetails
      public DataSet GET_BUS_VIEW(object[] obj)
      {
          DataSet ds = _CallBus.GET_BUS_VIEW(obj);
          return ds;
      }
      #endregion

      #region  GET_Fare_From_BoardingPoint
      public DataSet GET_Fare_From_BoardingPoint(object[] obj)
      {
          DataSet ds = _CallBus.GET_Fare_From_BoardingPoint(obj);
          return ds;
      }
      #endregion

      #region  GetBusFareForBookingCounter
      public DataTable GetBusFareForBookingCounter(object[] obj)
      {
          DataTable dt = _CallBus.GetBusFareForBookingCounter(obj);
          return dt;
      }
      #endregion

      #region  GET_FARE_ON_BOOKING_COUNTER_POINT
      public DataTable GET_FARE_ON_BOOKING_COUNTER_POINT(object[] obj)
      {
          DataTable dt = _CallBus.GET_FARE_ON_BOOKING_COUNTER_POINT(obj);
          return dt;
      }
      #endregion
      

    }
}
