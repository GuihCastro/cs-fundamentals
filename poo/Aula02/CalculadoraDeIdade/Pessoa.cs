using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDeIdade
{
    internal class Pessoa
    {
		public Pessoa(string nome, int anoNascimento)
		{
			this.Nome = nome;
			this.AnoNascimento = anoNascimento;
			this.CalcularIdade();
        }

		private string nome;

		public string Nome
		{
			get { return this.nome; }
			set { this.nome = value; }
		}

		private int anoNascimento;

		public int AnoNascimento
		{
			get { return this.anoNascimento; }
			set { this.anoNascimento = value; }
		}

		private int idade;

		public int Idade
		{
			get
			{
				this.CalcularIdade();
				return this.idade; 
			}
		}

		public void CalcularIdade()
		{
			int anoAtual = DateTime.Now.Year;
			this.idade = anoAtual - this.anoNascimento;
        }

		public void ExibirDados()
		{
            Console.WriteLine($"\nNome: {this.Nome} | Ano de Nascimento: {this.AnoNascimento} | Idade: {this.Idade}");
        }
	}
}
