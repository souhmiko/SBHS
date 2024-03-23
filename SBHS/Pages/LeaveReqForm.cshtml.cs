using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using SBHS.Models;
using System.ComponentModel.DataAnnotations;
using System.Net.Http;
using System.Security.Claims;


namespace SBHS.Pages
{
    public class LeaveReqFormModel : PageModel
    {
        private readonly SBHSDbContext _context;

        public LeaveReqFormModel(SBHSDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public LeaveRequests LeaveRequest { get; set; } = new LeaveRequests();
        public int LeaveTypeId { get; set; }
        public string FullName { get; set; } = string.Empty;   // Add a property to hold the user's full name


        public async Task OnGetAsync()
        {
            // Fetch leave types from the server
            var leaveTypes = await _context.LeaveTypes.ToListAsync();
            ViewData["LeaveTypes"] = new SelectList(await _context.LeaveTypes.ToListAsync(), "Id", "LeaveTypeName");


            // Fetch user details including full name
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var userDetails = await _context.UserDetails.FirstOrDefaultAsync(u => u.AspNetUserId == userId);

            if (userDetails != null)
            {
                ViewData["FullName"] = userDetails.FullName;
                
                // Assign UserDetailId
                LeaveRequest.UserDetailId = userDetails.Id;
            }

        }


        public async Task<IActionResult> OnPost()
        {

            if (!ModelState.IsValid)
            {
                return Page();
            }

            
            // Set default leave status to "Pending"
            LeaveRequest.LeaveStatusId = GetPendingLeaveStatusId();


            // Fetch user details including full name
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var userDetails = await _context.UserDetails.FirstOrDefaultAsync(u => u.AspNetUserId == userId);

            if (userDetails != null)
            {
                // Assign UserDetailId
                LeaveRequest.UserDetailId = userDetails.Id;
            }


            // Save the leave request to the database
            _context.LeaveRequests.Add(LeaveRequest);
            await _context.SaveChangesAsync();

            // Redirect to a confirmation page or dashboard
            return RedirectToPage("/User");
        }

        private int GetPendingLeaveStatusId()
        {
            // Assuming "Pending" leave status has ID 1 in the LeaveStatus table
            return 2; // Update this to query the database for the ID dynamically if needed
        }

    }
}
