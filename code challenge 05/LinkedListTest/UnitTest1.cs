using LinkedList;

namespace LinkedListTest

{
    public class UnitTest1
    {
        [Fact]
        public void EmptyInstanceSinglyLinkedList()
        {
            //arrange
            SinglyLinkedList test = new SinglyLinkedList();
            //act
            var result = test.Head;
            //assert
            Assert.Equal(test.Head, result);
        }

        [Fact]
        public void InsertTest()
        {
            //Arrange
            SinglyLinkedList test = new SinglyLinkedList();
            //act
            test.AddNodeToFront(1);
            var result = test.Head;
            //assert
            Assert.Equal(1, test.Head.data);

        }

        [Fact]
        public void HeadAlwaysFrontOfLinkedList()
        {
            //Arrange
            SinglyLinkedList test = new SinglyLinkedList();
            //act
            test.AddNodeToFront(1);
            test.AddNodeToFront(2);
            var result = test.Head;
            //assert
            Assert.Equal(2, test.Head.data);
        }

        [Theory]
        [InlineData("{ 2 } -> { 1 } -> NULL")]
        public void InsertMultipleNodes(string expected)
        {
            //Arrange
            SinglyLinkedList test = new SinglyLinkedList();
            //act
            test.AddNodeToFront(1);
            test.AddNodeToFront(2);
            string result = test.StringifyLinkedList();
            //assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void ReturnTrueIfNodeFound()
        {
            //arrange
            SinglyLinkedList test = new SinglyLinkedList();
            //act
            test.AddNodeToFront(1);
            test.AddNodeToFront(2);
            test.AddNodeToFront(3);
            test.AddNodeToFront(4);
            bool result = test.ExistInLinkedList(1);
            //assert
            Assert.True(result);
        }


        [Fact]
        public void ReturnFalseIfNodeFound()
        {
            //arrange
            SinglyLinkedList test = new SinglyLinkedList();
            //act
            test.AddNodeToFront(1);
            test.AddNodeToFront(2);
            test.AddNodeToFront(3);
            test.AddNodeToFront(4);
            bool result = test.ExistInLinkedList(5);
            //assert
            Assert.False(result);
        }

        [Theory]
        [InlineData("{ 5 } -> { 4 } -> { 3 } -> { 2 } -> { 1 } -> NULL")]
        public void ProperReturnOfCollectionOfData(string expected)
        {
            //Arrange
            SinglyLinkedList test = new SinglyLinkedList();
            //act
            test.AddNodeToFront(1);
            test.AddNodeToFront(2);
            test.AddNodeToFront(3);
            test.AddNodeToFront(4);
            test.AddNodeToFront(5);
            string result = test.StringifyLinkedList();
            //assert
            Assert.Equal(expected, result);
        }
    }
}
