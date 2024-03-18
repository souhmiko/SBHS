using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SBHS.Models;

namespace SBHS.Pages.WorkTitlePage
{
    public class WorkCreateModel : PageModel
    {
        private readonly SBHS.Models.SBHSDbContext _context;

        public WorkCreateModel(SBHS.Models.SBHSDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public WorkTitles WorkTitles { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.WorkTitles == null || WorkTitles == null)
            {
                return Page();
            }

            _context.WorkTitles.Add(WorkTitles);
            await _context.SaveChangesAsync();

            return RedirectToPage("./WorkIndex");
        }
    }
}
