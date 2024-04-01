using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade4
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, delta;

            Console.WriteLine("CALCULE A EQUAÇÃO DE SEGUNDO GRAU!");

            Console.Write("DIGITE O VALOR DE A: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("DIGITE O VALOR DE B: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("DIGITE O VALOR DE C: ");
            c = double.Parse(Console.ReadLine());
            delta = (b * b - 4 * a * c);

            

            if (delta < 0)
            {
                Console.Write("NÃO HÁ RAÍZES");
            }
            else if (delta == 0)
            {
                double x = -b / 2 * a;
                Console.WriteLine("A RAIZA TEM EQUAÇÃO:");
                Console.WriteLine("X = " + x);
            }
            else if (delta > 0)
            {
                double x1 = (-b + Math.Sqrt(delta)) / 2 * a;
                double x2 = (-b - Math.Sqrt(delta)) / 2 * a;
                Console.WriteLine("RAIZ DA EQUAÇÃO x1=" + x1);
                Console.WriteLine("RAIZ DA EQUAÇÃO x2=" + x2);
            }
            Console.ReadKey();
        }
    }
}
