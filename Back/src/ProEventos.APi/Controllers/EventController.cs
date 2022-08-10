using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProEventos.APi.Models;

namespace ProEventos.APi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EventController : ControllerBase
    {
        public IEnumerable<Evento> _evento = new Evento[]{
            new Evento(){
                EventoId = 1,
                Tema = "Angular 11 e .Net 5",
                Local = "Betim",
                Lote = "1º Lote",
                QuantidadePessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString(),
                ImagemUrl = "foto.png"
            },
                new Evento(){
                EventoId = 2,
                Tema = "Angular e suas novidades",
                Local = "São Paulo",
                Lote = "2º Lote",
                QuantidadePessoas = 350,
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                ImagemUrl = "foto1.png"
            }            
        };
        [HttpGet]
        public IEnumerable<Evento> Get(){
            return _evento;
        }
        
        [HttpGet("{id}")]
        public IEnumerable<Evento> Get(int id){
            return _evento.Where(_evento => _evento.EventoId == id);
        }
       
    }
}