using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMethod
{
    public class MeuConsole
    {
        public static string Ler()
        {
            return Console.ReadLine();
        } 

        public static string Ler(string texto)
        {
            Console.Write(texto);
            return Console.ReadLine();
        }

        public static void Escrever(string texto)
        {
            Console.WriteLine(texto);
        }

        public static void Aguardar()
        {
            Console.Write("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}
