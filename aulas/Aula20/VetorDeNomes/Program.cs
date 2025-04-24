using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetorDeNomes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[6];

            Console.WriteLine("\tCriando um vetor com 6 nomes\n");

            for (int i = 0; i < nomes.Length; i++)
            {
                Console.Write("Digite o {0}º nome: ", i + 1);
                nomes[i] = Console.ReadLine();
            }

            Console.Write("\nNomes: ");
            for (int i =0; i < nomes.Length; i++)
            {
                if (i < nomes.Length - 1)
                {
                    Console.Write("{0}, ", nomes[i]);
                }
                else
                {
                    Console.Write("{0}.", nomes[i]);
                }
            }

            Console.ReadKey();
            Console.Clear();
        }
    }
}
