using System;

class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product("Notebooks", 43592, 15, 25);
        Product product2 = new Product("Pencils", 83478, 10, 25);
        Product product3 = new Product("Erasers", 33455, 3, 10);
        Product product4 = new Product("Table", 63894, 1000, 1);
        Product product5 = new Product("Chairs", 04859, 60, 8);

        Address address1 = new Address("8454 Holcomb Dr", "Taylorsville", "UT", "USA");
        Address address2 = new Address("67 Popper St.", "Ottowa", "Ontario", "CANADA");

        Customer customer1 = new Customer("Jane Doe", address1);
        Customer customer2 = new Customer("Tyler Molvery", address2);

        Order order1 = new Order(customer1);
        order1.AddProduct(product5);
        order1.AddProduct(product4);

        Order order2 = new Order(customer2);
        order2.AddProduct(product1);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        Console.WriteLine();
        Console.WriteLine("Order 1");
        Console.WriteLine("Packing Label");
        Console.WriteLine();
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Shipping Label");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine("Total Cost:");
        Console.WriteLine($"${order1.TotalPrice()}");
        Console.WriteLine();

        Console.WriteLine();
        Console.WriteLine("Order 2");
        Console.WriteLine("Packing Label");
        Console.WriteLine();
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Shipping Label");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine("Total Cost:");
        Console.WriteLine($"${order2.TotalPrice()}");
        Console.WriteLine();






    }
}