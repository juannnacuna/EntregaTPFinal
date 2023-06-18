namespace AL.Aplicacion.Entidades;
public class Tercero: Persona
{
    //Hereda: Id, Apellido, Nombre, Dni, Telefono
    public string Aseguradora { get; private set; } = "";
    public int IdSiniestro { get; private set; }
    
    public override string ToString()
    {
        return base.ToString() + $", Aseguradora: {Aseguradora}, Id siniestro: {IdSiniestro}";
    }
}
