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
        Console.WriteLine($"Here is your summary for {_type}:");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Minutes: {_minutes}");
        Console.WriteLine($"Distance: {GetDistance()}");
        Console.WriteLine($"Pace: {GetPace()}");
        Console.WriteLine($"Speed: {GetSpeed()}");
    }
}