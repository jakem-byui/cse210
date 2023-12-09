abstract class AttackMove
{
    private string _name;

    public AttackMove(string name)
    {
        _name = name;
    }

    public string Name => _name;

    public abstract void Execute(Pokemon attacker, Pokemon defender);
}