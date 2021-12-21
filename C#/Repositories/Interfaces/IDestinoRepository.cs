using AgenciaDeViagens.Models;

namespace AgenciaDeViagens.Repositories.Interfaces
{
    public interface IDestinoRepository
    {
        IEnumerable<Destino> Destinos { get; }
    }
}
