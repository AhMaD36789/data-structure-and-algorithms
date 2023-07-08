using System.Security.Cryptography.X509Certificates;

namespace zip_two_linked_lists
{
    public class Program
    {
        static void Main(string[] args)
        {
            SinglyLinkedList list1 = new SinglyLinkedList();

            list1.Append(1);
            list1.Append(1);
            list1.Append(1);
            list1.Append(1);
            list1.Append(1);

            SinglyLinkedList list2 = new SinglyLinkedList();

            list2.Append(2);
            list2.Append(2);
            list2.Append(2);
            list2.Append(2);
            list2.Append(2);
            list2.Append(2);

            SinglyLinkedList zipped = ZipLists(list1, list2);
            Console.WriteLine(zipped.StringifyLinkedList());
        }

        public static SinglyLinkedList ZipLists(SinglyLinkedList list1, SinglyLinkedList list2)
        {
            SinglyLinkedList returnList = new SinglyLinkedList();
            LinkedListNode listNode1 = list1.Head;
            LinkedListNode listNode2 = list2.Head;

            while (listNode1 != null || listNode2 != null)
            {
                if (listNode1 != null)
                {
                    returnList.Append(listNode1.data);
                    listNode1 = listNode1.next;
                }

                if (listNode2 != null)
                {
                    returnList.Append(listNode2.data);
                    listNode2 = listNode2.next;
                }
            }

            return returnList;
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