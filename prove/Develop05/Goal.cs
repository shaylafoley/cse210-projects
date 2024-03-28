using System.Diagnostics.Tracing;

namespace GoalProgram{
public abstract class Goal
{
    protected string _shortname;
    protected string _description;
    protected string _points;
    public Goal (string name, string description, string points)
    {
        _shortname = name;
        _description = description;
        _points = points;
    }
    public virtual void RecordEvent()
    {

    }
    public abstract bool IsComplete();
    public virtual string GetDetailsString()
    {
        return $"{_shortname}";
    }
    public virtual string GetStringRepresentation()
    {
     return $"{_description}";   
    }

}
}