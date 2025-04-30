using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaConsole
{
    internal class DataBase
    {
        public static string file = "data.csv";

        public static bool SaveData(ref string[] names, ref string[] emails)
        {
            try
            {
                StreamWriter sw = new StreamWriter(file, false);
                for (int i = 0; names[i] != null; i++)
                {
                    sw.WriteLine($"{names[i]};{emails[i]}");
                }
                sw.Close();
                Console.WriteLine("\nAgenda salva com sucesso!");
            }
            catch (Exception e) 
            {
                Console.WriteLine($"Erro ao salvar dados: {e.Message}");
                return false;
            }
            return true;
        }

        public static bool RecoverData(ref string[] names, ref string[] emails)
        {
            try
            {
                string line;
                StreamReader sr = new StreamReader(file);
                line = sr.ReadLine();
                for (int i = 0; line != null; i++)
                {
                    names[i] = line.Split(';')[0];
                    emails[i] = line.Split(';')[1];
                    line = sr.ReadLine();
                }
                //Console.ReadKey();
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro ao ler os dados: {e.Message}");
            }
            return true;
        }
    }
}
