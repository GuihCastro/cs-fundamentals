using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeMaterias
{
    public class Gerenciador
    {
        private Aluno estudante;
        private List<Materia> materias;
        public Aluno Estudante { get => this.estudante; }
        public List<Materia> Materias { get => this.materias; }

        public Gerenciador(Aluno estudante)
        {
            this.estudante = estudante;
            this.materias = new List<Materia>();
        }

        public void CadastrarMateria()
        {
            string input;
            string nome;
            float notaMinima;
            float nota1;
            float nota2;
            Materia materia;

            Console.Write("\nNome da matéria: ");
            nome = Console.ReadLine();
            if (this.Materias.Exists(m => m.Nome == nome))
            {
                Console.WriteLine("Matéria já cadastrada!");
                return;
            }
            Console.Write("Nota mínima para aprovação: ");
            input = Console.ReadLine();
            while (!float.TryParse(input, out notaMinima))
            {
                Console.WriteLine("Nota inválida! Informe apenas valores numéricos.");
                Console.Write("Nota mínima: ");
                input = Console.ReadLine();
            }
            Console.Write("Nota da 1ª prova: ");
            input = Console.ReadLine();
            while (!float.TryParse(input, out nota1))
            {
                Console.WriteLine("Nota inválida! Informe apenas valores numéricos.");
                Console.Write("Nota da 1ª prova: ");
                input = Console.ReadLine();
            }
            Console.Write("Nota da 2ª prova: ");
            input = Console.ReadLine();
            while (!float.TryParse(input, out nota2))
            {
                Console.WriteLine("Nota inválida! Informe apenas valores numéricos.");
                Console.Write("Nota da 2ª prova: ");
                input = Console.ReadLine();
            }

            materia = new Materia(nome, notaMinima, nota1, nota2);
            this.materias.Add(materia);

            Console.WriteLine($"\nMatéria '{this.materias.Last().Nome}' cadastrada com sucesso!");
        }

        public void ExibirMaterias()
        {
            if (this.Materias.Count < 1)
            {
                Console.WriteLine("\nNão existem matérias cadastradas!");
                return;
            }
            int i = 1;
            Console.WriteLine("\n---Matérias cadastradas---");
            foreach (Materia materia in this.Materias)
            {
                Console.Write($"{i} | ");
                materia.ExibirDados();
                i++;
            }
            Console.WriteLine("------");
        }

        public bool EditarMateria()
        {
            string input;
            string nome;
            float notaMinima;
            float nota1;
            float nota2;
            int i;

            this.ExibirMaterias();
            Console.Write("\nInforme o índice da matéria que deseja editar (ou '0' para cancelar): ");
            input = Console.ReadLine();
            while (!int.TryParse(input, out i) || i < 0 || i >= this.Materias.Count + 1)
            {
                Console.WriteLine("Índice inválido! Informe apenas valores numéricos presentes na lista.");
                Console.Write("Índice (ou '0' para cancelar): ");
                input = Console.ReadLine();
            }

            if (i == 0)
            {
                Console.WriteLine("Operação cancelada!");
                return false;
            }

            i--;

            Console.Write("\nNome da matéria (ou deixe em branco para manter): ");
            nome = Console.ReadLine();
            if (this.Materias.Exists(m => m.Nome == nome))
            {
                Console.WriteLine("Matéria já cadastrada!");
                return false;
            }
            if (nome != "")
            {
                this.Materias[i].Nome = nome;
            }
            Console.Write("Nota mínima para aprovação (ou deixe em branco para manter): ");
            input = Console.ReadLine();
            while (!float.TryParse(input, out notaMinima) && input != "")
            {
                Console.WriteLine("Nota inválida! Informe apenas valores numéricos.");
                Console.Write("Nota mínima: ");
                input = Console.ReadLine();
            }
            if (notaMinima != 0)
            {
                this.Materias[i].NotaMinima = notaMinima;
            }
            Console.Write("Nota da 1ª prova: ");
            input = Console.ReadLine();
            while (!float.TryParse(input, out nota1) && input != "")
            {
                Console.WriteLine("Nota inválida! Informe apenas valores numéricos.");
                Console.Write("Nota da 1ª prova: ");
                input = Console.ReadLine();
            }
            if (nota1 != 0)
            {
                this.Materias[i].Nota1 = nota1;
            }
            Console.Write("Nota da 2ª prova: ");
            input = Console.ReadLine();
            while (!float.TryParse(input, out nota2) && input != "")
            {
                Console.WriteLine("Nota inválida! Informe apenas valores numéricos.");
                Console.Write("Nota da 2ª prova: ");
                input = Console.ReadLine();
            }
            if (nota2 != 0)
            {
                this.Materias[i].Nota2 = nota2;
            }

            this.Materias[i].AtualizarDados();

            return true;
        }

        public bool DeletarMateria()
        {
            string input;
            string materia;
            int i;

            this.ExibirMaterias();
            Console.Write("\nInforme o índice da matéria a ser deletada (ou '0' para cancelar): ");
            input = Console.ReadLine();
            while (!int.TryParse(input, out i) || i < 0 || i >= this.Materias.Count + 1)
            {
                Console.WriteLine("Índice inválido! Informe apenas valores numéricos presentes na lista.");
                Console.Write("Índice (ou '0' para cancelar): ");
                input = Console.ReadLine();
            }

            if (i == 0)
            {
                Console.WriteLine("Operação cancelada!");
                return false;
            }

            materia = this.Materias[i - 1].Nome;
            this.materias.RemoveAt(i - 1);

            Console.WriteLine($"\nMatéria '{materia}' deletada com sucesso!");

            return true;
        }
    }
}
