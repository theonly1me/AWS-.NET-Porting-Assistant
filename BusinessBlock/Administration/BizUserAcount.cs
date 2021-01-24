using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using SISDAPPS.DataAccessBlock;
namespace BusinessBlock
{
    public class BizUserAcount
    {
        DataProvider dataprovider = new DataProvider();
        public DataSet UserAcount(object[] obj)
        {
            DataSet ds = dataprovider.ExecuteDataSet("USP_USER_ACOUNT", obj);
            return ds;
        }      
    }
}
