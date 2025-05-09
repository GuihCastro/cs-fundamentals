using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerguntaEResposta
{
    public class Pergunta
    {
		public Pergunta()
		{
            this.Texto = string.Empty;
            this.Resposta = string.Empty;
        }

        public Pergunta(string texto, string resposta)
        {
            this.Texto = texto;
            this.Resposta = resposta;
        }

		public string Texto { get; set; }

		public string Resposta { get; set; }
	}
}
