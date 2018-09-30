using System;

namespace RpCater.model
{
    public class OrderInfo
    {
        public System.DateTime? BeginTime { get; set; }
        public Int32? DelFlag { get; set; }
        public System.Double? DisCount { get; set; }
        public System.DateTime? EndTime { get; set; }
        public Int32? OrderId { get; set; }
        public Int32? OrderMemberId { get; set; }
        public System.Double? OrderMoney { get; set; }
        public Int32? OrderState { get; set; }
        public string Remark { get; set; }
        public Int32? SubBy { get; set; }
        public System.DateTime? SubTime { get; set; }
    }
}