using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transaction_Management
{
    class Provider: Person
    {
        public List<Debt> Debts { get; set; }

        public Provider()
        {
            Debts = new List<Debt>();
        }
    }
}
