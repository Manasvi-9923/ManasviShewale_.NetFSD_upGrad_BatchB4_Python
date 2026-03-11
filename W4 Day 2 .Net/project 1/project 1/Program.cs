using System;

namespace Program
{
    class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Sub(int a, int b)
        {
            return a - b;
        }

        //public int Mul(int a, int b)
        //{
        //    return a * b;
        //}

        //public int Div(int a, int b)
        //{
        //    return a / b;
        //}
    }

   internal class Program
    {
        static void Main()
        {
            Calculator calc = new Calculator();

            Console.WriteLine("Enter first number:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Addition = "+ calc.Add(a, b));
            Console.WriteLine("Subtraction = " + calc.Sub(a, b));
            //Console.WriteLine("Multiplication = " + calc.Mul(a, b));
            //Console.WriteLine("Division = " + calc.Div(a, b));
        }
    }
}