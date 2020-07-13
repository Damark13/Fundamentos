using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            // DATOS
            Console.WriteLine("Ingrese su binario (1er digito): ");
            double b0 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese su binario (2do digito): ");
            double b1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese su binario (3er digito): ");
            double b2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese su binario (4to digito): ");
            double b3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese su binario (5to digito): ");
            double b4 = double.Parse(Console.ReadLine());


            // PROCESOS

            double b0f = b0 * Math.Pow(2, 0);
            double b1f = b1 * Math.Pow(2, 1);
            double b2f = b2 * Math.Pow(2, 2);
            double b3f = b3 * Math.Pow(2, 3);
            double b4f = b4 * Math.Pow(2, 4);

            double BF = b0f + b1f + b2f + b3f + b4f;


            // SALIDA

            Console.WriteLine("Su resultado es: " + BF);
        }
    }
}
