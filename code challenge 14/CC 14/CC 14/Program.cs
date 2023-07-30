namespace CC_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push(9);
            stack.Push(15);
            stack.Push(20);
            stack.Push(5);
            stack.Push(6);

            Console.WriteLine(stack.MaxStack());

        }
    }
}