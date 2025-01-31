using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        // Create addresses
        var address1 = new Address("123 Main St", "Springfield", "IL", "USA");
        var address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");

        // Create customers
        var customer1 = new Customer("Jihn Toe", address1);
        var customer2 = new Customer("Qane Smyth", address2);

        // Create products
        var product1 = new Product("Laptop", "P001", 1000m, 1);
        var product2 = new Product("Mouse", "P002", 25m, 2);
        var product3 = new Product("Keyboard", "P003", 50m, 1);
        var product4 = new Product("Monitor", "P004", 200m, 1);

        // Create orders
        var order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        var order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        // Store orders in a list
        var orders = new List<Order> { order1, order2 };

        // Display order details
        foreach (var order in orders)
        {
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"Total Cost: ${order.GetTotalCost()}\n");
        }
    }
}
