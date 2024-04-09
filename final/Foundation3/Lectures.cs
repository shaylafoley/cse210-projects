public class Lectures : Event
{
    private string _speaker;
    private int _capacity;
    public Lectures(string eventName, string title, string description, string date, string time, Address address, string speaker, int capacity)
    : base(eventName, title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }
    public string GetSpeaker()
    {
        return _speaker;
    }
    public int GetCapacity()
    {
        return _capacity;
    }
    public void DisplayFullDetailEvent()
    {
        Console.WriteLine($"Your speaker is {_speaker}. \n The Event capacity is {_capacity}");
    }
}