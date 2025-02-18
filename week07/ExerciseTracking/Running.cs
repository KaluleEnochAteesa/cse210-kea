public class Running : Activity
{
    private double _distance;

    public Running(DateTime date, int lengthInMinutes, double distance)
        : base(date, lengthInMinutes)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (_distance / _lengthInMinutes) * 60;
    }

    public override double GetPace()
    {
        return _lengthInMinutes / _distance;
    }
}
