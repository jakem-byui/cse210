abstract class Goal
{
    protected string name;
    protected int points;

    public Goal(string name)
    {
        this.name = name;
        points = 0;
    }

    public string Name
    {
        get { return name; }
    }

    public int Points
    {
        get { return points; }
    }

    public abstract void RecordEvent();
    public abstract void DisplayProgress();
}
