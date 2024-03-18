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
    public class OncallRequestsController : ControllerBase
    {
        private readonly SBHSDbContext _context;

        public OncallRequestsController(SBHSDbContext context)
        {
            _context = context;
        }

        // GET: api/OncallRequests
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OncallRequests>>> GetOncallRequests()
        {
            //if (_context.OncallRequests == null)
            //{
            //    return NotFound();
            //}
            //  return await _context.OncallRequests.ToListAsync();

            var oncallRequests = await _context.OncallRequests.ToListAsync();
            return Ok(oncallRequests);
        }

        // GET: api/OncallRequests/5
        [HttpGet("{id}")]
        public async Task<ActionResult<OncallRequests>> GetOncallRequests(int id)
        {
          if (_context.OncallRequests == null)
          {
              return NotFound();
          }
            var oncallRequest = await _context.OncallRequests.FindAsync(id);

            if (oncallRequest == null)
            {
                return NotFound();
            }

            return oncallRequest;
        }

        

        // POST: api/OncallRequests
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<OncallRequests>> PostOncallRequests([FromBody] OncallRequests oncallRequests)
        {
          if (_context.OncallRequests == null)
          {
              return BadRequest(ModelState);
          }


            _context.OncallRequests.Add(oncallRequests);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOncallRequests", new { id = oncallRequests.Id }, oncallRequests);
        }

        
        private bool OncallRequestsExists(int id)
        {
            return (_context.OncallRequests?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
