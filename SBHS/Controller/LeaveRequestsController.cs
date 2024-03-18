using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SBHS.Models;

namespace SBHS.Controller
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class LeaveRequestsController : ControllerBase
    {
        private readonly SBHSDbContext _context;
        private readonly UserManager<UserDetails> _userManager;

        public LeaveRequestsController(SBHSDbContext context, UserManager<UserDetails> userManager)
        {
            _context = context;
            _userManager = userManager;
            LeaveRequest = new LeaveRequests();
        }


        [BindProperty]
        public LeaveRequests LeaveRequest { get; set; }



        // GET: api/LeaveRequests
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LeaveRequests>>> GetLeaveRequests()
        {
          if (_context.LeaveRequests == null)
          {
              return NotFound();
          }
            return await _context.LeaveRequests.ToListAsync();
        }


        // GET: api/LeaveRequests/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LeaveRequests>> GetLeaveRequests(int id)
        {
          if (_context.LeaveRequests == null)
          {
              return NotFound();
          }
            var leaveRequests = await _context.LeaveRequests.FindAsync(id);

            if (leaveRequests == null)
            {
                return NotFound();
            }

            return leaveRequests;
        }

        

        // POST: api/LeaveRequests
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<LeaveRequests>> PostLeaveRequests([FromBody] LeaveRequests leaveRequests)
        {

            //Get the current user's details
            var currentUser = await _userManager.GetUserAsync(User);
            if(currentUser == null)
            {
                return BadRequest("Unable to find current user");
            }


            // Associate the leave request with the current user
            leaveRequests.UserDetailId = currentUser.Id;


            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var leaveRequest = new LeaveRequests
            {
                UserDetailId = LeaveRequest.UserDetailId,
                StartDate = LeaveRequest.StartDate,
                EndDate = LeaveRequest.EndDate,
                LeaveTypeId = LeaveRequest.LeaveTypeId,
                Reason = LeaveRequest.Reason,
                Days = LeaveRequest.Days,
            };


            // Add leave request to the database
            _context.LeaveRequests.Add(leaveRequests);
            await _context.SaveChangesAsync();


            return CreatedAtAction(nameof(GetLeaveRequests), new { id = leaveRequests.Id }, leaveRequests);
        }

        
        private bool LeaveRequestsExists(int id)
        {
            return (_context.LeaveRequests?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
