using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tOperadores");

            Console.WriteLine("\nAritméticos");
            Console.Write("5 + 2 = ");
            Console.WriteLine(5 + 2);
            Console.Write("5 - 2 = ");
            Console.WriteLine(5 - 2);
            Console.Write("5 * 2 = ");
            Console.WriteLine(5 * 2);
            Console.Write("5 / 2 = ");
            Console.WriteLine(5 / 2);
            Console.Write("5 % 2 = ");
            Console.WriteLine(5 % 2);

            Console.WriteLine("\nLógicos");
            Console.Write("5 > 2: ");
            Console.WriteLine(5 > 2);
            Console.Write("5 >= 2: ");
            Console.WriteLine(5 >= 2);
            Console.Write("5 < 2: ");
            Console.WriteLine(5 < 2);
            Console.Write("5 <= 2: ");
            Console.WriteLine(5 <= 2);
            Console.Write("5 == 2: ");
            Console.WriteLine(5 == 2);

            Console.ReadKey();
        }
    }
}
