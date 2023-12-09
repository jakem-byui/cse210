using System;

class BattleManager
{
    public static void StartBattle()
    {
        Console.WriteLine("Choose your Pokemon: \n1. Charmander \n2. Bulbasaur \n3. Squirtle ");
        int choice = Convert.ToInt32(Console.ReadLine());

        Pokemon playerPokemon = PokemonFactory.CreatePokemon(choice);
        Pokemon opponentPokemon = PokemonFactory.CreateRandomPokemon();

        Console.WriteLine($"You chose {playerPokemon.Name}!");
        Console.WriteLine($"Your opponent chose {opponentPokemon.Name}!");

        while (playerPokemon.IsAlive && opponentPokemon.IsAlive)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nPlayer's Turn:");
            playerPokemon.TakeTurn(opponentPokemon);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nOpponent's Turn:");
            opponentPokemon.TakeTurn(playerPokemon);
        }

        Console.WriteLine(playerPokemon.IsAlive ? "You win!" : "You lose!");
        Console.ResetColor();
    }
}
