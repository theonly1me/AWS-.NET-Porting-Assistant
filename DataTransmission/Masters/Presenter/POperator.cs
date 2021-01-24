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

namespace DataTransmission.Masters
{
   public class POperator
    {
        #region Declaration
        Operator operat;
        BusinessMaster businessmaster = new BusinessMaster();
        #endregion

        #region InsertUpdateDeleteOperator
        public int FuncInsertUpdateDeleteOperator(Operator operat)
        {
            return (businessmaster.FuncInsertUpdateDeleteOperator(CommonUtility.getObjectArrayFromClsObject(operat)));
        }
        #endregion

        #region GetOperatordescription
        public DataTable GetOperatordescription(Operator operat)
        {
            businessmaster = new BusinessMaster();
            DataTable dt = businessmaster.GetOperatordescription(CommonUtility.getObjectArrayFromClsObject(operat));
            return dt;
        }
        #endregion

    }
}
