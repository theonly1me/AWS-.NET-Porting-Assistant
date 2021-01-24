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
   public class PBusSchedule
    {
        #region Declaration
        BusinessMaster businessmaster = new BusinessMaster();
        #endregion

        #region GetBusNameNo For dropdownlist
        public DataTable GetBusNameNoDropdown(object[] obj)
        {
            return businessmaster.GetBusNameNoDropdown(obj);
           
        }
       #region GetBusNameNo For dropdownlist
        public DataTable GetBusNameNoDropdownSchedule(object[] obj)
        {
            return businessmaster.GetBusNameNoDropdownSchedule(obj);
           
        }
      #endregion
       
        #endregion

    }
}
