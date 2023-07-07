using System;

class Event
{
    protected string _eventTitle;
    protected string _description;
    protected string _date;
    protected string _time;
    protected string _address;

    public Event(string eventTitle, string description, string date, string time, string address)
    {
        _eventTitle = eventTitle;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public virtual void DisplayStandardMsg()
    {
        Console.WriteLine("Event: " + _eventTitle);
        Console.WriteLine("Date: " + _date);
        Console.WriteLine("Time: " + _time);
    }

    public virtual void DisplayDetailedMsg()
    {
        Console.WriteLine("Event: " + _eventTitle);
        Console.WriteLine("Description: " + _description);
        Console.WriteLine("Date: " + _date);
        Console.WriteLine("Time: " + _time);
        Console.WriteLine("Address: " + _address);
    }

    public string GetTitle()
    {
        return _eventTitle;
    }

    public void SetTitle(string eventTitle)
    {
        _eventTitle = eventTitle;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public string GetDate()
    {
        return _date;
    }

    public void SetDate(string date)
    {
        _date = date;
    }

    public string GetTime()
    {
        return _time;
    }

    public void SetTime(string time)
    {
        _time = time;
    }

    public string GetAddress()
    {
        return _address;
    }

    public void SetAddress(string address)
    {
        _address = address;
    }
}
