using AL.Aplicacion.Entidades;

namespace AL.Aplicacion.Interfaces;

public interface IRepositorioTercero
{
    void AgregarTercero(Tercero t);
    void ModificarTercero(Tercero t);
    void EliminarTercero(int id);
    Tercero? ObtenerTercero(int id);
    List<Tercero> ListarTerceros();
}
