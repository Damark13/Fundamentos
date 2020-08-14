using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int dado = 0;
            int dadoEsp = 0;
            int contDado = 2;
            int total = 0;
            int i = 0;
            int contador6 = 0;
            int contador1 = 0;
            int vidas = 3;

            Console.WriteLine("\n Desea iniciar el juego? (s/n)");
            string rpta = Console.ReadLine();



            // INICIO DEL WHILE
            while (rpta == "s" && vidas == 3)
            {
                dado = aleatorio.Next(1, 7);
                dadoEsp = aleatorio.Next(1, 12);

                if (contDado > 0)
                {
                    Console.WriteLine("\n Desea tirar el dado especial? (s/n)");
                    string respta = Console.ReadLine();
                    if (respta == "s")
                    {
                        
                        total = total + dadoEsp;
                        Console.WriteLine("DadoEspecial: " + dadoEsp);
                        contDado--;
                    }
                    else
                    {
                        Console.WriteLine("\n Haz tirado un dado normal");
                        total += dado;
                        Console.WriteLine("Dado: " + dado);
                        
                    }

                }
                else if (contDado == 0)
                {
                    total += dado;
                    
                    

                }




                // CALCULOS

                // -Vida
                if (dado == 1)
                {
                    contador1++;
                }
                else if (contador1 == 2)
                {
                    Console.WriteLine("pierdes 1 vida");
                    vidas--;
                    total = total - 10;
                    contador1 = 0;
                }


                //+Vida
                if (dado == 6)
                {
                    contador6++;
                }

                else if (contador6 == 1 && dado == 6)
                {
                    Console.WriteLine("vida extra");
                    vidas++;
                    if (vidas > 3) vidas = 3;

                }
                else contador6 = 0;



                //Ganar/Perder
                if (vidas == 0)
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
                    Console.WriteLine("Total: " + total);
                    Console.WriteLine("\n Desea tirar el dado? (s/n)");
                    rpta = Console.ReadLine();

                }
               

            }
        }
    }
}
