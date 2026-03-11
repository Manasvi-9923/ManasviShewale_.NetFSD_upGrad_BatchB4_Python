using System;

class SwapNumbers
{
    public void Swap(int a, int b)
    {
        int temp;

        temp = a;
        a = b;
        b = temp;

        Console.WriteLine("After Swapping:");
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);
    }
}

class Program
{
    static void Main()
    {
        SwapNumbers obj = new SwapNumbers();

        int a = 10;
        int b = 5;

        Console.WriteLine("Before Swapping:");
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);

        obj.Swap(a, b);
    }
}