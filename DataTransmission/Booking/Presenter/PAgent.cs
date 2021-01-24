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

namespace DataTransmission.Booking
{
   public class PAgent
    {

       #region Declaration

       BookingBlock _CallBus = new BookingBlock();
       #endregion


       #region  GetAgentHistoryDetails
       public DataTable GetAgentHistoryDetails(object[] obj)
       {
           DataTable dt = _CallBus.GetAgentHistoryDetails(obj);
           return dt;
       }
       #endregion
    }
}
