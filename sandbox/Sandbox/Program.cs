class Program1
{
    static void Main(string[] args)
    {
        // Sample scripture
        string reference = "John 3:16";
        string text = "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.";

        // Create the scripture
        Scripture scripture = new Scripture(reference, text);

        // Display the initial scripture
        scripture.Display();

        while (true)
        {
            // Get user input
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "quit")
                break;

            // Hide random words and display the updated scripture
            scripture.HideRandomWords();

            if (scripture.AllWordsHidden())
                break;
        }
    }
}