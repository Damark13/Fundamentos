using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¿Cuánto gana mensualmente? (no ingrese puntos ni comas): ");
            double salario = double.Parse(Console.ReadLine());
            double nsalario = salario / 877803;
            double salarioDiario = 877803 / 30;


            if (nsalario < 2)
            {
                Console.WriteLine("Tarifa A. Su cuota moderadora será del 11.6% (" + salarioDiario * 0.116 + ")");

            }

            else if (2 <= nsalario && nsalario < 4)
            {
                Console.WriteLine("Tarifa B. Su cuota moderadora será del 46.1% (" + salarioDiario * 0.461 + ")");
            }

            else
            {
                Console.WriteLine("Tarifa C. Su cuota moderadora será del 121.5% (" + salarioDiario * 1.215 + ")");
            }
        }
    }
}
