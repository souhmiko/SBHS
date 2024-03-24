using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SBHS.Models;

namespace SBHS.Pages
{
    public class RequestHistoryModel : PageModel
    {
        private readonly SBHSDbContext _context;

        public RequestHistoryModel(SBHSDbContext context)
        {
            _context = context;
        }

        public IList<LeaveRequests> ApprovedLeaveRequests { get; set; } = default!;
        public IList<LeaveRequests> RejectedLeaveRequests { get; set; } = default!;
        public IList<OncallRequests> ApprovedOncallRequests { get; set; } = default!;
        public IList<OncallRequests> RejectedOncallRequests { get; set; } = default!;

        public async Task OnGetAsync()
        {
            //Leave requests

            ApprovedLeaveRequests = await _context.LeaveRequests
                .Include(l => l.LeaveStatus)
                .Include(l => l.LeaveType)
                .Include(l => l.UserDetail)
                .Where(l => l.LeaveStatusId == 1) // Assuming 1 is the ID for approved status
                .ToListAsync();

            RejectedLeaveRequests = await _context.LeaveRequests
                .Include(l => l.LeaveStatus)
                .Include(l => l.LeaveType)
                .Include(l => l.UserDetail)
                .Where(l => l.LeaveStatusId == 3) // Assuming 3 is the ID for rejected status
                .ToListAsync();


            //Oncall requests

            ApprovedOncallRequests = await _context.OncallRequests
                .Include(l => l.LeaveStatus)
                .Include(l => l.UserDetail)
                .Where(l => l.LeaveStatusId == 1) // Assuming 1 is the ID for approved status
                .ToListAsync();

            RejectedOncallRequests = await _context.OncallRequests
                .Include(l => l.LeaveStatus)
                .Include(l => l.UserDetail)
                .Where(l => l.LeaveStatusId == 3) // Assuming 3 is the ID for rejected status
                .ToListAsync();
        }
    }
}
