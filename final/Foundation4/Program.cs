using System;

class Program
{
    static void Main(string[] args)
    {

        List<Activity> _activity = new List<Activity>();

        Running running1 = new Running("Running", "4/5/2024", 40, 4);
        _activity.Add(running1);

        Cycling cycling1 = new Cycling("Cycling", "6/12/2023", 60, 8);
        _activity.Add(cycling1);

        Swimming swimmin1 = new Swimming("Swimming", "9/22/2024", 30, 20);
        _activity.Add(swimmin1);

        foreach (Activity activtiy in _activity)
        {
            activtiy.GetSummary();
        }


    }
}