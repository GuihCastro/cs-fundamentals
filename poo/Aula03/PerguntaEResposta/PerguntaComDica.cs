using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerguntaEResposta
{
    public class PerguntaComDica : Pergunta
    {
        public PerguntaComDica() : base()
        {
            this.Dica = string.Empty;
        }

        public PerguntaComDica(string texto, string resposta, string dica) : base(texto, resposta) 
        {
            this.Dica = dica;
        }

        public string Dica { get; set; }
    }
}
