namespace AL.Aplicacion.Entidades;
public class Tercero : Persona
{
    //Hereda: Id, Apellido, Nombre, Dni, Telefono
    public string Aseguradora { get; set; } = "";
    public int SiniestroId { get; set; }
}
