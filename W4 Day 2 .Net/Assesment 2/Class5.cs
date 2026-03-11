using System;

namespace Program
{
    class Calculator
    {
        private int a;
        private int b;

        public void SetValues(int a, int b)
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

    class Program
    {
        static void Main()
        {
            Calculator calc = new Calculator();

            Console.WriteLine("Enter first number:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            int b = Convert.ToInt32(Console.ReadLine());

            calc.SetValues(a, b);

            calc.Display();
        }
    }
}