namespace AL.Aplicacion.Entidades;
public class Titular : Persona
{
    //Hereda: Id, Apellido, Nombre, Dni, Telefono
    public string Direccion { get; private set; } = "";
    public string Email { get; private set; } = "";
    public List<Vehiculo>? Vehiculos { get; set; }

    public override string ToString()
    {
        return base.ToString() + $", Email: {Email}, Direccion: {Direccion}";
    }
}
