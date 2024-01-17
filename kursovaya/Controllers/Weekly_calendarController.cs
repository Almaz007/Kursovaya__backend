using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using kursovaya.Data;
using kursovaya.Data.Entities;

namespace kursovaya.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Weekly_calendarController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public Weekly_calendarController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Weekly_calendar
        [HttpGet]
        public async Task<ActionResult<List<Weekly_calendar>>> GetWeekly_calendar()
        {
          if (_context.Weekly_calendar == null)
          {
              return NotFound();
          }
            return await _context.Weekly_calendar.ToListAsync();
        }


        // GET: api/Weekly_calendar/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Weekly_calendar>> GetWeekly_calendar(int id)
        {
          if (_context.Weekly_calendar == null)
          {
              return NotFound();
          }
            var weekly_calendar = await _context.Weekly_calendar.FindAsync(id);

            if (weekly_calendar == null)
            {
                return NotFound();
            }

            return weekly_calendar;
        }

        // PUT: api/Weekly_calendar/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWeekly_calendar(int id, Weekly_calendar weekly_calendar)
        {
            if (id != weekly_calendar.Id)
            {
                return BadRequest();
            }

            _context.Entry(weekly_calendar).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Weekly_calendarExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Weekly_calendar
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Weekly_calendar>> PostWeekly_calendar(Weekly_calendar weekly_calendar)
        {
          if (_context.Weekly_calendar == null)
          {
              return Problem("Entity set 'ApplicationDbContext.Weekly_calendar'  is null.");
          }
            _context.Weekly_calendar.Add(weekly_calendar);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetWeekly_calendar", new { id = weekly_calendar.Id }, weekly_calendar);
        }

        // DELETE: api/Weekly_calendar/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWeekly_calendar(int id)
        {
            if (_context.Weekly_calendar == null)
            {
                return NotFound();
            }
            var weekly_calendar = await _context.Weekly_calendar.FindAsync(id);
            if (weekly_calendar == null)
            {
                return NotFound();
            }

            _context.Weekly_calendar.Remove(weekly_calendar);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Weekly_calendarExists(int id)
        {
            return (_context.Weekly_calendar?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
