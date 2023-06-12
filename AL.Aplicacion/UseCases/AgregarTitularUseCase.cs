using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;

namespace AL.Aplicacion.UseCases;

public class AgregarTitularUseCase : TitularUseCase
{
    public AgregarTitularUseCase(IRepositorioTitular repo) : base(repo)
    {
    }
    public void Ejecutar(Titular t)
    {
        Repositorio.AgregarTitular(t);
    }
}