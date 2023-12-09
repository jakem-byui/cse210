class BattleManager
{
    public static void StartBattle()
    {
        Console.Clear();
        
        Console.WriteLine("Choose your Pokemon: \n1. Charmander \n2. Bulbasaur \n3. Squirtle \n");
        Console.Write("You choose (1,2,3): ");
        int choice = Convert.ToInt32(Console.ReadLine());
        BattlePace();

        Pokemon playerPokemon = PokemonFactory.CreatePokemon(choice);
        Pokemon opponentPokemon = PokemonFactory.CreateRandomPokemon();

        Console.WriteLine($"\nYour opponent chose {opponentPokemon.Name}!");
        BattlePace();

        while (playerPokemon.IsAlive && opponentPokemon.IsAlive)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nPlayer's Turn:");
            playerPokemon.TakeTurn(opponentPokemon, true);

            if (!opponentPokemon.IsAlive)
                break;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nOpponent's Turn:");
            opponentPokemon.TakeTurn(playerPokemon, false);
        }

        Console.WriteLine(playerPokemon.IsAlive ? "You win!" : "You lose!");
        Console.ForegroundColor = ConsoleColor.White;
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
        
        Console.WriteLine();
    }
}