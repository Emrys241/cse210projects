using System;

class OutdoorGathering : Event
{
    private string _weather;

    public OutdoorGathering(string eventTitle, string description, string date, string time, string address,
                            string weather)
        : base(eventTitle, description, date, time, address)
    {
        _weather = weather;
    }

    public override void DisplayDetailedMsg()
    {
        base.DisplayDetailedMsg();
        Console.WriteLine("Weather: " + _weather);
    }

    public string GetWeather()
    {
        return _weather;
    }

    public void SetWeather(string weather)
    {
        _weather = weather;
    }
}
