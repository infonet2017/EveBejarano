using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transaction_Management
{
    class Debt
    {
        public DateTime Date { get; set; }
        public Purchase OwedPurchase { get; set; }
        public float Amount { get; set; }

    }
}
