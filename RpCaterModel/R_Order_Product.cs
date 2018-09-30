using System;

namespace RpCater.model
{
    public class R_Order_Product
    {
        public Int32? DelFlag { get; set; }
        public Int32? OrderId { get; set; }
        public Int32? ProId { get; set; }
        public Int32? ROrderProId { get; set; }
        public System.DateTime? SubTime { get; set; }
        public Int32? UnitCount { get; set; }
    }
}