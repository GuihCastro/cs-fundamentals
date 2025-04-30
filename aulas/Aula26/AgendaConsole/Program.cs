using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaConsole
{
    internal class Program
    {
        static int ShowMenu()
        {
            try
            {
                int opt;
                Console.Clear();
                Console.WriteLine("\tAgenda de Contatos\n");
                Console.WriteLine("[1] Listar Contatos");
                Console.WriteLine("[2] Adicionar Contato");
                Console.WriteLine("[3] Editar Contato");
                Console.WriteLine("[4] Excluir Contato");
                Console.WriteLine("[5] Buscar Contato");
                Console.WriteLine("[0] Salvar e Sair");
                Console.Write("Opção: ");
                opt = int.Parse(Console.ReadLine());
                return opt;
            }
            catch (Exception e)
            {
                Console.WriteLine($"\nErro: {e.Message}");
                Console.Write("\nPressione qualquer tecla...");
                Console.ReadKey();
                return 999;
            }
        }

        static void ReadContacts(string[] names, string[] emails)
        {
            int i = 0;
            while (names[i] != null)
            {
                if (i == 0)
                {
                    Console.WriteLine("\nContatos:");
                }
                Console.WriteLine($"Nome: {names[i]} | e-mail: {emails[i]}");
                i++;
            }
            if (i == 0)
            {
                Console.WriteLine("\nA agenda está vazia!");
            }
            Console.Write("\nPressione qualquer tecla...");
            Console.ReadKey();
        }

        static void CreateContact(ref string[] names, ref string[] emails)
        {
            string name;
            string email;
            int i = 0;
            while (names[i] != null)
            {
                i++;
            }
            try
            {
                Console.WriteLine("\nNovo Contato");
                Console.Write("Nome: ");
                name = Console.ReadLine();
                Console.Write("E-mail: ");
                email = Console.ReadLine();
                for (int j = 0; j < i; j++)
                {
                    if (emails[j] == email)
                    {
                        Console.WriteLine("\nJá existe um contato com este e-mail.");
                        return;
                    }
                }
                names[i] = name;
                emails[i] = email;
                Console.WriteLine("\nContato adicionado com sucesso à agenda!");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro: {e.Message}");
            }
        }

        static int SearchContact(string[] names, string[] emails, string nameSearched)
        {
            int index = -1;
            int i = 0;
            while (names[i] != null)
            {
                if (names[i].ToLower() == nameSearched.ToLower())
                {
                    index = i;
                    break;
                }
                i++;
            }
            return index;
        }

        static void UpdateContact(ref string[] names, ref string[] emails)
        {
            string nameToUpdate;
            string emailToUpdate;
            string newName;
            string newEmail;

            Console.Write("\nInforme o nome do contato que deseja atualizar: ");
            nameToUpdate = Console.ReadLine();
            int index = SearchContact(names, emails, nameToUpdate);
            if (index == -1)
            {
                Console.WriteLine($"\nNão foi encontrado nenhum contato com o nome '{nameToUpdate}'");
            }
            else
            {
                nameToUpdate = names[index];
                emailToUpdate = emails[index];
                Console.WriteLine($"\nContato encontrado:\nNome: {nameToUpdate} | e-mail: {emailToUpdate}");
                Console.Write("Deseja alterar este contato (s/n)? ");
                string confirm = Console.ReadLine();
                if (confirm.ToLower() == "n")
                {
                    return;
                }
                Console.Write("\nInforme o novo NOME para o contato (ou deixe em branco para manter): ");
                newName = Console.ReadLine();
                if (newName == "") newName = nameToUpdate;
                Console.Write("\nInforme o novo E-MAIL para o contato (ou deixe em branco para manter): ");
                newEmail = Console.ReadLine();
                if (newEmail == "") newEmail = emailToUpdate;
                for (int i = 0; names[i] != null; i++)
                {
                    if (emails[i] == newEmail && i != index)
                    {
                        Console.WriteLine("\nJá existe um contato com este e-mail.");
                        return;
                    }
                }
                names[index] = newName;
                emails[index] = newEmail;
                Console.WriteLine($"\nContato atualizado com sucesso!\nNome: {names[index]} | e-mail: {emails[index]}");
            }
        }

        static bool DeleteContact(ref string[] names, ref string[] emails)
        {
            string emailToDelete;
            string confirm;
            int index;

            Console.Write("Informe o E-MAIL do contato que deseja excluir: ");
            emailToDelete = Console.ReadLine();
            index = searchByEmail(emails, emailToDelete);
            if (index == -1)
            {
                Console.WriteLine($"Não foi encontrado nenhum contato com o e-mail '{emailToDelete}'");
                return false;
            }

            Console.WriteLine($"\nContato encontrado:\nNome: {names[index]} | e-mail: {emails[index]}");
            Console.Write("Confirmar a exclusão do contato (s/n)? ");
            confirm = Console.ReadLine();
            if (confirm.ToLower() == "n")
            {
                Console.WriteLine("O contato não foi excluido.");
                return false;
            }

            for (int i = index; names[i] != null; i++)
            {
                names[i] = names[i + 1];
                emails[i] = emails[i + 1];
            }
            Console.WriteLine($"Contato excluído com sucesso!");
            return true;
        }

        static int searchByEmail(string[] emails, string emailToDelete)
        {
            int index = -1;
            for (int i = 0; emails[i] != null; i++)
            {
                if (emails[i].ToLower() == emailToDelete.ToLower()) index = i;
            }
            return index;
        }

        static void Main(string[] args)
        {
            string[] names = new string[200];
            string[] emails = new string[200];
            int option;
            DataBase.file = "dados.csv";

            DataBase.RecoverData(ref names, ref emails);

            //names[0] = "Guilherme";
            //emails[0] = "guilherme@gmail.com";
            //names[1] = "Mariana";
            //emails[1] = "marana@gmail.com";
            //names[2] = "Maggie";
            //emails[2] = "maggie@gmail.com";

            do
            {
                option = ShowMenu();

                switch (option)
                {
                    case 0:
                        DataBase.SaveData(ref names, ref emails);
                        Console.WriteLine("\nObrigado e volte sempre!");
                        Console.Write("\nPressione qualquer tecla...");
                        Console.ReadKey();
                        break;
                    case 1:
                        ReadContacts(names, emails);
                        break;
                    case 2:
                        CreateContact(ref names, ref emails);
                        Console.Write("\nPressione qualquer tecla...");
                        Console.ReadKey();
                        break;
                    case 3:
                        UpdateContact(ref names, ref emails);
                        Console.Write("\nPressione qualquer tecla...");
                        Console.ReadKey();
                        break;
                    case 4:
                        DeleteContact(ref names, ref emails);
                        Console.Write("\nPressione qualquer tecla...");
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Write("\nDigite o nome do contato que deseja encontrar: ");
                        string nameSearched = Console.ReadLine();
                        int index = SearchContact(names, emails, nameSearched);
                        if (index == -1)
                        {
                            Console.WriteLine($"\nNão foi encontrado nenhum contato com o nome '{nameSearched}'");
                        }
                        else
                        {
                            Console.WriteLine($"\nContato encontrado:\nNome: {names[index]} | e-mail: {emails[index]}");
                        }
                        Console.Write("\nPressione qualquer tecla...");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida!");
                        Console.Write("\nPressione qualquer tecla...");
                        Console.ReadKey();
                        break;

                }
            }
            while (option != 0);
        }
    }
}
