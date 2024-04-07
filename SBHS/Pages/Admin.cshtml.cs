using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SBHS.Models;

namespace SBHS.Pages
{
    [Authorize(Roles ="Admin")]
    public class AdminModel : PageModel
    {
        private readonly SBHSDbContext _context;

        private const int ConsultantWorkTitleId = 1;
        private const int SpecialistWorkTitleId = 2;

        public AdminModel(SBHSDbContext context)
        {
            _context = context;
        }

        public int TotalLeaveRequests {  get; set; }
        public int TotalOncallRequests {  get; set; }
        public int TotalConsultants {  get; set; }
        public int TotalSpecialists {  get; set; }
        public int TotalApprovedRequests {  get; set; }
        public int TotalPendingRequests {  get; set; }
        public int TotalRejectedRequests {  get; set; }
        public int TotalLeaveRequestsToday {  get; set; }
        public int TotalOncallRequestsToday {  get; set; }

        public async Task OnGetAsync()
        {
            TotalLeaveRequests = await _context.LeaveRequests.CountAsync();
            TotalOncallRequests = await _context.OncallRequests.CountAsync();
            TotalConsultants = await _context.UserDetails.CountAsync(u => u.WorkTitleId == ConsultantWorkTitleId);
            TotalSpecialists = await _context.UserDetails.CountAsync(u => u.WorkTitleId == SpecialistWorkTitleId);
            
            TotalApprovedRequests = await _context.LeaveRequests
                .CountAsync(lr => lr.LeaveStatusId == 1) +
                await _context.OncallRequests
                .CountAsync(or => or.LeaveStatusId == 1);
            
            TotalPendingRequests = await _context.LeaveRequests
                .CountAsync(lr => lr.LeaveStatusId == 2) +
                await _context.OncallRequests
                .CountAsync(or => or.LeaveStatusId == 2);
            
            TotalRejectedRequests = await _context.LeaveRequests
                .CountAsync(lr => lr.LeaveStatusId == 3) +
                await _context.OncallRequests
                .CountAsync(or => or.LeaveStatusId == 3);

            //Get the current date
            DateTime today = DateTime.Today;

            TotalLeaveRequestsToday = await _context.LeaveRequests
                .CountAsync(lr => lr.StartDate.HasValue && lr.StartDate.Value.Date == today);

            TotalOncallRequestsToday = await _context.OncallRequests
                .CountAsync(lr => lr.DateTimeOnCall.HasValue && lr.DateTimeOnCall.Value.Date == today);

            ResetCountIfNeeded(today);
        }

        private void ResetCountIfNeeded(DateTime today)
        {
            // Check if it's a new day and reset the count
            if (DateTime.Today > today)
            {
                TotalLeaveRequestsToday = 0; // Reset the count
                TotalOncallRequestsToday = 0;
            }
        }
    }
}
