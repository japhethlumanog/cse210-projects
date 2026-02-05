using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main street", "Los Angeles", "CA", "USA");

        Customer  customer1 = new Customer("John Smith", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "P1001", 1200,1));
        order1.AddProduct(new Product("Mouse", "P1002", 25,2));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalCost()}\n");

        Address address2 = new Address("456 Rizal Ave", "Manila", "NCR", "Philippines");

        Customer customer2 = new Customer("Maria Santos", address2);
        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("Headphones", "P2001", 80, 1));
        order2.AddProduct(new Product("Power Bank", "P2002", 40, 2));
        order2.AddProduct(new Product("USB Cable", "P2003", 10, 3));

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalCost()}");
    }
}