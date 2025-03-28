using Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NeXusERP.WebUI.Models;

namespace NeXusERP.WebUI.Pages.Login
{
    [AllowAnonymous]
    public class IndexModel : PageModel
    {
       private readonly SignInManager<UserAuthentication> _signInManager;
       private readonly UserManager<UserAuthentication> _userManager;

        public IndexModel(SignInManager<UserAuthentication> signInManager, UserManager<UserAuthentication> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }
        [BindProperty]
        public LoginInputModel Input { get; set; }
        public string ErrorMessage { get; set; } = string.Empty;

        public async Task<IActionResult> OnPostAsync(string email, string password)
        {
            var user = await _userManager.FindByEmailAsync(Input.email);
            if (user != null)
            {
                var result = await _signInManager.PasswordSignInAsync(user, Input.password, false, false);

                if (result.Succeeded)
                {
                    return RedirectToPage("/Index");
                }
            }
            ErrorMessage = "Usuario o contraseņa incorrecta";
            return Page();
        }     
    }
}
