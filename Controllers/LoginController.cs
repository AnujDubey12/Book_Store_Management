using Book_Store1.Models.Domain;
using Microsoft.AspNetCore.Mvc;
using static Book_Store1.Models.Domain.Login;

namespace Book_Store1.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Login model)
        {
            if (ModelState.IsValid)
            {
                // Hardcoded username and password for demonstration
                if (model.UserName == "Anuj" && model.Password == "Anuj123")
                {
                    // Redirect to some other page upon successful login
                    return RedirectToAction("GetAll", "Book");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid username or password.");
                }
            }

            // If we reach here, something went wrong, redisplay form with errors
            return View(model);
        }
    }
}
