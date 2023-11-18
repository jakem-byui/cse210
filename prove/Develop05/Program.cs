using System;

class ProgramD5
{
    static void Main()
    {
        // Create manager and add some initial goals
        EternalQuestManager manager = new EternalQuestManager();
        manager.AddGoal(new SimpleGoal("Run a marathon", 1000));
        manager.AddGoal(new EternalGoal("Read scriptures", 100));
        manager.AddGoal(new ChecklistGoal("Attend the temple", 50, 10));

        bool quit = false;

        while (!quit)
        {
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");

            Console.Write("Select a choice from the menu: ");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                switch (choice)
                {
                    case 1:
                        CreateNewGoal(manager);
                        break;

                    case 2:
                        manager.DisplayGoals();
                        break;

                    case 3:
                        // Console.Write("Enter the file name to save: ");
                        // string saveFileName = Console.ReadLine();
                        // manager.SaveProgress(saveFileName);
                        // break;

                    case 4:
                        // Console.Write("Enter the file name to load: ");
                        // string loadFileName = Console.ReadLine();
                        // manager = EternalQuestManager.LoadProgress(loadFileName);
                        // break;

                    case 5:
                        Console.Write("Enter the index of the goal to record an event: ");
                        if (int.TryParse(Console.ReadLine(), out int goalIndex))
                        {
                            manager.RecordEvent(goalIndex);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a valid goal index.");
                        }
                        break;

                    case 6:
                        quit = true;
                        Console.WriteLine("Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
    }

    static void CreateNewGoal(EternalQuestManager manager)
    {
        Console.WriteLine("\nSelect the type of goal to create:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        if (int.TryParse(Console.ReadLine(), out int choice))
        {
            Console.Write("Enter the name of the goal: ");
            string goalName = Console.ReadLine();

            switch (choice)
            {
                case 1:
                    Console.Write("Enter the points for completing the goal: ");
                    if (int.TryParse(Console.ReadLine(), out int simplePoints))
                    {
                        manager.AddGoal(new SimpleGoal(goalName, simplePoints));
                        Console.WriteLine("Simple Goal created successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number for points.");
                    }
                    break;

                case 2:
                    Console.Write("Enter the points for each event: ");
                    if (int.TryParse(Console.ReadLine(), out int eternalPoints))
                    {
                        manager.AddGoal(new EternalGoal(goalName, eternalPoints));
                        Console.WriteLine("Eternal Goal created successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number for points.");
                    }
                    break;

                case 3:
                    Console.Write("Enter the points for each event: ");
                    if (int.TryParse(Console.ReadLine(), out int checklistPoints))
                    {
                        Console.Write("Enter the target count for the checklist: ");
                        if (int.TryParse(Console.ReadLine(), out int targetCount))
                        {
                            manager.AddGoal(new ChecklistGoal(goalName, checklistPoints, targetCount));
                            Console.WriteLine("Checklist Goal created successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a valid number for the target count.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number for points.");
                    }
                    break;

                default:
                    Console.WriteLine("Invalid choice. No goal created.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number.");
        }
    }
}