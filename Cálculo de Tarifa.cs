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


            if (nsalario < 2)
            {
                Console.WriteLine("Tarifa A");
            }

            else if (2 <= nsalario && nsalario < 4)
            {
                Console.WriteLine("Tarifa B");
            }

            else
            {
                Console.WriteLine("Tarifa C");
            }
        }
    }
}
