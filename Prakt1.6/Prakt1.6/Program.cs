using System;

public class BankAccount
{
    // Поля класса
    private string accountNumber;
    private string owner;
    private double balance;

    // Конструктор класса для инициализации объектов
    public BankAccount(string accountNumber, string owner, double initialBalance)
    {
        this.accountNumber = accountNumber;
        this.owner = owner;
        this.balance = initialBalance;
    }

    // Метод для получения номера счета
    public string GetAccountNumber()
    {
        return accountNumber;
    }

    // Метод для установки номера счета
    public void SetAccountNumber(string accountNumber)
    {
        this.accountNumber = accountNumber;
    }

    // Метод для получения владельца счета
    public string GetOwner()
    {
        return owner;
    }

    // Метод для установки владельца счета
    public void SetOwner(string owner)
    {
        this.owner = owner;
    }

    // Метод для получения баланса счета
    public double GetBalance()
    {
        return balance;
    }

    // Метод для пополнения счета
    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine($"Счет {accountNumber} пополнен на {amount} рублей. Новый баланс: {balance} рублей.");
        }
        else
        {
            Console.WriteLine("Сумма для пополнения должна быть больше нуля.");
        }
    }

    // Метод для снятия средств со счета
    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
            Console.WriteLine($"Со счета {accountNumber} снято {amount} рублей. Новый баланс: {balance} рублей.");
        }
        else if (amount <= 0)
        {
            Console.WriteLine("Сумма для снятия должна быть больше нуля.");
        }
        else
        {
            Console.WriteLine("Недостаточно средств на счете.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Создание объекта BankAccount
        BankAccount account = new BankAccount("1234567890", "Иван Иванов", 1000.0);

        // Получение информации о счете
        Console.WriteLine($"Номер счета: {account.GetAccountNumber()}");
        Console.WriteLine($"Владелец счета: {account.GetOwner()}");
        Console.WriteLine($"Баланс счета: {account.GetBalance()} рублей");

        // Пополнение счета и снятие средств
        account.Deposit(500.0);
        account.Withdraw(300.0);
    }
}
