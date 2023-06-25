using System;
using System.Collections.Generic;
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
        
        public IEnumerable<Evento> _evento = new Evento[] {
                  new Evento (){
             
                     EventoId = 1,
                     Tema = "Angula 11 e .Net 5",
                     Local = "Belo Horizonte",
                     Lote = "1º Lote",
                     QtdPessoa = 250,
                     DataEvento = DateTime.Now.AddDays(2).ToString("dd/MMMM/yyyy"),
                     ImagemUrl = "foto.png"


                  },

                  new Evento (){
             
                     EventoId = 2,
                     Tema = "Angula e suas novidades ",
                     Local = "São Paulo",
                     Lote = "2º Lote",
                     QtdPessoa = 350,
                     DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                     ImagemUrl = "foto.png"


                  }
               };
        public EventoController()
        {
            
        }

        [HttpGet]
        

            public IEnumerable<Evento> Get(){

               return _evento;
            }
              
         [HttpGet("{id}")]
        

            public IEnumerable<Evento> GetById(int id){

               return _evento.Where(evento => evento.EventoId == id);
            }

        
        [HttpPost]
        public string Post()
        {
           return "post";
        }

        
        [HttpPut("id")]
        public string Get(int id)
        {
           return $"Put {id}";
        }

        
        [HttpDelete("id")]
        public string Delete( int id)
        {
           return $"Delete {id}";
        }
    }
}
