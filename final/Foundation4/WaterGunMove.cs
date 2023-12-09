class WaterGunMove : AttackMove
{
    public WaterGunMove() : base("Water Gun")
    {
    }

    public override void Execute(Pokemon attacker, Pokemon defender)
    {
        int damage = attacker.AttackPower + 12; // Additional damage for Water Gun
        defender.ReceiveDamage(damage);
    }
}