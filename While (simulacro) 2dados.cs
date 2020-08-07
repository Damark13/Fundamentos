using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sim2
{
    class Program
    {
        static void Main(string[] args)
        {

            Random aleatorio = new Random();
            int dado = 0;
            int dado2 = 0;
            int total = 0;
            int i = 0;
            int ide6 = 0;
            int iturnos = 0;
            int c12 = 0;
            
            Console.WriteLine("\n Desea tirar los dados? (s/n)");
            string rpta = Console.ReadLine();

            // INICIO DEL WHILE
            while (rpta == "s")
            {
                iturnos++;
                dado = 2;
                dado2 = 2;
                total += dado + dado2;
                Console.WriteLine("Dado1: " + dado);
                Console.WriteLine("Dado2: " + dado2);
                Console.WriteLine("Total: " + total);



                // Contador de dobles
                if (dado == dado2) i++;
                else i = 0;


                if (dado + dado2 >= 6) ide6++;
                

                //Ganar/Perder por pares/impares
                if (dado == 1 && dado2 == 1)
                {

                    Console.WriteLine("Ha perdido");
                    rpta = "n";

                }
                else if (total >= 100 || i == 3)
                {
                    Console.WriteLine("Ha Ganado");
                    rpta = "n";
                }
                else
                {

                    Console.WriteLine("\n Desea tirar los dados? (s/n)");
                    rpta = Console.ReadLine();
                    if (rpta == "n") Console.WriteLine("Ha salido");

                }


            }

            double porcentaje = (double) (ide6 * 100) / iturnos;
            Console.WriteLine("Porcentaje de turnos en los que salió 6+: " + porcentaje+ "%");
        }
    }
}
