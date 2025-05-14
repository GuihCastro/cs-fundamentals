using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeMaterias
{
    abstract public class MateriaAbstrata
    {
        protected string nome;
        protected float notaMinima;
        public string Nome { get => this.nome; set => this.nome = value; }
        public float NotaMinima { get => this.notaMinima; set => this.notaMinima = value; }

        public MateriaAbstrata(string nome, float notaMinima)
        {
            this.nome = nome;
            this.notaMinima = notaMinima;
        }

        abstract public void ExibirDados();
    }
}
