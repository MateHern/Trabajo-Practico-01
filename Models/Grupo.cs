using System;
using System.Collections.Generic;

namespace Tp01.Models
{
    public class Grupo
    {
        private Dictionary<int, Integrante> Integrantes;

        public Grupo()
        {
            Integrantes = new Dictionary<int, Integrante>();
            CargaDatosManual();
        }

        public Dictionary<int, Integrante> mostrarIntegrantes()
        {
            return Integrantes;
        }

        public Integrante GetIntegrante(int dni)
        {
            if (Integrantes.ContainsKey(dni))
            {
                return Integrantes[dni];
            }
            return null;
        }

        public void CargaDatosManual()
        {
            List<string> familiaresDuv = new List<string>();
            familiaresDuv.Add("Papá: Juan");
            familiaresDuv.Add("Mamá: Dolores");

            List<string> familiaresHern = new List<string>();
            familiaresHern.Add("Papá: Rodolfo");
            familiaresHern.Add("Mamá: Cintia");

            List<string> interesesDuv = new List<string>();
            interesesDuv.Add("Hacer mandalas");
            interesesDuv.Add("Hacer yoga");

            List<string> interesesHern = new List<string>();
            interesesHern.Add("Ser plomero");
            interesesHern.Add("Cortar leña");

            Integrante integrante1 = new Integrante(49764404, "Matias", new DateTime(2009, 09, 30), "mati12.jpg", familiaresDuv, interesesDuv);
            Integrante integrante2 = new Integrante(49979691, "Mateo", new DateTime(2009, 12, 13), "Sin título.jpg", familiaresHern, interesesHern);

            Integrantes.Add(49764404, integrante1);
            Integrantes.Add(49979691, integrante2);
        }
    }
}