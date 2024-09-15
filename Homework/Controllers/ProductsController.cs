using Homework.Models;
using Microsoft.AspNetCore.Mvc;

namespace Homework.Controllers;
public class ProductsController : Controller {
    public static List<Product> products = new List<Product>
    {
        new Product { Id = 1, Name = "Product 1", Price = 10.99m, Description = "Description 1"},
        new Product { Id = 2, Name = "Product 2", Price = 20.99m, Description = "Description 2"},
        new Product { Id = 3, Name = "Product 3", Price = 30.99m, Description = "Description 3"}
    };

    public IActionResult Index() {
        ViewData["Title"] = "Products";
        return View(products);
    }

    public IActionResult Details(int id) {
        var product = products.FirstOrDefault(p => p.Id == id);
        if (product == null) {
            return NotFound();
        }
        return View(product);
    }
}


