public class SimpleGoal : Goal
{
    private bool _isComplete;

    class SimpleGoal (string shortname, string description, string points, bool isComplete) 
    : base(name, description, points)
    {
        _isComplete = isComplete;
    }
}
