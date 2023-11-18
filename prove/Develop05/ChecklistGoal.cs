class ChecklistGoal : Goal
{
    private int targetCount;
    private int completedCount;

    public ChecklistGoal(string name, int pointsPerEvent, int targetCount) : base(name)
    {
        this.points = pointsPerEvent;
        this.targetCount = targetCount;
        completedCount = 0;
    }

    public override void RecordEvent()
    {
        completedCount++;
        Console.WriteLine($"{name} completed! You gained {points} points.");

        if (completedCount == targetCount)
        {
            points += 500; // Bonus points for completing the checklist
            Console.WriteLine($"Bonus! Goal {name} completed {completedCount}/{targetCount} times. You gained an additional 500 points.");
        }
    }

    public override void DisplayProgress()
    {
        Console.WriteLine($"[{completedCount}/{targetCount}] {name}");
    }
}
