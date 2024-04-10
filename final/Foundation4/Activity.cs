public class Activity
{
    protected string _type;
    protected string _date;
    protected int _minutes;

    public Activity(string type, string date, int minutes)
    {
        _type = type;
        _date = date;
        _minutes = minutes;
    }


    public virtual double GetDistance()
    {
        return 0;
    }
    public virtual double GetSpeed()
    {
        return 0;
    }
    public virtual double GetPace()
    {
        return 0;
    }
    public virtual void GetSummary()
    {
        Console.WriteLine();
        Console.WriteLine($"{_date} {_type} ({_minutes} min)- Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace: {GetPace().ToString("0.00")} min per mile");
        Console.WriteLine();
    }
}