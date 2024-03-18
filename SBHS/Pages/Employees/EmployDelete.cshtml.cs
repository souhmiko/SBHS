using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SBHS.Models;

namespace SBHS.Pages.user
{
    public class EmployDeleteModel : PageModel
    {
        private readonly SBHS.Models.SBHSDbContext _context;

        public EmployDeleteModel(SBHS.Models.SBHSDbContext context)
        {
            _context = context;
        }

        [BindProperty]
      public UserDetails UserDetails { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.UserDetails == null)
            {
                return NotFound();
            }

            var userdetails = await _context.UserDetails
                .Include(u => u.Department)
                .Include(u => u.WorkTitle)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (userdetails == null)
            {
                return NotFound();
            }
            else 
            {
                UserDetails = userdetails;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.UserDetails == null)
            {
                return NotFound();
            }
            var userdetails = await _context.UserDetails.FindAsync(id);

            if (userdetails != null)
            {
                UserDetails = userdetails;
                _context.UserDetails.Remove(UserDetails);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./EmployIndex");
        }
    }
}
