class BattleManager
{
    public static void StartBattle()
    {
        // Create a random opponent
        Pokemon opponentPokemon = GetRandomOpponent();
        
        // Let the user choose a Pokemon
        Console.WriteLine("Welcome to Battale Manager! Your opponent will be randomly selected. Prepare to make your selection");
        Thread.Sleep(1000);

        Console.WriteLine($"\nYour opponent chose {opponentPokemon.Name}!");
        Thread.Sleep(1000);

        Console.WriteLine("\nChoose your Pokémon:");
        Console.WriteLine("1 - Charmander, Lizard Pokémon");
        Console.WriteLine("2 - Squirtle, Seed Pokémon");
        Console.WriteLine("3 - Bulbasaur, Tiny Turtle Pokémon");

        Console.Write("\nYou choose: ");
        int choice = int.Parse(Console.ReadLine());

        Pokemon userPokemon;

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
                userPokemon = new Charmander();
                break;
        }

        // Let the battle begin
        Console.WriteLine("Battle Start!");
        Console.WriteLine($"{userPokemon.Name} vs. {opponentPokemon.Name}");

        // Battle loop
        while (userPokemon.Health > 0 && opponentPokemon.Health > 0)
        {
            // User's turn
            Console.WriteLine("\nYour turn!");

            Thread.Sleep(1500);

            userPokemon.Attack(opponentPokemon);

            BattlePace();

            // Check if opponent fainted
            if (opponentPokemon.Health <= 0)
            {
                Console.WriteLine($"{opponentPokemon.Name} fainted. You win!");
                break;
            }

            // Opponent's turn
            Console.WriteLine("\nOpponent's turn!");

            Thread.Sleep(1500);

            opponentPokemon.Attack(userPokemon);
            
            BattlePace();

            // Check if user fainted
            if (userPokemon.Health <= 0)
            {
                Console.WriteLine($"{userPokemon.Name} fainted. You lose!");
                break;
            }
        }

        // End of the battle
        Console.WriteLine("Battle Over!");
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