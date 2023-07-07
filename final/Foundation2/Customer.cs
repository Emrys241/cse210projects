using System;

class Customer
{
    private string _name;
    private bool _inUS;

    public Customer(string name, bool inUS)
    {
        _name = name;
        _inUS = inUS;
    }

    public void DetermineLocation()
    {
        // Determine customer's location based on _inUS attribute
    }

    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }
}
