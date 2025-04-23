using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tVariváveis\n");

            int n1 = 6;
            int n2 = 6;

            Console.WriteLine(n1 + " > " + n2 + ": " + (n1 > n2));
            Console.WriteLine(n1 + " >= " + n2 + ": " + (n1 >= n2));
            Console.WriteLine(n1 + " < " + n2 + ": " + (n1 < n2));
            Console.WriteLine(n1 + " <= " + n2 + ": " + (n1 <= n2));
            Console.WriteLine(n1 + " == " + n2 + ": " + (n1 == n2));
            Console.WriteLine(n1 + " != " + n2 + ": " + (n1 != n2));

            Console.ReadKey();
        }
    }
}
