using System;

class Stack
{
    private string[] items;
    private int top;

    public Stack(int size)
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

        items[top--] = null;
        Display();
    }

    public bool IsEmpty()
    {
        return top == -1;
    }

    public void Display()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Current State: Empty");
        }
        else
        {
            Console.Write("Current State: ");
            for (int i = 0; i <= top; i++)
            {
                Console.Write(items[i] + " ");
            }
            Console.WriteLine();
        }
    }
}

class namespaceProgram
{
    static void Main()
    {
        Stack editor = new Stack(10);

        editor.Push("Type A");
        editor.Push("Type B");
        editor.Push("Type C");

        editor.Pop();
        editor.Pop();
    }
}