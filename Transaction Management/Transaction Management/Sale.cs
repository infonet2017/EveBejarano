using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transaction_Management
{
    class Sale
    {
        public DateTime Date { get; set; }
        public Client Client { get; set; }
        public List<Product> SoldProducts { get; set; }
        public int AmountToTake { get; set; }



    }

}
