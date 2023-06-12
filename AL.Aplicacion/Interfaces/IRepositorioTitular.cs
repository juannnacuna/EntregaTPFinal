using AL.Aplicacion.Entidades;

namespace AL.Aplicacion.Interfaces;

public interface IRepositorioTitular
{
    void AgregarTitular(Titular t);
    void ModificarTitular(Titular t);
    void EliminarTitular(int id);
    List<Titular> ListarTitulares();
    List<Titular> ListarTitularesConSusVehiculos();
}
