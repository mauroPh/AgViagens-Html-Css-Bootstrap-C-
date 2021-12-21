using AgenciaDeViagens.Context;
using AgenciaDeViagens.Models;
using AgenciaDeViagens.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AgenciaDeViagens.Repositories
{
    public class PacoteRepository : IPacoteRepository
    {
        private readonly AppDbContext _context;
        public PacoteRepository(AppDbContext contexto)
        {
            _context = contexto;
        }
         
        public IEnumerable<Pacote> Pacotes =>_context.Pacotes.Include(c=>c.Destino );

        public Pacote GetPacoteById(int pacoteId)
        {
            throw new NotImplementedException();
        }
    }
}
