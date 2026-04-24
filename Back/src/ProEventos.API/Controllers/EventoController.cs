using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.Persistence;
using ProEventos.Domain;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        private readonly ProEventosContext _context;
        public EventoController(ProEventosContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public Evento GetById(int id)
        {
            return _context.Eventos.FirstOrDefault(
                evento => evento.Id == id
            );
        }
        
        [HttpPost]
        public string Post()
        {
            return "Exemplo de Post";
        }

        [HttpPut]
        public string Put()
        {
            return "Exemplo de Put";
        }
        
        [HttpDelete]
        public string Delete(int id)    
        {
            return "Exemplo de Delete com id = {id}";
        }
    }
}