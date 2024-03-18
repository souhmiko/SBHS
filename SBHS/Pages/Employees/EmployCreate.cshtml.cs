using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SBHS.Models;

namespace SBHS.Pages.user
{
    public class EmployCreateModel : PageModel
    {
        private readonly SBHS.Models.SBHSDbContext _context;

        public EmployCreateModel(SBHS.Models.SBHSDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["DepartmentId"] = new SelectList(_context.Departments, "DepartmentName", "DepartmentName");
        ViewData["WorkTitleId"] = new SelectList(_context.WorkTitles, "WorkTitleName", "WorkTitleName");
            return Page();
        }

        [BindProperty]
        public UserDetails UserDetails { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.UserDetails == null || UserDetails == null)
            {
                return Page();
            }

            _context.UserDetails.Add(UserDetails);
            await _context.SaveChangesAsync();

            return RedirectToPage("./EmployIndex");
        }
    }
}
