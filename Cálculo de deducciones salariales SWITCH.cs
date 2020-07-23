using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite su modalidad de trabajo:" + "Pulse 1 para Dependiente  /  Pulse 2 para Independiente");
            int M = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite su salario mensual: ");
            double S = double.Parse(Console.ReadLine());
            double BaseCoti = (((S * 40) / 100));
            double PorR = 0;

            if (BaseCoti < 877803)
            {
                BaseCoti = 877803;
            }

            switch (M)
            {
                case 1:
                    double Pension = (BaseCoti * 4) / 100;
                    Console.WriteLine("Cuota pension: " + Pension);
                    double Eps = Pension;
                    Console.WriteLine("Cuota EPS: " + Eps);
                    double SM = S - Pension - Eps;
                    Console.WriteLine("Salario mensual total: " + SM);
                    double SA = SM * 12 + S;
                    Console.WriteLine("Salario anual (con primas): " + SA);
                    break;


                case 2:
                    Console.WriteLine("Digite de de 1-5 su escala de riesgo laboral: ");
                    int R = int.Parse(Console.ReadLine());

                    Pension = (BaseCoti * 16) / 100;
                    Console.WriteLine("Cuota pension: " + Pension);
                    Eps = (BaseCoti * 12.5) / 100;
                    Console.WriteLine("Cuota EPS: " + Eps);


                    switch (R)
                    {
                        case 1: PorR = 0.522 / 100; break;
                        case 2: PorR = 1.044 / 100; break;
                        case 3: PorR = 2.436 / 100; break;
                        case 4: PorR = 4.350 / 100; break;
                        case 5: PorR = 6.960 / 100; break;

                    }
                    double Arl = BaseCoti * PorR;
                    Console.WriteLine("Cuota Arl: " + Arl);
                    SM = S - Pension - Eps;
                    Console.WriteLine("Salario mensual total: " + SM);
                    SA = SM * 12 + S;
                    Console.WriteLine("Salario anual (con primas): " + SA);
                    break;
            }

            



            
        }
    }
}
