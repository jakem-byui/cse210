using System;

class ProgramFinal
{
    static void Main()
    {
        // Let the user choose a Pokemon
        Console.WriteLine("Choose your Pokemon: 1 - Charmander, 2 - Squirtle, 3 - Bulbasaur");
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

        // Create a default opponent
        Pokemon opponentPokemon = new Charmander();

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
        
        string[] spinnerChars = {".","..","...","...."};
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
}