namespace LinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            SinglyLinkedList test = new SinglyLinkedList();
            test.AddNodeToFront(1);
            test.AddNodeToFront(2);
            test.AddNodeToFront(3);
            test.AddNodeToFront(4);
            test.AddNodeToFront(5);
            test.AddNodeToFront(6);
            test.AddNodeToFront(7);
            Console.WriteLine(test.ExistInLinkedList(5));
            Console.WriteLine(test.StringifyLinkedList());
        }
    }
    public class LinkedListNode
    {
        public int data { get; set; }
        public LinkedListNode next { get; set; }
        public LinkedListNode(int x)
        {
            data = x;
            next = null;
        }
    }

    public class SinglyLinkedList
    {
        public LinkedListNode Head { get; set; }

        public SinglyLinkedList()
        {
            Head = null;
        }

        public void AddNodeToFront(int data)
        {

            LinkedListNode node = new LinkedListNode(data);
            if (Head == null)
            {
                Head = node;
            }
            else
            {
                node.next = Head;
                Head = node;
            }
        }

        public bool ExistInLinkedList(int data)
        {
            LinkedListNode checkExist = Head;
            while (checkExist != null)
            {
                if (checkExist.data == data)
                {
                    return true;
                }
                checkExist = checkExist.next;
            }
            return false;
        }
        public string StringifyLinkedList()
        {
            string output = "";
            LinkedListNode Reader = Head;
            while (Reader != null)
            {
                output += $"{{ {Reader.data} }} -> ";
                Reader = Reader.next;
            }
            return output += "NULL";
        }
    }

}

