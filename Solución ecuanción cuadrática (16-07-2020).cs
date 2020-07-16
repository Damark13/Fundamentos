using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            // ENTRADAS

            Console.Write("Ingrese a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Ingrese b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Ingrese c: ");
            double c = double.Parse(Console.ReadLine());

            // PROCESOS
            double x = -b / (2 * a);
            double x1 = (-b + Math.Sqrt((b * b) - 4 * a * c)) / 2 * a;
            double x2 = (-b - Math.Sqrt((b * b) - 4 * a * c)) / 2 * a;
            double disc = (b * b) - 4 * a * c;

            if (disc == 0)
            {
                Console.WriteLine("La solucion existe y única: " + x);
            }
            else if (disc > 0)
            {
                Console.WriteLine("Existen dos posibles soluciones, x1: " + x1 + " y x2: " + x2 );
            }
            else if (disc < 0)
            {
                Console.WriteLine("No es posible hallar solucion");
            }

        }
    }
}
