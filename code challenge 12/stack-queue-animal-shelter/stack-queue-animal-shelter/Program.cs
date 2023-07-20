namespace stack_queue_animal_shelter
{
    public class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            queue.EnQueue(new Classes.ShelterAnimal("cat"));
            queue.EnQueue(new Classes.ShelterAnimal("dog"));
            queue.EnQueue(new Classes.ShelterAnimal("cat"));
            queue.EnQueue(new Classes.ShelterAnimal("dog"));
            queue.EnQueue(new Classes.ShelterAnimal("cat"));
            queue.EnQueue(new Classes.ShelterAnimal("dog"));
            queue.EnQueue(new Classes.ShelterAnimal("cat"));
            queue.DeQueue("dog");
            Console.WriteLine(queue.StringifyLinkedList());

        }
    }
}