using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SBHS.Pages
{
    [Authorize(Roles ="Admin")]
    public class AdminModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
