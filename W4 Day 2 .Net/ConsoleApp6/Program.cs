
using System;

class Program
{
    static void Main()
    {
        // Creating a tuple
        var customer = ("Manasvi", 45, "Pune");

        // Displaying values
        Console.WriteLine("Customer Name: " + customer.Item1);
        Console.WriteLine("Customer ID: " + customer.Item2);
        Console.WriteLine("Customer City: " + customer.Item3);
    }
}