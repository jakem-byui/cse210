// Base class for Pokemon
public enum PokemonType
{
    Fire,
    Water,
    Grass
}

public class Pokemon
{
    private string _name;
    private int _health;
    private int _attackPower;
    // List to store Pokemon moves
    public List<string> _moves;

    private PokemonType _type;
    public PokemonType Type => _type;
    public Pokemon(string name, int health, int attackPower, PokemonType type)
    {
        _name = name;
        _health = health;
        _attackPower = attackPower;
        _type = type;
        _moves = new List<string> { "Tackle" };
    }

    // Method to display available moves
    public void DisplayMoves()
    {
        Console.WriteLine("Available moves:");
        for (int i = 0; i < _moves.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_moves[i]}");
        }
    }

    public string Name => _name;
    public int Health => _health;

    // Method for attacking another Pokemon with a chosen move
    public void AttackWithMove(Pokemon opponent, int moveIndex)
    {
        if (moveIndex >= 0 && moveIndex < _moves.Count)
        {
            string selectedMove = _moves[moveIndex];
            Console.WriteLine($"{_name} uses {selectedMove} on {opponent.Name}!");

            Thread.Sleep(500);

            int damage = CalculateDamage(opponent);
            opponent.TakeDamage(damage);

            Console.WriteLine($"{opponent.Name} takes {damage} damage. {opponent.Name}'s health: {opponent.Health}");

            Thread.Sleep(500);
        }
        else
        {
            Console.WriteLine("Invalid move index.");
        }
    }

        // Method for attacking another Pokemon
    public virtual void Attack(Pokemon opponent)
    {
        // Default implementation for the base class
        Console.WriteLine($"{_name} attacks {opponent.Name}!");

        Thread.Sleep(500);

        int damage = CalculateDamage(opponent);
        opponent.TakeDamage(damage);

        Console.WriteLine($"{opponent.Name} takes {damage} damage. {opponent.Name}'s health: {opponent.Health}");

        Thread.Sleep(500);
    }

    // Method for calculating damage with type effectiveness
    protected virtual int CalculateDamage(Pokemon opponent)
    {
        double effectivenessMultiplier = GetTypeEffectivenessMultiplier(opponent.Type);
        return (int)(_attackPower * effectivenessMultiplier);
    }

    // Method for determining type effectiveness multiplier
    private double GetTypeEffectivenessMultiplier(PokemonType opponentType)
    {
        // Add type effectiveness logic here
        switch (_type)
        {
            case PokemonType.Fire:
                return (opponentType == PokemonType.Grass) ? 2.0 : (opponentType == PokemonType.Water) ? 0.5 : 1.0;
            case PokemonType.Water:
                return (opponentType == PokemonType.Fire) ? 2.0 : (opponentType == PokemonType.Grass) ? 0.5 : 1.0;
            case PokemonType.Grass:
                return (opponentType == PokemonType.Water) ? 2.0 : (opponentType == PokemonType.Fire) ? 0.5 : 1.0;
            default:
                return 1.0;
        }
    }

    // Method for taking damage
    public virtual void TakeDamage(int damage)
    {
        _health -= damage;
        if (_health <= 0)
        {
            Console.WriteLine($"{_name} fainted!");
        }
    }
}