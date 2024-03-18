using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SBHS.Models;

namespace SBHS.Pages
{
    public class OncallRequestAdminModel : PageModel
    {
        private readonly SBHS.Models.SBHSDbContext _context;

        public OncallRequestAdminModel(SBHS.Models.SBHSDbContext context)
        {
            _context = context;
        }

        public IList<OncallRequests> OncallRequests { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.OncallRequests != null)
            {
                OncallRequests = await _context.OncallRequests
                .Include(o => o.LeaveStatus)
                .Include(o => o.UserDetail).ToListAsync();
            }
        }
    }
}
