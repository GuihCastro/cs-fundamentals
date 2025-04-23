using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int qtd;
            double num;
            double soma = 0;
            double media;

            Console.WriteLine("\tCalculadora de média aritmética\n");

            Console.Write("Informe de quantos valores será calculada a média aritmética: ");
            qtd = int.Parse(Console.ReadLine());

            for (int i = 0; i < qtd; i++)
            {
                Console.Write("Informe o {0}º valor: ", i + 1);
                num = double.Parse(Console.ReadLine());
                soma += num;
            }

            media = soma / qtd;

            Console.WriteLine("\nForam informados {0} números, e a média aritmética deles é: {1}", qtd, media);

            Console.ReadKey();
        }
    }
}
