using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, string duration)
     : base(name, description, duration)
    {
    
    }
    public void Run()
    {
        DisplayStartingMessage("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly.  Clear your mind and focus on your breathing.");

        for (int i = 0; i < int.Parse(_duration)/8; i++)
        {
            Console.WriteLine($"Breath in...");
            //ShowSpinner();
            ShowCountDown(4);
            Console.WriteLine("Breath out...");
            //ShowSpinner();
            ShowCountDown(4);
        }

        DisplayEndingMessage(_duration, "Breathing Activity");
    }
} 