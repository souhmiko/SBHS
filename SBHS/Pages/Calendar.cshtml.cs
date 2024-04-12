using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SBHS.Models;

namespace SBHS.Pages
{
    public class CalendarModel : PageModel
    {
        public readonly SBHSDbContext _context;

        public CalendarModel(SBHSDbContext context)
        {
            _context = context;
        }

        public IList<LeaveRequests> ApprovedLeaveRequests { get; set; } = default!;
        public IList<OncallRequests> ApprovedOncallRequests { get; set; } = default!;

        public async Task OnGetAsync()
        {
            ApprovedLeaveRequests = await _context.LeaveRequests
                .Include(l => l.UserDetail)
                .Include(l => l.UserDetail)
                    .ThenInclude(u => u.Department)
                .Include(l => l.UserDetail)
                    .ThenInclude(u => u.WorkTitle)
                .Include(l => l.LeaveType)
                .Where(l => l.LeaveStatusId == 1) // Assuming 1 is the ID for approved status
                .ToListAsync();

            ApprovedOncallRequests = await _context.OncallRequests
                .Include(l => l.UserDetail)
                .Include(l => l.UserDetail)
                    .ThenInclude(u => u.Department) // Include Department navigation property
                .Include(l => l.UserDetail)
                    .ThenInclude(u => u.WorkTitle)
                .Where(l => l.LeaveStatusId == 1) // Assuming 1 is the ID for approved status
                .ToListAsync();
        }
    }
}
