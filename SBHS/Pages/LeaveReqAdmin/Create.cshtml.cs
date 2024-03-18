﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SBHS.Models;

namespace SBHS.Pages.LeaveReqAdmin
{
    public class CreateModel : PageModel
    {
        private readonly SBHS.Models.SBHSDbContext _context;

        public CreateModel(SBHS.Models.SBHSDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["LeaveStatusId"] = new SelectList(_context.LeaveStatus, "Id", "Id");
        ViewData["LeaveTypeId"] = new SelectList(_context.LeaveTypes, "Id", "Id");
        ViewData["UserDetailId"] = new SelectList(_context.UserDetails, "Id", "AspNetUserId");
            return Page();
        }

        [BindProperty]
        public LeaveRequests LeaveRequests { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.LeaveRequests == null || LeaveRequests == null)
            {
                return Page();
            }

            _context.LeaveRequests.Add(LeaveRequests);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
