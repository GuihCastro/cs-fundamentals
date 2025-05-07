using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooMensagem
{
    public class Mensagem
    {
        //private string txt;

        //public string getTxt()
        //{
        //    return this.txt;
        //}

        //public void setTxt(string txt)
        //{
        //    this.txt = txt;
        //}

        private string txt;

        public string Txt
        {
            get
            {
                return this.txt;
            }

            set
            {
                this.txt = value;
            }
        }

        public void ExibirMensagem()
        {
            Console.WriteLine(this.Txt);
        }
    }
}
