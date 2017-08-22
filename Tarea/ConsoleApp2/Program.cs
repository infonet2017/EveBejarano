using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.WriteLine("Ingrese el primer número");
            int.TryParse(Console.ReadLine(), out a);

            Console.WriteLine("Ingrese el segundo número");
            int.TryParse(Console.ReadLine(), out b);

            Console.WriteLine("Ingrese el tercer número");
            int.TryParse(Console.ReadLine(), out c);

            if ((a < b && b < c) || (a == b && a < c) || a == c && a== b || (b == c && a < b))
            {
                Console.WriteLine("Los numeros fueron ingresados en orden creciente.");
            }
            else 
            {
                Console.WriteLine("Los numeros NO fueron ingresados en orden creciente.");
            }
            Console.ReadLine();
        }
    }
}
