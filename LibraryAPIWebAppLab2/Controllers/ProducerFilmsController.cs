using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LibraryAPIWebAppLab2.Models;

namespace LibraryAPIWebAppLab2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProducerFilmsController : ControllerBase
    {
        private readonly LibraryAPIContext _context;

        public ProducerFilmsController(LibraryAPIContext context)
        {
            _context = context;
        }

        // GET: api/ProducerFilms
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProducerFilm>>> GetProducerFilms()
        {
          if (_context.ProducerFilms == null)
          {
              return NotFound();
          }
            return await _context.ProducerFilms.ToListAsync();
        }

        // GET: api/ProducerFilms/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProducerFilm>> GetProducerFilm(int id)
        {
          if (_context.ProducerFilms == null)
          {
              return NotFound();
          }
            var producerFilm = await _context.ProducerFilms.FindAsync(id);

            if (producerFilm == null)
            {
                return NotFound();
            }

            return producerFilm;
        }

        // PUT: api/ProducerFilms/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProducerFilm(int id, ProducerFilm producerFilm)
        {
            if (id != producerFilm.Id)
            {
                return BadRequest();
            }

            _context.Entry(producerFilm).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProducerFilmExists(id))
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

        // POST: api/ProducerFilms
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ProducerFilm>> PostProducerFilm(ProducerFilm producerFilm)
        {
          if (_context.ProducerFilms == null)
          {
              return Problem("Entity set 'LibraryAPIContext.ProducerFilms'  is null.");
          }
            _context.ProducerFilms.Add(producerFilm);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProducerFilm", new { id = producerFilm.Id }, producerFilm);
        }

        // DELETE: api/ProducerFilms/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProducerFilm(int id)
        {
            if (_context.ProducerFilms == null)
            {
                return NotFound();
            }
            var producerFilm = await _context.ProducerFilms.FindAsync(id);
            if (producerFilm == null)
            {
                return NotFound();
            }

            _context.ProducerFilms.Remove(producerFilm);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProducerFilmExists(int id)
        {
            return (_context.ProducerFilms?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
