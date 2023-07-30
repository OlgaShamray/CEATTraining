Console.WriteLine("--- Olha Shamray - Homework 6 - Exceptions handling ---");

Console.WriteLine("\n--- SHOW NEWLY CREATED CART ---\n");

    var cart = new ShopCart("Olha");

Console.WriteLine("\n--- ADDING PRODUCTS TO THE CART ---\n");

    cart.AddItem("Carrot", 1, 20); //(Product, Quantity, Price)
    cart.AddItem("Fish", 3, 150);
    cart.AddItem("Rice", 2, 50);
    cart.AddItem("Carrot", 1, 20); // For check adding the product that is already in the cart

    try
    {
        //cart.AddItem("Egg", -10, 7); // For check the exception: "Quantity must be positive"
        cart.AddItem("Egg", 10, -7); // For check the exception: "Price must be positive"
    }
    catch (ArgumentOutOfRangeException ex)
    {
        Console.WriteLine(" ! Something went wrong.");
        Console.WriteLine($" ! Error message 1: {ex.Message}\n");
    }

    cart.ShowItems();

Console.WriteLine("\n--- DELETING PRODUCTS FROM THE CART ---\n");

    cart.RemoveItem("Carrot", 2);   // For check deleting product from the cart
    cart.RemoveItem("Fish", 1);     // For check deleting product's quantity

    try
    {
        //cart.RemoveItem("Egg", 1);   // For check the exception: "The product does not exist in the cart"
        //cart.RemoveItem("Fish", -1); // For check the exception: "Quantity must be positive"
        //cart.RemoveItem("Fish", 0);  // For check the exception: "Quantity must be positive"
        cart.RemoveItem("Fish", 4);  // For check the exception: "Cannot delete {product} more than {Quantity}"
    }
    catch (ArgumentNullException ex)
    {
        Console.WriteLine(" ! Something went wrong.");
        Console.WriteLine($" ! Error message 2: {ex.Message}\n");
    }
    catch (ArgumentOutOfRangeException ex)
    {
        Console.WriteLine(" ! Something went wrong.");
        Console.WriteLine($" ! Error message 3: {ex.Message}\n");
        //throw new InvalidOperationException($"Error while deleting {productToDelete} from the cart", ex);
    }
    // catch (InvalidOperationException ex)
    // {
    //      Console.WriteLine("Something went wrong.");
    //      Console.WriteLine($"Error message: {ex.Message}");
    // }

    cart.ShowItems();
