using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SBHS.Models;
using SBHS.Services;

namespace SBHS.Pages
{
    public class LeaveReqAdminModel : PageModel
    {
        private readonly SBHS.Models.SBHSDbContext _context;

        public LeaveReqAdminModel(SBHS.Models.SBHSDbContext context)
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
                .Include(l => l.UserDetail).ToListAsync();
            }
        }

        public async Task<IActionResult> OnPostApproveAsync(int requestId)
        {
            var leaveRequest = await _context.LeaveRequests.FindAsync(requestId);

            if (leaveRequest == null)
            {
                return NotFound();
            }

            // Process the approval logic (update database, send notifications, etc.)
            leaveRequest.LeaveStatusId = 1;

            // Save changes to the database
            await _context.SaveChangesAsync();

            // Redirect to the same page after approval
            return RedirectToPage("/LeaveReqAdmin");
        }

        public async Task<IActionResult> OnPostRejectAsync(int requestId)
        {
            var leaveRequest = await _context.LeaveRequests.FindAsync(requestId);

            if (leaveRequest == null)
            {
                return NotFound();
            }

            // Process the rejection logic (update database, send notifications, etc.)
            leaveRequest.LeaveStatusId = 3;

            // Save changes to the database
            await _context.SaveChangesAsync();

            // Redirect to the same page after rejection
            return RedirectToPage("/LeaveReqAdmin");
        }
    }
}
