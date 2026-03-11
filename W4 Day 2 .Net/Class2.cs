using System;

class MathOperations
{
    public int Multiply(int a, int b)
    {
        return a * b;
    }
}

class Program
{
    static void Main()
    {
        MathOperations obj = new MathOperations();

        int result = obj.Multiply(6, 4);

        Console.WriteLine("Multiplication = " + result);
    }
}