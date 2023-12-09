public class Bulbasaur : Pokemon
{
    public Bulbasaur() : base("Bulbasaur", 110, 15, PokemonType.Grass)
    {
        // Add specific moves for Bulbasaur
        _moves.Add("Vine Whip");
    }

    public override void Attack(Pokemon opponent)
    {
        // Bulbasuar's specific attack logic
        VineWhip(opponent);
    }

    protected override int CalculateDamage(Pokemon opponent)
    {
        // Bulbasaur's specific damage calculation logic
        return base.CalculateDamage(opponent);
    }

    // Bulbasaur's special attack
    public void VineWhip(Pokemon opponent)
    {
        Console.WriteLine($"{Name} uses Vine Whip on {opponent.Name}!");

        Thread.Sleep(500);

        int damage = CalculateDamage(opponent) + 8; // Vine Whip adds extra damage

        opponent.TakeDamage(damage);

        Console.WriteLine($"{opponent.Name} takes {damage} damage. {opponent.Name}'s health: {opponent.Health}");

        Thread.Sleep(500);
    }
}