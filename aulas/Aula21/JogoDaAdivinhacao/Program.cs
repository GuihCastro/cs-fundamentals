using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaAdivinhacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] perguntas =
            {
                "Tem capa mas não voa...?",
                "Sem sair do seu canto, é capaz de viajar ao redor do mundo...?",
                "É alta quando jovem e baixinha quando fica velha. Além disso, é rápida quando magra e lentra quando gorda"
            };
            string[] respostas =
            {
                "Livro",
                "Selo",
                "Vela"
            };
            string resposta;
            string SimOuNao;
            
            Console.WriteLine("\tJogo da Adivinhação\n");

            while (true)
            {
                int index = new Random().Next(0, perguntas.Length);
                Console.WriteLine("O que é, o que é: {0}", perguntas[index]);
                Console.Write("Resposta: ");
                resposta = Console.ReadLine();

                while (resposta.ToLower() != respostas[index].ToLower())
                {
                    Console.Write("Ai que burro! Resposta errada...\nTentar novamente (s/n)? ");
                    SimOuNao = Console.ReadLine();
                    if (SimOuNao.ToLower() == "n")
                    {
                        break;
                    }
                    Console.Write("Resposta: ");
                    resposta = Console.ReadLine();
                }

                if (resposta.ToLower() == respostas[index].ToLower())
                {
                    Console.WriteLine("\nResposta correta!");
                }
                else
                {
                    Console.WriteLine("\nA resposta certa era: {0}", respostas[index]);
                }

                Console.Write("\nQuer jogar novamente (s/n)? ");
                SimOuNao = Console.ReadLine();

                if (SimOuNao.ToLower() == "n")
                {
                    Console.WriteLine("\nObrigado por jogar!");
                    break;
                }

                Console.Clear();
            }

            Console.ReadKey();
        }
    }
}
