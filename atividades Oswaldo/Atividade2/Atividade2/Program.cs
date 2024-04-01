using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade2
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double dtn, dta, idade;

            Console.WriteLine("DIGITE SEU NOME, ANO NASCIMENTO E ANO ATUAL PARA VER SE VOCÊ É MAIOR OU MEN0R DE IDADE!");

            Console.WriteLine("DIGITE O SEU NOME: ");
            nome = Console.ReadLine();
            Console.WriteLine("DIGITE O ANO DO SEU NASCIMENTO: ");
            dtn = double.Parse(Console.ReadLine());
            Console.WriteLine("DIGITE O ANO ATUAL: ");
            dta = double.Parse(Console.ReadLine());
            idade = (dta - dtn);
            Console.WriteLine("SUA IDADE É: " + idade);
            if (idade >= 18)
            {
                Console.Write("VOCÊ É MAIOR DE IDADE!");
            }
            else
            {
                Console.Write("vOCÊ É MENOR DE IDADE!");
            }
            Console.ReadKey();
        }
    }
}
