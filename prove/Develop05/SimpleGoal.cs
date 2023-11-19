class SimpleGoal : Goal
{
    private bool _completed;

    public SimpleGoal(string name, string description, int points) : base(name)
    {
        _completed = false;
        _description = description;
        _points = points;
    }

    public override void RecordEvent()
    {
        _completed = true;
        Console.WriteLine($"\n{_name} completed! You gained {_points} points.");
        Console.WriteLine($"Here's how you defined your goal: {_description}");
    }

    public override void DisplayProgress()
    {
        Console.WriteLine($"[{(_completed ? 'X' : ' ')}] {Description}");
    }
}