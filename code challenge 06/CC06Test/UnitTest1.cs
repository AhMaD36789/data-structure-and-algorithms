using CC06;

namespace CC06Test
{
    public class UnitTest1
    {
        [Fact]
        public void appendLast()
        //testing successful addition and testing multiple insertions to the end of the list
        {
            SinglyLinkedList test = new SinglyLinkedList();
            test.Append(1);
            test.Append(2);
            test.Append(3);
            test.Append(4);

            string result = test.StringifyLinkedList();

            Assert.Equal("{ 1 } -> { 2 } -> { 3 } -> { 4 } -> NULL", result);

        }

        [Fact]
        public void MiddleBeforeIndexInsert()
        // testing an insertion using insert before method 
        {
            SinglyLinkedList test = new SinglyLinkedList();
            test.Append(1);
            test.Append(2);
            test.Append(4);
            test.InsertBefore(3, 4);

            string result = test.StringifyLinkedList();

            Assert.Equal("{ 1 } -> { 2 } -> { 3 } -> { 4 } -> NULL", result);

        }

        [Fact]
        public void BeforeFirstListInsert()
        //testing insertion before the first element in the array
        {
            SinglyLinkedList test = new SinglyLinkedList();
            test.Append(2);
            test.Append(3);
            test.Append(4);
            test.InsertBefore(1, 2);

            string result = test.StringifyLinkedList();

            Assert.Equal("{ 1 } -> { 2 } -> { 3 } -> { 4 } -> NULL", result);

        }

        [Fact]
        public void MiddleAfterIndexInsert()
        // testing insertion after a specific index
        {
            SinglyLinkedList test = new SinglyLinkedList();
            test.Append(1);
            test.Append(2);
            test.Append(4);
            test.InsertAfter(3, 2);

            string result = test.StringifyLinkedList();

            Assert.Equal("{ 1 } -> { 2 } -> { 3 } -> { 4 } -> NULL", result);

        }

        [Fact]
        public void AfterLastListInsert()
        // testing insertion at the end of the list using insert after and not append
        {
            SinglyLinkedList test = new SinglyLinkedList();
            test.Append(1);
            test.Append(2);
            test.Append(3);
            test.InsertAfter(4, 3);

            string result = test.StringifyLinkedList();

            Assert.Equal("{ 1 } -> { 2 } -> { 3 } -> { 4 } -> NULL", result);

        }
    }
}