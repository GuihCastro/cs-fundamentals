using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TxtReader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string arquivo = args[0];
            string linha;

            try
            {
                StreamReader sr = new StreamReader(arquivo);
                linha = sr.ReadLine();
                while (linha != null)
                {
                    Console.WriteLine(linha);
                    linha = sr.ReadLine();
                }
                sr.Close();
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }
    }
}
