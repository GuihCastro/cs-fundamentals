using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class FormaGeometrica
    {
        public FormaGeometrica(string tipo)
        {
            this.Tipo = tipo;
            this.Base = 0;
            this.Altura = 0;
        }

        public FormaGeometrica(string tipo, double b, double h)
        {
            this.Tipo = tipo;
            this.Base = b;
            this.Altura = h;
        }

        public virtual string Tipo { get; }

        public double Base { get; set; }

        public double Altura { get; set; }

        public virtual double CalcularArea()
        {
            return 0;
        }
    }
}
