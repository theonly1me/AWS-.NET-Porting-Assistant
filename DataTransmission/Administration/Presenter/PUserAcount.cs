using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessBlock;
using System.Data;
namespace DataTransmission
{
   public class PUserAcount
    {
        #region Declaration
        UserAcount  userAcount;
        BizUserAcount bizUserAcount = new BizUserAcount();
        #endregion

        public DataSet UserAcount(UserAcount userAcount)
        {
            DataSet ds = bizUserAcount.UserAcount(CommonUtility.getObjectArrayFromClsObject(userAcount));
            return ds;
        }      
    }
}
