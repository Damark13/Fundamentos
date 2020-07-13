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
            double z = 3;
            double c = 56.31;
            double pi = 3.1416;


            // PROCESOS
            double radc = c * (pi / 180);
            double y = z / Math.Tan(radc);
            double t = Math.Sqrt((z * z) + (y * y));
            double a = 180 - 90 - c; //Partiendo de que la suma de los angulos interiores es 180°
                                      //Y que todo Triangulo rectangulo tiene un angulo de 90°


            // SALIDA
            Console.WriteLine("Lado Y = " + y);
            Console.WriteLine("Lado t = " + t);
            Console.WriteLine("Angulo a = " + a);
            Console.WriteLine("Angulo c = " + c); 
        }
    }
}
