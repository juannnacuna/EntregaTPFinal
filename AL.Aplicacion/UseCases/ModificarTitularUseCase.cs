using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;

namespace AL.Aplicacion.UseCases;
public class ModificarTitularUseCase : TitularUseCase
{
    public ModificarTitularUseCase(IRepositorioTitular repo) : base(repo)
    {
    }
    public void Ejecutar(Titular t)
    {
        Repositorio.ModificarTitular(t);
    }
}