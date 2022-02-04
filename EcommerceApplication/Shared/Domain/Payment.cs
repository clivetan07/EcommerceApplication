using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApplication.Shared.Domain
{
    class Payment
    {
        public int paymentID { get; set; }
        public string paymentMethod { get; set; }
        public DateTime dateTime {get; set;}
    }
}
