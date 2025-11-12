interface IAttack
{
    void Attack();
}

interface IHeal
{
    void Heal();
}

class Warrior : IAttack
{
    public void Attack()
    {
        Console.WriteLine("Воин атакует мечом!");
    }
}

class Mage : IAttack, IHeal
{
    public void Attack()
    {
        Console.WriteLine("Маг бросает FIRE BALL!");
    }

    public void Heal()
    {
        Console.WriteLine("Маг кастует исцеление!");
    }
}
class Program
{
    static void Main(string[] args)
    {
        IAttack[] attackers = { new Warrior(), new Mage() };
        IHeal[] healers = { new Mage() };

        Console.WriteLine("Атакуют:");
        foreach (var attacker in attackers)
        {
            attacker.Attack();
        }

        Console.WriteLine();

        Console.WriteLine("Лечат:");
        foreach (var healer in healers)
        {
            healer.Heal();
        }
    }
}