// DAY-4 Hands-On — Level-2 Problem 1: Employee Management (singly linked list)

using System;

class EmployeeNode
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public EmployeeNode? Next { get; set; }
}

class EmployeeList
{
    private EmployeeNode? head;

    public void InsertAtBeginning(int id, string name)
    {
        var node = new EmployeeNode { Id = id, Name = name, Next = head };
        head = node;
    }

    public void InsertAtEnd(int id, string name)
    {
        var node = new EmployeeNode { Id = id, Name = name };
        if (head == null)
        {
            head = node;
            return;
        }

        var cur = head;
        while (cur.Next != null)
            cur = cur.Next;
        cur.Next = node;
    }

    public bool DeleteById(int id)
    {
        if (head == null) return false;

        if (head.Id == id)
        {
            head = head.Next;
            return true;
        }

        var prev = head;
        while (prev.Next != null)
        {
            if (prev.Next.Id == id)
            {
                prev.Next = prev.Next.Next;
                return true;
            }
            prev = prev.Next;
        }

        return false;
    }

    public void Display()
    {
        var cur = head;
        while (cur != null)
        {
            Console.WriteLine($"{cur.Id} - {cur.Name}");
            cur = cur.Next;
        }
    }
}

class Program
{
    static void Main()
    {
        var list = new EmployeeList();

        // Insert order: (101, John), (102, Sara), (103, Mike) — end inserts preserve order
        list.InsertAtEnd(101, "John");
        list.InsertAtEnd(102, "Sara");
        list.InsertAtEnd(103, "Mike");

        list.DeleteById(102);

        Console.WriteLine("Employee List After Deletion:");
        list.Display();
    }
}
