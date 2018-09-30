using System;

namespace RpCater.model
{
    public class CategoryInfo
    {
        public Int32? CId { get; set; }
        public string CName { get; set; }
        public string CNum { get; set; }
        public string CRemark { get; set; }
        public Int32? DelFlag { get; set; }
        public Int32? SubBy { get; set; }
        public System.DateTime? SubTime { get; set; }
    }
}