using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecebendoInputs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tRecebendo Inputs\n");

            Console.Write("Digite o seu nome: ");
            string name = Console.ReadLine();
            Console.WriteLine("Olá, {0}! Seja bem vindo ao Digimundo!", name);
            Console.ReadKey();
        }
    }
}
