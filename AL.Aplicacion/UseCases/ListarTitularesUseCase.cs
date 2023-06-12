using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;

namespace AL.Aplicacion.UseCases;

public class ListarTitularesUseCase : TitularUseCase
{
    public ListarTitularesUseCase(IRepositorioTitular repo) : base(repo)
    {
    }
    public List<Titular> Ejecutar()
    {
        return Repositorio.ListarTitulares();
    }
}