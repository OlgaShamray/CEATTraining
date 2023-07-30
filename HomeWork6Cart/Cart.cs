public class ShopCart
{
    private static int UserIdNumberSeed = 12001;                      // <--- Encapsulation. Used to create unique UserId.
    public string UserId { get; }
    public string Owner { get; set; }

    public ShopCart(string name)
    {
        if (name != null)
        {
            Owner = name;
        }
        else Owner = "NoName";

        UserId = Owner + UserIdNumberSeed.ToString();
        UserIdNumberSeed++;
        ShowItems();
    }

    public decimal Amount
    {
        get
        {
            decimal amount = 0;
            foreach (var item in cartItems)
            {
                amount += item.Price * item.Quantity;
            }

            return amount;
        }
    }

    private List<Item> cartItems = new List<Item>();                  // <--- Encapsulation. Created to store products added to Cart.

    public void ShowItems()                                           // <--- Abstraction. Some way to show cart contents
    {
        if (Amount == 0)
        {
            Console.WriteLine($"Cart for UserId {UserId} is empty.");
        }
        else
        {
            Console.WriteLine($"Cart for UserId {UserId} contains products.");
            Console.WriteLine("Product | Quantity | Price | Amount");
            foreach (var item in cartItems)
            {
                Console.WriteLine($"{item.Product} | {item.Quantity} | {item.Price} | {item.Price * item.Quantity}");
            }
            Console.WriteLine($" Total Amount: {Amount}");
        }
    }

    public void AddItem(string product, int quantity, decimal price)  // <--- Abstraction. Some implementation of adding products to cart
    {
        if (price <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(price), "Price must be positive");
        }
        if (quantity <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(quantity), "Quantity must be positive");
        }

        var existitem = cartItems.Find(p => p.Product.Equals(product));

        if (existitem != null)
        {
            existitem.Quantity += quantity;
        }
        else
        {
            var item = new Item(product, quantity, price);
            cartItems.Add(item);
        }
    }

    public void RemoveItem(string product, int quantity)              // <--- Abstraction. Some implementation of removing products from cart
    {
        var item = cartItems.Find(p => p.Product.Equals(product));

        if (item == null)
        {
            throw new ArgumentNullException(nameof(item), $"The product '{product}' does not exist in the cart");
        }
        if (quantity <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(quantity), "Quantity must be positive");
        }
        if (quantity > item.Quantity)
        {
            throw new ArgumentOutOfRangeException(nameof(quantity), $"Cannot delete {product} more than {item.Quantity}");
        }
        if (quantity == item.Quantity)
        {
            cartItems.Remove(item);
        }
        if (quantity < item.Quantity)
        {  
          //item.Quantity = item.Quantity - quantity; //alt
            item.Quantity -= quantity;  
        }
    }

}

