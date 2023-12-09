class BattleManager
{
    public static void StartBattle()
    {
        // Clear screen
        Console.Clear();
        int choice;
        
        // Create a random opponent
        Pokemon opponentPokemon = GetRandomOpponent();
        
        // Let the user choose a Pokemon
        Console.WriteLine("Welcome to Battale Manager! Your opponent will be randomly selected. Prepare to make your selection");
        Thread.Sleep(1000);

        Console.WriteLine($"\nYour opponent chose {opponentPokemon.Name}!");
        Thread.Sleep(1000);

        Console.WriteLine("\nChoose your Pokémon:");
        Console.WriteLine("1 - Charmander, Lizard Pokémon");
        Console.WriteLine("2 - Squirtle, Tiny Turtle Pokémon");
        Console.WriteLine("3 - Bulbasaur, Seed Pokémon");

        Console.Write("\nYou choose: ");

        Pokemon userPokemon = new Charmander();  // Default value

        if (int.TryParse(Console.ReadLine(), out choice))
        {
            switch (choice)
            {
                case 1:
                    userPokemon = new Charmander();
                    break;
                case 2:
                    userPokemon = new Squirtle();
                    break;
                case 3:
                    userPokemon = new Bulbasaur();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Defaulting to Charmander.");
                    // No need to assign a value here because userPokemon already has a default value.
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number.");
        }

        // Let the battle begin
        Console.WriteLine("Battle Start!");
        Console.WriteLine($"{userPokemon.Name} vs. {opponentPokemon.Name}. It's your move!");
        Console.WriteLine();

        // Battle loop
        while (userPokemon.Health > 0 && opponentPokemon.Health > 0)
        {
            // User's turn
            Console.ForegroundColor = ConsoleColor.Green;
            // Display available moves
            userPokemon.DisplayMoves();

            // User's turn
            Console.Write("Choose a move (enter the corresponding number): ");
            if (int.TryParse(Console.ReadLine(), out int moveChoice))
            {
                userPokemon.AttackWithMove(opponentPokemon, moveChoice - 1);

                // Check if opponent fainted
                if (opponentPokemon.Health <= 0)
                {
                    Console.WriteLine($"Your opponent's {opponentPokemon.Name} fainted. You win!");
                    break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }

            Thread.Sleep(1500);

            // Check if opponent's health is still greater than zero before executing the opponent's turn
            if (opponentPokemon.Health > 0)
            {
                // Opponent's turn
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Opponent's turn!");

                Thread.Sleep(1500);

                opponentPokemon.Attack(userPokemon);

                BattlePace();

                // Check if user fainted
                if (userPokemon.Health <= 0)
                {
                    Console.WriteLine($"Your {userPokemon.Name} fainted. You lose!");
                    break;
                }
            }
        }

        // End of the battle
        Console.ResetColor();

        Console.WriteLine("Battle Over! Press 'Enter' to continue.");

        Console.ReadLine();

        Console.Clear();
    }

    static void BattlePace()
    {
        
        string[] spinnerChars = {".","..","..."};
        int iterations = 1;

        for (int i = 0; i < iterations; i++)
        {
            foreach (var c in spinnerChars)
            {
                Console.Write(c + "\r");
                Thread.Sleep(300);
            }
        }
        
        Console.WriteLine(); // Move to the next line after the spinner
    }

    static Pokemon GetRandomOpponent()
    {
        Random random = new Random();
        int randomOpponent = random.Next(1, 4);

        switch (randomOpponent)
        {
            case 1:
                return new Charmander();
            case 2:
                return new Squirtle();
            case 3:
                return new Bulbasaur();
            default:
                return new Charmander();
        }
    }
}