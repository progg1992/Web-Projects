using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FlightDocs.Models;

namespace FlightDocs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class aircraftController : ControllerBase
    {
        private readonly AircraftContext _context;

        public aircraftController(AircraftContext context)
        {
            _context = context;
        }

        // GET: api/aircraftItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AircraftItem>>> GetAircraftItems()
        {
            return await _context.AircraftItems.ToListAsync();
        }

        // GET: api/aircraftItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AircraftItem>> GetAircraftItem(int id)
        {
            var aircraftItem = await _context.AircraftItems.FindAsync(id);

            if (aircraftItem == null)
            {
                return NotFound();
            }

            return aircraftItem;
        }

        // PUT: api/aircraftItems/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAircraftItem(int id, AircraftItem aircraftItem)
        {
            if (id != aircraftItem.Id)
            {
                return BadRequest();
            }

            _context.Entry(aircraftItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AircraftItemExists(id))
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

        // POST: api/aircraftItems
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost("{id}/duelist")]
        public async Task<ActionResult<AircraftItem>> PostAircraftItem(AircraftItem aircraftItem)
        {
            _context.AircraftItems.Add(aircraftItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetAircraftItem), new { id = aircraftItem.Id }, aircraftItem);
        }

        // DELETE: api/aircraftItems/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<AircraftItem>> DeleteAircraftItem(int id)
        {
            var aircraftItem = await _context.AircraftItems.FindAsync(id);
            if (aircraftItem == null)
            {
                return NotFound();
            }

            _context.AircraftItems.Remove(aircraftItem);
            await _context.SaveChangesAsync();

            return aircraftItem;
        }

        private bool AircraftItemExists(int id)
        {
            return _context.AircraftItems.Any(e => e.Id == id);
        }
    }
}
