using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpCater.Model
{
    public class Content
    {
        public string ContentText { get; set; }
        public string ErrorMessage { get; set; }
        public bool IsInvalid { get; set; }
    }
}