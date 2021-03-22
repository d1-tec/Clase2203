using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoC;
using ProyectoB;

namespace ProyectoA
{
    class Program
    {
        static void Main(string[] args)
        {
            C c = new C();
            B b = new B();
            b.AceptarSaludador(c); // Lo van a ver en disenio 2, se llama inyeccion de dependencias

            Console.ReadLine();
        }
    }
}
