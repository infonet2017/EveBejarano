using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAndTeacherTest
{
    class Person
    {
        public int Age { get; set; }

        public void SetAge (int n)
        {
            this.Age = n;
        }

        public void SayHello()
        {
            Console.WriteLine("Hi People !");
        }
    }
}
