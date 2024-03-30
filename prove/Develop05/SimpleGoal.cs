namespace GoalProgram{
public class SimpleGoal : Goal
{

public SimpleGoal(string name, string description, int points) : base(name, description, points)
{
    
}
    public override void RecordEvent()
    {
     _points += _points;
     Console.WriteLine($"Goal {_shortname} recorded!  You gained {_points} points!");
    }
    public override string IsComplete()
    {
        return "[X]";
    }
    public override string GetStringRepresentation()
    {
        string completionStatus = IsComplete();
        return $"{completionStatus},{_shortname},{_description},{_points}";
    }
}
}
