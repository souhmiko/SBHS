using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SBHS.Models;
using SBHS.Services;
using System.Security.Claims;

namespace SBHS.Pages
{
    [Authorize(Roles = "Admin")]
    public class LeaveReqAdminModel : PageModel
    {
        private readonly SBHSDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public LeaveReqAdminModel(SBHSDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
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


            // Get the ID of the current user
            var currentUser = await _userManager.GetUserAsync(User);
            var adminDetails = await _context.UserDetails.FirstOrDefaultAsync(u => u.AspNetUserId == currentUser.Id);

            if (action == "Approve")
            {
                leaveRequest.LeaveStatusId = 1; // Assuming 1 is the ID for approved status
                leaveRequest.ApprovedByUserDetailId = adminDetails?.AspNetUserId; // Set the admin who approved the request
                leaveRequest.DateApproved = DateTime.Now; // Set the current date/time as the approval date
            }
            else if (action == "Reject")
            {
                leaveRequest.LeaveStatusId = 3; // Assuming 3 is the ID for rejected status
                leaveRequest.RejectedByUserDetailId = adminDetails?.AspNetUserId; // Set the admin who rejected the request
                leaveRequest.DateRejected = DateTime.Now; // Set the current date/time as the rejection date
            }

            // Save changes to the database
            await _context.SaveChangesAsync();

            

            // Redirect to the same page after approval
            return RedirectToPage("/LeaveReqAdmin");
        }

        public async Task<IActionResult> OnGetDownloadDocument(int id)
        {
            var leaveRequest = await _context.LeaveRequests.FindAsync(id);
            if (leaveRequest == null || leaveRequest.UploadDocument == null)
            {
                return NotFound();
            }

            // Return the file as a stream to allow the admin to view it in the browser
            return File(leaveRequest.UploadDocument, "application/octet-stream", "document.pdf");
        }
    }
}
