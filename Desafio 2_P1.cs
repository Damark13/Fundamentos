using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            // DATOS
            double y = 2;
            double z = 3;
            double pi = 3.1416;


            // PROCESOS
            double t = Math.Sqrt(Math.Pow(y, 2) + Math.Pow(z, 2));
            double a0 = Math.Atan(y / z);
            double c0 = Math.Atan(z / y);

            double a1 = (a0 * 180) / pi;
            double c1 = (c0 * 180) / pi;


            // SALIDA
            Console.WriteLine("Hipotenusa(t) = " + t);
            Console.WriteLine("Angulo a = " + a1);
            Console.WriteLine("Angulo c = " + c1);
        }
    }
}
