using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {

            // Entradas
            Random aleatorio = new Random();
            
            int carta1 = 0;
            int carta2 = 0;
            int total = 0;
            int nCarta = 0;

            carta1 = aleatorio.Next(1, 11);
            carta2 = aleatorio.Next(1, 11);
            total = carta1 + carta2;
            Console.WriteLine("Carta 1: " + carta1);
            Console.WriteLine("Carta 2: " + carta2);
            Console.WriteLine("total: " + total);

            Console.WriteLine("\n Desea sacar otra carta? (s/n)");
            string rpta = Console.ReadLine();

            while (rpta == "s" && total <= 21)
            {

                nCarta = aleatorio.Next(1, 11);
                Console.WriteLine("Carta: " + nCarta);

                total += nCarta;

                if (total < 21)
                {
                    Console.WriteLine("Total: " + total);
                    Console.WriteLine("\n Desea sacar otra carta? (s/n)");
                    rpta = Console.ReadLine();
                }


                else if (total > 21)
                {
                    Console.WriteLine("\n Haz perdido!"); rpta = "n";
                }
                else
                {
                    Console.WriteLine("\n Haz ganado! "); rpta = "n";
                }
    
               
            }

            Console.WriteLine("El juego ha finalizado, su total fue de: " + total);
        }
    }
}
