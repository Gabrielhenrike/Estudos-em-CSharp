using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("DIGITE 2 NÚMEROS, O MAIOR SERÁ MOSTRADO");
            Console.WriteLine("DIGITE UM NÚMERO: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("DIGITE OUTRO NÚMERO: ");
            num2 = int.Parse(Console.ReadLine());
            if (num1 > num2) 
            {
                Console.WriteLine("O MAIOR NÚMERO É: " + num1);
            }
            else 
            {
                Console.WriteLine("O MAIOR NÚMERO É: " + num2); 
            }

            Console.ReadKey();
        }
    }
}
