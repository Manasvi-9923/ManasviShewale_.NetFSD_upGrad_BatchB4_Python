using System;

namespace Program
{
    class Calculator
    {
        private int a;
        private int b;

        
        public Calculator(int a, int b)
        {
           this.a = a;
            this.b = b;
        }

        public int Add()
        {
            return a + b;
        }

        public int Sub()
        {
            return a - b;
        }

        public int Mul()
        {
            return a * b;
        }

        public int Div()
        {
            return a / b;
        }

        public void Display()
        {
            Console.WriteLine("Addition = " + Add());
            Console.WriteLine("Subtraction = " + Sub());
            Console.WriteLine("Multiplication = " + Mul());
            Console.WriteLine("Division = " + Div());
        }
    }

    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Calculator calc = new Calculator(num1, num2);

            calc.Display();
        }
    }
}