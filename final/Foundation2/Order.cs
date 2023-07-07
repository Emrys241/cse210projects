using System;
using System.Collections.Generic;

class Order
{
    private Customer _customer;
    private List<Product> _products;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetTotal()
    {
        double total = 0;
        foreach (Product product in _products)
        {
            total += product.ProductPrice();
        }
        return total;
    }

    public string DisplayPackingLb()
    {
        // Generate and return packing label
        return "Packing Label";
    }

    public string DisplayShippingLb()
    {
        // Generate and return shipping label
        return "Shipping Label";
    }
}

