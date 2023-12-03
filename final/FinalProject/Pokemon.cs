class Pokemon
{
    public string Name { get; }
    public int Health { get; private set; }
    public int AttackPower { get; }

    public bool IsAlive => Health > 0;

    public Pokemon(string name, int health, int attackPower)
    {
        Name = name;
        Health = health;
        AttackPower = attackPower;
    }

    public void Attack(Pokemon target)
    {
        int damage = AttackPower;
        Console.WriteLine($"{Name} attacks {target.Name} and deals {damage} damage!");
        target.TakeDamage(damage);
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        if (Health < 0)
        {
            Health = 0;
        }
    }
}