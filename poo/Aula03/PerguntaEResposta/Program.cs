using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerguntaEResposta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;

            PerguntaComDica pergunta = new PerguntaComDica();
            pergunta.Texto = "Qual é a capital da França?";
            pergunta.Resposta = "Paris";
            pergunta.Dica = "É também conhecida como a cidade do amor.";

            Console.WriteLine("\tPergunta e Resposta\n");

            Console.WriteLine("Pergunta: " + pergunta.Texto);
            Console.WriteLine("Dica: " + pergunta.Dica);
            Console.Write("Resposta: ");
            input = Console.ReadLine();

            if (input.ToLower() == pergunta.Resposta.ToLower())
            {
                Console.WriteLine("\nResposta correta! Parabéns!");
            }
            else
            {
                Console.WriteLine("\nResposta errada!\nA resposta correta é: " + pergunta.Resposta);
            }

            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
