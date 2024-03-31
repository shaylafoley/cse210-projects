using System.Collections;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime;
using System.Runtime.CompilerServices;

namespace GoalProgram
{
public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();

    private int _score = 0;

public void Start()
{
    int option;
    do
       {
        Console.WriteLine();
        Console.WriteLine("Menu Options:");
        Console.WriteLine("  1. Create New Goal");
        Console.WriteLine("  2. List Goals");
        Console.WriteLine("  3. Save Goals");
        Console.WriteLine("  4. Load Goals");
        Console.WriteLine("  5. Record Event");
        Console.WriteLine("  6. Display Total Points");
        Console.WriteLine("  7. Exit");
        Console.WriteLine();
        Console.WriteLine("Select a choice from the menu: ");

        if (int.TryParse(Console.ReadLine(), out option))

        switch (option)
        {
            case 1:
                CreateGoal();
                break;
            case 2:
                ListGoalDetails();
                break;
            case 3:
                SaveGoals();
                break;
            case 4:
                LoadGoals();
                break;
            case 5:
                RecordEvent();
                break;
            case 6:
                DisplayPlayerInfo();
                break;
            case 7:
                Console.WriteLine();
                Console.WriteLine("Exiting the program....");
                Thread.Sleep(2000);
                break;

            default:
                Console.WriteLine("Invalid Option:");
                break;
        }
        else
        {
            Console.WriteLine("Invalid choice!");
        }

       } while (option != 7);
        
}
public void DisplayPlayerInfo()
{
    
    Console.WriteLine($"You have {_score} points.");
}

public void ListGoalNames()
{
    Console.WriteLine("Goal Names:");
    int count = 1;
    Console.WriteLine();
    foreach (var goal in _goals)
    {
        Console.WriteLine($"{count}. {goal}");
        count ++;
    }
}
public void ListGoalDetails()
{
   //List the details of each goal, including the checkbox
    Console.WriteLine("Your Goals:");
    Console.WriteLine();
    foreach (var goal in _goals)
    {
        Console.WriteLine(goal.GetDetailsString());
    }
    
}
public void CreateGoal()
{
    Console.WriteLine();
    Console.WriteLine("The Types of Goals are: ");
    Console.WriteLine("  1. Simple Goal");
    Console.WriteLine("  2. Eternal Goal");
    Console.WriteLine("  3. Checklist Goal");
    Console.WriteLine();
    Console.WriteLine("Which type of goal would you like to create? ");
   
    string option = Console.ReadLine();
    
    Goal goal;
    switch (option)
    {
        case "1":
        Console.WriteLine();
        Console.WriteLine("What is the name of your goal?");
        string nameS = Console.ReadLine();
        Console.WriteLine("What is a short description of your goal? ");
        string descriptionS = Console.ReadLine();
        Console.WriteLine("What is the amount of points associated with this goal? ");
        int pointsS;
        int.TryParse(Console.ReadLine(), out pointsS);
        goal = new SimpleGoal(nameS, descriptionS, pointsS);
        break;

        case "2":
        Console.WriteLine();
        Console.WriteLine("What is the name of your goal?");
        string nameE = Console.ReadLine();
        Console.WriteLine("What is a short description of your goal? ");
        string descriptionE = Console.ReadLine();
        Console.WriteLine("What is the amount of points associated with this goal? ");
        int pointsE;
        int.TryParse(Console.ReadLine(), out pointsE);
        goal = new EternalGoal(nameE, descriptionE, pointsE);
        break;

        case "3":
        Console.WriteLine();
        Console.WriteLine("What is the name of your goal?");
        string nameC = Console.ReadLine();
        Console.WriteLine("What is a short description of your goal? ");
        string descriptionC = Console.ReadLine();
        Console.WriteLine("What is the amount of points associated with this goal? ");
        int pointsC;
        int.TryParse(Console.ReadLine(), out pointsC);
        Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
        int targetC;
        int.TryParse(Console.ReadLine(), out targetC);
        Console.WriteLine("What is the bonus for accomplishing it that many times? ");
        int bonusC;
        int.TryParse(Console.ReadLine(), out bonusC);
        goal = new ChecklistGoal(nameC, descriptionC, pointsC, targetC, bonusC, 0);
        break;
        default:
            Console.WriteLine("Invalid option");
        return;
    
    } 
    _goals.Add(goal);
}
public void RecordEvent()

{
    ListGoalNames();
    Console.WriteLine();
    Console.WriteLine("Which goal did you accomplish?");
    int goalNumber;
    int.TryParse(Console.ReadLine(), out goalNumber);
    if (goalNumber >= 1 && goalNumber -1 <= _goals.Count)
    {
        Goal goal = _goals[goalNumber - 1];
        goal.RecordEvent();
        _score += goal.Points;
        Console.WriteLine("Way to go!");
    }
    //asks the user which goal they have done and then
    //records the event by calling the RecordEvent method
    //on that goal
}
public void SaveGoals()

{ 
    Console.WriteLine();
    Console.Write("Enter the file you want this saved to: "); 
    string fileName = Console.ReadLine();
   
    using (StreamWriter outputFile = new StreamWriter(fileName)) 

   {
     foreach (Goal goal in _goals)
     {
        outputFile.WriteLine(goal.GetStringRepresentation());

     }
    }
    Console.WriteLine("Goals saved Successfully.");
}
public void LoadGoals()
{
    Console.Write("Enter the file you want to load goals from: ");
    string fileName = Console.ReadLine();


        using (StreamReader inputFile = new StreamReader(fileName))
        {
            string line;
            while ((line = inputFile.ReadLine()) != null)
            {
                Goal goal = CreatePerson(line);
                if (goal != null)
                {
                    _goals.Add(goal);
                }
            }
        }
        Console.WriteLine("Goals Loaded.");
}
//}
//}

private Goal CreatePerson(string line)
{
    string[] parts = line.Split(',');
    if (parts.Length >= 3)
    {
        string goalType = parts[0];
        string name = parts[1];
        string description = parts[2];
        int points = int.Parse(parts[3]);

        switch (goalType)
        {
            case "Simple Goal":
                return new SimpleGoal(name, description, points);
            case "Eternal Goal":
                return new EternalGoal(name, description, points);
            case "Checklist Goal":
                int target = int.Parse(parts[4]);
                int bonus = int.Parse(parts[5]);
                return new ChecklistGoal(name, description, points,  target, bonus, 0);
            default:
                Console.WriteLine("Unknown.");
                return null;
        }
    }
    else
    {
        Console.WriteLine("Invalid");
        return null;
     }
}
}
}