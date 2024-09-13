using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion
{
    public class Estudiante
    {
        public string Nombre { get; set; }
        public double Nota { get; set; }

        public Estudiante(string nombre, double nota)
        {
            Nombre = nombre;
            Nota = nota;
        }
    }
}
