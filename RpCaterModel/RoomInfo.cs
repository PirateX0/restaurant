using System;

namespace RpCater.model
{
    public class RoomInfo
    {
        public Int32? DelFlag { get; set; }
        public string IsDefault { get; set; }
        public Int32? RoomId { get; set; }
        public Int32? RoomMaxNum { get; set; }
        public System.Double? RoomMinMoney { get; set; }
        public string RoomName { get; set; }
        public Int32? RoomType { get; set; }
        public Int32? SubBy { get; set; }
        public System.DateTime? SubTime { get; set; }
    }
}