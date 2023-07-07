public class Cycling : Activity
{
    private double _speed;

    public Cycling(string date, double length, double speed) : base(date, length)
    {
        _speed = speed;
    }

    public override double CalculateDistance()
    {
        return _speed * _length;
    }

    public override double CalculateSpeed()
    {
        return _speed;
    }

    public override double CalculatePace()
    {
        return 1 / _speed;
    }
}
