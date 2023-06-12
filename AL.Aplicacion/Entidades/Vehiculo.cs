namespace AL.Aplicacion.Entidades;
public class Vehiculo
{
    public int Id { get; private set; }
    public string Dominio { get; private set; } = "";
    public string Marca { get; private set; } = "";
    public int Anio { get; private set; }
    public int IdTitular { get; private set; }
    
    public override string ToString()
    {
        return $"Id: {Id}, Dominio: {Dominio}, Marca: {Marca}, Anio: {Anio}. Id titular: {IdTitular}";
    }
}
