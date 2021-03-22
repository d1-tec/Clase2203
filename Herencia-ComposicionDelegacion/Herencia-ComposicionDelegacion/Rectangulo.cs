using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_ComposicionDelegacion
{
    public class Rectangulo
    {
        private int largo;
        private int ancho;

        public Rectangulo(int largo, int ancho)
        {
            this.largo = largo;
            this.ancho = ancho;
        }

        public int CalcularArea()
        {
            return this.largo * this.ancho;
        }
    }
}
