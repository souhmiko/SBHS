using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SBHS.Models;

namespace SBHS.Pages
{
    public class ViewFileModel : PageModel
    {
        private readonly SBHSDbContext _context;

        public ViewFileModel(SBHSDbContext context)
        {
            _context = context;
        }

        public byte[] DocumentData { get; private set; }

        public async Task<IActionResult> OnGetAsync(int documentId)
        {
            var leaveRequest = await _context.LeaveRequests.FindAsync(documentId);
            if (leaveRequest == null || leaveRequest.UploadDocument == null)
            {
                return NotFound();
            }

            DocumentData = leaveRequest.UploadDocument;
            return Page();
        }
    }
}
