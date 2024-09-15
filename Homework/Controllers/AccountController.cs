using Microsoft.AspNetCore.Mvc;

namespace Homework.Controllers;
public class AccountController : Controller {
    public IActionResult Login() {
        ViewData["Title"] = "Login";
        return View();
    }

    [HttpPost]
    public IActionResult Login(string username, string password) {
        if (username == "admin" && password == "password") {
            return RedirectToAction("Index", "Home");
        }
        else {
            ViewBag.Error = "Invalid credentials";
            return View();
        }
    }
}


