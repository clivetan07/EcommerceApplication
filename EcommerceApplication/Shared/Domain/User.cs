using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApplication.Shared.Domain
{
    class User
    {
        public int userID { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string full_name { get; set; }
        public string billing_address { get; set; }
        public string country  { get; set; }
        public string phone { get; set; }
        public string default_shipping_address { get; set; }
    }
}
