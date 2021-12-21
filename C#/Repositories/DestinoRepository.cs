using AgenciaDeViagens.Context;
using AgenciaDeViagens.Models;
using AgenciaDeViagens.Repositories.Interfaces;

namespace AgenciaDeViagens.Repositories
{
    public class DestinoRepository : IDestinoRepository
    {

        private readonly AppDbContext _context;

        public DestinoRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Destino> Destinos => _context.Destinos;
    }
}
