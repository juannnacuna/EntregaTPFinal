namespace AL.Aplicacion.Entidades;
public class Poliza
{
    public enum TipoCob
    {
        ResponsabilidadCivil, TodoRiesgo
    }
    public int Id { get; set; }
    public int IdVehiculo { get; set; }
    public float Valor { get; set; }
    public float Franquicia { get; set; }
    public TipoCob TipoCobertura { get; set; }
    public DateTime FechaInicioVigencia { get; set; }
    public DateTime FechaFinVigencia { get; set; }
    public List<Siniestro>? Siniestros { get; set; }

    public override string ToString()
    {
        return $"Id: {Id}, Id Vehículo: {IdVehiculo}, Valor Asegurado: {Valor}, Valor Franquicia: {Franquicia}, Cobertura de tipo: {TipoCobertura}, Fecha inicio vigencia: {FechaInicioVigencia:dd/MM/yy}, Fecha fin vigencia {FechaFinVigencia:dd/MM/yy}";
    }
}
