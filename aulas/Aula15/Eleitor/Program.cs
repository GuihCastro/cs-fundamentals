using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eleitor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String nome;
            String msg;
            int idade;

            Console.WriteLine("\tPrograma para classificar eleitor pela idade\n");

            Console.Write("Informe o nome: ");
            nome = Console.ReadLine();
            Console.Write("Informe a idade: ");
            idade = int.Parse(Console.ReadLine());

            if (idade < 16)
            {
                msg = "não tem idade para votar.";
            }
            else if (idade < 18 || idade >= 70)
            {
                msg = "é eleitor(a) opcional.";
            }
            else
            {
                msg = "é eleitor(a) obrigatório(a).";
            }

            Console.WriteLine("\n{0} {1}", nome, msg);

            Console.ReadKey();
        }
    }
}
