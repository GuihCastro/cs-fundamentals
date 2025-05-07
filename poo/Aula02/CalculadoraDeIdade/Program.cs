using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDeIdade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tCalculadora de Idade\n");

            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();
            Console.Write("Digite seu ano de nascimento: ");
            int anoNascimento = int.Parse(Console.ReadLine());

            Pessoa p = new Pessoa(nome, anoNascimento);

            p.ExibirDados();

            Console.ReadKey();
        }
    }
}
