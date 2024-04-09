using System.ComponentModel.Design;

public class Event
{
    private string _eventName;
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    public Event(string eventName, string title, string description, string date, string time, Address address)
    {
        _eventName = eventName;
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }
    public void GetStandardDetails()
    {
        Console.WriteLine($"Your Event title is: {_title}");
        Console.WriteLine($"Here are the details: {_description}.");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Time: {_time}");
        Console.WriteLine($"Address: \n{_address.ReturnAddress()}");

    }
    
    public void GetShortDescription()
    {
        Console.WriteLine($"Your event is: {_eventName}.");
        Console.WriteLine($"The Title is {_title}.");
        Console.WriteLine($"Date: {_date}.");
    }

}