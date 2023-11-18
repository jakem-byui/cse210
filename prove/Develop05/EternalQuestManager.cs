// using System.Text.Json;

class EternalQuestManager
{
    private List<Goal> goals;
    private int totalScore;

    public EternalQuestManager()
    {
        goals = new List<Goal>();
        totalScore = 0;
    }

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public void RecordEvent(int goalIndex)
    {
        if (goalIndex >= 0 && goalIndex < goals.Count)
        {
            goals[goalIndex].RecordEvent();
            totalScore += goals[goalIndex].Points;
        }
        else
        {
            Console.WriteLine("Invalid goal index.");
        }
    }

    public void DisplayGoals()
    {
        Console.WriteLine("Eternal Quest Goals:");
        for (int i = 0; i < goals.Count; i++)
        {
            goals[i].DisplayProgress();
        }

        Console.WriteLine($"Total Score: {totalScore} points");
    }

    // public void SaveProgress(string fileName)
    // {
    //     string json = JsonSerializer.Serialize(this);
    //     File.WriteAllText(fileName, json);

    //     Console.WriteLine("Progress saved successfully.");
    // }

    // public static EternalQuestManager LoadProgress(string fileName)
    // {
    //     string json = File.ReadAllText(fileName);
    //     return JsonSerializer.Deserialize<EternalQuestManager>(json);
    // }
}