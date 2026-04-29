using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProEventos.Domain;

namespace ProEventos.Persistence.Contratos
{
    public interface IPalestrantePersist
    {
        //Palestrantes

        public Task<Palestrante[]> GetAllPalestrantesByNomeAsync(string nome, bool includeEventos);
        public Task<Palestrante[]> GetAllPalestrantesAsync(bool includeEventos);
        public Task<Palestrante> GetAllPalestranteByIdAsync(int palestranteId, bool includeEventos);
    } 
}