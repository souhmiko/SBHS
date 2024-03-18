using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SBHS.API.Models;

namespace SBHS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeaveRequestsController : ControllerBase
    {
        private readonly SBHSContext2 _context;

        public LeaveRequestsController(SBHSContext2 context)
        {
            _context = context;
        }

        //// GET: api/LeaveRequests
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<LeaveRequests>>> GetLeaveRequests()
        //{
        //  if (_context.LeaveRequests == null)
        //  {
        //      return NotFound();
        //  }
        //    return await _context.LeaveRequests.ToListAsync();
        //}

        //// GET: api/LeaveRequests/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<LeaveRequests>> GetLeaveRequests(int id)
        //{
        //  if (_context.LeaveRequests == null)
        //  {
        //      return NotFound();
        //  }
        //    var leaveRequests = await _context.LeaveRequests.FindAsync(id);

        //    if (leaveRequests == null)
        //    {
        //        return NotFound();
        //    }

        //    return leaveRequests;
        //}

        //// PUT: api/LeaveRequests/5
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutLeaveRequests(int id, LeaveRequests leaveRequests)
        //{
        //    if (id != leaveRequests.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(leaveRequests).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!LeaveRequestsExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}



        // POST: api/LeaveRequests
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<LeaveRequests>> SubmitLeaveRequests(LeaveRequests leaveRequests)
        {
          if (_context.LeaveRequests == null)
          {
              return Problem("Entity set 'SBHSContext2.LeaveRequests'  is null.");
          }
            _context.LeaveRequests.Add(leaveRequests);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (LeaveRequestsExists(leaveRequests.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetLeaveRequests", new { id = leaveRequests.Id }, leaveRequests);
        }

        // DELETE: api/LeaveRequests/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteLeaveRequests(int id)
        //{
        //    if (_context.LeaveRequests == null)
        //    {
        //        return NotFound();
        //    }
        //    var leaveRequests = await _context.LeaveRequests.FindAsync(id);
        //    if (leaveRequests == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.LeaveRequests.Remove(leaveRequests);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        private bool LeaveRequestsExists(int id)
        {
            return (_context.LeaveRequests?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
