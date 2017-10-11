using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transaction_Management
{
    class Client: Person
    {
        List<Loan> Loans { get; set; }

        public Client()
        {
            List<Loan> Loans = new List<Loan>();
        }
    }
}
