using System;

class BankAccount
{
    // Властивості
    public string AccountNumber { get; private set; }
    public double Balance { get; private set; }

    // Конструктор
    public BankAccount(string accountNumber, double initialBalance)
    {
        AccountNumber = accountNumber;
        Balance = initialBalance;
    }

    // Метод для поповнення рахунку
    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            Console.WriteLine($"Рахунок {AccountNumber} поповнено на {amount} грн. Поточний баланс: {Balance} грн.");
        }
        else
        {
            Console.WriteLine("Сума поповнення має бути більше нуля.");
        }
    }

    // Метод для зняття грошей з рахунку
    public void Withdraw(double amount)
    {
        if (amount > 0)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"З рахунку {AccountNumber} знято {amount} грн. Поточний баланс: {Balance} грн.");
            }
            else
            {
                Console.WriteLine("Недостатньо коштів на рахунку.");
            }
        }
        else
        {
            Console.WriteLine("Сума зняття має бути більше нуля.");
        }
    }

    // Метод для виведення інформації про рахунок
    public void ShowAccountInfo()
    {
        Console.WriteLine($"Рахунок: {AccountNumber}");
        Console.WriteLine($"Баланс: {Balance} грн.");
    }
}

class Program
{
    static void Main()
    {
        // Створення банківського рахунку
        BankAccount myAccount = new BankAccount("UA123456789", 5000.0);

        // Виведення початкової інформації про рахунок
        myAccount.ShowAccountInfo();

        // Поповнення рахунку
        myAccount.Deposit(1500.0);

        // Спроба зняття коштів
        myAccount.Withdraw(1000.0);
        myAccount.Withdraw(6000.0);  // Недостатньо коштів

        // Виведення кінцевої інформації про рахунок
        myAccount.ShowAccountInfo();
    }
}
