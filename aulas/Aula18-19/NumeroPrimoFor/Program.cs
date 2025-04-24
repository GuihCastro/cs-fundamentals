using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroPrimoFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            bool ehPrimo = true;

            Console.WriteLine("\tPrograma que verifica se o númeor informado é primo\n");

            Console.Write("Informe o número que deseja verificar: ");
            num = int.Parse(Console.ReadLine());

            for (int i = 1; i < num; i**)
            {
                if (num % i == 0)
                {
                    ehPrimo = false;
                    break;
                }
            }

            if (ehPrimo)
            {
                Console.WriteLine("\nO número {0} É primo!", num);
            }
            else
            {
                Console.WriteLine("\nO número {0} NÃO é primo!", num);
            }

            Console.ReadKey();
        }
    }
}
