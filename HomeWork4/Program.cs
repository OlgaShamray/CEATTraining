Console.WriteLine("--- Olha Shamray - Homework 4 - E-shop cart ---");

Console.WriteLine("\n--- SHOW NEWLY CREATED CART ---");
    
    var cart = new ShopCart("Olha");

Console.WriteLine("\n--- ADDING PRODUCTS TO THE CART ---");

    cart.AddItem("Carrot", 1, 20); //(Product, Quantity, Price)
    cart.AddItem("Fish", 3, 150);
    cart.AddItem("Rice", 2, 50);

    cart.AddItem("Carrot", 1, 20); // For check adding the product that is already in the cart

    //cart.AddItem("Egg", -10, 7); // For check the exception: "Quantity must be positive"
    //cart.AddItem("Egg", 10, -7); // For check the exception: "Price must be positive"

    cart.ShowItems();

Console.WriteLine("\n--- DELETING PRODUCTS FROM THE CART ---");   

    cart.RemoveItem("Carrot", 2);   // For check deleting product from the cart
    cart.RemoveItem("Fish", 1);     // For check deleting product's quantity
    //cart.RemoveItem("Egg", 1);    // For check the exception: "The product does not exist in the cart"
    //cart.RemoveItem("Fish", -1);  // For check the exception: "Quantity must be positive"
    //cart.RemoveItem("Fish", 0);   // For check the exception: "Quantity must be positive"
    //cart.RemoveItem("Fish", 3);   // For check deleting product from the cart
    //cart.RemoveItem("Fish", 4);   // For check the exception: "Quantity to be deleted must not exceed the product's quantity contained in the cart"
    
    cart.ShowItems();