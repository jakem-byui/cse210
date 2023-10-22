using System;

class Program2
{
    static void Main()
    {
        string reference = "John 3:16";

        string text = "For God so loved the world, that He gave His only begotten Son, that whosoever believeth in Him should not perish, but have everlasting life.";

        Reference scriptureReference = new Reference(reference);
        Scripture scripture = new Scripture(reference, text);

        bool quit = false;
        while (!scripture.AllWordsHidden() && !quit)
        {
            Console.Clear();
            Console.WriteLine("The Scripture Memorization Game!");
            scripture.Display();

            Console.Write("Press Enter to hide a word or type 'quit' to exit: ");
            string userInput = Console.ReadLine().ToLower();

            if (userInput == "quit")
            {
                quit = true;
            }
            else
            {
                scripture.HideRandomWord();
            }
        }

        if (quit)
        {
            Console.WriteLine("Thanks for playing!");
        }
        else
        {
            Console.Clear();
            scripture.Display();
            Console.WriteLine("Nice work! All the words are now hidden.");
        }
    }
}