using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número");

            int a;

            int.TryParse(Console.ReadLine(), out a);

            if (a== 2)
            {
                Console.WriteLine("Lunes");
            }
            else if (a == 3)
            {
                Console.WriteLine("Martes");
            }
            else if (a == 4)
            {
                Console.WriteLine("Miércoles"); ;
            }
            else if (a == 5)
            {
                Console.WriteLine("Jueves"); ;
            }
            else if (a == 6)
            {
                Console.WriteLine("Viernes");
            }
            else if (a == 7)
            {
                Console.WriteLine("Sábado"); ;
            }
            else if (a == 1)
            {
                Console.WriteLine("Domingo"); ;
            }
            else
            {
                Console.WriteLine("El número ingresado no se corresponde con ningún día de la semana");
            }
            Console.ReadLine();
        }
    }
}
