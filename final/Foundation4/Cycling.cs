public class Cycling : Activity
{
    private int _speed;
    public Cycling(string type, string date, int minutes, int speed)
    : base(type, date, minutes)
    {
        _speed = speed;
    }

    public override double GetSpeed()
    {
        return _speed;
    }
    public override double GetDistance()
    {
        return _speed * _minutes;
    }
    public override double GetPace()
    {
        return 60 / _speed;
    }
    
}