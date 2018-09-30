using System;

namespace RpCater.model
{
    public class ProductInfo
    {
        public Int32? CId { get; set; }
        public Int32? DelFlag { get; set; }
        public System.Double? ProCost { get; set; }
        public Int32? ProId { get; set; }
        public string ProName { get; set; }
        public string ProNum { get; set; }
        public System.Double? ProPrice { get; set; }
        public string ProSpell { get; set; }
        public Int32? ProStock { get; set; }
        public string ProUnit { get; set; }
        public string Remark { get; set; }
        public Int32? SubBy { get; set; }
        public System.DateTime? SubTime { get; set; }
    }
}