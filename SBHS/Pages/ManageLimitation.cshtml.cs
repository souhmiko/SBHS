using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SBHS.Models;

namespace SBHS.Pages
{
    public class ManageLimitationModel : PageModel
    {
        private readonly SBHSDbContext _context;

        public ManageLimitationModel(SBHSDbContext context)
        {
            _context = context;
        }


        [BindProperty]
        public int WorkTitleId { get; set; }

        [BindProperty]
        public int MaxLeaveLimit { get; set; }

        [BindProperty]
        public int MaxOncallLimit { get; set; }

        public List<WorkTitles> WorkTitles { get; set; }=new List<WorkTitles>();
        public List<LeaveConditions> LeaveConditions { get; set; } = new List<LeaveConditions>();
        public List<OncallConditions> OncallConditions { get; set; } = new List<OncallConditions>();

        public async Task<IActionResult> OnGetAsync()
        {
            WorkTitles = await _context.WorkTitles.ToListAsync();

            LeaveConditions = await _context.LeaveConditions.Include(l => l.WorkTitle).ToListAsync();
            OncallConditions = await _context.OncallConditions.Include(o => o.WorkTitle).ToListAsync();


            return Page();
        }

        public async Task<IActionResult> OnPostLeaveConditionsAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // Update Leave Conditions
            var leaveConditions = await _context.LeaveConditions
                .FirstOrDefaultAsync(l => l.WorkTitleId == WorkTitleId);

            if (leaveConditions != null)
            {
                leaveConditions.MaxAmountofStaffAllowed = MaxLeaveLimit;
            }
            else
            {
                // If no existing record found, create a new one
                leaveConditions = new LeaveConditions
                {
                    WorkTitleId = WorkTitleId,
                    MaxAmountofStaffAllowed = MaxLeaveLimit
                    // Set other properties as needed
                };
                _context.LeaveConditions.Add(leaveConditions);
            }

            await _context.SaveChangesAsync();

            // Redirect back to the page
            return RedirectToPage("./ManageLimitation");
        }

        public async Task<IActionResult> OnPostOncallConditionsAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // Update Oncall Conditions
            var oncallConditions = await _context.OncallConditions
                .FirstOrDefaultAsync(o => o.WorkTitleId == WorkTitleId);

            if (oncallConditions != null)
            {
                oncallConditions.MaxAmountofStaffAllowed = MaxOncallLimit;
            }
            else
            {
                // If no existing record found, create a new one
                oncallConditions = new OncallConditions
                {
                    WorkTitleId = WorkTitleId,
                    MaxAmountofStaffAllowed = MaxOncallLimit
                    // Set other properties as needed
                };
                _context.OncallConditions.Add(oncallConditions);
            }

            await _context.SaveChangesAsync();

            // Redirect back to the page
            return RedirectToPage("./ManageLimitation");
        }

        public async Task<IActionResult> OnPostUpdateLeaveConditionAsync(int workTitleId, int updatedLeaveLimit)
        {
            var leaveCondition = await _context.LeaveConditions.FirstOrDefaultAsync(l => l.WorkTitleId == workTitleId);

            if (leaveCondition == null)
            {
                return NotFound();
            }

            leaveCondition.MaxAmountofStaffAllowed = updatedLeaveLimit;

            await _context.SaveChangesAsync();

            return RedirectToPage("./ManageLimitation");
        }

        public async Task<IActionResult> OnPostUpdateOncallConditionAsync(int workTitleId, int updatedOncallLimit)
        {
            var oncallCondition = await _context.OncallConditions.FirstOrDefaultAsync(o => o.WorkTitleId == workTitleId);

            if (oncallCondition == null)
            {
                return NotFound();
            }

            oncallCondition.MaxAmountofStaffAllowed = updatedOncallLimit;

            await _context.SaveChangesAsync();

            return RedirectToPage("./ManageLimitation");
        }
    }
}
