using System.Threading.Tasks;
using ProEventos.Domain;

namespace ProEventos.Application.Contratos
{
    public interface IEventoService
    {
        Task<Evento> AddEventos(Evento model);

        Task<Evento> UpdateEvento(int eventoId, Evento model);

        Task<bool> DeleteEvento(int eventoId);

        public Task<Evento[]> GetAllEventosAsync(bool includePalestrantes = false);

        public Task<Evento[]> GetAllEventosByTemaAsync(string tema, bool includePalestrantes = false);
        
        public Task<Evento> GetEventoByIdAsync(int eventoId, bool includePalestrantes = false);
    }
}