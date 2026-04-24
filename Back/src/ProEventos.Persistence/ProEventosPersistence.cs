using System;
using System.Threading.Tasks;
using ProEventos.Domain;
using ProEventos.Persistence;

namespace ProEventos.Persistence
{
    public class ProEventosPersistence : IProEventosPersistence

    {
        public void Add<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }

        public void Update<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }

        public void Delete<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }

        public void DeleteRange<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }

        public Task<bool> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Evento[]> GetAllEventosAsync(int EventoId, bool includePalestrantes)
        {
            throw new NotImplementedException();
        }

        public Task<Evento[]> GetAllEventosByTemaAsync(string tema, bool includePalestrantes)
        {
            throw new NotImplementedException();
        }

        public Task<Evento[]> GetAllEventosByIdAsync(bool includePalestrantes)
        {
            throw new NotImplementedException();
        }

        public Task<Palestrante[]> GetAllPalestranteAsync(int PalestranteId, bool includeEventos)
        {
            throw new NotImplementedException();
        }

        public Task<Palestrante[]> GetAllPalestrantesByNomeAsync(string Nome, bool includeEventos)
        {
            throw new NotImplementedException();
        }

        public Task<Palestrante> GetAllPalestranteByIdAsync(bool includeEventos)
        {
            throw new NotImplementedException();
        }        
    }
}