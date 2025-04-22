using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaDoTriangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double h;
            string input;

            Console.WriteLine("\tPrograma para calcular a área de um triângulo\n");

            Console.Write("Informe a BASE do triângulo: ");
            input = Console.ReadLine();
            b = Convert.ToDouble(input);
            Console.Write("Informe a ALTURA do triângulo: ");
            input = Console.ReadLine();
            h = Convert.ToDouble(input);
            a = (b * h) / 2;
            Console.WriteLine("\nA área do triângulo de base {0} e altura {1} é: {2}", b, h, a);
            Console.ReadKey();
        }
    }
}
