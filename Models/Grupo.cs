namespace Tp01;

public class Grupo
{
    private Dictionary<int, Integrante> Integrantes;

public Grupo()
{
    CargaDatosManual();
}
Dictionary<int, Integrante> mostrarIntegrantes()
{
    return Integrantes;    
}
void CargaDatosManual()
{    
   
    List <string> FamiliaresDuv = new List<string>();
    FamiliaresDuv.Add("Papá: Juan");
    FamiliaresDuv.Add("Mamá: Dolores");

    List <string> FamiliaresHern = new List<string>();
    FamiliaresHern.Add("Papá: Rodolfo");
    FamiliaresHern.Add("Mamá: Cintia");
        
    List <string> InteresesDuv = new List <string>();
    InteresesDuv.Add("Hacer mandalas");
    InteresesDuv.Add("Hacer yoga");

    List <string> InteresesHern = new List <string>();
    InteresesHern.Add("Ser plomero");
    InteresesHern.Add("Cortar leña");

    Integrante Integreante1 = new Integrante(49764404, "Matias" , new DateTime(2009,09,30), "integrante1.webp", FamiliaresDuv,  InteresesDuv);
    Integrante Integreante2 = new Integrante(49979691, "Mateo" , new DateTime(2009,12,13), "integrante2.webp", FamiliaresHern,  InteresesHern);

    Integrantes.Add(49764404,Integreante1);
    Integrantes.Add(49979691,Integreante2);


}
}