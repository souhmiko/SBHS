using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SBHS.Models;

namespace SBHS.Pages
{
    [Authorize(Roles = "Admin")]
    public class RequestHistoryModel : PageModel
    {
        private readonly SBHSDbContext _context;

        public RequestHistoryModel(SBHSDbContext context)
        {
            _context = context;
        }

        public IList<LeaveRequests> AllLeaveRequests { get; set; } = default!;
        public IList<OncallRequests> AllOncallRequests { get; set; } = default!;
        public UserDetails UserDetail { get; set; } = new UserDetails();

        public async Task OnGetAsync()
        {
            // Combined leave requests
            AllLeaveRequests = await _context.LeaveRequests
                .Include(l => l.LeaveStatus)
                .Include(l => l.LeaveType)
                .Include(l => l.UserDetail)
                .Where(l => l.LeaveStatusId == 1 || l.LeaveStatusId == 3) // Combine approved and rejected
                .OrderByDescending(l => l.DateApproved ?? l.DateRejected) // Sort by approval date or rejection date
                .ToListAsync();

            // Combined on-call requests
            AllOncallRequests = await _context.OncallRequests
                .Include(l => l.LeaveStatus)
                .Include(l => l.UserDetail)
                .Where(l => l.LeaveStatusId == 1 || l.LeaveStatusId == 3) // Combine approved and rejected
                .OrderByDescending(l => l.DateApproved ?? l.DateRejected) // Sort by approval date or rejection date
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
