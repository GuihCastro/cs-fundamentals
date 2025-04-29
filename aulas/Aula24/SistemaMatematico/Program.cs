using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMatematico
{
    internal class Program
    {
        static int ExibirMenu()
        {
            int opc;
            Console.WriteLine("Selecione a opção desejada:");
            Console.WriteLine("\t[1] - Calcular fatorial;");
            Console.WriteLine("\t[2] - Consultar número primo;");
            Console.WriteLine("\t[3] - Dividir 2 números;");
            Console.WriteLine("\t[0] - Encerrar.");
            Console.Write("Opção: ");
            opc = int.Parse(Console.ReadLine());
            return opc;
        }

        static int CalcularFatorial(int num)
        {
            for (int i = num - 1; i >= 1; i--)
            {
                num = num * i;
            }
            return num;
        }

        static void ConferirSePrimo(int num)
        {
            bool ehPrimo = true;
            for (int i = num - 1; i > 1; i--)
            {
                if (num % i == 0)
                {
                    ehPrimo = false;
                    break;
                }
            }
            if (ehPrimo)
            {
                Console.WriteLine($"\n{num} É um número primo.");
            }
            else
            {
                Console.WriteLine($"\n{num} NÃO é um número primo.");
            }
        }

        static void CalcularDivisao(int n1, int n2)
        {
            double quociente = n1 / n2;
            int resto = n1 % n2;
            Console.WriteLine($"\nO quociente de {n1} dividido por {n2} é: {quociente};\nO resto dessa divisão é: {resto}.");
        }

        static void Main(string[] args)
        {
            int opcao = 666;
            int n1;
            int n2;
            int fatorial;

            Console.WriteLine("\tSistema Matemático\n");

            while (opcao != 0)
            {
                opcao = ExibirMenu();

                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Obrigado e volte sempre!");
                        break;
                    case 1:
                        Console.Clear();
                        Console.Write("Informe um número para calcular seu fatorial: ");
                        n1 = int.Parse(Console.ReadLine());
                        fatorial = CalcularFatorial(n1);
                        Console.WriteLine($"\nO fatorial de {n1} é {fatorial}");
                        break;
                    case 2:
                        Console.Clear();
                        Console.Write("Informe um número para conferir se ele é primo: ");
                        n1 = int.Parse(Console.ReadLine());
                        ConferirSePrimo(n1);
                        break;
                    case 3:
                        Console.Clear();
                        Console.Write("Informe o dividendo: ");
                        n1 = int.Parse(Console.ReadLine());
                        Console.Write("Informe o divisor: ");
                        n2 = int.Parse(Console.ReadLine());
                        CalcularDivisao(n1, n2);
                        break;
                }
            Console.ReadKey();
            Console.Clear();
            }
        }
    }
}
