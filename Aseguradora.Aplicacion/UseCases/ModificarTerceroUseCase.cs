using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;

namespace Aseguradora.Aplicacion.UseCases;
public class ModificarTerceroUseCase : TerceroUseCase
{
    public ModificarTerceroUseCase(IRepositorioTercero repo) : base(repo)
    {
    }
    public void Ejecutar(Tercero t)
    {
        Repositorio.ModificarTercero(t);
    }
}