using System;

class Program
{
    static void Main(string[] args)
    {
        // In the Guess My Number game the computer picks a magic number, 
        // and then the user tries to guess it. After each guess, the 
        // computer tells the user to guess "higher" or "lower" until they 
        // guess the magic number.

        // This assignment is a little tricky, because it brings together 
        // many of the concepts you've learned in this course including 
        // loops and if statements.

        // Random number generator
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int magicGuess = -1;

        // Collect magic number and convert to int
        Console.Write("What is the magic number? ");
        magicNumber = int.Parse(Console.ReadLine());

        // Compare magic number with guess
        while (magicNumber != magicGuess)
        {
            // User guesses the magic number and converts to int
            Console.Write("What is your guess? ");
            magicGuess = int.Parse(Console.ReadLine());

            if (magicNumber > magicGuess)
            {
                Console.WriteLine("Higher");
            }

            else if (magicGuess > magicNumber)
            {
                Console.WriteLine("Lower");
            }

            else 
            {
                Console.WriteLine("You did it!");
            }
        }
    }
}