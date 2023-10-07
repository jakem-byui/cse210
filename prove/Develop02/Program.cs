class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                string prompt = PromptGenerator.GetRandomPrompt();
                Console.WriteLine("Prompt: " + prompt);
                string response = GetUserResponse();
                Entry newEntry = new Entry(prompt, response, DateTime.Now.ToString());
                journal.AddEntry(newEntry);
            }
            else if (choice == "2")
            {
                Console.WriteLine("Journal Entries:\n");
                journal.DisplayEntries();
            }
            else if (choice == "3")
            {
                Console.Write("Enter file name to save: ");
                string saveFileName = Console.ReadLine();
                journal.SaveToFile(saveFileName);
            }
            else if (choice == "4")
            {
                Console.Write("Enter file name to load: ");
                string loadFileName = Console.ReadLine();
                journal.LoadFromFile(loadFileName);
            }
            else if (choice == "5")
            {
                Environment.Exit(0);
            }
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