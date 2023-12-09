class VineWhipMove : AttackMove
{
    public VineWhipMove() : base("Vine Whip")
    {
    }

    public override void Execute(Pokemon attacker, Pokemon defender)
    {
        int damage = attacker.AttackPower + 8; // Additional damage for Vine Whip
        defender.ReceiveDamage(damage);
    }
}