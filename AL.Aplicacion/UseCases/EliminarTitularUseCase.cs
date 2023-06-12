using AL.Aplicacion.Interfaces;

namespace AL.Aplicacion.UseCases;
public class EliminarTitularUseCase : TitularUseCase
{
    public EliminarTitularUseCase(IRepositorioTitular repo) : base(repo)
    {
    }
    public void Ejecutar(int id)
    {
        Repositorio.EliminarTitular(id);
    }
}