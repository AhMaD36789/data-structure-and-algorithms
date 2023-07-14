using System;


public class Stack
{
    public Node? Top { get; set; }

    public Stack()
    {
        Top = null;
    }

    public void Push(int value)
    {
        Node node = new Node(value);
        if (Top == null)
        {
            Top = node;
        }

        else
        {
            node.Next = Top;
            Top = node;
        }
    }

    public int Pop()
    {
        if (Top == null)
            throw new Exception("EMPTY STACK");
        int returnValue = Top.Data;
        Top = Top.Next;
        return returnValue;
    }

    public int Peek()
    {
        if (Top == null)
            throw new Exception("EMPTY STACK");
        return Top.Data;
    }

    public bool IsEmpty()
    {
        if (Top == null)
            return false;
        return true;
    }
}
