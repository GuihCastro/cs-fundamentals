using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeMaterias
{
    public class Aluno : AlunoInterface
    {
        private string nome;
        private string email;
        public string Nome { get => this.nome; set => this.email = value; }
        public string Email { get => this.email; set => this.nome = value; }

        public Aluno(string nome)
        {
            this.nome = nome;
            this.email = "";
        }

        public Aluno(string nome, string email)
        {
            this.nome = nome;
            this.email = email;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {this.Nome} | Email: {this.Email}");
        }
    }
}
