using linked_list_kth;

namespace linked_list_kth_Test
{
    public class UnitTest1
    {
        [Fact]
        public void TestkGreaterThanListLength()
        {
            SinglyLinkedList test = new SinglyLinkedList();
            test.Append(1);
            test.Append(3);
            test.Append(5);
            test.Append(7);
            test.Append(9);

            int result = test.KthFromEnd(7);

            Assert.Equal(-1, result);
        }
        [Fact]
        public void TestkEqualsListLength()
        {
            SinglyLinkedList test = new SinglyLinkedList();
            test.Append(1);
            test.Append(3);
            test.Append(5);
            test.Append(7);
            test.Append(9);

            int result = test.KthFromEnd(5);

            Assert.Equal(1, result);
        }

        [Fact]
        public void TestkIsANegativeNumber()
        {
            SinglyLinkedList test = new SinglyLinkedList();
            test.Append(1);
            test.Append(3);
            test.Append(5);
            test.Append(7);
            test.Append(9);

            int result = test.KthFromEnd(-5);

            Assert.Equal(-1, result);
        }

        [Fact]
        public void TestListLengthEqualsOne()
        {
            SinglyLinkedList test = new SinglyLinkedList();
            test.Append(5);

            int result = test.KthFromEnd(1);

            Assert.Equal(5, result);
        }

        [Fact]
        public void TestHappyPath()
        {
            SinglyLinkedList test = new SinglyLinkedList();
            test.Append(1);
            test.Append(3);
            test.Append(5);
            test.Append(7);
            test.Append(9);

            int result = test.KthFromEnd(2);

            Assert.Equal(5, result);

        }
    }
}