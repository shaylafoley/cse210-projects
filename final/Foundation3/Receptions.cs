public class Receptions : Event
{
    private string _email;
    public Receptions(string eventName, string title, string description, string date, string time, Address address, string email)
    : base(eventName, title, description, date, time, address)
    {
        _email = email;
    }
    public string GetEmail()
    {
        return _email;
    }
    public void DisplayFullDetailEvent()
    {
        Console.WriteLine($"The email on file is {_email} for the RSVP.");
    }
}