public class Charmander : Pokemon
{
    public Charmander() : base("Charmander", 100, 25, PokemonType.Fire)
    {
    }

    public override void Attack(Pokemon opponent)
    {
        // Charmander's specific attack logic
        Ember(opponent);
    }

    protected override int CalculateDamage(Pokemon opponent)
    {
        // Charmander's specific damage calculation logic
        return base.CalculateDamage(opponent);
    }

    // Charmander's special attack
    public void Ember(Pokemon opponent)
    {
        Console.WriteLine($"{Name} uses Ember on {opponent.Name}!");

        Thread.Sleep(500);

        int damage = CalculateDamage(opponent) + 10; // Ember adds extra damage

        opponent.TakeDamage(damage);

        Console.WriteLine($"{opponent.Name} takes {damage} damage. {opponent.Name}'s health: {opponent.Health}");

        Thread.Sleep(500);
    }
}