using System;

class Program
{
    static void Main(string[] args)
    {
        // Order 1
        Address address1 = new Address("123 Queens Road", "Suva", "Central", "Fiji");
        Customer customer1 = new Customer("Mere Lutu", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Rugby Ball", "FJ001", 25.00, 2));
        order1.AddProduct(new Product("Jersey", "FJ002", 30.00, 1));

        // Order 2
        Address address2 = new Address("45 Nadi Back Road", "Nadi", "Western", "Fiji");
        Customer customer2 = new Customer("Jone Ravoka", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Hiking Boots", "FJ101", 70.00, 1));
        order2.AddProduct(new Product("Camping Tent", "FJ102", 150.00, 1));
        order2.AddProduct(new Product("Water Bottle", "FJ103", 10.00, 3));

        // Display Order 1
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():0.00}\n");

        // Display Order 2
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():0.00}");
    }
}