using QueueUsingTwoStacks.Classes;

namespace QueueUsingTwoStacks
{
    public class Program
    {
        static void Main(string[] args)
        {
            PseudoQueue x = new PseudoQueue();
            x.EnQueueUsingStack(1);
            x.EnQueueUsingStack(2);
            x.EnQueueUsingStack(3);
            x.EnQueueUsingStack(4);
            x.EnQueueUsingStack(5);
            x.DeQueueUsingStack();
        }
    }
}