using CarroCRUD.Entidades;
using Microsoft.EntityFrameworkCore;

namespace CarroCRUD.Utilidades
{
    public class ApplicationDbContext:DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):
            base(options)
        {

        }

        public DbSet<Carro> carros { get; set; }
        public DbSet<Marca> marcas { get; set; }
    }
}
