using Aseguradora.Aplicacion.Entidades;

namespace Aseguradora.Aplicacion.Interfaces;

public interface IRepositorioTitular
{
    void AgregarTitular(Titular t);
    void ModificarTitular(Titular t);
    void EliminarTitular(int id);
    Titular? ObtenerTitular(int id);
    List<Titular> ListarTitulares();
    List<Titular> ListarTitularesConSusVehiculos();
}
