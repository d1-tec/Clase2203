using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_ComposicionDelegacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangulo rectangulo = new Rectangulo(3, 5);
            Console.WriteLine($"El area del rectangulo es {rectangulo.CalcularArea()}");
            Cuadrado cuadrado = new Cuadrado(4);
            Console.WriteLine($"El area del cuadrado es {cuadrado.CalcularArea()}");
            Console.ReadLine();
        }
    }
}
