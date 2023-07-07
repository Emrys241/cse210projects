using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation2 World!");

        // Create a customer
        Customer customer = new Customer("Bernard Amegah", true);

        // Create an address
        Address address = new Address(true, "123 Main St", "New York", "NY", "USA");

        // Create an order
        Order order = new Order(customer);

        // Add products to the order
        Product product1 = new Product("Product 1", 1, 10.99, 2);
        Product product2 = new Product("Product 2", 2, 5.99, 3);

        order.AddProduct(product1);
        order.AddProduct(product2);

        // Display the total cost of the order
        double total = order.GetTotal();
        Console.WriteLine($"Total Cost: ${total}");

        // Display the packing label
        string packingLabel = order.DisplayPackingLb();
        Console.WriteLine($"Packing Label: {packingLabel}");

        // Display the shipping label
        string shippingLabel = order.DisplayShippingLb();
        Console.WriteLine($"Shipping Label: {shippingLabel}");

        // Update customer's name
        customer.SetName("Bernard Amegah");
        Console.WriteLine($"Customer Name: {customer.GetName()}");

        // Update address details
        address.SetStreet("456 Elm St");
        address.SetCity("Los Angeles");
        address.SetState("CA");
        address.SetCountry("USA");

        // Display complete address
        string completeAddress = address.DisplayCompleteAddress();
        Console.WriteLine($"Complete Address: {completeAddress}");
    }
}
