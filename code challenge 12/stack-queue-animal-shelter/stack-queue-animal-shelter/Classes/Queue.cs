using stack_queue_animal_shelter.Classes;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;

public class Queue
{
    public Node? Front { get; set; }
    public Node? End { get; set; }

    public Queue()
    {
        Front = null;
        End = null;
    }

    public void EnQueue(ShelterAnimal value)
    {
        //only take cat or dog as animal
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

    public string DeQueue(string value)
    {
        if (Front == null)
            throw new Exception("EMPTY QUEUE");

        if (value != "dog" && value != "cat")
            return null;

        Node node = Front;
        Node previous = null;

        while (node != null)
        {
            if (node.Data.animal == value)
            {
                if (previous == null)
                {
                    Front = Front.Next;
                }
                else
                {
                    previous.Next = node.Next;
                }

                return node.Data.animal;
            }

            previous = node;
            node = node.Next;
        }

        return null;
    }


    public string StringifyLinkedList()
    {
        int count = 1;
        string output = "";
        Node Reader = Front;
        while (Reader != null)
        {
            output += $"{{ {Reader.Data.animal} }} -> ";
            count++;
            Reader = Reader.Next;
        }
        return output += "NULL";
    }

}
