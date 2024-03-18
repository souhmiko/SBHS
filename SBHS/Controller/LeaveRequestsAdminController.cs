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
    [Authorize(Roles = "Admin")]
    [Route("api/[controller]")]
    [ApiController]
    public class LeaveRequestsAdminController : ControllerBase
    {
        private readonly SBHSDbContext _context;

        public LeaveRequestsAdminController(SBHSDbContext context)
        {
            _context = context;
        }


        // GET: api/LeaveRequestsAdmin
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LeaveRequests>>> GetLeaveRequests()
        {
            var leaveRequests = await _context.LeaveRequests.Include(lr => lr.UserDetail).ToListAsync();
            return Ok(leaveRequests);
        }



        // GET: api/LeaveRequestsAdmin/5
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

        

        // POST: api/LeaveRequestsAdmin
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost("{id}/approved")]
        public async Task<ActionResult<LeaveRequests>> ApproveLeaveRequest(int id)
        {
            var leaveRequest = await _context.LeaveRequests.FindAsync(id);
            if (leaveRequest == null)
            {
                return NotFound();
            }

            leaveRequest.LeaveStatusId = 1;  // 1 represents 'Approved'
            leaveRequest.ApprovedByUserDetailId = User.FindFirstValue(ClaimTypes.NameIdentifier); // Record admin who approved the request
            leaveRequest.DateApproved = DateTime.Now; // Record approval date

            await _context.SaveChangesAsync();

            return Ok($"Leave request {id} approved successfully."); // Return success status
        }


        // Admin action: Reject a leave request
        [HttpPost("{id}/reject")]
        public async Task<IActionResult> RejectLeaveRequest(int id)
        {
            var leaveRequest = await _context.LeaveRequests.FindAsync(id);
            if(leaveRequest == null)
            {
                return NotFound();
            }

            leaveRequest.LeaveStatusId = 3; // 3 represents 'Rejected'
            leaveRequest.RejectedByUserDetailId = User.FindFirstValue(ClaimTypes.NameIdentifier); // Record admin who rejected the request
            leaveRequest.DateRejected = DateTime.Now; // Record rejection date

            await _context.SaveChangesAsync();

            return Ok($"Leave request {id} rejected."); // Return success status
        }


        private bool LeaveRequestsExists(int id)
        {
            return (_context.LeaveRequests?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }

}
