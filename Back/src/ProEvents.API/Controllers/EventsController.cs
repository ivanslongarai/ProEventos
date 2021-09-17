using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ProEvents.Domain;
using ProEvents.Persistence;

namespace ProEvents.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventsController : ControllerBase
    {
        private readonly ProEventsContext _context;

        public EventsController(ProEventsContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public IEnumerable<Event> Get()
        {
            return _context.Events;
        }

        [HttpGet("{id}")]
        public Event GetById(int id)
        {
            return _context.Events.FirstOrDefault(e => e.Id == id);
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
