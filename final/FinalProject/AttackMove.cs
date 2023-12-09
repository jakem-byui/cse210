abstract class AttackMove
{
    private string _name;

    public AttackMove(string name)
    {
        _name = name;
    }

    public string Name => _name;

    public abstract void Execute(Pokemon attacker, Pokemon defender);

    protected int CalculateDamage(Pokemon attacker, Pokemon defender)
    {
        double effectiveness = GetEffectiveness(attacker.Type, defender.Type);
        int damage = (int)(attacker.AttackPower * effectiveness);
        return damage;
    }

    private double GetEffectiveness(PokemonType attackerType, PokemonType defenderType)
    {
        if (attackerType is FireType && defenderType is GrassType)
        {
            return 2.0; // WaterGunMove does x2 damage to GrassType
        }
        else if (attackerType is WaterType && defenderType is FireType)
        {
            return 2.0; // WaterGunMove does x2 damage to FireType
        }
        else if (attackerType is GrassType && defenderType is WaterType)
        {
            return 2.0; // WaterGunMove does x2 damage to WaterType
        }
        else if (attackerType is GrassType && defenderType is FireType)
        {
            return 0.5; // WaterGunMove does x0.5 damage to FireType
        }
        else if (attackerType is FireType && defenderType is WaterType)
        {
            return 0.5; // WaterGunMove does x0.5 damage to WaterType
        }
        else if (attackerType is WaterType && defenderType is GrassType)
        {
            return 0.5; // WaterGunMove does x0.5 damage to GrassType
        }
        else
        {
            return 1.0; // Default: normal effectiveness
        }
    }
}