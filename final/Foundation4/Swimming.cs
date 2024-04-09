public class Swimming : Activity
{
    private int _laps;
    public Swimming(string type, string date, int minutes, int laps)
    : base(type, date, minutes)
    {
        _laps = laps;
    }
    public override double GetDistance()
    {
        return _laps * 50 / 1000 * 0.62;
    }
    public override double GetSpeed()
    {
        double distance = GetDistance();
        return distance / _minutes * 60;
    }
    public override double GetPace()
    {
        double speed = GetSpeed();
        return 60 / speed;
    }
}