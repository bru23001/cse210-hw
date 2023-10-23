using System;

class Program
{
    static void Main(string[] args)
    {
        // Create some orders and products
        Customer customer1 = new Customer("John Doe", new Address("123 Main St", "SomeCity", "CA", "USA"));
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", 101, 1000, 1));
        order1.AddProduct(new Product("Mouse", 102, 20, 2));

        Customer customer2 = new Customer("Jane Smith", new Address("456 Elm St", "AnotherCity", "ON", "Canada"));
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Keyboard", 103, 50, 1));
        order2.AddProduct(new Product("Monitor", 104, 200, 1));

        // Display order details
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice()}\n");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice()}");
    }
}