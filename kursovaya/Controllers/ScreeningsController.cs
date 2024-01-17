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
    public class ScreeningsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ScreeningsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Screenings
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Screening>>> GetScreenings()
        {
          if (_context.Screenings == null)
          {
              return NotFound();
          }
            return await _context.Screenings.ToListAsync();
        }

        // GET: api/Screenings/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Screening>> GetScreening(int id)
        {
          if (_context.Screenings == null)
          {
              return NotFound();
          }
            var screening = await _context.Screenings.FindAsync(id);

            if (screening == null)
            {
                return NotFound();
            }

            return screening;
        }

        // GET: api/Screenings/date
        [HttpGet("DateTime{date}")]
        public async Task<ActionResult<List<Screening>>> GetScreeningsMByDate(DateTime date)
        {
            if (_context.Screenings == null)
            {
                return NotFound();
            }
            var screenings =
                 await _context.Screenings
                .Where(elem => elem.Screening_start.Date == date.Date).ToListAsync();
            
            if (screenings == null)
            {
                return NotFound();
            }

            return screenings;
        }
        // GET: api/Screenings/date
        [HttpGet("DateTime{date}/movieId{movieId}")]
        public async Task<ActionResult<List<Screening>>> getScreeningsBySelectedMovieDate(DateTime date, int movieId )
        {
            if (_context.Screenings == null)
            {
                return NotFound();
            }
            var screenings =
                 await _context.Screenings
                .Where(elem => elem.Screening_start.Date >= date.Date && elem.MovieId == movieId).ToListAsync();

            if (screenings == null)
            {
                return NotFound();
            }

            return screenings;
        }

        // PUT: api/Screenings/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutScreening(int id, Screening screening)
        {
            if (id != screening.Id)
            {
                return BadRequest();
            }

            _context.Entry(screening).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ScreeningExists(id))
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

        // POST: api/Screenings
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Screening>> PostScreening(Screening screening)
        {
          if (_context.Screenings == null)
          {
              return Problem("Entity set 'ApplicationDbContext.Screenings'  is null.");
          }
            _context.Screenings.Add(screening);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetScreening", new { id = screening.Id }, screening);
        }

        // DELETE: api/Screenings/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteScreening(int id)
        {
            if (_context.Screenings == null)
            {
                return NotFound();
            }
            var screening = await _context.Screenings.FindAsync(id);
            if (screening == null)
            {
                return NotFound();
            }

            _context.Screenings.Remove(screening);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ScreeningExists(int id)
        {
            return (_context.Screenings?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
