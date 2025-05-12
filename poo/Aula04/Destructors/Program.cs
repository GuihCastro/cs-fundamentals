using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tool ferramenta1 = new Tool("Alicate");
            Tool ferramenta2 = new Tool("Martelo");

            ferramenta1 = null;
            ferramenta2 = new Tool("Chave de Fenda");

            GC.Collect(); // força a coleta de lixo

            Console.ReadKey();
        }
    }
}
