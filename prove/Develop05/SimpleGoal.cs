namespace GoalProgram{
public class SimpleGoal : Goal
{
    private bool _isCompleted;

public SimpleGoal(string name, string description, int points) : base(name, description, points)
{
    _isCompleted = false;
}
    public override void RecordEvent()
    {
        
     _isCompleted = true;
     _points += _points;
     Console.WriteLine($"Goal {_shortname} recorded!  You gained {_points} points!");
    }
    public override string IsComplete()
    {
        if (_isCompleted)
        
        {
            return "[X]";
        }
        else
        {
            return "[ ]";
        }
    }
    public override string GetStringRepresentation()
    {
        string completionStatus = IsComplete();
        return $"{completionStatus},{_shortname},{_description},{_points}";
    }
}
}
