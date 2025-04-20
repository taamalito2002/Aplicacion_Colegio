using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;
using POWApp.Models;

namespace POWApp.Pages.AdminUsuarios
{
    public class IndexModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public IndexModel(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        public List<ApplicationUser> Usuarios { get; set; } = new();

        public void OnGet()
        {
            Usuarios = _userManager.Users.ToList();
        }
    }
}
