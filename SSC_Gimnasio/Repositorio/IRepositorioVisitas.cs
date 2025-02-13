using SSC_Gimnasio.Modelos;

namespace SSC_Gimnasio.Repositorios
{
    public interface IRepositorioVisitas
    {
        Task<List<Visitas>> GetAll();
        Task<Visitas?> Get(int id);
        Task<Visitas> Add(Visitas visita);
        Task Update(int id, Visitas visita);
        Task Delete(int id);
    }
}
