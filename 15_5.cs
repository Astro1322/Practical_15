interface BankOperations
{
    void Deposit(int amount);
    void Withdraw(int amount);
}
interface ITransfer
{
    void Transfer(BankAccount targetAccount, int amount);
}
class BankAccount : BankOperations, ITransfer
{
    private string name;
    private int balance;
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public int Balance
    {
        get { return balance; }
        set
        {
            if (value >= 0) { balance = value; }
            else
            {
                Console.WriteLine("Баланс не может быть отрицательным!");
            }
        }
    }
    public BankAccount(string name, int balance)
    {
        Name = name;
        Balance = balance;
    }
    public void Deposit(int amount)
    {
        if (amount >= 0)
        {
            Balance += amount;
            Console.WriteLine($"{Name} положил на счёт {amount} руб. Баланс: {Balance}");
        }
        else
        {
            Balance += 0;
            Console.WriteLine("Нельзя положить на счёт отрицательную сумму!");
        }
    }
    public void Withdraw(int amount)
    {
        if (Balance >= amount)
        {
            Balance -= amount;
            Console.WriteLine($"{Name} снял со счёта {amount} руб. Баланс: {Balance}");
        }
        else
        {
            Balance -= 0;
            Console.WriteLine("Недостаточно средств!");
        }
    }
    public void Transfer(BankAccount targetAccount, int amount)
    {
        if (amount < 0)
        {
            Console.WriteLine("Сумма перевода должна быть положительной!");
            return;
        }
        if (Balance >= amount)
        {
            Balance -= amount;
            targetAccount.Balance += amount;
            Console.WriteLine($"{Name} перевёл {amount} руб на другой счёт. Баланс: {Balance}");
        }
        else
        {
            Balance -= 0;
            Console.WriteLine("Недостаточно средств для перевода на другой счёт!");
        }
    }
    public void Info()
    {
        Console.WriteLine($"Владелец: {Name}, баланс: {Balance}");
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        BankAccount b1 = new BankAccount("Aртём", 20000);
        BankAccount b2 = new BankAccount("Максим", 11000);
        b1.Info();
        b1.Deposit(7000);
        b1.Withdraw(2000);

        Console.WriteLine();

        b2.Info();
        b2.Withdraw(1000);
        b2.Deposit(3000);

        Console.WriteLine();

        b1.Transfer(b2, 5000);
        b1.Info();
        b2.Info();
    }
}
