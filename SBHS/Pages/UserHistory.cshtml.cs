using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SBHS.Models;
using System.Security.Claims;

namespace SBHS.Pages
{
    public class UserHistoryModel : PageModel
    {
        private readonly SBHSDbContext _context;

        public UserHistoryModel(SBHSDbContext context)
        {
            _context = context;
        }

        public IList<LeaveRequests> LeaveRequests { get; set; } = default!;
        public IList<OncallRequests> OncallRequests { get; set; } = default!;
        public IList<LeaveRequests> AdminApprovedRequests { get; set; } = default!;
        public IList<LeaveRequests> AdminRejectedRequests { get; set; } = default!;

        public async Task OnGetAsync()
        {
            // Retrieve the currently logged-in user's UserDetailId
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (!string.IsNullOrEmpty(userId))
            {
                // Retrieve leave requests associated with the UserDetailId of the logged-in user
                LeaveRequests = await _context.LeaveRequests
                    .Include(l => l.LeaveStatus)
                    .Include(l => l.LeaveType)
                    .Where(l => l.UserDetailId == GetUserDetailId(userId))
                    .ToListAsync();

                // Retrieve oncall requests associated with the UserDetailId of the logged-in user
                OncallRequests = await _context.OncallRequests
                    .Include(l => l.LeaveStatus)
                    .Where(l => l.UserDetailId == GetUserDetailId(userId))
                    .ToListAsync();

                // Retrieve approved requests by the admin
                AdminApprovedRequests = await _context.LeaveRequests
                    .Include(l => l.LeaveStatus)
                    .Include(l => l.LeaveType)
                    .Where(l => l.LeaveStatusId == 1 && l.UserDetail.AspNetUserId == userId) // Assuming 1 is the ID for approved status
                    .ToListAsync();

                // Retrieve rejected requests by the admin
                AdminRejectedRequests = await _context.LeaveRequests
                    .Include(l => l.LeaveStatus)
                    .Include(l => l.LeaveType)
                    .Where(l => l.LeaveStatusId == 3 && l.UserDetail.AspNetUserId == userId) // Assuming 3 is the ID for rejected status
                    .ToListAsync();
            }
        }

        // Helper method to retrieve UserDetailId based on the AspNetUserId
        private int GetUserDetailId(string aspNetUserId)
        {
            var userDetail = _context.UserDetails.FirstOrDefault(u => u.AspNetUserId == aspNetUserId);
            return userDetail != null ? userDetail.Id : 0;
        }
    }
}
