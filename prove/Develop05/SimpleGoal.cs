namespace GoalProgram{
public class SimpleGoal : Goal
{
    private bool _isComplete;

public SimpleGoal(string name, string description, string points, bool isComplete) : base(name, description, points)
{
    _isComplete = isComplete;
}
    public override void RecordEvent()
    {
     
    }
    public override bool IsComplete()
    {
        return false;
    }
    public override string GetStringRepresentation()
    {
        return $"{_description}";
    }
}
}
