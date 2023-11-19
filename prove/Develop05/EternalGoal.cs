class EternalGoal : Goal
{
    public EternalGoal(string name, int points, string description) : base(name)
    {
        _points = points;
        _description = description;
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"\n{_name} recorded! You gained {_points} points.");
        Console.WriteLine($"Here's how you defined your goal: {_description}");
        
    }

    public override void DisplayProgress()
    {
        Console.WriteLine($"[{(_points > 0 ? ' ' : 'X')}] {_name}");
    }
}
