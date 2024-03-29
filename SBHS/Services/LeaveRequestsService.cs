using Microsoft.EntityFrameworkCore;
using SBHS.Models;

namespace SBHS.Services
{
    public class LeaveRequestsService
    {
        private readonly SBHSDbContext _context;
        private const int MaxLeaveRequestsPerDay = 1;

        public LeaveRequestsService(SBHSDbContext context)
        {
            _context = context;
        }

        public async Task<bool> IsLeaveRequestLimitReached(int userDetailId, DateTime date)
        {
            int leaveRequestsCount = await _context.LeaveRequests
                .CountAsync(r => r.UserDetailId == userDetailId &&
                                 r.StartDate.HasValue &&
                                 r.StartDate.Value.Date == date.Date);

            return leaveRequestsCount >= MaxLeaveRequestsPerDay;
        }
    }
}
