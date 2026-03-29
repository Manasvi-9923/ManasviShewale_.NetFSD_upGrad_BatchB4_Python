// DAY-4 Hands-On — Level-2 Problem 2: Student Record Management (record type)

using System;
using System.Collections.Generic;
using System.Globalization;

record Student(int RollNumber, string Name, string Course, int Marks);

class Program
{
    static void Main()
    {
        var students = new List<Student>();

        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("=== Student Record Management ===");
            Console.WriteLine("1. Add student(s)");
            Console.WriteLine("2. Display all records");
            Console.WriteLine("3. Search by Roll Number");
            Console.WriteLine("4. Exit");
            Console.Write("Choose option: ");

            string? choice = Console.ReadLine()?.Trim();

            switch (choice)
            {
                case "1":
                    AddStudents(students);
                    break;
                case "2":
                    DisplayAll(students);
                    break;
                case "3":
                    SearchByRoll(students);
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }

    static void AddStudents(List<Student> students)
    {
        Console.Write("How many students to add? ");
        if (!int.TryParse(Console.ReadLine(), out int n) || n < 1)
        {
            Console.WriteLine("Invalid count.");
            return;
        }

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\n--- Student {i + 1} ---");
            int roll = ReadPositiveInt("Enter Roll Number: ");
            if (students.Exists(s => s.RollNumber == roll))
            {
                Console.WriteLine("Roll Number already exists. Skipping.");
                continue;
            }

            Console.Write("Enter Name: ");
            string name = Console.ReadLine()?.Trim() ?? "";
            Console.Write("Enter Course: ");
            string course = Console.ReadLine()?.Trim() ?? "";
            int marks = ReadMarks("Enter Marks: ");

            students.Add(new Student(roll, name, course, marks));
            Console.WriteLine("Record saved.");
        }
    }

    static void DisplayAll(List<Student> students)
    {
        if (students.Count == 0)
        {
            Console.WriteLine("No records yet.");
            return;
        }

        Console.WriteLine("Student Records:");
        foreach (var s in students)
            PrintStudent(s);
    }

    static void SearchByRoll(List<Student> students)
    {
        int searchRoll = ReadPositiveInt("Search Roll Number: ");
        var found = students.Find(s => s.RollNumber == searchRoll);

        Console.WriteLine();
        Console.WriteLine("Search Result:");
        if (found != null)
        {
            Console.WriteLine("Student Found:");
            PrintStudent(found);
        }
        else
            Console.WriteLine("Record not found.");
    }

    static void PrintStudent(Student s) =>
        Console.WriteLine($"Roll No: {s.RollNumber} | Name: {s.Name} | Course: {s.Course} | Marks: {s.Marks}");

    static int ReadPositiveInt(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string? line = Console.ReadLine();
            if (int.TryParse(line, NumberStyles.Integer, CultureInfo.InvariantCulture, out int v) && v > 0)
                return v;
            Console.WriteLine("Please enter a valid positive integer.");
        }
    }

    static int ReadMarks(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string? line = Console.ReadLine();
            if (int.TryParse(line, NumberStyles.Integer, CultureInfo.InvariantCulture, out int m) && m >= 0 && m <= 100)
                return m;
            Console.WriteLine("Please enter marks between 0 and 100.");
        }
    }
}
