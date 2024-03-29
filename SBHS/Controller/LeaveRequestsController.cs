using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SBHS.Models;
using SBHS.Services;

namespace SBHS.Controller
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class LeaveRequestsController : ControllerBase
    {
        private readonly SBHSDbContext _context;

        public LeaveRequestsController(SBHSDbContext context)
        {
            _context = context;
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
        public async Task<ActionResult<LeaveRequests>> PostLeaveRequests([FromForm] LeaveRequests leaveRequests, IFormFile file)
        {
            // Check if a file is uploaded
            if (file != null && file.Length > 0)
            {
                // Read the file content into a byte array
                using (var memoryStream = new MemoryStream())
                {
                    await file.CopyToAsync(memoryStream);
                    leaveRequests.UploadDocument = memoryStream.ToArray();
                }
            }



            // Retrieve the UserDetailId based on the logged-in user's ID

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var userDetails = await _context.UserDetails.FirstOrDefaultAsync(u => u.AspNetUserId == userId);
            if (userDetails == null)
            {
                return BadRequest("Unable to find user details for current user");
            }

            // Associate the UserDetailId with the leave request

            leaveRequests.UserDetailId = userDetails.Id;


            // Set the leave status to "Pending" (assuming "Pending" has an Id of 2)

            leaveRequests.LeaveStatusId = 2; // Assuming "Pending" has an Id of 2



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
                LeaveStatusId = 2
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
