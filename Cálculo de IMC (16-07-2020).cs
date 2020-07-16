using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            // ENTRADAS

            Console.Write("Ingrese su estatura (en metros): ");
            double alt = double.Parse(Console.ReadLine());
            Console.Write("Ingrese su peso actual (en kilogramos): ");
            double pes = double.Parse(Console.ReadLine());

            // PROCESOS
            double imc = pes / (alt * alt);

            if (imc < 18.5)
            {
                Console.WriteLine("Subir de peso");
            }
            else if (18.5 <= imc && imc < 25)
            {
                Console.WriteLine("Saludable");
            }
            else if (25 <= imc && imc < 30)
            {
                Console.WriteLine("Sobrepeso");
            }
            else if (imc >= 30)
            {
                Console.WriteLine("Obesidad");
            }
        }
    }
}
