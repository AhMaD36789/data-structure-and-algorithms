using zip_two_linked_lists;

namespace zipinkedListTEST
{
    public class UnitTest1
    {
        [Fact]
        public void TestLinkedListZippingForEquallySizedLists()
        {
            SinglyLinkedList list1 = new SinglyLinkedList();

            list1.Append(1);
            list1.Append(1);
            list1.Append(1);

            SinglyLinkedList list2 = new SinglyLinkedList();

            list2.Append(2);
            list2.Append(2);
            list2.Append(2);

            SinglyLinkedList zipped = Program.ZipLists(list1, list2);
            string result = zipped.StringifyLinkedList();

            Assert.Equal("{ 1 } -> { 2 } -> { 1 } -> { 2 } -> { 1 } -> { 2 } -> NULL", result);
        }

        [Fact]
        public void TestLinkedListZippingList1BiggerThanList2()
        {
            SinglyLinkedList list1 = new SinglyLinkedList();

            list1.Append(1);
            list1.Append(1);
            list1.Append(1);
            list1.Append(1);

            SinglyLinkedList list2 = new SinglyLinkedList();

            list2.Append(2);
            list2.Append(2);
            list2.Append(2);

            SinglyLinkedList zipped = Program.ZipLists(list1, list2);
            string result = zipped.StringifyLinkedList();

            Assert.Equal("{ 1 } -> { 2 } -> { 1 } -> { 2 } -> { 1 } -> { 2 } -> { 1 } -> NULL", result);
        }

        [Fact]
        public void TestLinkedListZippingList2BiggerThanList1()
        {
            SinglyLinkedList list1 = new SinglyLinkedList();

            list1.Append(1);
            list1.Append(1);
            list1.Append(1);

            SinglyLinkedList list2 = new SinglyLinkedList();

            list2.Append(2);
            list2.Append(2);
            list2.Append(2);
            list2.Append(2);

            SinglyLinkedList zipped = Program.ZipLists(list1, list2);
            string result = zipped.StringifyLinkedList();

            Assert.Equal("{ 1 } -> { 2 } -> { 1 } -> { 2 } -> { 1 } -> { 2 } -> { 2 } -> NULL", result);
        }
    }
}