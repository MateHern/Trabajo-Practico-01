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

    public string ObtenerCategoria(){
        return categoria;
    }

    public int ObtenerAnio(){
        return anio;
    }

    public double ObtenerPrecio(){
        return precio;
    }

    public string ObtenerDescripcion(){
        return descripcion;
    }

}