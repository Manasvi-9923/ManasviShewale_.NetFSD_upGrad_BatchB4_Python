using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Intrinsics.X86;
//DAY - 4 Hands - On
//Level - 1 Problem 1: Student Score Analyzer Using Arrays and Maps
//Scenario:
//A training institute wants to analyze student scores stored in an array. The system should calculate total marks, average, highest score, and count of students scoring above a threshold.
//Requirements:
//-Store student marks in an array.
//- Use array methods (push, map, filter, reduce) for processing.
//- Store subject-wise highest marks using a Map (key - value pair).
//-Display total, average, and filtered results.
//Technical Constraints:
//-Must use array indexing and iteration.
//- Use reduce() for total calculation.
//- Use filter() for threshold-based filtering.
//- Use Map or Dictionary for subject-highest mapping.
//Sample Input:
//Marks: [78, 85, 90, 67, 88]
//Threshold: 80
//Sample Output:
//Total Marks: 408
//Average Marks: 81.6
//Students above 80: 3
//Highest Score: 90
//Expectations:
//-Clean and modular implementation.
//- Proper use of array methods.
//- Efficient iteration logic.
//Learning Outcome:
//-Understand array manipulation.
//-Use Map for key-value storage.
//- Apply functional programming methods.


class Program
{
    static void Main()
    {
        int[] marks = { 78, 85, 90, 67, 88 };
        int threshold = 80;
        int total = marks.Aggregate((a, b) => a + b);
        double average = (double)total / marks.Length;
        var aboveThreshold = marks.Where(m => m > threshold);
        int highest = marks.Max();
        Dictionary<string, int> subjectHighest = new Dictionary<string, int>();
        subjectHighest.Add("Math", 90);
        subjectHighest.Add("Science", 88);
        subjectHighest.Add("English", 85);

        Console.WriteLine("Total Marks: " + total);
        Console.WriteLine("Average Marks: " + average);
        Console.WriteLine("Students above 80: " + aboveThreshold.Count());
        Console.WriteLine("Highest Score: " + highest);

        Console.WriteLine("\nSubject Highest Marks:");
        foreach (var item in subjectHighest)
        {
            Console.WriteLine(item.Key + " : " + item.Value);
        }
    }
}