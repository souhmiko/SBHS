using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SBHS.Models;

namespace SBHS.Pages
{
    public class OncallRequestAdminModel : PageModel
    {
        private readonly SBHS.Models.SBHSDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public OncallRequestAdminModel(SBHS.Models.SBHSDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IList<OncallRequests> OncallRequests { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.OncallRequests != null)
            {
                OncallRequests = await _context.OncallRequests
                .Include(o => o.Department)
                .Include(o => o.LeaveStatus)
                .Where(l => l.LeaveStatusId != 1 && l.LeaveStatusId != 3) // Exclude approved and rejected requests
                .Include(o => o.UserDetail).ToListAsync();
            }
        }


        public async Task<IActionResult> OnPostAsync(int requestId, string action)
        {
            var oncallRequest = await _context.OncallRequests.FindAsync(requestId);

            if (oncallRequest == null)
            {
                return NotFound();
            }

            // Get the ID of the current user
            var currentUser = await _userManager.GetUserAsync(User);
            var adminDetails = await _context.UserDetails.FirstOrDefaultAsync(u => u.AspNetUserId == currentUser.Id);

            if (action == "Approve")
            {
                oncallRequest.LeaveStatusId = 1; // Assuming 1 is the ID for approved status
                oncallRequest.ApprovedByUserDetailId = adminDetails?.AspNetUserId; ; // Set the admin who approved the request
                oncallRequest.DateApproved = DateTime.Now; // Set the current date/time as the approval date
            }
            else if (action == "Reject")
            {
                oncallRequest.LeaveStatusId = 3; // Assuming 3 is the ID for rejected status
                oncallRequest.RejectedByUserDetailId = adminDetails?.AspNetUserId; // Set the admin who rejected the request
                oncallRequest.DateRejected = DateTime.Now; // Set the current date/time as the rejection date
            }

            // Save changes to the database
            await _context.SaveChangesAsync();



            // Redirect to the same page after approval
            return RedirectToPage("/OncallRequestAdmin");
        }
    }
}
