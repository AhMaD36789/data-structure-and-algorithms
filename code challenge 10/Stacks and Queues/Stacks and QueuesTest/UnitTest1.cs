namespace Stacks_and_QueuesTest
{
    public class StackQueueTesting
    {
        [Fact]
        public void StackPush()
        {
            Stack stack = new Stack();
            stack.Push(1);
            var result = stack.Peek();
            Assert.Equal(1, result);

        }
        [Fact]
        public void StackMultiPush()
        {
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            string result = "";
            result += Convert.ToString(stack.Pop());
            result += Convert.ToString(stack.Pop());
            result += Convert.ToString(stack.Pop());
            Assert.True(result == "321");
        }

        [Fact]
        public void StackPop()
        {
            Stack stack = new Stack();
            stack.Push(1);
            int result = 0;
            result = stack.Pop();
            Assert.Equal(1, result);
        }

        [Fact]
        public void StackPopUntilEmpty()
        {
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Pop();
            stack.Pop();
            stack.Pop();
            Assert.Null(stack.Top);
        }

        [Fact]
        public void StackPeekNext()
        {
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Top = stack.Top.Next;
            int result = stack.Peek();
            Assert.Equal(2, result);
        }

        [Fact]
        public void StackPeekTop()
        {
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            int result = stack.Peek();
            Assert.Equal(3, result);
        }

        [Fact]
        public void ExceptionThrownOnCallingPop()
        {
            Stack stack = new Stack();
            Assert.Throws<Exception>(() => stack.Pop());
        }

        [Fact]
        public void ExceptionThrownOnCallingPeek()
        {
            Stack stack = new Stack();
            Assert.Throws<Exception>(() => stack.Pop());
        }

        [Fact]
        public void EnQueueTesting()
        {
            Queue queue = new Queue();
            queue.EnQueue(5);
            Assert.Equal(queue.Front.Data, 5);
        }

        [Fact]
        public void MultipleEnQueueTesting()
        {
            Queue queue = new Queue();
            queue.EnQueue(1);
            queue.EnQueue(2);
            queue.EnQueue(3);
            string result = "";
            result += Convert.ToString(queue.DeQueue());
            result += Convert.ToString(queue.DeQueue());
            result += Convert.ToString(queue.DeQueue());
            Assert.True(result == "123");
        }

        [Fact]
        public void DeQueueTesting()
        {
            Queue queue = new Queue();
            queue.EnQueue(1);
            queue.EnQueue(2);
            int result = queue.DeQueue();
            Assert.Equal(result, 1);
        }

        [Fact]
        public void QueuePeekTesting()
        {
            Queue queue = new Queue();
            queue.EnQueue(1);
            queue.EnQueue(2);
            int result = queue.Peek();
            Assert.Equal(result, 1);
        }

        [Fact]
        public void MultiDeQueueTesting()
        {
            Queue queue = new Queue();
            queue.EnQueue(1);
            queue.EnQueue(2);
            queue.EnQueue(3);
            queue.DeQueue();
            queue.DeQueue();
            queue.DeQueue();
            Assert.Null(queue.Front);
        }

        [Fact]
        public void EmptyQueueInstance()
        {
            Queue queue = new Queue();
            Assert.Null(queue.Front);
        }

        [Fact]
        public void ExceptionThrownOnCallingDeQueue()
        {
            Queue queue = new Queue();
            Assert.Throws<Exception>(() => queue.DeQueue());
        }

        [Fact]
        public void ExceptionThrownOnCallingQueuePeek()
        {
            Queue queue = new Queue();
            Assert.Throws<Exception>(() => queue.Peek());
        }
    }
}