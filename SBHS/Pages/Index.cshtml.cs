using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SBHS.Pages
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public IActionResult OnGet()
        {
            if (User.IsInRole("Admin"))
            {
                return RedirectToPage("/Admin");
            }
            else if (User.IsInRole("User"))
            {
                return RedirectToPage("/User");
            }

            // Default behavior if not in any role
            return Page();
        }
    }
}