using System;

public class Node
{
    public char Data { get; set; }
    public Node Next { get; set; }

    public Node(char data)
    {
        this.Data = data;
    }
}
