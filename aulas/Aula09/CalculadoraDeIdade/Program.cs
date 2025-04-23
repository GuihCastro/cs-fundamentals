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
            int anoAtual = DateTime.Now.Year;
            int mesAtual = DateTime.Now.Month;
            int diaAtual = DateTime.Now.Day;
            int anoNascimento;
            int mesNascimento;
            int diaNascimento;
            int idade;
            string nome;

            Console.WriteLine("\tCalculadora de Idades\n");

            Console.Write("Informe o nome da pessoa: ");
            nome = Console.ReadLine();
            do
            {
                Console.Write("Informe o ano de nascimento: ");
                anoNascimento = int.Parse(Console.ReadLine());
                if (anoNascimento > anoAtual)
                {
                    Console.WriteLine("Ano inválido. Tente novamente.");
                }
            }
            while (anoNascimento > anoAtual);

            Console.Write("Informe o mês de nascimento (em números): ");
            mesNascimento = int.Parse(Console.ReadLine());
            Console.Write("Informe o dia de nascimento (em números): ");
            diaNascimento = int.Parse(Console.ReadLine());

            if ((mesNascimento > mesAtual) | ((mesNascimento == mesAtual) & (diaNascimento > diaAtual)))
            {
                idade = anoAtual - anoNascimento - 1;
            }
            else
            {
                idade = anoAtual - anoNascimento;
            }

            Console.WriteLine("\n{0} tem {1} anos hoje.", nome, idade);

            Console.ReadKey();
        }
    }
}
