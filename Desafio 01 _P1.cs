using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {

            // DATOS
            Console.WriteLine("Recuerde escribir decimales con coma (,)");
            

            Console.Write("Valor de b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Valor de y: ");
            double y = double.Parse(Console.ReadLine());
            Console.Write("Valor de z: ");
            double z = double.Parse(Console.ReadLine());


            // PROCESOS
            double radb = b * 180 / Math.PI;
            double a = Math.Atan(y / z);
            double t = Math.Sqrt((y * y) + (z * z));
            double abgrados = (a + radb) * Math.PI /180;
            double d = 180 - 90 - abgrados;

            double x = (t * Math.Sin(b)) / Math.Sin(d);

            // SALIDA
            Console.WriteLine("Valor de x: " + x);


        }
    }
}
