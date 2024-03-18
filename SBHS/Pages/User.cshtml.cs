using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SBHS.Pages
{
    [Authorize(Roles = "User")]
    public class UserModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
