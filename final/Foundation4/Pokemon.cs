abstract class Pokemon
{
    private string _name;
    private int _health;
    private int _attackPower;
    private AttackMove _move1;
    private AttackMove _move2;
    private PokemonType _type;

    public Pokemon(string name, int health, int attackPower, AttackMove move1, AttackMove move2, PokemonType type)
    {
        _name = name;
        _health = health;
        _attackPower = attackPower;
        _move1 = move1;
        _move2 = move2;
        _type = type;
    }

    public string Name => _name;
    public int Health => _health;
    public int AttackPower => _attackPower;
    public PokemonType Type => _type;
    public bool IsAlive => _health > 0;

    public void TakeTurn(Pokemon opponent, bool isPlayerTurn = true)
    {
        if (isPlayerTurn)
        {
            Console.WriteLine($"1. {_move1.Name}\t2. {_move2.Name}");
            Console.Write("You choose to do (1 or 2)... ");
            int moveChoice = Convert.ToInt32(Console.ReadLine());

            Thread.Sleep(300);
            AttackMove selectedMove = (moveChoice == 1) ? _move1 : _move2;
            Console.WriteLine($"{Name} uses {selectedMove.Name}!");
            selectedMove.Execute(this, opponent);
        }
        else
        {
            Thread.Sleep(300);
            AttackMove selectedMove = GetRandomMove();
            Console.WriteLine($"{Name} used {selectedMove.Name}!");
            selectedMove.Execute(this, opponent);
        }
    }

    public virtual void Display()
    {
        Console.WriteLine($"{_name} - Health: {_health}");
    }

    public void ReceiveDamage(int damage)
    {
        _health -= damage;
        if (_health < 0)
            _health = 0;

        Console.WriteLine($"{_name} took {damage} damage!");
        Display();
    }

    public AttackMove GetRandomMove()
    {
        Random random = new Random();
        int moveChoice = random.Next(1, 3);
        return (moveChoice == 1) ? _move1 : _move2;
    }
}
