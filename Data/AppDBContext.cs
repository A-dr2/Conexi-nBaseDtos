using conexiondebasededatos.Models;
using Microsoft.EntityFrameworkCore;

namespace conexiondebasededatos.Data
{
    public class AppDBContext: DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
        }
        public DbSet<Usuario>usuarios => Set<Usuario>();
        public DbSet<Contacto>contactos => Set<Contacto>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Usuario>()
                .HasMany(u=> u.contactos)
                .WithOne(c=> c.usuario)
                .HasForeignKey(c=> c.usuarioId);
        }










































    }
    
}

