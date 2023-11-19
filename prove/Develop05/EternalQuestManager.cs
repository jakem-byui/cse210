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
        Console.WriteLine("\nEternal Quest Goals:");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.Write($"{i}. ");
            goals[i].DisplayProgress();
        }

        Console.WriteLine($"Total Score: {totalScore} points");
    }

    public void SaveProgress(string fileName)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (Goal goal in goals)
                {
                    if (goal is ChecklistGoal checklistGoal)
                    {
                        writer.WriteLine($"ChecklistGoal:{goal.Name},{goal.Points},{checklistGoal.TargetCount},{checklistGoal.CompletedCount},{goal.Description}");
                    }
                    else
                    {
                        writer.WriteLine($"{goal.GetType().Name}:{goal.Name},{goal.Points},{goal.Description}");
                    }
                }
                writer.WriteLine($"Total Score:{totalScore}");
            }

            Console.WriteLine("Progress saved successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving progress: {ex.Message}");
        }
    }

    public static EternalQuestManager LoadProgress(string fileName)
    {
        EternalQuestManager manager = new EternalQuestManager();

        using (StreamReader reader = new StreamReader(fileName))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                if (line.StartsWith("Total Score:"))
                {
                    // Extract total score from the last line
                    int totalScoreIndex = line.IndexOf(':') + 1;
                    manager.totalScore = int.Parse(line.Substring(totalScoreIndex).Trim());
                }
                else
                {
                    // Parse goal information
                    string[] parts = line.Split(':');
                    if (parts.Length == 2)
                    {
                        string[] details = parts[1].Split(',');
                        if (details.Length == 3)
                        {
                            string goalType = parts[0].Trim();
                            string name = details[0].Trim();
                            int points = int.Parse(details[1].Trim());
                            string description = details[2].Trim();

                            // Create the goal based on its type
                            switch (goalType)
                            {
                                case "SimpleGoal":
                                    manager.AddGoal(new SimpleGoal(name, description, points));
                                    break;
                                case "EternalGoal":
                                    manager.AddGoal(new EternalGoal(name, points, description));
                                    break;
                                case "ChecklistGoal":
                                    // Additional parsing logic for ChecklistGoal
                                    if (details.Length == 5)
                                    {
                                        int targetCount = int.Parse(details[2].Trim());
                                        int completedCount = int.Parse(details[3].Trim());
                                        manager.AddGoal(new ChecklistGoal(name, points, targetCount, completedCount));
                                    }
                                    break;
                            }
                        }
                    }
                }
            }
        }
        Console.WriteLine("Progress loaded successfully.");
        return manager;
    }
}
