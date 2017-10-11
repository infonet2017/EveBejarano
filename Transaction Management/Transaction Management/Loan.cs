using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transaction_Management
{
    class Loan
    {
        public DateTime Date { get; set; }
        public Sale InFavorSale { get; set; }
        public float Amount { get; set; }
    }
}
