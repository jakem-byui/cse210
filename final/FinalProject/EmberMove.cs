class EmberMove : AttackMove
{
    public EmberMove() : base("Ember")
    {
    }

    public override void Execute(Pokemon attacker, Pokemon defender)
    {
        int damage = CalculateDamage(attacker, defender);
        defender.ReceiveDamage(damage);
    }
}