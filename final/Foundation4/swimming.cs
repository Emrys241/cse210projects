public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, double length, int laps) : base(date, length)
    {
        _laps = laps;
    }

    public override double CalculateDistance()
    {
        return _laps * _length;
    }

    public override double CalculateSpeed()
    {
        return (_laps * _length) / _length;
    }

    public override double CalculatePace()
    {
        return _length / (_laps * _length);
    }
}
