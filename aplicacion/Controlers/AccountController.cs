using Microsoft.AspNetCore.Mvc;
using aplicacion.Models;
using aplicacion.Services;

namespace app_to_do.Controllers
{
    public class AccountController : Controller
    {
        private readonly AuthService _authService;

        public AccountController(AuthService authService)
        {
            _authService = authService;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LogingViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            bool valido =
                _authService.ValidarUsuario(
                    model.Email,
                    model.Password);

            if (valido)
                return RedirectToAction("Welcome");

            return RedirectToAction("Error");
        }

        public IActionResult Welcome()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
