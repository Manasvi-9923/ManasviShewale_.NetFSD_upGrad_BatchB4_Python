using System;

class Employee
{
    public string name;
    public double salary;
    public int experience;

    public void GetEmployeeData()
    {
        Console.Write("Enter Employee Name: ");
        name = Console.ReadLine();

        Console.Write("Enter Salary: ");
        salary = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Years of Experience: ");
        experience = Convert.ToInt32(Console.ReadLine());
    }

    public void DisplayEmployeeData()
    {
        Console.WriteLine("\nEmployee Details");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Salary: " + salary);
        Console.WriteLine("Experience: " + experience + " years");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Employee emp = new Employee();

        emp.GetEmployeeData();   
        emp.DisplayEmployeeData(); 

        Console.ReadLine();
    }
}