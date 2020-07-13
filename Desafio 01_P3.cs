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


            Console.Write("Valor de d: ");
            double d = double.Parse(Console.ReadLine());
            Console.Write("Valor de w: ");
            double w = double.Parse(Console.ReadLine());
            Console.Write("Valor de x: ");
            double x = double.Parse(Console.ReadLine());

            double d1 = d * Math.PI / 180; //Convirtiendo a radianes

            // PROCESOS
            double t = Math.Sqrt((w * w + x * x) - 2 * w * x * Math.Cos(d1)); //Ley del coseno
            double b = Math.Asin((x * Math.Sin(d1)) / t) * 180 / Math.PI;  //Ley del seno y conversion a grados
            double e = 180 - d - b;
            double c = (180 - e) * Math.PI / 180;

            double y = t * Math.Cos(c);
            

            // SALIDA

           
            Console.WriteLine("Valor de y" + y);


        }
    }
}
