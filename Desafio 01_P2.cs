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
            Console.Write("Valor de b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Valor de y: ");
            double y = double.Parse(Console.ReadLine());



            // PROCESOS

            double e = 180 - d - b;
            double c = 180 - e;
            double crad = c * Math.PI / 180;
            double c1 = Math.Tan(crad);
            double z = y * c1;


            // SALIDA
            
            Console.WriteLine("Valor de z: " + z);


        }
    }
}
