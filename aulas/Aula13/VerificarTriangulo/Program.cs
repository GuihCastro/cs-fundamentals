using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificarTriangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;
            bool formaTriangulo;

            Console.WriteLine("\tVerificando se 3 valores formam um triângulo\n");

            Console.Write("Informe o valor de A: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Informe o valor de B: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Informe o valor de C: ");
            c = int.Parse(Console.ReadLine());

            formaTriangulo = (a < b + c) && (b < a + c) && (c < a + b);

            if (formaTriangulo)
            {
                Console.WriteLine("\n{0}, {1} e {2} FORMAM um triângulo!", a, b, c);
            }
            else
            {
                Console.WriteLine("\n{0}, {1} e {2} NÃO formam um triângulo!", a, b, c);
            }

            Console.ReadKey();
        }
    }
}
