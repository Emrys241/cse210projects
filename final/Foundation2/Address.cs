using System;

class Address
{
    private bool _inUS;
    private string _streetAddress;
    private string _city;
    private string _stateProvince;
    private string _country;

    public Address(bool inUS, string streetAddress, string city, string stateProvince, string country)
    {
        _inUS = inUS;
        _streetAddress = streetAddress;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }

    public bool IsUS()
    {
        return _inUS;
    }

    public string DisplayCompleteAddress()
    {
        return $"{_streetAddress}\n{_city}, {_stateProvince}\n{_country}";
    }

    public string GetStreet()
    {
        return _streetAddress;
    }

    public void SetStreet(string streetAddress)
    {
        _streetAddress = streetAddress;
    }

    public string GetCity()
    {
        return _city;
    }

    public void SetCity(string city)
    {
        _city = city;
    }

    public string GetState()
{
    return _stateProvince;
}


    public void SetState(string stateProvince)
    {
        _stateProvince = stateProvince;
    }

    public string GetCountry()
    {
        return _country;
    }

    public void SetCountry(string country)
    {
        _country = country;
    }
}
