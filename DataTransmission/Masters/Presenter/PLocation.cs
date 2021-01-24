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
  public class PLocation
    {
        #region Declaration
        Location location;
        BusinessMaster businessmaster = new BusinessMaster();
        #endregion

        #region FuncInsertUpdateDelete Location 
        public int FuncInsertUpdateDeleteLocation(Location location)
        {
            return (businessmaster.FuncInsertUpdateDeleteLocation(CommonUtility.getObjectArrayFromClsObject(location)));
        }
        #endregion

        #region GetLocationdescription
        public DataTable GetLocationdescription(Location location)
        {
            businessmaster = new BusinessMaster();
            DataTable dt = businessmaster.GetLocationdescription(CommonUtility.getObjectArrayFromClsObject(location));
            return dt;
        }
        #endregion


    }
}
