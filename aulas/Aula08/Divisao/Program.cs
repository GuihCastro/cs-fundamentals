using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divisao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1;
            double n2;
            double quotient;
            double rest;

            Console.WriteLine("\tPrograma que calcula o quociente e o resto da divisão entre 2 números\n");
            Console.Write("Informe o DIVIDENDO: ");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe o DIVISOR: ");
            n2 = Convert.ToDouble(Console.ReadLine());
            quotient = n1 / n2;
            rest = n1 % n2;

            Console.WriteLine("\nQUOCIENTE da divisão ({0} / {1}): {2}", n1, n2, quotient);
            Console.WriteLine("RESTO da divisão ({0} / {1}): {2}", n1, n2, rest);

            Console.ReadKey();
        }
    }
}
