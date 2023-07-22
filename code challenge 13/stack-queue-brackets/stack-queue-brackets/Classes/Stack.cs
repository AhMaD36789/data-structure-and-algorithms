using System;


public class Stack
{
    public Node? Top { get; set; }

    public Stack()
    {
        Top = null;
    }

    public void Push(char value)
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

    public char Pop()
    {
        if (Top == null)
            throw new Exception("EMPTY STACK");
        char returnValue = Top.Data;
        Top = Top.Next;
        return returnValue;
    }

    public char Peek()
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

    public string StringifyLinkedList()
    {
        int count = 1;
        string output = "";
        Node Reader = Top;
        while (Reader != null)
        {
            output += $" --- {Reader.Data} --- -> ";
            count++;
            Reader = Reader.Next;
        }
        return output += "NULL";
    }

    public bool ValidateBrackets(string input)
    {

        foreach (char ch in input)
        {
            if (ch == '(' || ch == '{' || ch == '[')
            {
                Push(ch);
            }

            switch (ch)
            {
                case ')':
                    if (Top.Data == '(')
                    {
                        Pop();
                        break;
                    }
                    return false;


                case ']':
                    if (Top.Data == '[')
                    {
                        Pop();
                        break;
                    }
                    return false;

                case '}':
                    if (Top.Data == '{')
                    {
                        Pop();
                        break;
                    }
                    return false;
                default: continue;
            }

        }
        return true;

    }
}
