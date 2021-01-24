using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessBlock;
using System.Reflection;
using System.Collections;
using System.Data;
using BusinessBlock.Common;
using System.Web.UI.WebControls;


namespace DataTransmission.Common
{
    public class PUnit
    {
        CommonBlock commonBlock;

        public DataSet FillUnit(Unit unit)
        {
            commonBlock = new CommonBlock();
            object[] temp = CommonUtility.getObjectArrayFromSingleOrMultipleClsObjectWithRemoveNull(unit, true);

            DataSet ds = commonBlock.FillUnit(temp);
            return ds;
        }
    }
}
