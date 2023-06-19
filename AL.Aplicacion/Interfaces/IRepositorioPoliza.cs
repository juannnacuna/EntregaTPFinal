using AL.Aplicacion.Entidades;

namespace AL.Aplicacion.Interfaces;

public interface IRepositorioPoliza
{
    void AgregarPoliza(Poliza p);
    void ModificarPoliza(Poliza p);
    void EliminarPoliza(int id);
    Poliza? ObtenerPoliza(int id);
    List<Poliza> ListarPolizas();    
}