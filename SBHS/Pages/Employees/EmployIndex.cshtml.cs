using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SBHS.Models;

namespace SBHS.Pages.user
{
    [Authorize(Roles = "Admin")]
    public class EmployIndexModel : PageModel
    {
        private readonly SBHS.Models.SBHSDbContext _context;

        public EmployIndexModel(SBHS.Models.SBHSDbContext context)
        {
            _context = context;
        }

        public IList<UserDetails> UserDetails { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.UserDetails != null)
            {
                UserDetails = await _context.UserDetails
                .Include(u => u.Department)
                .Include(u => u.WorkTitle).ToListAsync();
            }
        }
    }
}
