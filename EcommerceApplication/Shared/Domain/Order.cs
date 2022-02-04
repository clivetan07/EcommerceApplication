using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApplication.Shared.Domain
{
    class Order
    {
        public int orderID { get; set; }
        public DateTime orderDATE { get; set; }
        public string orderSTATUS { get; set; }
    }
}
