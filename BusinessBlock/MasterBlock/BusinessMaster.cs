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
   public partial class BusinessMaster
    {
        #region Member Declaration

        DataProvider dataprovider = new DataProvider();
       
        public DataTable getDTForComboMultiWhere(string DataTextField, string DataValueField, string TableName, string varWhereClause)
        {
            DataTable dt = dataprovider.getDTForComboMultiWhere(DataTextField, DataValueField, TableName, varWhereClause);
            return dt;
        }

        #endregion

        #region BUS Master
        public DataSet funcBusMaster(object[] obj)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_MST_Bus", obj);
            return ds;
        }
        #endregion

        #region BUS-Route Allocation Master
        public DataSet funcBusRouteAllocation(object[] obj)
        {
            DataSet ds = dataprovider.ExecuteDataSet("usp_ETicket_BUS_ROUTE_LOCATION", obj);
            return ds;
        }
        #endregion

        #region Route Master

        #region InsertUpdateDeleteRoute
        public int FuncInsertUpdateDeleteRoute(object[] obj)
       {
           return dataprovider.ExecuteNonQuery("usp_Eticket_MST_Route_Name", obj);
       }
       #endregion

        #region GetRoutedescription
       public DataTable GetRoutedescription(object[] objArr)
       {
           DataTable dt = dataprovider.ExecuteDataTable("usp_Eticket_MST_Route_Name", objArr);
           return dt;
       }
       #endregion

       #endregion

        #region Location Master

       #region InsertUpdateDelete Location
       public int FuncInsertUpdateDeleteLocation(object[] obj)
       {
           return dataprovider.ExecuteNonQuery("usp_Eticket_MST_Location", obj);
       }
       #endregion

       #region GetLocationdescription
       public DataTable GetLocationdescription(object[] objArr)
       {
           DataTable dt = dataprovider.ExecuteDataTable("usp_Eticket_MST_Location", objArr);
           return dt;
       }
       #endregion
        #endregion

        #region Operator Master
       #region InsertUpdateDelete Operator
       public int FuncInsertUpdateDeleteOperator(object[] obj)
       {
           return dataprovider.ExecuteNonQuery("usp_Eticket_MST_Operators", obj);
       }
       #endregion

       #region GetOperatordescription
       public DataTable GetOperatordescription(object[] objArr)
       {
           DataTable dt = dataprovider.ExecuteDataTable("usp_Eticket_MST_Operators", objArr);
           return dt;
       }
       #endregion
        #endregion

        #region Bus Schedule
       #region GetBusNameNo For dropdownlist
       public DataTable GetBusNameNoDropdown(object[] obj)
       {
           DataTable dt = dataprovider.ExecuteDataTable("usp_Eticket_MST_Bus_FillDropdown", obj);
           return dt;
       }
       #endregion
       #region GetBusNameNo For dropdownlist
       public DataTable GetBusNameNoDropdownSchedule(object[] obj)
       {
           DataTable dt = dataprovider.ExecuteDataTable("usp_Eticket_MST_Bus_FillDropdown_Schedule", obj);
           return dt;
       }
      #endregion
       
        #endregion


    }
}
