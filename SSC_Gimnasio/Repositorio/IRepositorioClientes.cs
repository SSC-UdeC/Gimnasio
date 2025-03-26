using SSC_Gimnasio.Modelos;

namespace SSC_Gimnasio.Repositorios
{
    public interface IRepositorioClientes
    {
        Task<List<Clientes>> GetAll(); 
        Task<Clientes?> Get(int id); 
        Task<Clientes> Add(Clientes cliente); 

        Task<bool> ClienteExisteAsync(string email, string telefono);
        Task Update(int id, Clientes cliente); 
        Task Delete(int id); 
    }
}
