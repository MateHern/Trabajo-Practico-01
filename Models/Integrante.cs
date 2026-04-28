
using System;
using System.Collections.Generic;

namespace Tp01.Models
{
    public class Integrante
    {
        public int DNI { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Foto { get; set; }
        public List<string> Familiares { get; set; }
        public List<string> Intereses { get; set; }

        public Integrante(int dni, string nombre, DateTime fechaNacimiento, string foto, List<string> familiares, List<string> intereses)
        {
            DNI = dni;
            Nombre = nombre;
            FechaNacimiento = fechaNacimiento;
            Foto = foto;
            Familiares = familiares;
            Intereses = intereses;
        }
    }
}
namespace Tp01;

