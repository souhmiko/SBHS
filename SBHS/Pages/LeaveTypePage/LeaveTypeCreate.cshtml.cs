using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SBHS.Models;

namespace SBHS.Pages.LeaveTypePage
{
    public class LeaveTypeCreateModel : PageModel
    {
        private readonly SBHS.Models.SBHSDbContext _context;

        public LeaveTypeCreateModel(SBHS.Models.SBHSDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public LeaveTypes LeaveTypes { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.LeaveTypes == null || LeaveTypes == null)
            {
                return Page();
            }

            _context.LeaveTypes.Add(LeaveTypes);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
