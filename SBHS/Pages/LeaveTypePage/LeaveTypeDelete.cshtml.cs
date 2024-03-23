using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SBHS.Models;

namespace SBHS.Pages.LeaveTypePage
{
    public class LeaveTypeDeleteModel : PageModel
    {
        private readonly SBHS.Models.SBHSDbContext _context;

        public LeaveTypeDeleteModel(SBHS.Models.SBHSDbContext context)
        {
            _context = context;
        }

        [BindProperty]
      public LeaveTypes LeaveTypes { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.LeaveTypes == null)
            {
                return NotFound();
            }

            var leavetypes = await _context.LeaveTypes.FirstOrDefaultAsync(m => m.Id == id);

            if (leavetypes == null)
            {
                return NotFound();
            }
            else 
            {
                LeaveTypes = leavetypes;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.LeaveTypes == null)
            {
                return NotFound();
            }
            var leavetypes = await _context.LeaveTypes.FindAsync(id);

            if (leavetypes != null)
            {
                LeaveTypes = leavetypes;
                _context.LeaveTypes.Remove(LeaveTypes);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./LeaveTypeIndex");
        }
    }
}
