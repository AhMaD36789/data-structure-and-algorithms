using QueueUsingTwoStacks.Classes;

namespace TestPseudoQueue
{
    public class UnitTest1
    {
        [Fact]
        public void TestEnqueueUsingStack()
        {
            PseudoQueue x = new PseudoQueue();
            x.EnQueueUsingStack(20);
            x.EnQueueUsingStack(15);
            x.EnQueueUsingStack(10);
            x.EnQueueUsingStack(5);
            Assert.Equal(5, x.stack1.Top.Data);
        }

        [Fact]
        public void TestDeQueueUsingStack()
        {
            PseudoQueue x = new PseudoQueue();
            x.EnQueueUsingStack(20);
            x.EnQueueUsingStack(15);
            x.EnQueueUsingStack(10);
            x.EnQueueUsingStack(5);
            int result = x.DeQueueUsingStack();
            Assert.Equal(20, result);
        }
    }
}