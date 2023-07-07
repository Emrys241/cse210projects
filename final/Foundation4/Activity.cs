using System;

public abstract class Activity
{
    protected string _date;
    protected double _length;

    public Activity(string date, double length)
    {
        _date = date;
        _length = length;
    }

    public abstract double CalculateDistance();
    public abstract double CalculateSpeed();
    public abstract double CalculatePace();
}
