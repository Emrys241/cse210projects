using System;

class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string eventTitle, string description, string date, string time, string address,
                   string speaker, int capacity)
        : base(eventTitle, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public override void DisplayDetailedMsg()
    {
        base.DisplayDetailedMsg();
        Console.WriteLine("Speaker: " + _speaker);
        Console.WriteLine("Capacity: " + _capacity);
    }

    public string GetSpeaker()
    {
        return _speaker;
    }

    public void SetSpeaker(string speaker)
    {
        _speaker = speaker;
    }

    public int GetCapacity()
    {
        return _capacity;
    }

    public void SetCapacity(int capacity)
    {
        _capacity = capacity;
    }
}
