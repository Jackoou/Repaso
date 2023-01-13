using Microsoft.EntityFrameworkCore;
using Dominio;

namespace Persistencia;
public class AppContext : DbContext
{
    public DbSet<Persona> Personas { set; get; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {


        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder
            .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = HopitalizacionData");
        }
    }
}
