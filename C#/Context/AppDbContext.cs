using AgenciaDeViagens.Models;
using Microsoft.EntityFrameworkCore;

namespace AgenciaDeViagens.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
                
        }

        public DbSet<Destino> Destinos { get; set; }
        public DbSet<Pacote> Pacotes { get; set; }

        public DbSet<CarrinhoCompraItem> CarrinhoCompraItems{ get; set; }

    }
}
