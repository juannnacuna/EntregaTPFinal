using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;

namespace AL.Aplicacion.UseCases;

public class ObtenerTitularUseCase : TitularUseCase
{
    public ObtenerTitularUseCase(IRepositorioTitular repo) : base(repo)
    {
    }
    public Titular? Ejecutar(int id)
    {
        return Repositorio.ObtenerTitular(id);
    }
}