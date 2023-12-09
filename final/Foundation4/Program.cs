using System;

class ProgramSandbox
{
    static void Main(string[] args)
    {
        int menuChoice;

        Console.WriteLine("Welcome to Pokémon C#!");
        Thread.Sleep(500);

        do
        {
            Console.WriteLine("\nMain Menu:");
            Console.WriteLine("1. Launch Battle Manager");
            Console.WriteLine("2. Exit Program");
            Console.Write("Enter your choice: ");
            
            if (int.TryParse(Console.ReadLine(), out menuChoice))
            {
                switch (menuChoice)
                {
                    case 1:
                        BattleManager.StartBattle();
                        break;
                    case 2:
                        Console.WriteLine("Exiting program. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }

        } while (menuChoice != 2);
    }
}