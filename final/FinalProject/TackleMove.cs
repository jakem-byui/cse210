class TackleMove : AttackMove
{
    public TackleMove() : base("Tackle")
    {
    }

    public override void Execute(Pokemon attacker, Pokemon defender)
    {
        int damage = attacker.AttackPower;
        defender.ReceiveDamage(damage);
    }
}