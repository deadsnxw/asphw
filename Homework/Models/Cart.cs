namespace Homework.Models;

public class Cart {
    public List<CartItem> Items { get; set; } = new List<CartItem>();

    public decimal TotalPrice {
        get { return Items.Sum(item => item.Product.Price * item.Quantity); }
    }

    public void AddItem(Product product, int quantity = 1) {
        var cartItem = Items.FirstOrDefault(i => i.Product.Id == product.Id);
        if (cartItem == null) {
            Items.Add(new CartItem { Product = product, Quantity = quantity });
        }
        else {
            cartItem.Quantity += quantity;
        }
    }

    public void RemoveItem(int productId) {
        var cartItem = Items.FirstOrDefault(i => i.Product.Id == productId);
        if (cartItem != null) {
            Items.Remove(cartItem);
        }
    }

    public void Clear() {
        Items.Clear();
    }
}

