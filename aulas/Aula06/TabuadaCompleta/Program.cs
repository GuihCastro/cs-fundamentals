using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabuadaCompleta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            int number;

            Console.WriteLine("\tTabuada Completa\n");

            Console.Write("Digite um número para ver a sua tabuada: ");
            input = Console.ReadLine();
            number = Convert.ToInt32(input);

            Console.WriteLine("\nTabuada do {0}", number);
            Console.WriteLine("{0} x 1 = {1}", number, (number * 1));
            Console.WriteLine("{0} x 2 = {1}", number, (number * 2));
            Console.WriteLine("{0} x 3 = {1}", number, (number * 3));
            Console.WriteLine("{0} x 4 = {1}", number, (number * 4));
            Console.WriteLine("{0} x 5 = {1}", number, (number * 5));
            Console.WriteLine("{0} x 6 = {1}", number, (number * 6));
            Console.WriteLine("{0} x 7 = {1}", number, (number * 7));
            Console.WriteLine("{0} x 8 = {1}", number, (number * 8));
            Console.WriteLine("{0} x 9 = {1}", number, (number * 9));
            Console.WriteLine("{0} x 10 = {1}", number, (number * 10));
            Console.ReadKey();
        }
    }
}
