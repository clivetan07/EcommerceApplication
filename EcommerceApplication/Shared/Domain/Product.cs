using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApplication.Shared.Domain
{
    class Product
    {
        public int productID { get; set; }
        public string productNAME { get; set; }
        public char productPRICE { get; set; }
        public string description { get; set; }
        public Byte thumbnail { get; set; }
        public Byte image { get;  set; }
        public string stocks { get; set; }

    }
}
