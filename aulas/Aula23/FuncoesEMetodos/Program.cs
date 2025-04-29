using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncoesEMetodos
{
    internal class Program
    {
        // modificadores de acesso | tipo | nome | parâmetros

        // Função que executa uma ação, sem parâmetros e sem retorno
        public static void MostrarDataAtual()
        {
            string dataAtual = DateTime.Now.Date.ToString();
            Console.WriteLine("\nData atual: {0}", dataAtual);
        }

        // Função que recebe dois parâmetros e executa uma ação, sem retorno
        public static void Cumprimentar(string nome, int idade)
        {
            Console.WriteLine("\nOlá, {0}! Você tem {1} anos.", nome, idade);
        }

        // Função que recebe um parâmetro, executa uma ação e retorna um valor
        public static int CalcularIdade(int anoNascimento)
        {
            int anoAtual = DateTime.Now.Year;
            int idade = anoAtual - anoNascimento;
            return idade;
        }

        static void Main(string[] args)
        {
            string nome;
            int anoNascimento;
            int idade;

            Console.WriteLine("\tExperimentando Funções\n");

            Console.Write("Qual é o seu nome? ");
            nome = Console.ReadLine();
            Console.Write("Em que ano você nasceu? ");
            anoNascimento = int.Parse(Console.ReadLine());

            idade = CalcularIdade(anoNascimento);
            Cumprimentar(nome, idade);
            MostrarDataAtual();

            Console.ReadKey();
        }
    }
}
