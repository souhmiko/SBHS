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
        public SelectList DepartmentId { get; set; }
        public string FullName { get; set; } = string.Empty;

        public async Task OnGetAsync()
        {
            // Fetch user details including full name
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            
            var userDetails = await _context.UserDetails
                .FirstOrDefaultAsync(u => u.AspNetUserId == userId);

            var departments = await _context.Departments.ToListAsync();
            ViewData["Departments"] = new SelectList(await _context.Departments.ToListAsync(), "Id", "DepartmentName");


            if (userDetails != null)
            {
                ViewData["FullName"] = userDetails.FullName;

                // Assign UserDetailId
                OncallRequest.UserDetailId = userDetails.Id;
            }
        }


        public async Task<IActionResult> OnPostSubmitRequest([Bind("UserDetailId, DepartmentId, DateTimeOnCall, LeaveStatusId")] OncallRequests formData)
        {
            //Validate and process the form data
            if (ModelState.IsValid)
            {
                return Page();
            }

            // Get the current user's ID
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            // Find the associated UserDetails using the AspNetUserId
            var userDetails = await _context.UserDetails
                .FirstOrDefaultAsync(u => u.AspNetUserId == userId);

            if (userDetails == null)
            {
                // Handle case where user details are not found
                return BadRequest("User details not found.");
            }

            // Assign the UserDetailId to the on-call request
            OncallRequest.UserDetailId = userDetails.Id;

            // Assign the DepartmentId to the on-call request
            OncallRequest.DepartmentId = userDetails.DepartmentId;

            // Assign the datetimeoncall to the on-call request
            OncallRequest.DateTimeOnCall = OncallRequest.DateTimeOnCall;

            // Set default leave status to "Pending"
            OncallRequest.LeaveStatusId = GetPendingLeaveStatusId();

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
