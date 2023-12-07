using System;
using System.Threading;

class ProgramFinal
{
    static void Main()
    {
        int menuChoice;

        Console.WriteLine("Welcome to Pokémon C#!");
        Thread.Sleep(500);

        Console.WriteLine("\nCurrently there's two minigames you can play: 'Battle Manager' and 'Safari Zone'.");
        Thread.Sleep(500);

        do
        {
            Console.WriteLine("\nMain Menu:");
            Console.WriteLine("1. Launch Battle Manager");
            Console.WriteLine("2. Launch Safari Zone");
            Console.WriteLine("3. Exit Program");
            Console.Write("Enter your choice: ");
            
            if (int.TryParse(Console.ReadLine(), out menuChoice))
            {
                switch (menuChoice)
                {
                    case 1:
                        BattleManager.StartBattle();
                        break;
                    case 2:
                        // Your code for option 2 (To be determined)
                        break;
                    case 3:
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

        } while (menuChoice != 3);
    }
}