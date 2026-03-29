// DAY-5 Hands-On — Level-2 Problem 1: Bank Withdrawal System with Custom Exception

using Assesment2;

class Program
{
    static void Main()
    {
        double balance = 3000;
        double withdraw = 5000;

        var account = new BankAccount(balance);

        try
        {
            account.Withdraw(withdraw);
            Console.WriteLine("Withdrawal successful. New balance: " + account.Balance);
        }
        catch (InsufficientBalanceException)
        {
            Console.WriteLine("Error: Withdrawal amount exceeds available balance");
        }
        finally
        {
            // Guaranteed cleanup after withdrawal attempt (always runs).
        }
    }
}
