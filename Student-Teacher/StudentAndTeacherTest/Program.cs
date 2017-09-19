using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAndTeacherTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var Person = new Person();
            Person.SayHello();

            var Student = new Student();
            Student.Age = 21;
            Student.SayHello();
            Student.ShowAge();

            var Teacher = new Teacher();
            Teacher.Age = 30;
            Teacher.SayHello();
            Teacher.Explain();
            Console.Read();

        }
    }
}
