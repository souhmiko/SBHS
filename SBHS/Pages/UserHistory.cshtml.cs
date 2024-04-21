using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SBHS.Models;
using System.Security.Claims;

namespace SBHS.Pages
{
    [Authorize(Roles = "Admin")]
    public class UserHistoryModel : PageModel
    {
        private readonly SBHSDbContext _context;

        public UserHistoryModel(SBHSDbContext context)
        {
            _context = context;
        }

        public IList<LeaveRequests> AllLeaveRequests { get; set; } = default!;
        public IList<OncallRequests> AllOncallRequests { get; set; } = default!;
        public UserDetails UserDetail { get; set; } = new UserDetails();

        public async Task OnGetAsync()
        {
            // Retrieve the currently logged-in user's UserDetailId
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (!string.IsNullOrEmpty(userId))
            {
                // Retrieve leave requests associated with the UserDetailId of the logged-in user
                AllLeaveRequests = await _context.LeaveRequests
                    .Include(l => l.LeaveStatus)
                    .Include(l => l.LeaveType)
                    .Where(l => l.UserDetailId == GetUserDetailId(userId))
                    .Where(l => l.LeaveStatusId == 1 || l.LeaveStatusId == 3)
                    .OrderByDescending(l => l.DateApproved ?? l.DateRejected)
                    .ToListAsync();

                // Retrieve oncall requests associated with the UserDetailId of the logged-in user
                AllOncallRequests = await _context.OncallRequests
                    .Include(l => l.LeaveStatus)
                    .Where(l => l.UserDetailId == GetUserDetailId(userId))
                    .Where(l => l.LeaveStatusId == 1 || l.LeaveStatusId == 3)
                    .OrderByDescending(l => l.DateApproved ?? l.DateRejected)
                    .ToListAsync();

                // Fetch admin full names for leave requests
                foreach (var leaveRequest in AllLeaveRequests)
                {
                    leaveRequest.ApprovedByUserDetailId = GetAdminFullName(leaveRequest.ApprovedByUserDetailId);
                    leaveRequest.RejectedByUserDetailId = GetAdminFullName(leaveRequest.RejectedByUserDetailId);
                }

                // Fetch admin full names for on-call requests
                foreach (var oncallRequest in AllOncallRequests)
                {
                    oncallRequest.ApprovedByUserDetailId = GetAdminFullName(oncallRequest.ApprovedByUserDetailId);
                    oncallRequest.RejectedByUserDetailId = GetAdminFullName(oncallRequest.RejectedByUserDetailId);
                }
            }
        }

        // Helper method to retrieve UserDetailId based on the AspNetUserId
        private int GetUserDetailId(string aspNetUserId)
        {
            var userDetail = _context.UserDetails.FirstOrDefault(u => u.AspNetUserId == aspNetUserId);
            return userDetail != null ? userDetail.Id : 0;
        }


        // Method to fetch admin full name by user ID
        private string? GetAdminFullName(string? userId)
        {
            if (userId == null)
            {
                return null; // Or handle the null case accordingly
            }

            var userDetails = _context.UserDetails.FirstOrDefault(u => u.AspNetUserId == userId);
            return userDetails?.FullName;
        }
    }
}
