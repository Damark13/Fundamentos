using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¿Cuántos smmlv gana por su empleo?: ");
            double salario = double.Parse(Console.ReadLine());


            if (salario < 2)
            {
                Console.WriteLine("Tarifa A");
            }

            else if (2 <= salario && salario < 4)
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
