class EternalGoal : Goal
{
    public EternalGoal(string name, int pointsPerEvent) : base(name)
    {
        this.points = pointsPerEvent;
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"{name} recorded! You gained {points} points.");
    }

    public override void DisplayProgress()
    {
        Console.WriteLine($"[{(points > 0 ? 'X' : ' ')}] {name}");
    }
}
