using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoB
{
    public class B
    {
        public void AceptarSaludador(ISaludable saludable)
        {
            saludable.Saludar();
        }
    }
}
