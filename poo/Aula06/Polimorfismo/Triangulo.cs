using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Triangulo : FormaGeometrica
    {
        public Triangulo() : base("Triângulo") { }

        public Triangulo(double b, double h) : base("Triângulo", b, h) { }

        public override string Tipo => base.Tipo;

        public override double CalcularArea()
        {
            return (this.Base * this.Altura) / 2;
        }
    }
}
