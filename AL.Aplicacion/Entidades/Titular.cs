namespace AL.Aplicacion.Entidades;
public class Titular : Persona
{
    //Hereda: Id, Apellido, Nombre, Dni, Telefono
    public string Direccion { get; set; } = "";
    public string Email { get; set; } = "";
    public List<Vehiculo>? Vehiculos { get; set; }
}
