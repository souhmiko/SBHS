using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SBHS.Models;

namespace SBHS.Pages.LeaveTypePage
{
    public class LeaveTypeEditModel : PageModel
    {
        private readonly SBHS.Models.SBHSDbContext _context;

        public LeaveTypeEditModel(SBHS.Models.SBHSDbContext context)
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

            var leavetypes =  await _context.LeaveTypes.FirstOrDefaultAsync(m => m.Id == id);
            if (leavetypes == null)
            {
                return NotFound();
            }
            LeaveTypes = leavetypes;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(LeaveTypes).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LeaveTypesExists(LeaveTypes.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./LeaveTypeIndex");
        }

        private bool LeaveTypesExists(int id)
        {
          return (_context.LeaveTypes?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
