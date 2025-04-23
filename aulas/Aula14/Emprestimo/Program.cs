using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emprestimo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boolean estaEmpregado = false;
            Boolean possuiFiador = false;
            String input;

            Console.WriteLine("\tSimulação de Empréstimo\n");

            Console.Write("Está empregado (s/n)? ");
            input = Console.ReadLine();
            if (input.ToLower() == "s")
            {
                estaEmpregado = true;
            }
            Console.Write("Possui fiador (s/n)? ");
            input = Console.ReadLine();
            if (input.ToLower() == "s")
            {
                possuiFiador = true;
            }

            if (estaEmpregado && possuiFiador)
            {
                Console.WriteLine("\nEmprestimo CONCEDIDO!");
            }
            else
            {
                Console.WriteLine("\nEmprestimo NEGADO!");
            }

            Console.ReadKey();
        }
    }
}
