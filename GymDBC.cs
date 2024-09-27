using Microsoft.EntityFrameworkCore;

namespace SSC_Gimnasio
{
    public class GymDBC : DbContext
    {
        public GymDBC(DbContextOptions<GymDBC> options) : base(options)
        {
        }
    }

    public DbSet<Id_Cliente> Clientes { get; set; }
    public DbSet<Nombre> Nombre { get; set; }
    public DbSet<Telefono> Teléfono { get; set; }
    public DbSet<Email> Email { get; set; }
    public DbSet<Fecha_Registro> Registro { get; set; }
    public DbSet<Fecha_Vencimiento> Vencimiento { get; set; }
    public DbSet<Telefono_Emergencia> Telefono de Emergencia { get; set; }

    public DbSet<Id_Visita> Visita { get; set; }
    public DbSet<Id_Cliente> Cliente { get; set; }
    public DbSet<Fecha_Visita> Fecha de Visita { get; set; }
}
