namespace linked_list_kth
{
    public class Program
    {
        static void Main(string[] args)
        {
            SinglyLinkedList test = new SinglyLinkedList();
            //test.AddNodeToFront(Convert.ToInt32(Console.ReadLine()));
            test.AddNodeToFront(1);
            test.AddNodeToFront(2);
            test.AddNodeToFront(3);
            test.AddNodeToFront(4);
            test.AddNodeToFront(5);
            test.AddNodeToFront(6);
            test.AddNodeToFront(7);
            Console.WriteLine(test.StringifyLinkedList());
            //Console.WriteLine(test.ExistInLinkedList(5));
            //Console.WriteLine(test.StringifyLinkedList());
            //test.Append(Convert.ToInt32(Console.ReadLine()));
            //Console.WriteLine(test.StringifyLinkedList());
            //test.InsertBefore(Convert.ToInt32(Console.ReadLine()), (Convert.ToInt32(Console.ReadLine())));
            //Console.WriteLine(test.StringifyLinkedList());
            //test.InsertAfter(Convert.ToInt32(Console.ReadLine()), (Convert.ToInt32(Console.ReadLine())));
            //Console.WriteLine(test.StringifyLinkedList());
            Console.WriteLine(test.KthFromEnd(Convert.ToInt32(Console.ReadLine())));
            //Console.WriteLine(test.StringifyLinkedList());


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

        //CC06 starts here
        public void Append(int data)
        {
            LinkedListNode newNode = new LinkedListNode(data);
            if (Head == null)
            {
                Head = newNode;
                return;
            }
            LinkedListNode searchingListEnd = Head;
            while (searchingListEnd.next != null)
            {
                searchingListEnd = searchingListEnd.next;
            }
            searchingListEnd.next = newNode;
        }


        public void InsertBefore(int before, int data)
        {
            LinkedListNode newNode = new LinkedListNode(data);
            LinkedListNode searchingList = Head;
            if (Head == null || Head.data == before)
            {
                newNode.next = Head;
                Head = newNode;
                return;
            }
            while (searchingList.next.data != before)
            {
                searchingList = searchingList.next;
            }
            newNode.next = searchingList.next;
            searchingList.next = newNode;
        }

        public void InsertAfter(int after, int data)
        {
            LinkedListNode newNode = new LinkedListNode(data);
            LinkedListNode searchingList = Head;
            while (searchingList.data != after)
            {
                searchingList = searchingList.next;
            }
            newNode.next = searchingList.next;
            searchingList.next = newNode;
        }

        // CC 07

        public int KthFromEnd(int k)
        {
            try
            {
                if (k < 0)
                {
                    throw new Exception("please enter a positive number");
                }
                LinkedListNode looper = new LinkedListNode(0);
                int listLength = 0;
                int position;
                looper = Head;
                while (looper != null)
                {
                    looper = looper.next;
                    listLength++;
                }

                if (k > listLength)
                {
                    throw new Exception("k greater than list length");
                }

                if (listLength == k)
                    return Head.data;

                position = listLength - k;
                looper = Head;
                while (position != 1)
                {
                    position--;
                    looper = looper.next;
                }
                return looper.data;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return -1;
            }
        }

    }
}