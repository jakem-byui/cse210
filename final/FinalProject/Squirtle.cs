public class Squirtle : Pokemon
{
    public Squirtle() : base("Squirtle", 120, 20, PokemonType.Water)
    {
    }

    public override void Attack(Pokemon opponent)
    {
        // Squirtle's specific attack logic
        WaterGun(opponent);
    }

    protected override int CalculateDamage(Pokemon opponent)
    {
        // Squirtle's specific damage calculation logic
        return base.CalculateDamage(opponent);
    }

    // Squirtle's special attack
    public void WaterGun(Pokemon opponent)
    {
        Console.WriteLine($"{Name} uses Water Gun on {opponent.Name}!");

        Thread.Sleep(500);

        int damage = CalculateDamage(opponent) + 5; // Water Gun adds extra damage

        opponent.TakeDamage(damage);

        Console.WriteLine($"{opponent.Name} takes {damage} damage. {opponent.Name}'s health: {opponent.Health}");

        Thread.Sleep(500);
    }
}