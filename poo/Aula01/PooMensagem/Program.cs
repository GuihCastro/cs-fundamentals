using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooMensagem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mensagem msgEN = new Mensagem();
            //msgEN.setTxt("Hello, World!");
            msgEN.Txt = "Hello, World!";
            Mensagem msgPT = new Mensagem();
            //msgPT.setTxt("Olá, Mundo!");
            msgPT.Txt = "Olá, Mundo!";

            msgEN.ExibirMensagem();
            msgPT.ExibirMensagem();

            Console.ReadKey();
        }
    }
}
