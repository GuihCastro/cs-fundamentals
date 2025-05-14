using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeMaterias
{
    internal class Program
    {
        static void Logar(ref Aluno aluno, ref Gerenciador gm)
        {
            string nome;
            string email;
            Console.Write("Nome do aluno: ");
            nome = Console.ReadLine();
            Console.Write("Email do aluno: ");
            email = Console.ReadLine();
            aluno = new Aluno(nome, email);
            gm = new Gerenciador(aluno);
        }

        static string ExibirMenu()
        {
            string input;
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("\t[1] - Cadastrar Matéria");
            Console.WriteLine("\t[2] - Consultar Matéria");
            Console.WriteLine("\t[3] - Alterar Matéria");
            Console.WriteLine("\t[4] - Excluir Matéria");
            Console.WriteLine("\t[0] - Sair");
            Console.Write("Opção: ");
            input = Console.ReadLine();
            while (input != "0" && input != "1" && input != "2" && input != "3" && input != "4")
            {
                Console.WriteLine("Opção inválida! Tente novamente.");
                Console.Write("Opção: ");
                input = Console.ReadLine();
            }
            return input;
        }

        static void Main(string[] args)
        {
            string op = "";
            Aluno aluno = new Aluno("");
            Gerenciador gm = new Gerenciador(aluno);

            Logar(ref aluno, ref gm);

            while (op != "0")
            {
                Console.Clear();
                Console.WriteLine("\tGerenciamento de Notas");
                aluno.ExibirDados();
                Console.WriteLine();
                op = ExibirMenu();
                switch (op)
                {
                    case "0":
                        Console.WriteLine("\nPressione qualquer tecla para sair...");
                        Console.ReadKey();
                        break;
                    case "1":
                        gm.CadastrarMateria();
                        Console.WriteLine("\nPressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case "2":
                        gm.ExibirMaterias();
                        Console.WriteLine("\nPressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case "3":
                        gm.EditarMateria();
                        Console.WriteLine("\nPressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case "4":
                        gm.DeletarMateria();
                        Console.WriteLine("\nPressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
