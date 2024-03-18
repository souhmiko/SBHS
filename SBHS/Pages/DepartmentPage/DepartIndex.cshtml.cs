using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SBHS.Models;

namespace SBHS.Pages.DepartmentPage
{
    public class DepartIndexModel : PageModel
    {
        private readonly SBHS.Models.SBHSDbContext _context;

        public DepartIndexModel(SBHS.Models.SBHSDbContext context)
        {
            _context = context;
        }

        public IList<Departments> Departments { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Departments != null)
            {
                Departments = await _context.Departments.ToListAsync();
            }
        }
    }
}
