using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeMaterias
{
    public class Materia : MateriaAbstrata
    {
        private float nota1;
        private float nota2;
        private float media;
        private string status;
        public float Nota1 { get => this.nota1; set => this.nota1 = value; }
        public float Nota2 { get => this.nota2; set => this.nota1 = value; }
        public float Media { get => this.media; }
        public string Status { get => this.status; }

        public Materia(string nome, float notaMinima, float nota1, float nota2) : base(nome, notaMinima)
        {
            this.nota1 = nota1;
            this.nota2 = nota2;
            this.media = (this.Nota1 + this.Nota2) / 2;
            this.status = this.Media >= this.NotaMinima ? "Aprovado(a)" : "Reprovado(a)";
        }

        public override void ExibirDados()
        {
            Console.WriteLine($"{this.Nome} - Nota 1: {this.Nota1.ToString("n1")} | Nota 2: {this.Nota2.ToString("n1")} | Média: {this.Media.ToString("n1")}");
            Console.WriteLine($"\tSituação: {this.Status}");
        }

        public void AtualizarDados()
        {
            this.media = (this.Nota1 + this.Nota2) / 2;
            this.status = this.Media >= this.NotaMinima ? "Aprovado(a)" : "Reprovado(a)";
            Console.WriteLine($"\nDados de '{this.Nome}' atualizados com sucesso!");
        }
    }
}
