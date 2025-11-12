interface OnOff
{
    void On();
    void Off();
}
interface SettingTheLevel
{
    void SetLevel(int level);
}
class Lamp : OnOff, SettingTheLevel
{
    private int level { get; set; } = 100;
    public int Level
    {
        get 
        {
            return level;
        }
        set
        {
            if (value >= 0 && value <= 100) 
            { 
                level = value; 
            }
            else
            {
                Console.WriteLine("Уровень должен быть от 0 до 100!");
            }
        }
    }
    private int getLevel { get; set; } = 100;

    public void On()
    {
        Level = getLevel;
        Console.WriteLine($"Лампа включена. Уровень: {Level}");
    }
    public void Off()
    {
        Level = 0;
        Console.WriteLine($"Лампа выключена. Уровень: {Level}");
    }
    public void SetLevel(int level)
    {
        getLevel = level;
        Level = level;
        Console.WriteLine($"Установлен уровень: {Level}");
    }
}
class Fan : OnOff
{
    public void On()
    {
        Console.WriteLine("Вентилятор включен.");
    }
    public void Off()
    {
        Console.WriteLine("Вентилятор выключен.");
    }
}
internal class Program
{
    static void Main(string[] args)
    {
        Lamp[] lamp = { new Lamp() };
        foreach (Lamp l in lamp)
        {
            l.SetLevel(100);
            l.On();
            l.Off();
            l.On();
            l.Off();
            l.On();
        }
        Console.WriteLine();

        Fan[] fan = { new Fan() };
        foreach (Fan f in fan)
        {
            f.On();
            f.Off();
        }
    }
}