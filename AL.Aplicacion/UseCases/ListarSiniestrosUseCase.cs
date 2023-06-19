using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;

namespace AL.Aplicacion.UseCases;

public class ListarSiniestrosUseCase : SiniestroUseCase
{
    public ListarSiniestrosUseCase(IRepositorioSiniestro repo) : base(repo)
    {
    }

    public List<Siniestro> Ejecutar()
    {
        return Repositorio.ListarSiniestros();
    }
}