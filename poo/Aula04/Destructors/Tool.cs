using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destructors
{
    public class Tool
    {
        public Tool(string name)
        {
            this.Name = name;
            Console.WriteLine($"Ferramenta '{this.Name}' criada!");
        }

        // finalizador ou destruidor
        ~Tool()
        {
            Console.WriteLine($"Ferramenta '{this.Name}' destruída!");
        }

        public string Name { get; set; }
    }
}
