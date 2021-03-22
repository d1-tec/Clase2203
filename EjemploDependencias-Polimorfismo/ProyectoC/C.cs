using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoB;

namespace ProyectoC
{
    public class C : ISaludable
    {
        public void Saludar()
        {
            Console.WriteLine("Hola desde C!");
        }
    }
}
