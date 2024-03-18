using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SBHS.Pages
{
    public class ConfirmationLeaveRequestPageModel : PageModel
    {
        public int RequestId { get; set; }

        public void OnGet(int id)
        {
            RequestId = id;
        }
    }
}
