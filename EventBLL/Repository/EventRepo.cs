using EventAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EventAPI.Repository
{
    public class EventRepo : IDataRepository<Event>
    {
        readonly EventContext _eventContext;

        public EventRepo(EventContext context)
        {
            _eventContext = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<IEnumerable<Event>> GetEventsAsync()
        {
            return await _eventContext.Events.ToListAsync();
        }

        public async Task<Event> GetEventAsync(long id)
        {
            return await  _eventContext.Events
                  .FirstOrDefaultAsync(e => e.Id == id);
        }

        public void AddEvent(Event entity)
        {
            _eventContext.Events.Add(entity);
            _eventContext.SaveChanges();
        }

        public void UpdateEvent(Event ev, Event entity)
        {
            
            ev.Title  = entity.Title;
            ev.Date = entity.Date;
            ev.Description = entity.Description;
            ev.Notes = entity.Notes;
            _eventContext.SaveChanges();
        }

        public void DeleteEvent(Event ev)
        {
            _eventContext.Events.Remove(ev);
            _eventContext.SaveChanges();
        }

    }
}

