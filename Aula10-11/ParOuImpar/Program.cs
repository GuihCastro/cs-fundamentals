using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParOuImpar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            bool isEven;
            string txt;

            Console.WriteLine("\tPrograma para verificar se número é par ou ímpar\n");

            Console.Write("Informe um número inteiro: ");
            num = int.Parse(Console.ReadLine());
            isEven = num % 2 == 0;

            if (isEven)
            {
                txt = "par";
            }
            else
            {
                txt = "ímpar";
            }

            Console.WriteLine("O número {0} é {1}", num, txt.ToUpper());

            Console.ReadKey();
        }
    }
}
