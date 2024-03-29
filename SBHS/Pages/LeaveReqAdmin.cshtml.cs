using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SBHS.Models;
using SBHS.Services;

namespace SBHS.Pages
{
    public class LeaveReqAdminModel : PageModel
    {
        private readonly SBHSDbContext _context;

        public LeaveReqAdminModel(SBHSDbContext context)
        {
            _context = context;
            
        }

        public IList<LeaveRequests> LeaveRequests { get; set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.LeaveRequests != null)
            {
                LeaveRequests = await _context.LeaveRequests
                .Include(l => l.LeaveStatus)
                .Include(l => l.LeaveType)
                .Where(l => l.LeaveStatusId != 1 && l.LeaveStatusId != 3) // Exclude approved and rejected requests
                .Include(l => l.UserDetail).ToListAsync();
            }
        }

        public async Task<IActionResult> OnPostAsync(int requestId, string action)
        {
            var leaveRequest = await _context.LeaveRequests.FindAsync(requestId);

            if (leaveRequest == null)
            {
                return NotFound();
            }


            if (action == "Approve")
            {
                leaveRequest.LeaveStatusId = 1; // Assuming 1 is the ID for approved status
                leaveRequest.ApprovedByUserDetailId = "admin"; // Set the admin who approved the request
                leaveRequest.DateApproved = DateTime.Now; // Set the current date/time as the approval date
            }
            else if (action == "Reject")
            {
                leaveRequest.LeaveStatusId = 3; // Assuming 3 is the ID for rejected status
                leaveRequest.RejectedByUserDetailId = "admin"; // Set the admin who rejected the request
                leaveRequest.DateRejected = DateTime.Now; // Set the current date/time as the rejection date
            }

            // Save changes to the database
            await _context.SaveChangesAsync();

            

            // Redirect to the same page after approval
            return RedirectToPage("/LeaveReqAdmin");
        }

        

    }
}
