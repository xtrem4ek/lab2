using System;

class BankAccount
{
    
    public string AccountNumber { get; private set; }
    public double Balance { get; private set; }

   
    public BankAccount(string accountNumber, double initialBalance)
    {
        AccountNumber = accountNumber;
        Balance = initialBalance;
    }

   
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
        
        BankAccount myAccount = new BankAccount("UA123456789", 5000.0);

        
        myAccount.ShowAccountInfo();

        
        myAccount.Deposit(1500.0);

        
        myAccount.Withdraw(1000.0);
        myAccount.Withdraw(6000.0);  

        
        myAccount.ShowAccountInfo();
    }
}
