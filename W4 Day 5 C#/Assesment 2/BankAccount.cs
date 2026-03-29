// DAY-5 Hands-On — Level-2 Problem 1: Bank Withdrawal System

namespace Assesment2;

public class BankAccount
{
    private double balance;

    public BankAccount(double initialBalance)
    {
        balance = initialBalance;
    }

    public double Balance => balance;

    public void Withdraw(double amount)
    {
        if (amount > balance)
            throw new InsufficientBalanceException("Withdrawal amount exceeds available balance");

        balance -= amount;
    }
}
