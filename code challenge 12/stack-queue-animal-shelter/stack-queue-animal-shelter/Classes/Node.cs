using stack_queue_animal_shelter.Classes;
using System;

public class Node
{
    public ShelterAnimal Data { get; set; }
    public Node Next { get; set; }

    public Node(ShelterAnimal data)
    {
        this.Data = data;
    }
}
