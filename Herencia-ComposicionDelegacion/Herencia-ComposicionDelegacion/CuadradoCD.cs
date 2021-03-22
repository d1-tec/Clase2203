using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_ComposicionDelegacion
{
    public class CuadradoCD
    {
        private int ladoDelCuadrado;

        public CuadradoCD(int ladoDelCuadrado)
        {
            this.ladoDelCuadrado = ladoDelCuadrado;
        }

        public int CalcularArea()
        {
            Rectangulo rectangulo = new Rectangulo(this.ladoDelCuadrado, this.ladoDelCuadrado);
            return rectangulo.CalcularArea();
        }
    }
}
