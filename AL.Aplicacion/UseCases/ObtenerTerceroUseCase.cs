using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;

namespace AL.Aplicacion.UseCases;

public class ObtenerTerceroUseCase : TerceroUseCase
{
    public ObtenerTerceroUseCase(IRepositorioTercero repo) : base(repo)
    {
    }
    public Tercero? Ejecutar(int id)
    {
        return Repositorio.ObtenerTercero(id);
    }
}