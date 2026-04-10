using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {

        public EventoController()
        { 
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return new Evento[] {
            
                new Evento()
                {
                    EventoId = 1,
                    Tema = "Angular e .NET",
                    Local = "Belo Horizonte",
                    DataEvento = DateTime.Now.AddDays(2).ToString(),  
                    QtdPessoas = 250,
                    Lote = "1º Lote",
                    ImagemURL = "foto.png"
                },
                new Evento()
                {
                    EventoId = 2,  
                    Tema = "Angular e .NET",
                    Local = "Sao Paulo",
                    DataEvento = DateTime.Now.AddDays(2).ToString(),  
                    QtdPessoas = 350,
                    Lote = "1º Lote",
                    ImagemURL = "foto.png"
                }
            };
        }
    }
}