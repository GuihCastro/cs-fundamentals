using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            string nomeFerramenta;
            int durabilidadeFerramenta;
            List<Ferramenta> ferramentas = new List<Ferramenta>();

            MeuConsole.Escrever("Olá, Mundo!");

            nome = MeuConsole.Ler("\nDigite o seu nome: ");
            MeuConsole.Escrever($"Seja bem vindo(a), {nome}!\n");

            for (int i = 0; i < 2; i++)
            {
                nomeFerramenta = MeuConsole.Ler($"Digite o nome da ferramenta {i + 1}: ");
                durabilidadeFerramenta = int.Parse(MeuConsole.Ler($"Digite a durabilidade da ferramenta {i + 1}: "));

                Ferramenta ferramenta = new Ferramenta(nomeFerramenta, durabilidadeFerramenta);
                ferramentas.Add(ferramenta);
            }

            MeuConsole.Escrever("\nFerramentas:");
            ferramentas[0].ExibirDados();
            ferramentas[1].ExibirDados();

            MeuConsole.Aguardar();
        }
    }
}
