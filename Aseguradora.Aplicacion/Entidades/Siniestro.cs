namespace Aseguradora.Aplicacion.Entidades;
public class Siniestro
{
    public int Id { get; private set; }
    public int PolizaId { get; set; }
    public DateOnly FechaIngreso { get; set; }
    public DateOnly FechaOcurrencia { get; set; }
    public string Direccion { get; set; } = "";
    public string Descripcion { get; set; } = "";
    public List<Tercero>? Terceros { get; set; }
}
