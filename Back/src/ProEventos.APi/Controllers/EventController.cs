using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProEventos.APi.Models;
using ProEventos.APi.Data;

namespace ProEventos.APi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EventController : ControllerBase
    {
        private readonly DataContext _context;
       public EventController(DataContext context){
         _context = context;
       }    
        [HttpGet]
        public IEnumerable<Evento> Get(){
            return _context.Eventos;
        }

        [HttpGet("{id}")]
        public Evento Get(int id){
            return _context.Eventos.FirstOrDefault(_evento => _evento.EventoId == id);
        }
       
    }
}