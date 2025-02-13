using Microsoft.EntityFrameworkCore;
using SSC_Gimnasio.Modelos;

namespace SSC_Gimnasio.Repositorios
{
    public class RepositorioVisitas : IRepositorioVisitas
    {
        private readonly GymnasioDBContext _context;

        public RepositorioVisitas(GymnasioDBContext context)
        {
            _context = context;
        }

        public async Task<List<Visitas>> GetAll()
        {
            return await _context.Visitas.Include(v => v.Cliente).ToListAsync();
        }

        public async Task<Visitas?> Get(int id)
        {
            return await _context.Visitas.Include(v => v.Cliente).FirstOrDefaultAsync(v => v.Id_Visita == id);
        }

        public async Task<Visitas> Add(Visitas visita)
        {
            await _context.Visitas.AddAsync(visita);
            await _context.SaveChangesAsync();
            return visita;
        }

        public async Task Update(int id, Visitas visita)
        {
            var visitaActual = await _context.Visitas.FindAsync(id);
            if (visitaActual != null)
            {
                visitaActual.Fecha_Visita = visita.Fecha_Visita;
                visitaActual.Id_Cliente = visita.Id_Cliente;

                await _context.SaveChangesAsync();
            }
        }

        public async Task Delete(int id)
        {
            var visita = await _context.Visitas.FindAsync(id);
            if (visita != null)
            {
                _context.Visitas.Remove(visita);
                await _context.SaveChangesAsync();
            }
        }
    }
}
