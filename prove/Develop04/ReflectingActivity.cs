using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity(string name, string description, string duration)
     : base(name, description, duration)
    {

    }
    public void Run()
    
    {
        DisplayStartingMessage("Refelcting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");

        for (int i = 0; i < int.Parse(_duration)/8; i++)
        {
            string _random = GetRandomPrompt();
            Console.WriteLine(_random);
            ShowSpinner();
            Thread.Sleep(4000);
            string _question = GetRandomQuestion();
            Console.WriteLine(_question);
            ShowSpinner();
            Thread.Sleep(4000);
        }
        DisplayEndingMessage(_duration, "Reflecting Activity");
    }
    public string GetRandomPrompt()
    {
        List<string> prompts = new List<string>();
        prompts.Add("Think of a time when you stood up for someone else.");
        prompts.Add("Think of a time when you did something really difficult.");
        prompts.Add("Think of a time when you helped someone in need.");
        prompts.Add("Think of a time when you did something truly selfless.");

        Random random = new Random();
        int randomIndex = random.Next(prompts.Count);

        return prompts[randomIndex];
    }
    public string GetRandomQuestion()
    {
        List<string> questions = new List<string>();
        questions.Add("Why was this experience meaningful to you?");
        questions.Add("Have you ever done anything like this before?");
        questions.Add("How did you get started?");
        questions.Add("How did you feel when it was complete?");
        questions.Add("What made this time different than other times when you were not as successful?");
        questions.Add("What is your favorite thing about this experience?");
        questions.Add("What could you learn from this experience that applies to other situations?");
        questions.Add("What did you learn about yourself through this experience?");
        questions.Add("How can you keep this experience in mind in the future?");

        Random random = new Random();
        int randomIndex = random.Next(questions.Count);
        return questions[randomIndex];

        
    }
    public void DisplayPrompt()
    {

    }
    public void DisplayQuestions()
    {

    }
}