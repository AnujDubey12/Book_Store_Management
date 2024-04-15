using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace Book_Store1.Controllers
{
    public class AccountController : Controller
    {
        public async Task<IActionResult> Logout()
        {
            // Sign out the user.
           // await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            // Redirect to home page or any other page after logout.
            return RedirectToAction("Login", "Login");
        }
    }
}
