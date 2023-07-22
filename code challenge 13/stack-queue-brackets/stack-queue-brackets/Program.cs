namespace stack_queue_brackets
{
    public class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            //Console.WriteLine(stack.ValidateBrackets(""));
            Console.WriteLine(stack.ValidateBrackets("{(})"));

        }
    }
}