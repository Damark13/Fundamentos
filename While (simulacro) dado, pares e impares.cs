using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Par_impar
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int dado = aleatorio.Next(1, 13);
            int total = 0;
            int i = 0;
            int c12 = 0;

            Console.WriteLine("\n Desea tirar el dado? (s/n)");
            string rpta = Console.ReadLine();

            // INICIO DEL WHILE
            while (rpta == "s")
            {
                i++;
                dado = aleatorio.Next(1, 13);
                total += dado;
                Console.WriteLine("Dado: " + dado);
                Console.WriteLine("Total: " + total);

                // Ganar por consecutivos
                if (dado == 12)
                {
                    c12++;
                }
                
                else if (c12 == 1 && dado == 10)
                {
                    Console.WriteLine("Ha Ganado");
                    rpta = "n";
                }
                else c12 = 0;

                //Ganar/Perder por pares/impares
                if (dado % 2 != 0 && i > 3)
                {

                    Console.WriteLine("Ha perdido");
                    rpta = "n";

                }
                else if (total >= 100)
                {
                    Console.WriteLine("Ha Ganado");
                    rpta = "n";
                }
                else
                {
                    
                    Console.WriteLine("\n Desea tirar el dado? (s/n)");
                    rpta = Console.ReadLine();
                    if (rpta == "n") Console.WriteLine("Ha salido"); 

                }

                

                



            }

        }
    }
}
