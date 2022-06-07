using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CbsStudents.Data;
using cbsStudents.Models.Entities;

namespace cbsStudents.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsAPIController : ControllerBase
    {
        private readonly CbsStudentsContext _context;

        public EventsAPIController(CbsStudentsContext context)
        {
            _context = context;
        }

        // GET: api/EventsAPI
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Event>>> GetEvent()
        {
            return await _context.Event.ToListAsync();
        }

        // GET: api/EventsAPI/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Event>> GetEvent(int id)
        {
            var @event = await _context.Event.FindAsync(id);

            if (@event == null)
            {
                return NotFound();
            }

            return @event;
        }

        // PUT: api/EventsAPI/5
        // To protect from overposting attacks, use DTO - see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEvent(int id, Event @event)
        {

            if (id != @event.Id)
            {
                return BadRequest();
            }

            _context.Entry(@event).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EventExists(id))
                {

                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return Ok("Event er opdateret!");
            // return NoContent();

        }

        // POST: api/EventsAPI
        // To protect from overposting attacks, use DTO - see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Event>> PostEvent(Event @event)
        {
            _context.Event.Add(@event);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEvent", new { id = @event.Id }, @event);
        }

        // DELETE: api/EventsAPI/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEvent(int id)
        {
            var @event = await _context.Event.FindAsync(id);
            if (@event == null)
            {
                return NotFound();
            }

            _context.Event.Remove(@event);
            await _context.SaveChangesAsync();

            // return NoContent();
            return Redirect("./"); //Tilbage til oversigt
        }

        private bool EventExists(int id)
        {
            return _context.Event.Any(e => e.Id == id);
        }
    }
}
