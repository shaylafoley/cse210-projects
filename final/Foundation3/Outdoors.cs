using System.ComponentModel.DataAnnotations;
using System.Reflection;

public class Outdoors : Event
{
    private string _weather;

    public Outdoors (string eventName, string title, string description, string date, string time, Address address, string weather)
     : base (eventName, title, description, date, time, address)
    {
        _weather = weather;
    }
    public string SetWeather()
    {
        return _weather;
    }
    public void DisplayFullDetailEvent()
    {
        Console.WriteLine($"Your current weather is {_weather}.");
    }
}
