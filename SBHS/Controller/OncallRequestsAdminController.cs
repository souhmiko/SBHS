using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SBHS.Models;

namespace SBHS.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class OncallRequestsAdminController : ControllerBase
    {
        private readonly SBHSDbContext _context;

        public OncallRequestsAdminController(SBHSDbContext context)
        {
            _context = context;
        }

        // GET: api/OncallRequestsAdmin
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OncallRequests>>> GetOncallRequests()
        {
          if (_context.OncallRequests == null)
          {
              return NotFound();
          }
            return await _context.OncallRequests.ToListAsync();
        }

        // GET: api/OncallRequestsAdmin/5
        [HttpGet("{id}")]
        public async Task<ActionResult<OncallRequests>> GetOncallRequests(int id)
        {
          if (_context.OncallRequests == null)
          {
              return NotFound();
          }
            var oncallRequests = await _context.OncallRequests.FindAsync(id);

            if (oncallRequests == null)
            {
                return NotFound();
            }

            return oncallRequests;
        }

        // PUT: api/OncallRequestsAdmin/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOncallRequests(int id, OncallRequests oncallRequests)
        {
            if (id != oncallRequests.Id)
            {
                return BadRequest();
            }

            _context.Entry(oncallRequests).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OncallRequestsExists(id))
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

        // POST: api/OncallRequestsAdmin
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<OncallRequests>> PostOncallRequests(OncallRequests oncallRequests)
        {
          if (_context.OncallRequests == null)
          {
              return Problem("Entity set 'SBHSDbContext.OncallRequests'  is null.");
          }
            _context.OncallRequests.Add(oncallRequests);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (OncallRequestsExists(oncallRequests.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetOncallRequests", new { id = oncallRequests.Id }, oncallRequests);
        }

        // DELETE: api/OncallRequestsAdmin/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOncallRequests(int id)
        {
            if (_context.OncallRequests == null)
            {
                return NotFound();
            }
            var oncallRequests = await _context.OncallRequests.FindAsync(id);
            if (oncallRequests == null)
            {
                return NotFound();
            }

            _context.OncallRequests.Remove(oncallRequests);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool OncallRequestsExists(int id)
        {
            return (_context.OncallRequests?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
