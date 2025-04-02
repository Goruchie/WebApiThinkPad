using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiThinkPad.Context;
using WebApiThinkPad.Models;

namespace WebApiThinkPad.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ThinkPadsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ThinkPadsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/ThinkPads
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ThinkPad>>> GetThinkPads()
        {
            return await _context.ThinkPads.ToListAsync();
        }

        // GET: api/ThinkPads/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ThinkPad>> GetThinkPad(int id)
        {
            var thinkPad = await _context.ThinkPads.FindAsync(id);

            if (thinkPad == null)
            {
                return NotFound();
            }

            return thinkPad;
        }

        // PUT: api/ThinkPads/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutThinkPad(int id, ThinkPad thinkPad)
        {
            if (id != thinkPad.Id)
            {
                return BadRequest();
            }

            _context.Entry(thinkPad).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ThinkPadExists(id))
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

        // POST: api/ThinkPads
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ThinkPad>> PostThinkPad(ThinkPad thinkPad)
        {
            _context.ThinkPads.Add(thinkPad);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetThinkPad", new { id = thinkPad.Id }, thinkPad);
        }

        // DELETE: api/ThinkPads/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteThinkPad(int id)
        {
            var thinkPad = await _context.ThinkPads.FindAsync(id);
            if (thinkPad == null)
            {
                return NotFound();
            }

            _context.ThinkPads.Remove(thinkPad);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ThinkPadExists(int id)
        {
            return _context.ThinkPads.Any(e => e.Id == id);
        }
    }
}
