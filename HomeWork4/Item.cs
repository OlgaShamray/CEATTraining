public class Item
{
    public string Product {get; set;}
    public int Quantity {get; set;}
    public decimal Price {get;}

    public Item (string product, int quantity, decimal price)
    {
        Product = product;
        Quantity = quantity;
        Price = price;
    }
}