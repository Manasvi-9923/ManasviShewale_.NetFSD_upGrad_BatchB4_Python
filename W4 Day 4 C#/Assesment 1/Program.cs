// DAY-4 Hands-On — Level-1 Problem 1: Student Score Analyzer (Arrays + Map)

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] marks = { 78, 85, 90, 67, 88 };
        int threshold = 80;

        // reduce() equivalent — total
        int total = marks.Aggregate((a, b) => a + b);

        double average = (double)total / marks.Length;

        // filter() equivalent
        var aboveThreshold = marks.Where(m => m > threshold).ToArray();

        // map() equivalent — transform each mark (e.g. scaled view)
        _ = marks.Select(m => m / 100.0).ToArray();

        int highest = marks.Max();

        // Subject-wise highest — Dictionary built with indexed parallel arrays
        string[] subjects = { "Math", "Science", "English" };
        int[] subjectTopMarks = { 90, 88, 85 };
        var subjectHighest = new Dictionary<string, int>();
        for (int i = 0; i < subjects.Length; i++)
            subjectHighest[subjects[i]] = subjectTopMarks[i];

        Console.WriteLine("Total Marks: " + total);
        Console.WriteLine("Average Marks: " + average);
        Console.WriteLine("Students above " + threshold + ": " + aboveThreshold.Length);
        Console.WriteLine("Highest Score: " + highest);

        Console.WriteLine("\nSubject Highest Marks:");
        foreach (var kv in subjectHighest)
            Console.WriteLine(kv.Key + " : " + kv.Value);
    }
}
