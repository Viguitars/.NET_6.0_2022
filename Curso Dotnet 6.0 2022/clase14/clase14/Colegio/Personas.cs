using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase14.Colegio
{
    public class Persona
    {
        public string NombreCompleto { get; set; }
        public int DNI { get; set; }
        public Persona()
        {
            NombreCompleto = "Juan Perez";
            DNI = 33785467;
        }
        public string Clave()
        {
            return "6797649719471";
        }
    }
}

