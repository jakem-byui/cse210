class SimpleGoal : Goal
{
    public SimpleGoal(string name, int points) : base(name)
    {
        this.points = points;
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"{name} completed! You gained {points} points.");
    }

    public override void DisplayProgress()
    {
        Console.WriteLine($"[{(points > 0 ? 'X' : ' ')}] {name}");
    }
}
