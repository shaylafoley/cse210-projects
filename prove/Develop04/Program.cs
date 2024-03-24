using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

//Some extra things:  wrote a default in case entering wrong numbers
//put in some extra spinners
//Let the person have more guidance in the activities as to what was going to happen

class Program
{
    static void Main(string[] args)
    {
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to the Emotional Resilience Program!");
            Thread.Sleep(2000);
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start Breathing Activity");
            Console.WriteLine("  2. Start Reflecting Activity");
            Console.WriteLine("  3. Start Listening Activity");
            Console.WriteLine("  4. Exit");
            Console.WriteLine("Select a Choice from the Menu: ");

            string option = Console.ReadLine();
        
        switch(option)

        {
            case "1":

                BreathingActivity breath = new BreathingActivity("Breathing", "A Relaxing Activity","5" );
                breath.Run();
                break;
            case "2":
                ReflectingActivity reflect = new ReflectingActivity("Refelcting Activity", "Time to Reflect", "5");
                reflect.Run();
                break;
            case "3":
                ListingActivity list = new ListingActivity("Listing Activity", "Thinking with a List", "5");
                list.Run();
                break;
            case "4":
                exit = true;
                break;
            default:
                Console.WriteLine("Invalid Option.");
                break;

        }
        }
        Console.WriteLine("Thank you for participating!  Hope you feel relaxed and rejuvinated!");
        Thread.Sleep(2000);
        Console.WriteLine("Exiting Program....");
    }
}