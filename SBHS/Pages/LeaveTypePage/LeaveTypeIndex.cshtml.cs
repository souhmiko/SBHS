using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SBHS.Models;

namespace SBHS.Pages.LeaveTypePage
{
    public class LeaveTypeIndexModel : PageModel
    {
        private readonly SBHS.Models.SBHSDbContext _context;

        public LeaveTypeIndexModel(SBHS.Models.SBHSDbContext context)
        {
            _context = context;
        }

        public IList<LeaveTypes> LeaveTypes { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.LeaveTypes != null)
            {
                LeaveTypes = await _context.LeaveTypes.ToListAsync();
            }
        }
    }
}
