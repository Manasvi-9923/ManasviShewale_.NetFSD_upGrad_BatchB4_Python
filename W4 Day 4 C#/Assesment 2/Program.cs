// DAY-4 Hands-On — Level-1 Problem 2: Stack-Based Undo (array stack, LIFO)

using System;

class EditorStack
{
    private readonly string[] items;
    private int top;

    public EditorStack(int size)
    {
        items = new string[size];
        top = -1;
    }

    public void Push(string action)
    {
        if (top == items.Length - 1)
        {
            Console.WriteLine("Stack Overflow");
            return;
        }

        items[++top] = action;
        Display();
    }

    public void Pop()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Nothing to undo");
            return;
        }

        items[top--] = null!;
        Display();
    }

    public bool IsEmpty() => top == -1;

    public void Display()
    {
        if (IsEmpty())
            Console.WriteLine("Current State: Empty");
        else
        {
            Console.Write("Current State: ");
            for (int i = 0; i <= top; i++)
                Console.Write(items[i] + " ");
            Console.WriteLine();
        }
    }

    public string CurrentStateSummary()
    {
        if (IsEmpty()) return "Empty";
        var parts = new string[top + 1];
        for (int i = 0; i <= top; i++)
            parts[i] = items[i]!;
        return string.Join(" ", parts);
    }
}

class Program
{
    static void Main()
    {
        var editor = new EditorStack(10);

        editor.Push("Type A");
        editor.Push("Type B");
        editor.Push("Type C");

        editor.Pop();
        editor.Pop();

        Console.WriteLine("Current State After Operations: " + editor.CurrentStateSummary());
    }
}
