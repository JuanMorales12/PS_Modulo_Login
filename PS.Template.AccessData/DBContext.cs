using Microsoft.EntityFrameworkCore;
using PS.Template.Domain.EntitiesConfiguration;
using PS.Template.Domain.Entities;

namespace PS.Template.AccessData
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options) {}

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Tipo> Tipos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TipoConfiguration());
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
        }

    }
}
