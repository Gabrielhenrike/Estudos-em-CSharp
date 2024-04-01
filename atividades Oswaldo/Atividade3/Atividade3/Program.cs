using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade3
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, num3;

            Console.WriteLine("DIGITE UMA SEQUÊNCIA DE 3 NÚMEROS E VEJA EM ORDEM CRESCENTE!");

            Console.Write("DIGITE O PRIMEIRO NÚMERO: ");
            num1 = double.Parse(Console.ReadLine());
            Console.Write("DIGITE O SEGUNDO NÚMERO: ");
            num2 = double.Parse(Console.ReadLine());
            Console.Write("DIGITE O TERCEIRO NÚMERO: ");
            num3 = double.Parse(Console.ReadLine());
            if (num1 <= num2 && num1 <= num3)
            {
                Console.Write(num1 + ", ");
                if (num2 <= num3)
                {
                    Console.Write(num2 + ", " + num3);
                }
                else
                {
                    Console.Write(num3 + ", " + num2);
                }
            }
            else if (num2 <= num1 && num2 <= num3)
            {
                Console.Write(num2 + ", ");
                if (num1 <= num3)
                {
                    Console.Write(num1 + ", " + num3);
                }
                else
                {
                    Console.Write(num3 + ", " + num1);
                }
            }
            else
            {
                Console.Write(num3 + ", ");
                if (num1 <= num2)
                {
                    Console.Write(num1 + ", " + num2);
                }
                else
                {
                    Console.Write(num2 + ", " + num1);
                }
            }

            Console.ReadKey();
        }


    
    }
}
