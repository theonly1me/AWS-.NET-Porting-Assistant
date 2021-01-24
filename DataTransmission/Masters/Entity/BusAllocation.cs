using System;
namespace DataTransmission.Masters
{
    public class BusAllocation
    {
        public Int32? Map_ID { get; set; }
        public Int32? Bus_ID { get; set; }
        public Int32? Route_ID { get; set; }
        public Int32? Location_ID { get; set; }
        public Int32? RouteOrder { get; set; }
        //public DateTime TimeArrival { get; set; }
        //public DateTime TimeDeparture { get; set; }
        public String LogIN { get; set; }
        public Int32? OFlag { get; set; }
        public Int32? Distance_bw_Stations { get; set; }
    }
}
