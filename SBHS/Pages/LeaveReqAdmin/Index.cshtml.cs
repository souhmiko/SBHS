using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SBHS.Models;

namespace SBHS.Pages.LeaveReqAdmin
{
    public class IndexModel : PageModel
    {
        private readonly SBHS.Models.SBHSDbContext _context;

        public IndexModel(SBHS.Models.SBHSDbContext context)
        {
            _context = context;
        }

        public IList<LeaveRequests> LeaveRequests { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.LeaveRequests != null)
            {
                LeaveRequests = await _context.LeaveRequests
                .Include(l => l.LeaveStatus)
                .Include(l => l.LeaveType)
                .Include(l => l.UserDetail).ToListAsync();
            }
        }
    }
}
