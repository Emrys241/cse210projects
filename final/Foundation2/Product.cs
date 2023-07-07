using System;

class Product
{
    private string _name;
    private int _productId;
    private double _price;
    private int _quantity;

    public Product(string name, int productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public double ProductPrice()
    {
        return _price * _quantity;
    }

    public string GetProductName()
    {
        return _name;
    }

    public void SetProductName(string name)
    {
        _name = name;
    }

    public int GetProductID()
    {
        return _productId;
    }

    public void SetProductID(int productId)
    {
        _productId = productId;
    }

    public double GetPrice()
    {
        return _price;
    }

    public void SetPrice(double price)
    {
        _price = price;
    }

    public int GetQuantity()
    {
        return _quantity;
    }

    public void SetQuantity(int quantity)
    {
        _quantity = quantity;
    }
}
