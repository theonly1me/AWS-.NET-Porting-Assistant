using BusinessBlock.MasterBlock;
using System.Data;
using System;
using System.Web.UI.WebControls;
namespace DataTransmission.Masters
{
    public class PBus
    {
        #region Declaration
        BusinessMaster businessmaster = new BusinessMaster();
        #endregion

        #region BusMater
        public DataSet funcBusMaster(Bus bus)
        {
            DataSet ds = businessmaster.funcBusMaster(CommonUtility.getObjectArrayFromClsObject(bus));
            return ds;
        }
        #endregion
        #region Bus-Route Allocation Mater
        public DataSet funcBusRouteAllocation(BusAllocation busAllocation)
        {
            DataSet ds = businessmaster.funcBusRouteAllocation(CommonUtility.getObjectArrayFromClsObject(busAllocation));
            return ds;
        }
        #endregion

        public DropDownList getDDLMultiWhereth(DropDownList DDL, string DataTextField, string DataValueField, string TableName, string varWhereClause)
        {
            businessmaster = new BusinessMaster();
            DataTable dt = businessmaster.getDTForComboMultiWhere(DataTextField, DataValueField, TableName, varWhereClause);
            DDL.DataSource = dt;
            DDL.DataValueField = dt.Columns[DataValueField].ToString();
            DDL.DataTextField = dt.Columns[DataTextField].ToString();
            DDL.DataBind();
            return DDL;
        }

    }
}
