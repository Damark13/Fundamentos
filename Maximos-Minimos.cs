using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    class Program
    {
        static void Main(string[] args)
        {
            double total = 0;
            Console.Write("Ingrese N° de datos: ");
            int n = int.Parse(Console.ReadLine());
            int i = 0;
            int max = 0;
            int min = 200;
            string nMax = "";
            string nMin = "";
             

            while (i < n)
            {
                Console.Write("Ingrese nombre: ");
                string name = Console.ReadLine();


                Console.Write("Edad: ");
                int edad = int.Parse(Console.ReadLine());


              
                if (edad >= max)
                {
                    max = edad;
                    nMax = name;
                    
                }
                if (edad <= min)
                {
                    min = edad;
                    nMin = name;

                }

                total += edad;

                i++;
            }

            double promedio = total / n;
            Console.WriteLine("Promedio: " + promedio);
            Console.WriteLine("Nombre del mayor: " + nMax + " edad: " + max);
            Console.WriteLine("Nombre del menor: " + nMin + " edad: " + min);
            



        }
    }
}
