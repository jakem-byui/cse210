using System.Net.Http.Json;

class ProgramFinal
{
    private static readonly HttpClient httpClient = new HttpClient();
    
    static async Task Main()
    {
        bool exitProgram = false;

        while (!exitProgram)
        {
            Console.WriteLine("Main Menu:");
            Console.WriteLine("1. Start a battle");
            Console.WriteLine("2. Exit Program");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    await StartBattleAsync();
                    break;

                case "2":
                    exitProgram = true;
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please enter a valid option.");
                    break;
            }

            Console.WriteLine(); // Add a line break for better readability
        }
    }

    static async Task StartBattleAsync()
    {
        // Fetch Pokémon data from the API
        Pokemon pikachu = await GetPokemonAsync("pikachu");
        Pokemon charmander = await GetPokemonAsync("charmander");

        // The battle logic from the previous example can be placed here
        Console.WriteLine("Starting a battle...");
        // You can copy and paste the battle logic code here
    }

    static async Task<Pokemon> GetPokemonAsync(string pokemonName)
    {
        string apiUrl = $"https://pokeapi.co/api/v2/pokemon/{pokemonName.ToLower()}";
        HttpResponseMessage response = await httpClient.GetAsync(apiUrl);

        if (response.IsSuccessStatusCode)
        {
            var pokemonData = await response.Content.ReadFromJsonAsync<PokemonApiResponse>();
            return new Pokemon(pokemonData.Name, pokemonData.Stats[5].base_stat, 20); // Assuming the 6th stat is HP
        }
        else
        {
            Console.WriteLine($"Failed to fetch Pokémon data for {pokemonName}.");
            return null;
        }
    }
}