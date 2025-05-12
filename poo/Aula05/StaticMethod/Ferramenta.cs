using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMethod
{
    public class Ferramenta
    {
        private static int nextID;

        private int ID { get; set; }

        public string Nome { get; set; }

        public int Durabilidade { get; set; }

        public Ferramenta(string nome, int durabilidade)
        {
            try
            {
                nextID++;
            }
            catch
            {
                nextID = 1;
            }
            this.ID = nextID;
            this.Nome = nome;
            this.Durabilidade = durabilidade;
        }

        public void ExibirDados()
        {
            MeuConsole.Escrever($"ID: {this.ID} | Nome: {this.Nome} | Durabilidade: {this.Durabilidade}");
        }
    }
}
