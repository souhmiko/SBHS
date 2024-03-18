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
    public class DetailsModel : PageModel
    {
        private readonly SBHS.Models.SBHSDbContext _context;

        public DetailsModel(SBHS.Models.SBHSDbContext context)
        {
            _context = context;
        }

      public LeaveRequests LeaveRequests { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.LeaveRequests == null)
            {
                return NotFound();
            }

            var leaverequests = await _context.LeaveRequests.FirstOrDefaultAsync(m => m.Id == id);
            if (leaverequests == null)
            {
                return NotFound();
            }
            else 
            {
                LeaveRequests = leaverequests;
            }
            return Page();
        }
    }
}
