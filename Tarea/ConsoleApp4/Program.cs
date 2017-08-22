using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la cantidad de años trabajados");

            int años;

            int.TryParse(Console.ReadLine(), out años);

            Console.WriteLine("Ingrese sus ingresos anuales");

            double ingresomensual;

            double.TryParse(Console.ReadLine(), out ingresomensual);

            ingresomensual = ingresomensual / 12;
            Console.Write("Su ingreso mensual es de: ");
            Console.WriteLine(ingresomensual);

            if (años > 10)
            {
                ingresomensual = ingresomensual * (1.10);
                Console.Write("Su sueldo es de: ");
                Console.WriteLine(ingresomensual);
            }
            else if (años > 5)
            {
                ingresomensual = ingresomensual * 1.07;
                Console.Write("Su sueldo es de: ");
                Console.WriteLine(ingresomensual);
            }
            else if (años > 3)
            {
                ingresomensual = ingresomensual * 1.05;
                Console.Write("Su sueldo es de: ");
                Console.WriteLine(ingresomensual);
            }
            else if (años <= 3)
            {
                ingresomensual = ingresomensual * 1.01;
                Console.Write("Su sueldo es de: ");
                Console.WriteLine(ingresomensual);
            }

            Console.ReadLine();
        }
    }
}
