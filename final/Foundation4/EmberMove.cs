class EmberMove : AttackMove
{
    public EmberMove() : base("Ember")
    {
    }

    public override void Execute(Pokemon attacker, Pokemon defender)
    {
        int damage = attacker.AttackPower + 10; // Additional damage for Ember
        defender.ReceiveDamage(damage);
    }
}