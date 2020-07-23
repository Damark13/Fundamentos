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
            int a = int.Parse(Console.ReadLine());
            Console.Write("Ingrese votos de B: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Ingrese votos en blanco: ");
            int blancos = int.Parse(Console.ReadLine());
            Console.Write("Ingrese votos anulados: ");
            int anulados = int.Parse(Console.ReadLine());
            Console.Write("Ingrese número de habitantes: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Ingrese porcentaje de habitantes habilitados para votar (solo el número, sin %): ");
            double p0 = int.Parse(Console.ReadLine());




            // PROCESOS
            
            int Medad = (int) (n * (p0 / 100));
            double abstencion = Medad - (a + b + blancos + anulados);
            bool A = anulados < (a + b * 0.30);
            bool B = a + b > blancos;
            bool C = abstencion < (a + b + blancos + anulados);

            // SALIDAS
            Console.WriteLine("Abstencion: " + abstencion);
            Console.WriteLine("Poblacion mayor de edad: " + Medad);
            Console.WriteLine("Total votantes: " + (a + b + blancos + anulados));

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
