using System;

public class Queue
{
    public Node? Front { get; set; }
    public Node? End { get; set; }

    public Queue()
    {
        Front = null;
        End = null;
    }

    public void EnQueue(int value)
    {
        Node node = new Node(value);
        if (Front == null)
        {
            Front = node;
            End = node;
        }
        else
        {
            End.Next = node;
            End = node;
        }

    }

    public int DeQueue()
    {
        if (Front == null)
        {
            throw new Exception("EMPTY QUEUE");
        }

        int returnValue = Front.Data;
        Front = Front.Next;
        return returnValue;
    }

    public int Peek()
    {
        if (Front == null)
            throw new Exception("EMPTY QUEUE");
        return Front.Data;
    }

    public bool IsEmpty()
    {
        if (Front == null)
            return false;
        return true;
    }

    
}
