namespace AL.Aplicacion.Entidades;
public class Vehiculo
{
    public int Id { get; private set; }
    public string Dominio { get; set; } = "";
    public string Marca { get; set; } = "";
    public int Anio { get; set; }
    public int IdTitular { get; set; }
    public List<Poliza>? Polizas { get; set; }

    public override string ToString()
    {
        return $"Id: {Id}, Dominio: {Dominio}, Marca: {Marca}, Anio: {Anio}. Id titular: {IdTitular}";
    }
}
