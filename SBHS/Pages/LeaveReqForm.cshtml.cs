using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using SBHS.Models;
using SBHS.Services;
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
        public IFormFile? UploadDocument { get; set; }

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
            // Check if the quota for the requested date is full
            //if (IsQuotaFull(LeaveRequest.StartDate))
            //{
            //    // Set a message indicating that the quota is full
            //    ViewData["QuotaFullMessage"] = "Quota for this date is full. Please choose another date.";
            //    return Page(); // Return the page with the message
            //}

            if (!ModelState.IsValid)
            {
                return Page();
            }

            // Save uploaded file data to the database
            if (UploadDocument != null && UploadDocument.Length > 0)
            {
                using (var memoryStream = new MemoryStream())
                {
                    await UploadDocument.CopyToAsync(memoryStream);
                    LeaveRequest.UploadDocument = memoryStream.ToArray(); // Convert to byte array and store in the model
                }
            }

            // Set default leave status to "Pending"
            LeaveRequest.LeaveStatusId = GetPendingLeaveStatusId();


            // Fetch user details including full name
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var userDetails = await _context.UserDetails
                .Include(u => u.WorkTitle)
                .FirstOrDefaultAsync(u => u.AspNetUserId == userId);

            if (userDetails != null)
            {
                // Assign UserDetailId
                LeaveRequest.UserDetailId = userDetails.Id;
            }


            // Fetch the leave conditions for the user's work title
            var leaveCondition = await _context.LeaveConditions
                .FirstOrDefaultAsync(lc => userDetails != null && lc.WorkTitleId == userDetails.WorkTitleId);

            if (leaveCondition == null)
            {
                // Handle the case where leave conditions are not found for the user's work title
                return NotFound();
            }

            // Check if the quota for the requested date is full
            if (IsQuotaFull(LeaveRequest.StartDate, leaveCondition.MaxAmountofStaffAllowed))
            {
                // Set a message indicating that the quota is full
                ViewData["QuotaFullMessage"] = "Quota for this date is full. Please choose another date.";
                return Page(); // Return the page with the message
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

        //private bool IsQuotaFull(DateTime? date)
        //{
        //    if (date.HasValue)
        //    {
        //        // Count the number of leave requests for the given date
        //        var leaveRequestsCount = _context.LeaveRequests
        //            .Count(lr => lr.StartDate.HasValue && lr.StartDate.Value.Date == date.Value.Date);

        //        // Assuming the quota is 3, check if the count exceeds the quota
        //        return leaveRequestsCount >= 1;
        //    }
        //    else
        //    {
        //        // Handle the case where date is null (optional)
        //        return false; // or throw an exception, depending on your requirements
        //    }
        //}

        private bool IsQuotaFull(DateTime? date, int? maxAllowed)
        {
            if (date.HasValue)
            {
                // Count the number of leave requests for the given date
                var leaveRequestsCount = _context.LeaveRequests
                    .Count(lr => lr.StartDate.HasValue && lr.StartDate.Value.Date == date.Value.Date);

                // Check if the count exceeds the maximum allowed
                return leaveRequestsCount >= maxAllowed;
            }
            else
            {
                // Handle the case where date is null (optional)
                return false; // or throw an exception, depending on your requirements
            }
        }
    }
}
