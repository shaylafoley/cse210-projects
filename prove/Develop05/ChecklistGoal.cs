using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace GoalProgram
{
public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus, int amountCompleted) :base (name, description, points)
    {
        _amountCompleted = amountCompleted;
        _target = target;
        _bonus = bonus;

    }
    public override void RecordEvent()
    {
       _amountCompleted++;
       _points += _points;
       Console.WriteLine($"Goal '{_shortname}' recorded! You gained {_points} points!");

        if (_amountCompleted == _target)
        {
            _points += _bonus;
            Console.WriteLine("****************************");
            Console.WriteLine($"Congratulations!  You've completed the goal '{_shortname}' and get the bonus points of {_bonus}!");
            Console.WriteLine($"You have {_points} points!");
            Console.WriteLine("*****************************");
        }
    }
    public override string IsComplete()
    {
        if (_amountCompleted == _target)
        {
            return $"[X] {_amountCompleted}/{_target}";
        }
        else 
        {
            return $"[ ] {_amountCompleted}/{_target}";
        }
    }
    public override string GetDetailsString()
    {
       string completionStatus = IsComplete(); 
       return $"{completionStatus} {_shortname} ({_description})";
    }
    public override string GetStringRepresentation()
    {
        string completionStatus = IsComplete();
       return $"{completionStatus}, {_shortname}, ({_description}, {_points}, {_bonus} )";
    }
}
}