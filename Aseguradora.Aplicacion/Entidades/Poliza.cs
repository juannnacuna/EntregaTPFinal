namespace Aseguradora.Aplicacion.Entidades;
public class Poliza
{
    public enum TipoCob
    {
        ResponsabilidadCivil, TodoRiesgo
    }
    public int Id { get; set; }
    public int VehiculoId { get; set; }
    public float Valor { get; set; }
    public float Franquicia { get; set; }
    public TipoCob TipoCobertura { get; set; }
    public DateOnly FechaInicioVigencia { get; set; }
    public DateOnly FechaFinVigencia { get; set; }
    public List<Siniestro>? Siniestros { get; set; }
}
