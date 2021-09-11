using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEvents.API.Models;

namespace ProEvents.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventController : ControllerBase
    {
        public IEnumerable<Event>
            _event =
                new Event[] {
                    new Event {
                        Id = 1,
                        Subject = "Angular 11 e .NET 5",
                        Local = "Florianópolis - SC",
                        Quantity = 10,
                        EventDate = DateTime.Now.AddDays(2).ToString(),
                        Lot = "1º Lote",
                        ImageURL = "http://localhost:8080/img/img01.jpg"
                    },
                    new Event {
                        Id = 2,
                        Subject = "Entity Framework",
                        Local = "Porto Alegre - RS",
                        Quantity = 20,
                        EventDate = DateTime.Now.AddDays(3).ToString(),
                        Lot = "2º Lote",
                        ImageURL = "http://localhost:8080/img/img02.jpg"
                    }
                };

        public EventController()
        {
        }

        [HttpGet]
        public IEnumerable<Event> Get()
        {
            return _event;
        }

        [HttpGet("{id}")]
        public IEnumerable<Event> GetById(int id)
        {
            return _event.Where(e => e.Id == id);
        }

        [HttpPost]
        public string Post()
        {
            return "Post Example";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Put Example - {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Delete Example - {id}";
        }
    }
}
