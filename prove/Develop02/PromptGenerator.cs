public class PromptGenerator
{
    public List<string> prompts;

    public PromptGenerator()
    {
        prompts = new List<string>
        {
            "Who was the most interesting person I interacted with?",
            "What was the best part of my day?",
            "How did I see the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "How did I show someone I loved them today?"
        };
    }
    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(0, prompts.Count);
        return prompts[index];
    }
}