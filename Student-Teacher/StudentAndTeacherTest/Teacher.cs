using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAndTeacherTest
{
    class Teacher: Person
    {
        private string Subject { get; set; }

        public void Explain()
        {
            Console.WriteLine("Explanation begins");
        }
    }
}
