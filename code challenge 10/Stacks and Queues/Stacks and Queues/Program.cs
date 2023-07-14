namespace Stacks_and_Queues
{
    public class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            queue.EnQueue(1);
            queue.EnQueue(2);
            queue.EnQueue(3);
            string result = "";
            result += Convert.ToString(queue.DeQueue());
            result += Convert.ToString(queue.DeQueue());
            result += Convert.ToString(queue.DeQueue());
            Console.WriteLine(result);
        }
    }
}