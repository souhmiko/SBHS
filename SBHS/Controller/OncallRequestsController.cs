using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SBHS.Models;

namespace SBHS.Controller
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class OncallRequestsController : ControllerBase
    {
        private readonly SBHSDbContext _context;

        public OncallRequestsController(SBHSDbContext context)
        {
            _context = context;
            OncallRequest = new OncallRequests();
        }

        public OncallRequests OncallRequest { get; set; }

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
        public async Task<ActionResult<OncallRequests>> PostOncallRequests([FromForm] OncallRequests oncallRequests)
        {
            // Retrieve the UserDetailId based on the logged-in user's ID

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var userDetails = await _context.UserDetails.FirstOrDefaultAsync(u => u.AspNetUserId == userId);
            if (userDetails == null)
            {
                return BadRequest("Unable to find user details for current user");
            }

            oncallRequests.UserDetailId = userDetails.Id;

            oncallRequests.LeaveStatusId = 2;


            if (_context.OncallRequests == null)
            {
                return BadRequest(ModelState);
            }

            
            var oncallRequest = new OncallRequests
            {
                UserDetailId = OncallRequest.UserDetailId,
                DepartmentId = OncallRequest.DepartmentId,
                DateTimeOnCall = OncallRequest.DateTimeOnCall,
                LeaveStatusId = 2
            };


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
