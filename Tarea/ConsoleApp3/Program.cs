using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];

            for (int i = 0; i < a.Length; i++)
            {
                int c;

                Console.WriteLine("Ingrese un número");

                int.TryParse(Console.ReadLine(), out c);

                a[i] = c;
            }

            Console.Write("El mayor numero ingresado es: ");
            Console.WriteLine(a.Max());

            Console.Write("El menor numero ingresado es: ");
            Console.WriteLine(a.Min());
            Console.ReadLine();
        }
    }
}
