using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroPrimoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int i;
            bool ehPrimo = true;

            Console.WriteLine("\tPrograma que verifica se o número informado é primo ou não\n");

            Console.Write("Informe o número que deseja consultar: ");
            num = int.Parse(Console.ReadLine());
            i = num - 1;

            while (i > 1)
            {
                if (num % i == 0)
                {
                    ehPrimo = false;
                    break;
                }
                i--;
            }

            if (ehPrimo)
            {
                Console.WriteLine("\n{0} É um número primo!", num);
            }
            else
            {
                Console.WriteLine("\n{0} NÃO é um número primo!", num);
            }

            Console.ReadKey();
        }
    }
}
