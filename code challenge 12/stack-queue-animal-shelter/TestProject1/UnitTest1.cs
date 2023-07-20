using System.Collections;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void EnQueue()
        {
            Queue q = new Queue();
            q.Enqueue(1);
            Assert.Single(q);
        }

        [Fact]
        public void DeQueue()
        {
            Queue q = new Queue();
            q.Enqueue(1);
            q.Dequeue();
            Assert.Empty(q);
        }
    }
}