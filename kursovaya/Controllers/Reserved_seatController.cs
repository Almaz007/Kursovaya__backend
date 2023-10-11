using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using kursovaya.Data;
using volzshki.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace kursovaya.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Reserved_seatController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public Reserved_seatController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Reserved_seat
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Reserved_seat>>> GetReserved_seats()
        {
          if (_context.Reserved_seats == null)
          {
              return NotFound();
          }
            return await _context.Reserved_seats.ToListAsync();
        }

        // GET: api/Reserved_seat/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Reserved_seat>> GetReserved_seat(int id)
        {
          if (_context.Reserved_seats == null)
          {
              return NotFound();
          }
            var reserved_seat = await _context.Reserved_seats.FindAsync(id);

            if (reserved_seat == null)
            {
                return NotFound();
            }

            return reserved_seat;
        }
        // GET: api/Reserved_seat/ScreeningId{id}
        [HttpGet("ScreeningId{ScreeningId}")]
        public async Task<ActionResult<List<Reserved_seat>>> getReservedSeatsByScreening(int ScreeningId)
        {
            if (_context.Reserved_seats == null)
            {
                return NotFound();
            }
           /* var reserved_seat = await _context.Reserved_seats.FindAsync(id);*/
            var reserved_seats =
            await _context.Reserved_seats
               .Where(elem => elem.ScreeningId == ScreeningId).ToListAsync();

            if (reserved_seats == null)
            {
                return NotFound();
            }

            return reserved_seats;
        }

        // PUT: api/Reserved_seat/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutReserved_seat(int id, Reserved_seat reserved_seat)
        {
            if (id != reserved_seat.Id)
            {
                return BadRequest();
            }

            _context.Entry(reserved_seat).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Reserved_seatExists(id))
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

        // POST: api/Reserved_seat
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Reserved_seat>> PostReserved_seat(Reserved_seat reserved_seat)
        {
          if (_context.Reserved_seats == null)
          {
              return Problem("Entity set 'ApplicationDbContext.Reserved_seats'  is null.");
          }
            _context.Reserved_seats.Add(reserved_seat);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetReserved_seat", new { id = reserved_seat.Id }, reserved_seat);
        }

        // DELETE: api/Reserved_seat/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteReserved_seat(int id)
        {
            if (_context.Reserved_seats == null)
            {
                return NotFound();
            }
            var reserved_seat = await _context.Reserved_seats.FindAsync(id);
            if (reserved_seat == null)
            {
                return NotFound();
            }

            _context.Reserved_seats.Remove(reserved_seat);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Reserved_seatExists(int id)
        {
            return (_context.Reserved_seats?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
