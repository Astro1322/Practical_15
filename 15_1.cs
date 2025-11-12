interface IWork
{
    void Work();
}

interface ICharge
{
    void Charge();
}

class Robot : IWork, ICharge
{
    public string Name;
    public int Energy;

    public Robot(string name, int energy)
    {
        Name = name;
        Energy = energy;
    }

    public void Work()
    {
        if (Energy > 0)
        {
            Energy = Math.Max(0, Energy - 20);
        }
        Console.WriteLine($"{Name} поработал. Энергия: {Energy}");
    }

    public void Charge()
    {
        Energy = Math.Min(100, Energy + 50);
        Console.WriteLine($"{Name} зарядился. Энергия: {Energy}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Robot robot = new Robot("Atom", 100);

        robot.Work();
        robot.Work();
        robot.Charge();
        robot.Work();
    }
}
