using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese votos de A: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Ingrese votos de B: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Ingrese votos en blanco: ");
            double blancos = double.Parse(Console.ReadLine());
            Console.Write("Ingrese votos anulados: ");
            double anulados = double.Parse(Console.ReadLine());
            Console.Write("Ingrese número de habitantes: ");
            double n = double.Parse(Console.ReadLine());
            Console.Write("Ingrese porcentaje de habitantes habilitados para votar (solo el número, sin %): ");
            double p0 = double.Parse(Console.ReadLine());




            // PROCESOS
            double p = p0 / 100;
            double Medad = n * p;
            double abstencion = Medad - (a + b + blancos + anulados);

            bool A = anulados < (a + b * 0.30);
            bool B = a + b > blancos;
            bool C = abstencion < (a + b + blancos + anulados);

            // SALIDAS

            if ((A || B) && C)
            {
                Console.WriteLine("Las votaciones fueron exitosas!");

                if(a > b ) Console.WriteLine("El ganador fue A con " + a + " votos!");
                else Console.WriteLine("El ganador fue B con " + b + " votos!");
            }
            else Console.WriteLine("Las votaciones deben repetirse");
        }
    }
}
