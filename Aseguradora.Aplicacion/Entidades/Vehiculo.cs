namespace Aseguradora.Aplicacion.Entidades;
public class Vehiculo
{
    public int Id { get; private set; }
    public string Dominio { get; set; } = "";
    public string Marca { get; set; } = "";
    public int Anio { get; set; }
    public int TitularId { get; set; }
    public List<Poliza>? Polizas { get; set; }
}
