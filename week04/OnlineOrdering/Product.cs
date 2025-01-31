public class Product
{
    private string name;
    private string productId;
    private decimal price;
    private int quantity;

    public Product(string name, string productId, decimal price, int quantity)
    {
        this.name = name;
        this.productId = productId;
        this.price = price;
        this.quantity = quantity;
    }

    public string Name { get => name; }
    public string ProductId { get => productId; }
    public decimal Price { get => price; }
    public int Quantity { get => quantity; }

    public decimal GetTotalCost()
    {
        return price * quantity;
    }
}
