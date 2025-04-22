using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaiorNumero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int maiorNumero = 0;

            Console.WriteLine("\tPrograma para encontrar o maior de 5 números\n");

            Console.Write("Informe o 1º número: ");
            maiorNumero = int.Parse(Console.ReadLine());
            Console.Write("Informe o 2º número: ");
            num = int.Parse(Console.ReadLine());
            if (num > maiorNumero)
            {
                maiorNumero = num;
            }
            Console.Write("Informe o 3º número: ");
            num = int.Parse(Console.ReadLine());
            if (num > maiorNumero)
            {
                maiorNumero = num;
            }
            Console.Write("Informe o 4º número: ");
            num = int.Parse(Console.ReadLine());
            if (num > maiorNumero)
            {
                maiorNumero = num;
            }
            Console.Write("Informe o 5º número: ");
            num = int.Parse(Console.ReadLine());
            if (num > maiorNumero)
            {
                maiorNumero = num;
            }

            Console.WriteLine("\nO maior dos números informados foi {0}", maiorNumero);

            Console.ReadKey();
        }
    }
}
