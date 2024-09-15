using Homework.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Homework.Controllers;
public class HomeController : Controller {
    public IActionResult Index() {
        ViewData["Title"] = "Home";
        return View();
    }
}

