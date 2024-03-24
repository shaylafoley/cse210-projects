


public class ListingActivity : Activity
{
    private string _random;
    List<string> _prompts = new List<string>();

    public ListingActivity(string name, string description, string duration)
     : base(name, description, duration)
    {
       
    }
    public void Run()
    {
        DisplayStartingMessage("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        ShowSpinner();
        
        _random = GetRandomPrompt();
        Console.WriteLine(_random);
        Console.WriteLine("Think for a few seconds, then write your list: ");
        ShowCountDown(10);
        string _count = GetListFromUser();
        Console.WriteLine(_count);
        ShowSpinner();

        DisplayEndingMessage(_duration, "Listing Name");
    }
    public string GetRandomPrompt()
    {
        List<string> prompt = new List<string>();
        prompt.Add("Who are people that you appreciate?");
        prompt.Add("What are personal strengths of yours?");
        prompt.Add("Who are people that you have helped this week?");
        prompt.Add("When have you felt the Holy Ghost this month?");
        prompt.Add("Who are some of your personal heroes?");

        Random random = new Random();
        int randomIndex = random.Next(prompt.Count);
        return prompt[randomIndex];
    }
    public string GetListFromUser()
    {
        Console.WriteLine("Start listing items: ");
        DateTime startTime = DateTime.Now;

        DateTime endTime = startTime.AddSeconds(int.Parse(_duration));

        List<string> itemsListed = new List<string>();
        
        while (DateTime.Now < endTime)
        {
            string item = Console.ReadLine();
            if (!string.IsNullOrEmpty(item))
            {
             itemsListed.Add(item);
            }
            else
            {
                break;
            }
        }
        return $"You listed {itemsListed.Count} items.";

    }
}