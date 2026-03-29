using System;

class BankAccount
{
    // Private field
    private double balance;

    // Method to deposit money
    public void Deposit(double amount)
    {
        balance = balance + amount;
        Console.WriteLine("Deposited: " + amount);
    }

    // Method to withdraw money
    public void Withdraw(double amount)
    {
        if (amount <= balance)
        {
            balance = balance - amount;
            Console.WriteLine("Withdrawn: " + amount);
        }
        else
        {
            Console.WriteLine("Insufficient Balance");
        }
    }

    // Method to get current balance
    public double GetBalance()
    {
        return balance;
    }
}

class Program
{
    static void Main()
    {
        BankAccount account = new BankAccount();

        account.Deposit(1000);
        account.Withdraw(300);

        Console.WriteLine("Current Balance = " + account.GetBalance());
    }
}