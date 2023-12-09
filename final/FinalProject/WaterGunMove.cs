class WaterGunMove : AttackMove
{
    public WaterGunMove() : base("Water Gun")
    {
    }

    public override void Execute(Pokemon attacker, Pokemon defender)
    {
        int damage = CalculateDamage(attacker, defender);
        defender.ReceiveDamage(damage);
    }
}