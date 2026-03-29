// DAY-5 Hands-On — Level-2 Problem 1: Bank Withdrawal System (custom exception)

namespace Assesment2;

public class InsufficientBalanceException : Exception
{
    public InsufficientBalanceException(string message)
        : base(message)
    {
    }
}
