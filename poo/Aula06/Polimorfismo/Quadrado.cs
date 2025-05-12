using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Quadrado : FormaGeometrica
    {
        public Quadrado() : base("Quadrado") { }

        public Quadrado(double b, double h) : base("Quadrado", b, h) { }

        public override string Tipo => base.Tipo;

        public override double CalcularArea()
        {
            return this.Base * this.Altura;
        }
    }
}
