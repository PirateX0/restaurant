using System;

namespace RpCater.model
{
    public class DeskInfo
    {
        public Int32? DelFlag { get; set; }
        public Int32? DeskId { get; set; }
        public string DeskName { get; set; }
        public string DeskRegion { get; set; }
        public string DeskRemark { get; set; }
        public Int32? DeskState { get; set; }

        //²¹³ä
        public string DeskStateString { get; set; }

        public Int32? RoomId { get; set; }
        public Int32? SubBy { get; set; }
        public System.DateTime? SubTime { get; set; }
    }
}