using ExercicesEFCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExercicesEFCore.Controllers
{
    public class AuthController : Controller
    {
        private static readonly List<User> Users = new()
        {
            new User {Id = 1, Username = "admin", Password = "admin"},
            new User {Id = 2, Username = "user", Password = "user"}
        };
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            var user = Users.FirstOrDefault(x => x.Username == username && x.Password == password);

            if (user != null)
            {
                HttpContext.Session.SetString("Username", user.Username);
                return RedirectToAction("Index", "ToDo");
            }
            ViewBag.Message = "Nom d'utilisateur ou mot de passe incorrect";
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
    }
}
