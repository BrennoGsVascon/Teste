using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProEventos.Domain;

namespace ProEventos.Persistence
{
    public interface IProEventosPersistence
    {
        //Geral
        void Add<T>(T entity) where T: class;
        void Update<T>(T entity) where T: class;
        void Delete<T>(T entity) where T: class;
        void DeleteRange<T>(T entity) where T: class;
        Task<bool> SaveChangesAsync();

        //Eventos 
        public Task<Evento[]> GetAllEventosByTemaAsync(string tema, bool includePalestrantes);
        public Task<Evento[]> GetAllEventosAsync(bool includePalestrantes);
        public Task<Evento> GetAllEventoByIdAsync(int EventoId, bool includePalestrantes);

        //Palestrantes
        public Task<Palestrante[]> GetAllPalestrantesByNomeAsync(string Nome, bool includeEventos);
        public Task<Palestrante[]> GetAllPalestrantesAsync(bool includeEventos);
        public Task<Palestrante> GetAllPalestranteByIdAsync(int PalestranteId, bool includeEventos);
    }
}