using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quadrado quadrado1 = new Quadrado(2, 2);
            Quadrado quadrado2 = new Quadrado(4, 4);
            Quadrado quadrado3 = new Quadrado(6, 6);
            Triangulo triangulo1 = new Triangulo(3, 3);
            Triangulo triangulo2 = new Triangulo(6, 6);
            Triangulo triangulo3 = new Triangulo(9, 9);

            List<FormaGeometrica> formas = new List<FormaGeometrica>();
            formas.Add(quadrado1);
            formas.Add(quadrado2);
            formas.Add(quadrado3);
            formas.Add(triangulo1);
            formas.Add(triangulo2);
            formas.Add(triangulo3);

            foreach (FormaGeometrica forma in formas)
            {
                Console.WriteLine($"A área do {forma.Tipo} de base {forma.Base} e altura {forma.Altura} é: {forma.CalcularArea()}");
            }

            Console.ReadKey();
        }
    }
}
