using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EventAPI.Models;
using EventAPI.Repository;

namespace EventAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        readonly IDataRepository<Event> _eventRepository;

        public EventsController(IDataRepository<Event> eventRepository)
        {
            _eventRepository = eventRepository;
        }

         [HttpGet]
        public async Task<ActionResult<IEnumerable<Event>>> GetAll()
        {
            var events = await _eventRepository.GetEventsAsync();
            return Ok(events);
        }

        // GET: api/Event/5
        [HttpGet("{id}", Name = "Get")]
        public async Task<IActionResult> Get(long id)
        {
            Event @event = await _eventRepository.GetEventAsync(id);

            if (@event == null)
            {
                return NotFound("The Event record couldn't be found.");
            }

            return Ok(@event);
        }

        // POST: api/Event
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Event @event)
        {
            if (@event == null)
            {
                return BadRequest("Event is null.");
            }

            _eventRepository.AddEvent(@event);
            return CreatedAtRoute(
                  "Get",
                  new { Id = @event.Id },
                  @event);
        }

        // PUT: api/Event/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(long id, [FromBody] Event @event)
        {
            if (@event == null)
            {
                return BadRequest("Event is null.");
            }

            Event eventToUpdate = await _eventRepository.GetEventAsync(id);
            if (eventToUpdate == null)
            {
                return NotFound("The Event record couldn't be found.");
            }

            _eventRepository.UpdateEvent(eventToUpdate, @event);
            return NoContent();
        }

        // DELETE: api/Event/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            Event ev = await _eventRepository.GetEventAsync(id);
            if (ev == null)
            {
                return NotFound("The Event record couldn't be found.");
            }

            _eventRepository.DeleteEvent(ev);
            return NoContent();
        }
    }
}
