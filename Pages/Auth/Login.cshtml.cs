using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SmartCRM.Models;
using SmartCRM.Services;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace SmartCRM.Pages.Auth
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public User LoginUser { get; set; } = new();

        public string ErrorMessage { get; set; } = "";

        public async Task<IActionResult> OnPost()
        {
            var auth = new AuthService();
            var user = auth.Validate(LoginUser.Username, LoginUser.Password);

            if (user == null)
            {
                ErrorMessage = "Invalid Username or Password";
                return Page();
            }

            // 🔐 CREATE SESSION
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, LoginUser.Username)
            };

            var identity = new ClaimsIdentity(claims, "MyCookieAuth");
            var principal = new ClaimsPrincipal(identity);

            await HttpContext.SignInAsync("MyCookieAuth", principal);

            return RedirectToPage("/Index");
        }
    }
}