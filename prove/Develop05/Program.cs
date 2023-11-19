using System;

class Program
{
    static void Main()
    {
        // Create manager and add some initial goals
        EternalQuestManager manager = new EternalQuestManager();

        Console.Clear();

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

            Console.Write("\nSelect a choice from the menu: ");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                LoadingBar();

                switch (choice)
                {
                    case 1:
                        CreateNewGoal(manager);
                        break;

                    case 2:
                        manager.DisplayGoals();
                        break;

                    case 3:
                        Console.Write("Enter the file name to save: ");
                        string saveFileName = Console.ReadLine();
                        manager.SaveProgress(saveFileName);
                        break;

                    case 4:
                        Console.Write("Enter the file name to load: ");
                        string loadFileName = Console.ReadLine();
                        manager = EternalQuestManager.LoadProgress(loadFileName);
                        break;

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

            Console.Write("Enter a description for the goal: ");
            string goalDescription = Console.ReadLine();

            switch (choice)
            {
                case 1:
                    Console.Write("Enter the points for completing the goal: ");
                    if (int.TryParse(Console.ReadLine(), out int simplePoints))
                    {
                        manager.AddGoal(new SimpleGoal(goalName, goalDescription, simplePoints));
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
                        manager.AddGoal(new EternalGoal(goalName, eternalPoints, goalDescription));
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
                            Console.Write("Enter the completed count for the checklist: ");
                            if (int.TryParse(Console.ReadLine(), out int completedCount))
                            {
                                manager.AddGoal(new ChecklistGoal(goalName, checklistPoints, targetCount, completedCount));
                                Console.WriteLine("Checklist Goal created successfully.");
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please enter a valid number for the completed count.");
                            }
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

    static void LoadingBar()
    {
        Console.Clear();
        
        Console.WriteLine("| Loading |");
        string[] spinnerChars = { "|~        |", "|~~~      |", "|~~~~~    |", "|~~~~~~~  |", "|~~~~~~~~~|" };
        int iterations = 1;

        for (int i = 0; i < iterations; i++)
        {
            foreach (var c in spinnerChars)
            {
                Console.Write(c + "\r");
                System.Threading.Thread.Sleep(250);
            }
        }
        
        Console.Clear();
        Console.WriteLine(); // Move to the next line after the spinner
    }
}