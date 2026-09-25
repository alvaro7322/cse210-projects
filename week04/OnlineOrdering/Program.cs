using System;
 
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
 
        Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");
        Customer customer1 = new Customer("Alice Johnson", address1);
 
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Wireless Mouse", "P001", 25.50, 2));
        order1.AddProduct(new Product("Keyboard", "P002", 45.00, 1));
        order1.AddProduct(new Product("USB Cable", "P003", 8.75, 3));
 
        Address address2 = new Address("45 King Street", "Toronto", "Ontario", "Canada");
        Customer customer2 = new Customer("Michael Smith", address2);
 
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Desk Lamp", "P004", 30.00, 1));
        order2.AddProduct(new Product("Notebook", "P005", 3.25, 5));
 
        Console.WriteLine("Order 1");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Total Cost: $" + order1.GetTotalCost());
        Console.WriteLine();
 
        Console.WriteLine("Order 2");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Total Cost: $" + order2.GetTotalCost());
    }
}