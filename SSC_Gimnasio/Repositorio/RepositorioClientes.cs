using Microsoft.EntityFrameworkCore;
using SSC_Gimnasio.Modelos;
using SSC_Gimnasio.Repositorios;

namespace SSC_Gimnasio.Repositorios
{
    public class RepositorioClientes : IRepositorioClientes
    {
        private readonly GymnasioDBContext _contexto;

        public RepositorioClientes(GymnasioDBContext contexto)
        {
            _contexto = contexto;
        }

        public async Task<Clientes> Add(Clientes cliente)
        {
            await _contexto.Clientes.AddAsync(cliente);
            await _contexto.SaveChangesAsync();
            return cliente;
        }
        public async Task Delete(int id)
        {
            var cliente = await _contexto.Clientes.FindAsync(id);
            if (cliente != null)
            {
                _contexto.Clientes.Remove(cliente);
                await _contexto.SaveChangesAsync();
            }
        }

        public async Task<Clientes?> Get(int id)
        {
            return await _contexto.Clientes.FindAsync(id);
        }

        public async Task<List<Clientes>> GetAll()
        {
            return await _contexto.Clientes.ToListAsync();
        }

        public async Task Update(int id, Clientes cliente)
        {
            var clienteActual = await _contexto.Clientes.FindAsync(id);
            if (clienteActual != null)
            {
                clienteActual.Nombre = cliente.Nombre;
                clienteActual.Telefono = cliente.Telefono;
                clienteActual.Email = cliente.Email;
                clienteActual.Fecha_Registro = cliente.Fecha_Registro;
                clienteActual.Fecha_Vencimiento = cliente.Fecha_Vencimiento;
                clienteActual.Telefono_Emergencia = cliente.Telefono_Emergencia;

                await _contexto.SaveChangesAsync();
            }
        }
    }
}
