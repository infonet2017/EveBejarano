using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transaction_Management
{
    class Purchase
    {
        public DateTime Date { get; set; }
        public Provider Provider { get; set; }
        public List<Product> PurchasedProducts { get; set; }
        public int AmountToPay { get; set; }
    }
}
