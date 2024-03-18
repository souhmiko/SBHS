using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SBHS.Models;

namespace SBHS.Pages.DepartmentPage
{
    public class DepartCreateModel : PageModel
    {
        private readonly SBHS.Models.SBHSDbContext _context;

        public DepartCreateModel(SBHS.Models.SBHSDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Departments Departments { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Departments == null || Departments == null)
            {
                return Page();
            }

            _context.Departments.Add(Departments);
            await _context.SaveChangesAsync();

            return RedirectToPage("./DepartIndex");
        }
    }
}
