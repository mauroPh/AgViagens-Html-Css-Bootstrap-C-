using AgenciaDeViagens.Models;

namespace AgenciaDeViagens.Repositories.Interfaces
{
    public interface IPacoteRepository
    {
        IEnumerable <Pacote> Pacotes { get; }
        

        Pacote GetPacoteById(int pacoteId);



    }
}
