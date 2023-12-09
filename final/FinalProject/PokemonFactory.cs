class PokemonFactory
{
    public static Pokemon CreatePokemon(int choice)
    {
        switch (choice)
        {
            case 1:
                return new Charmander();
            case 2:
                return new Bulbasaur();
            case 3:
                return new Squirtle();
            default:
                throw new ArgumentException("Invalid choice");
        }
    }

    public static Pokemon CreateRandomPokemon()
    {
        Random random = new Random();
        int choice = random.Next(1, 4);
        return CreatePokemon(choice);
    }
}