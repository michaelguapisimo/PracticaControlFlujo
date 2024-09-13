using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion2
{
    internal class Persona
    {
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public int CalcularEdad()
        {
            DateTime ahora = DateTime.Now;
            int edad = ahora.Year - FechaNacimiento.Year;
            if (FechaNacimiento > ahora.AddYears(-edad)) edad--;
            return edad;
        }

        public override string ToString()
        {
            return $"{Nombres} {Apellidos}, Edad: {CalcularEdad()}";
        }

    }
}
