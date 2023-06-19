using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;

namespace AL.Aplicacion.UseCases;

public class AgregarTerceroUseCase : TerceroUseCase
{
    public AgregarTerceroUseCase(IRepositorioTercero repo) : base(repo)
    {
    }
    public void Ejecutar(Tercero t)
    {
        Repositorio.AgregarTercero(t);
    }
}