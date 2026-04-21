namespace Tp01;

public class Integrante
{
    private int dni;
    private string nombre;
    private DateTime fechaDeNacimiento;
    private string foto;
    private List<string> Familiares;
    private List<string>  Intereses;

    public Integrante(int dni, string nombre, DateTime fechaDeNacimiento, string foto, List <string> Familiares, List<string> Intereses){
        this.dni= dni;
        this.nombre = nombre;
        this.fechaDeNacimiento = fechaDeNacimiento;
        this.foto = foto;
        this.Familiares = Familiares;
        this.Intereses = Intereses;
    }

    public string ObtenerNombre(){
        return nombre;
    }

    public int ObtenerDni(){
        return categoria;
    }

    public DateTime ObtenerFechadeNacimiento(){
        return fechaDeNacimiento;
    }

    public string Obtenerfoto(){
        return foto;
    }

    public List<string> ObtenerFamiliares(){
        return descripcion;
    }
    public List<string> ObtenerIntereses(){
        return Intereses;
    }

}