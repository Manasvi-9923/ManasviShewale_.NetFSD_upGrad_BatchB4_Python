using System;

class Employee
{
    public string name;
    public double salary;
    public int experience;

    public void GetData()
    {
        Console.Write("Enter Name: ");
        name = Console.ReadLine();

        Console.Write("Enter Salary: ");
        salary = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Experience (in years): ");
        experience = Convert.ToInt32(Console.ReadLine());
    }

    public void CalculateBonus()
    {
        double bonus = 0;

        // Using if-else
        if (experience < 2)
        {
            bonus = salary * 0.05;
        }
        else if (experience >= 2 && experience <= 5)
        {
            bonus = salary * 0.10;
        }
        else
        {
            bonus = salary * 0.15;
        }

        // Using ternary operator for final salary
        double finalSalary = bonus > 0 ? salary + bonus : salary;

        Console.WriteLine("\nEmployee: " + name);
        Console.WriteLine("Bonus: " + bonus.ToString("C"));
        Console.WriteLine("Final Salary: " + finalSalary.ToString("C"));
    }
}

class Program
{
    static void Main()
    {
        Employee emp = new Employee();

        emp.GetData();
        emp.CalculateBonus();

        Console.ReadLine();
    }
}