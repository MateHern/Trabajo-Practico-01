namespace Tp01;

public class Grupo
{
    private Dictionary<int, Integrante> Integrantes;

public Grupo(Dictionary <int,Integrante> Integrantes)
{
    this.Integrantes = Integrantes;
}

void CargaDatosManual()
{


    Integreante1 = new Integrante(49764404, "Matias" , new DateTime(2009,09,30), imagen.jpg, FamiliaresDuv,  InteresesDuv);
    Integreante2 = new Integrante(49979691, "Mateo" , new DateTime(2009,12,13), imagen.jpg, FamiliaresHern,  InteresesHern);
   
    FamiliaresDuv = new List<string>();
    FamiliaresDuv.Add("Papá: Juan");
    FamiliaresDuv.Add("Mamá: Dolores");

    FamiliaresHern = new List<string>();
    FamiliaresHern.Add("Papá: Rodolfo");
    FamiliaresHern.Add("Mamá: Cintia");
        
    InteresesDuv = new List <string>();
    InteresesDuv.Add("Hacer mandalas");
    InteresesDuv.Add("Hacer yoga");

    InteresesHern = new List <string>();
    InteresesHern.Add("Ser plomero");
    InteresesHern.Add("Cortar leña");

    Integrantes.Add(49764404,Integreante1);
    Integrantes.Add(49979691,Integreante2);


}
}