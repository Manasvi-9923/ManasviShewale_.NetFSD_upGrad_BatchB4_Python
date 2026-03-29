using System.Buffers.Text;
using System.Reflection.Emit;
using System.Runtime.ConstrainedExecution;

//DAY - 3 Hands - On


//Level - 1 Problem 1: Student Grade Calculator
//Scenario:
//A school wants to calculate the average marks of a student using a class-based approach.
//Requirements:
//1.Create a class Student.
//2.Create method CalculateAverage(int m1, int m2, int m3).
//3.Return the average marks.
//4. Display grade based on average.
//Technical Constraints:
//1.Use return type double for average.
//2. Avoid hard-coded values.
//Expectations:
//Clear separation of logic inside methods.
//Learning Outcome:
//Learn method creation, return values, and basic OOP concepts.
//Sample Input:
//80 70 90
//Sample Output:
//Average = 80, Grade = A
using System;

namespace StudentAvg
{
    class Student
    {
        // Method to calculate average
        public double CalculateAverage(int m1, int m2, int m3)
        {
            double avg = (m1 + m2 + m3) / 3.0;
            return avg;
        }

        // Method to get grade using switch case
        public string GetGrade(double avg)
        {
            int gradeCategory = (int)avg / 10;

            switch (gradeCategory)
            {
                case 10:
                case 9:
                case 8:
                    return "A";

                case 7:
                    return "B";

                case 6:
                    return "C";

                default:
                    return "Fail";
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Student s = new Student();

            Console.WriteLine("Enter three marks:");
            Console.WriteLine("Enter marks:");

            int m1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter marks:");
            int m2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter marks:");
            int m3 = Convert.ToInt32(Console.ReadLine());

            double average = s.CalculateAverage(m1, m2, m3);
            string grade = s.GetGrade(average);

            Console.WriteLine("Average = " + average);
            Console.WriteLine("Grade = " + grade);
        }
    }
}