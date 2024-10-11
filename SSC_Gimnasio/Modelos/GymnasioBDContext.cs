using Microsoft.EntityFrameworkCore;

namespace SSC_Gimnasio.Modelos
{
    public class GymnasioDBContext : DbContext
    {
        public GymnasioDBContext(DbContextOptions<GymnasioDBContext> options) : base(options)
        {
        }

        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Visitas> Visitas { get; set; }
    }
}