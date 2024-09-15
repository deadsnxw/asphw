using Homework.Models;
using Microsoft.AspNetCore.Mvc;

namespace Homework.Controllers;
public class CartController : Controller {
    private readonly Cart _cart;

    public CartController(Cart cart) {
        _cart = cart;
    }

    public IActionResult Index() {
        return View(_cart);
    }

    [HttpPost]
    public IActionResult AddToCart(int productId, int quantity = 1) {
        var product = ProductsController.products.FirstOrDefault(p => p.Id == productId);
        if (product != null) {
            _cart.AddItem(product, quantity);
        }
        return RedirectToAction("Index");
    }

    [HttpPost]
    public IActionResult RemoveFromCart(int productId) {
        _cart.RemoveItem(productId);
        return RedirectToAction("Index");
    }

    [HttpPost]
    public IActionResult ClearCart() {
        _cart.Clear();
        return RedirectToAction("Index");
    }
}


