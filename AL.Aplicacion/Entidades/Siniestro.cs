namespace AL.Aplicacion.Entidades;
public class Siniestro
{
    public int Id { get; private set; }
    public int IdPoliza { get; set; }
    public DateTime FechaIngreso { get; set; }
    public DateTime FechaOcurrencia { get; set; }
    public string Direccion { get; set; } = "";
    public string Descripcion { get; set; } = "";
    public List<Tercero>? Terceros { get; set; }

    public override string ToString()
    {
        return $"Id: {Id}, Id Póliza: {IdPoliza}, Fecha ingreso: {FechaIngreso:dd/MM/yy}, Fecha ocurrencia: {FechaOcurrencia:dd/MM/yy}, Direccion: {Direccion} , Descripcion: {Descripcion}";
    }
}
