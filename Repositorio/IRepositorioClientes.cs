using SSC_Gimnasio.Modelos;

namespace SSC_Gimnasio.Repositorios
{
    public interface IRepositorioClientes
    {
        Task<List<Clientes>> GetAll(); // Get all clients
        Task<Clientes?> Get(int id); // Get a client by ID
        Task<Clientes> Add(Clientes cliente); // Create a new client
        Task Update(int id, Clientes cliente); // Update an existing client
        Task Delete(int id); // Delete a client by ID
    }
}
