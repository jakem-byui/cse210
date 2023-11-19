class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _completedCount;

    public ChecklistGoal(string name, int points, int targetCount, int completedCount) : base(name)
    {
        _points = points;
        _targetCount = targetCount;
        _completedCount = completedCount;
    }

    public override void RecordEvent()
    {
        _completedCount++;
        Console.WriteLine($"\n{_name} completed! You gained {_points} points.");

        if (_completedCount == _targetCount)
        {
            _points += 500; // Bonus points for completing the checklist
            Console.WriteLine($"Bonus! Goal {_name} completed {_completedCount}/{_targetCount} times. You gained an additional 500 points.");
        }
    }

    public override void DisplayProgress()
    {
        Console.WriteLine($"[{_completedCount}/{_targetCount}] {_name}");
    }

    public int TargetCount
    {
        get { return _targetCount; }
    }

    public int CompletedCount
    {
        get { return _completedCount; }
    }
}