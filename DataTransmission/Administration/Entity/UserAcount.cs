using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataTransmission
{
    public class UserAcount
    {
        public double UserID { get; set; }
        public int UserType{ get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }      
        public string EMail { get; set; }
        public double MobileNo { get; set; }
        public string Password { get; set; }
        public string OrganizationName { get; set; }
        public string City { get; set; }                                       
        public string Address1 { get; set; }
        public double? PinCode { get; set; }
        public double? FaxNo { get; set; }
        public string PanNo { get; set; }
        public bool IsActive { get; set; }
        public string UserIds { get; set; }
        public int Flag { get; set; }
    }
}
