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

        public Dictionary<int, Integrante> DevolverIntegrantes()
        {
            return Integrantes;
        }

        public Integrante GetIntegrante(int dni)
        {
            if (Integrantes.ContainsKey(dni))
                return Integrantes[dni];
            return null;
        }

        public void CargaDatosManual()
        {
            List<string> familiaresDuv = new List<string> { "Papá: Juan", "Mamá: Dolores" };
            List<string> familiaresHern = new List<string> { "Papá: Rodolfo", "Mamá: Cintia" };
            List<string> interesesDuv = new List<string> { "Hacer mandalas", "Hacer yoga" };
            List<string> interesesHern = new List<string> { "Ser plomero", "Cortar leña" };

            Integrante integrante1 = new Integrante(49764404, "Matias", new DateTime(2009, 09, 30), "/img/indio.jpg", familiaresDuv, interesesDuv);
            Integrante integrante2 = new Integrante(49979691, "Mateo", new DateTime(2009, 12, 13), "/img/valentini.jpg", familiaresHern, interesesHern);

            Integrantes.Add(49764404, integrante1);
            Integrantes.Add(49979691, integrante2);
        }
    }
}