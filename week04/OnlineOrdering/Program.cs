using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("456 Main St", "Fort Collins", "Colorado", "USA");
        Customer customer1 = new Customer("John Doe", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("PC", "P01", 1000, 1));
        order1.AddProduct(new Product("Keyboard", "P02", 35, 5));

        Address address2 = new Address("234 Coyote Ave", "Versailles", "Paris", "France");
        Customer customer2 = new Customer("Maria Silva", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Mouse", "P03", 50, 1));
        order2.AddProduct(new Product("Monitor", "P04", 300, 1));

        Console.WriteLine("ORDER 1:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalCost()}");

        Console.WriteLine("\nORDER 2:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalCost()}");
    }
}