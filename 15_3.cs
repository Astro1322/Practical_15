interface IPrice
{
    int Price();
}

interface IWarranty
{
    int Warranty();
}

class Phone : IPrice, IWarranty
{
    public int Price()
    {
        return 25000;
    }

    public int Warranty()
    {
        return 12;
    }
}

class Laptop : IPrice
{
    public int Price()
    {
        return 80000;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Phone phone = new Phone();
        Laptop laptop = new Laptop();

        int totalCost = phone.Price() + laptop.Price();

        Console.WriteLine($"Гарантия: {phone.Warranty()} мес");
        Console.WriteLine($"Общая стоимость: {totalCost}");
    }
}