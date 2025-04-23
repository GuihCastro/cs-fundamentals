using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabuadaDefinitiva
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("\tCalculando a tabuada de qualquer número dinamicamente\n");

            Console.Write("Informe o número para saber sua tabuada: ");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", num, i, num * i);
            }

            Console.ReadKey();
        }
    }
}
