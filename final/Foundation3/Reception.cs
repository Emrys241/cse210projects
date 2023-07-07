using System;

class Reception : Event
{
    private string _email;
    private bool _rsvp;
    private bool _register;

    public Reception(string eventTitle, string description, string date, string time, string address,
                     string email, bool rsvp, bool register)
        : base(eventTitle, description, date, time, address)
    {
        _email = email;
        _rsvp = rsvp;
        _register = register;
    }

    public override void DisplayDetailedMsg()
    {
        base.DisplayDetailedMsg();
        Console.WriteLine("Send your RSVP to " + _email);
    }

    public string GetEmail()
    {
        return _email;
    }

    public void SetEmail(string email)
    {
        _email = email;
    }

    public bool GetRSVP()
    {
        return _rsvp;
    }

    public void SetRSVP(bool rsvp)
    {
        _rsvp = rsvp;
    }

    public bool GetRegister()
    {
        return _register;
    }

    public void SetRegister(bool register)
    {
        _register = register;
    }
}
