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
            double t = 3.61;
            double a = 33.69;
            double pi = 3.1416;


            // PROCESOS
            double rada = a * (pi / 180);
            double y = Math.Sin(rada) * t;
            double z = Math.Sqrt((t * t) - (y * y));
            double c0 = Math.Atan(z / y);
            double c1 = (c0 * 180) / pi;


            // SALIDA
            Console.WriteLine("Lado Y = " + y);
            Console.WriteLine("Lado z = " + z);
            Console.WriteLine("Angulo a = " + a);
            Console.WriteLine("Angulo c = " + c1);
        }
    }
}
