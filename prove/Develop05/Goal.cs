using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;

namespace GoalProgram
{
public abstract class Goal
{
    protected string _shortname;
    protected string _description;
    protected int _points;
    
    public Goal (string name, string description, int points)
    {
        _shortname = name;
        _description = description;
        _points = points;
    }
    public abstract void RecordEvent();
    public abstract string IsComplete();
    public virtual string GetDetailsString()
    {
        string completionStatus = IsComplete();
        return $"{completionStatus} {_shortname} ({_description})";
    }
    public virtual string GetStringRepresentation()
    {
        string completionStatus = IsComplete();
        return $"{completionStatus}, {_shortname}, {_description}, {_points}";   
    }

}
}