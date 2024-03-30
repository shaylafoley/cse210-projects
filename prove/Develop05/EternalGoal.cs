using System.ComponentModel;

namespace GoalProgram{
public class EternalGoal : Goal
{
public EternalGoal(string name, string description, int points) :base (name, description, points)
{

}
    public override void RecordEvent()
    {
        _points += _points;
        Console.WriteLine($"Goal {_shortname} recorded!  You gained {_points}.");
    }
    public override string IsComplete()
    {
        return $"[ ]";
    }
    public override string GetStringRepresentation()
    {
        string completionStatus = IsComplete();
       return $"{completionStatus}, {_shortname}, {_description}, {_points}";
    }
}
}