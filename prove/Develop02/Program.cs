class ProgramD2
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        while (true)
        {
            // Menu options to choose from
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();

            // Prompts user with a  random question for a journal entry
            if (choice == "1") 
            {
                string prompt = PromptGenerator.GetRandomPrompt();
                Console.WriteLine($"Prompt: {prompt}");

                string response = GetUserResponse();

                Entry newEntry = new Entry(prompt, response, DateTime.Now.ToString());
                journal.AddEntry(newEntry);
            }
            
            // Shows user previously input journal entries
            else if (choice == "2")
            {
                Console.WriteLine("Journal Entries:\n");
                journal.DisplayEntries();
            }

            // Prompts user for a file name and then saves file
            else if (choice == "3")
            {
                Console.Write("Enter file name to save: ");
                string saveFileName = Console.ReadLine();
                journal.SaveToFile(saveFileName);
            }

            // Asks user for a file name to load into the journal
            else if (choice == "4")
            {
                Console.Write("Enter file name to load: ");
                string loadFileName = Console.ReadLine();
                journal.LoadFromFile(loadFileName);
            }

            // Exits the program
            else if (choice == "5")
            {
                Environment.Exit(0);
            }

            // User input invalid menu option
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }

            Console.WriteLine();  // Add a line break for readability
        }
    }

    public static string GetUserResponse()
    {
        Console.Write("Your response: ");
        return Console.ReadLine();
    }

}