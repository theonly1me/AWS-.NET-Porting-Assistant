using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessBlock;
using BusinessBlock.MasterBlock;
using System.Collections;
using System.Web.UI;

namespace DataTransmission.Masters
{
   public class Location
    {
        public Int32? LocationID { get; set; }
        public String LocationCode { get; set; }
        public String LocationName { get; set; }      
        public String Description { get; set; }
        public String createdBy { get; set; }
        public String updatedBy { get; set; }
        public String actInctBy { get; set; }
        public Int32? OFlag { get; set; }
    }
}
