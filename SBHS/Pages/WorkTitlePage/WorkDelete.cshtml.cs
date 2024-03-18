﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SBHS.Models;

namespace SBHS.Pages.WorkTitlePage
{
    public class WorkDeleteModel : PageModel
    {
        private readonly SBHS.Models.SBHSDbContext _context;

        public WorkDeleteModel(SBHS.Models.SBHSDbContext context)
        {
            _context = context;
        }

        [BindProperty]
      public WorkTitles WorkTitles { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.WorkTitles == null)
            {
                return NotFound();
            }

            var worktitles = await _context.WorkTitles.FirstOrDefaultAsync(m => m.Id == id);

            if (worktitles == null)
            {
                return NotFound();
            }
            else 
            {
                WorkTitles = worktitles;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.WorkTitles == null)
            {
                return NotFound();
            }
            var worktitles = await _context.WorkTitles.FindAsync(id);

            if (worktitles != null)
            {
                WorkTitles = worktitles;
                _context.WorkTitles.Remove(WorkTitles);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./WorkIndex");
        }
    }
}
