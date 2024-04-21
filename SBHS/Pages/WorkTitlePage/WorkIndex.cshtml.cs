using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SBHS.Models;

namespace SBHS.Pages.WorkTitlePage
{
    [Authorize(Roles = "Admin")]
    public class WorkIndexModel : PageModel
    {
        private readonly SBHS.Models.SBHSDbContext _context;

        public WorkIndexModel(SBHS.Models.SBHSDbContext context)
        {
            _context = context;
        }

        public IList<WorkTitles> WorkTitles { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.WorkTitles != null)
            {
                WorkTitles = await _context.WorkTitles.ToListAsync();
            }
        }
    }
}
