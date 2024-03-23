using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SBHS.Models;
using System.Security.Claims;

namespace SBHS.Pages
{
    [Authorize]
    public class OncallFormModel : PageModel
    {
        private readonly SBHSDbContext _context;

        public OncallFormModel(SBHSDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public OncallRequests OncallRequest { get; set; } = new OncallRequests();
        public int DepartmentId { get; set; }
        public string FullName { get; set; } = string.Empty;

        public async Task OnGetAsync()
        {
            // Fetch user details including full name
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            
            var userDetails = await _context.UserDetails
                .Include(u => u.Department)
                .FirstOrDefaultAsync(u => u.AspNetUserId == userId);

            
            if (userDetails != null)
            {
                ViewData["FullName"] = userDetails.FullName;
                ViewData["Department"] = userDetails.Department.DepartmentName;

                // Assign UserDetailId
                OncallRequest.UserDetailId = userDetails.Id;
            }
        }


        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                return Page();
            }

            // Set default leave status to "Pending"
            OncallRequest.LeaveStatusId = GetPendingLeaveStatusId();
            

            // Get the current user's ID
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var userDetails = await _context.UserDetails
                .Include(u => u.Department)
                .FirstOrDefaultAsync(u => u.AspNetUserId == userId);

            if (userDetails != null)
            {
                // Assign UserDetailId
                OncallRequest.UserDetailId = userDetails.Id;
                OncallRequest.DepartmentId = userDetails.DepartmentId;

            }

            
            

            // Save the on-call request to the database
            _context.OncallRequests.Add(OncallRequest);
            await _context.SaveChangesAsync();

            
            return RedirectToPage("/User");
        }

        private int GetPendingLeaveStatusId()
        {
            // Assuming "Pending" leave status has ID 1 in the LeaveStatus table
            return 2; // Update this to query the database for the ID dynamically if needed
        }
    }
}
