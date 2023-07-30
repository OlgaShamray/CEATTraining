using System;

namespace HomeWork8CartTest;
//using HomeWork6;

public class Tests
{
    ShopCart cart;

    [SetUp]
    public void Setup()
    {
        cart = new ShopCart("Olha");
    }

    // Adding item and calculation amount for the item
    [TestCase(20, 1, 20)]    
    [TestCase(40, 2, 20)]
    [TestCase(45, 3, 15)]
    public void TestAdd1(int Expected, int Quantity, decimal Price)
    {
        cart.AddItem("Carrot", Quantity, Price);
        Assert.That(cart.Amount, Is.EqualTo(Expected));
    }

    // Adding different items and calculation amount of the Cart
    [Test]   
    public void TestAdd2()
    {
        cart.AddItem("Carrot", 1, 20);
        cart.AddItem("Fish", 3, 150);
        Assert.AreEqual(470, cart.Amount);
    }

    // Deleting item and calculation amount of the Cart
    [Test]
    public void TestRemove1()
    {
        cart.AddItem("Carrot", 3, 20);
        cart.RemoveItem("Carrot", 2);
        Assert.AreEqual(20, cart.Amount);
    }

    // Adding item with the exception: "Quantity must be positive"
    [Test]
    public void TestAddException1()
    {
        Assert.Throws<ArgumentOutOfRangeException>(delegate { cart.AddItem("Carrot", 0, 20); });
    }

    // Adding item with the exception: "Price must be positive"
    [Test]
    public void TestAddException2()
    {
        Assert.Throws<ArgumentOutOfRangeException>(delegate { cart.AddItem("Carrot", 2, 0); });
    }

    // Deleting item with the exception: "The product '{product}' does not exist in the cart"
    [Test]
    public void TestRemoveException1()
    {
        Assert.Throws<ArgumentNullException>(delegate { cart.RemoveItem("Carrot", 1); });
    }

    // Deleting item with the exception: "Quantity must be positive"
    [Test]
    public void TestRemoveException2()
    {
        cart.AddItem("Carrot", 2, 20);
        Assert.Throws<ArgumentOutOfRangeException>(delegate { cart.RemoveItem("Carrot", -1); });
    }

    // Deleting item with the exception: "Cannot delete {product} more than {item.Quantity}");
    [Test]
    public void TestRemoveException3()
    {
        cart.AddItem("Carrot", 1, 20);
        Assert.Throws<ArgumentOutOfRangeException>(delegate { cart.RemoveItem("Carrot", 2); });
        //test git
    }
}    

