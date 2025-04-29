using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditorDeTextos
{
    internal class Program
    {
        static int ExibirMenu()
        {
            int opt;
            Console.WriteLine("[1] Abrir / Criar Arquivo;");
            Console.WriteLine("[2] Ler Arquivo;");
            Console.WriteLine("[3] Escrever / Editar Arquivo;");
            Console.WriteLine("[4] Adicionar conteúdo ao arquivo;");
            Console.WriteLine("[0] Sair;");
            Console.Write("Opção: ");
            opt = int.Parse(Console.ReadLine());
            return opt;
        }

        static bool OpenFile(string path)
        {
            try
            {
                StreamReader sr = new StreamReader(path);
                Console.WriteLine($"\nArquivo '{path}' aberto com sucesso!");
                sr.Close();
            }
            catch (FileNotFoundException e)
            {
                string criarArquivo;
                Console.Write($"O arquivo '{path}' não existe. Deseja criá-lo (s/n)? ");
                criarArquivo = Console.ReadLine();
                if (criarArquivo.ToLower() == "n")
                {
                    return false;
                }
                StreamWriter sr = new StreamWriter(path);
                Console.WriteLine($"\nArquivo '{path}' criado com sucesso!");
                sr.Close();
            }

            return true;
        }

        static string ReadFile(string path)
        {
            string line;
            if (path.Length == 0)
            {
                Console.Write("Informe o nome do arquivo: ");
                path = $"{Console.ReadLine()}.txt";
                OpenFile(path);
            }
            try
            {
                StreamReader sr = new StreamReader(path);
                line = sr.ReadLine();
                Console.Clear();
                while (line != null)
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                }
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro: {e.Message}");
            }
            return path;
        }

        static string WriteFile(string path)
        {
            string line;
            if (path.Length == 0)
            {
                Console.Write("Informe o nome do arquivo: ");
                path = $"{Console.ReadLine()}.txt";
                OpenFile(path);
            }
            try
            {
                StreamReader sr = new StreamReader(path);
                if (sr.ToString().Length != 0)
                {
                    string overwrite;
                    Console.Write("O arquivo já tem conteúdo. Deseja sobrescrever (s/n)? ");
                    overwrite = Console.ReadLine();
                    if (overwrite.ToLower() == "n")
                    {
                        sr.Close();
                        return path;
                    }
                }
                sr.Close();
                StreamWriter sw = new StreamWriter(path);
                Console.WriteLine("Informe o texto para escrever no arquivo:\n");
                line = Console.ReadLine();
                sw.WriteLine(line);
                Console.WriteLine("\nArquivo escrito com sucesso!");
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro: {e.Message}");
            }
            return path;
        }

        static string AppendFile(string path)
        {
            string line;
            if (path.Length == 0)
            {
                Console.Write("Informe o nome do arquivo: ");
                path = $"{Console.ReadLine()}.txt";
                OpenFile(path);
            }
            try
            {
                StreamWriter sw = new StreamWriter(path, true);
                Console.WriteLine("Informe o texto para escrever no arquivo:\n");
                line = Console.ReadLine();
                sw.WriteLine(line);
                Console.WriteLine("\nArquivo escrito com sucesso!");
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro: {e.Message}");
            }
            return path;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("\tEditor de Textos\n");

            int option;
            string file = "";
            bool isOpen = false;

            do
            {
                if (isOpen)
                {
                    Console.WriteLine($"Arquivo aberto: {file}");
                }
                option = ExibirMenu();
                switch (option)
                {
                    case 0:
                        Console.WriteLine("Encerrando o programa...");
                        break;
                    case 1:
                        Console.Write("Informe o nome do arquivo: ");
                        file = $"{Console.ReadLine()}.txt";
                        isOpen = OpenFile(file);
                        break;
                    case 2:
                        file = ReadFile(file);
                        isOpen = file.Length > 0;
                        break;
                    case 3:
                        file = WriteFile(file);
                        isOpen = file.Length > 0;
                        break;
                    case 4:
                        file = AppendFile(file);
                        isOpen = file.Length > 0;
                        break;
                }
                Console.Write("\nPressione qualquer tecla...");
                Console.ReadKey();
                Console.Clear();
            }
            while (option != 0);

            Console.ReadKey();
        }
    }
}
