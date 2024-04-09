public class Running : Activity
{
    private int _distance;

    public Running(string type, string date, int minutes, int distance)
    : base(type, date, minutes)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetPace()
    {
        return _minutes / _distance;
    }
    public override double GetSpeed()
    {
        double pace = GetPace();
        return 60 / pace;
    }
    
}