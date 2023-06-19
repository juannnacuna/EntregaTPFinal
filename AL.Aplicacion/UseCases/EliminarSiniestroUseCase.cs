using AL.Aplicacion.Interfaces;

namespace AL.Aplicacion.UseCases;

public class EliminarSiniestroUseCase : SiniestroUseCase
{
    public EliminarSiniestroUseCase(IRepositorioSiniestro repo) : base(repo)
    {
    }
    public void Ejecutar(int id)
    {
        Repositorio.EliminarSiniestro(id);
    }
}