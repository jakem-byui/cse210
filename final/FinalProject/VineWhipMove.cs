class VineWhipMove : AttackMove
{
    public VineWhipMove() : base("Vine Whip")
    {
    }

    public override void Execute(Pokemon attacker, Pokemon defender)
    {
        int damage = CalculateDamage(attacker, defender);
        defender.ReceiveDamage(damage);
    }
}