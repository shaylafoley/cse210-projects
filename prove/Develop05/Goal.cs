public class Goal
{
    protected string _shortname;
    protected string _description;
    protected string _points;
    public Goal (string shortname, string description, string points)
    {
        _shortname = shortname;
        _description = description;
        _points = points;
    }
    public virtual void RecordEvent()
    {

    }
    public virtual bool IsComplete()
    {

    }
    public virtual string GetDetailsString()
    {
        
    }
    public virtual string GetStringRepresentation()
    {

    }

}