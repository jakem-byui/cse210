abstract class PokemonType
{
    private string _name;

    public PokemonType(string name)
    {
        _name = name;
    }

    public string Name => _name;
}