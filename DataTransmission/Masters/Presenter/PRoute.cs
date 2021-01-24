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
  public class PRoute
    {
        #region Declaration
        Route route;
        BusinessMaster businessmaster = new BusinessMaster();
        #endregion

        #region InsertUpdateDeleteRoute
        public int FuncInsertUpdateDeleteRoute(Route route)
        {
            return (businessmaster.FuncInsertUpdateDeleteRoute(CommonUtility.getObjectArrayFromClsObject(route)));
        }
        #endregion

        #region GetRoutedescription
        public DataTable GetRoutedescription(Route route)
        {
            businessmaster = new BusinessMaster();
            DataTable dt = businessmaster.GetRoutedescription(CommonUtility.getObjectArrayFromClsObject(route));
            return dt;
        }
        #endregion

    }
}
