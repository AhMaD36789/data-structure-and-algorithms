using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueUsingTwoStacks.Classes
{
    public class PseudoQueue
    {
        public Stack stack1;
        public Stack stack2;
        public PseudoQueue()
        {
            stack1 = new Stack();
            stack2 = new Stack();
        }

        public void EnQueueUsingStack(int value)
        {
            stack1.Push(value);
        }

        public int DeQueueUsingStack()
        {
            if (stack2.IsEmpty())
            {
                while (!stack1.IsEmpty())
                {
                    stack2.Push(stack1.Pop());
                }
            }

            return stack2.Pop();
        }
    }
}
