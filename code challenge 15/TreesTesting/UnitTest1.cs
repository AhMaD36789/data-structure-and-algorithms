using Trees.Classes;

namespace TreesTesting
{
    public class UnitTest1
    {
        [Fact]
        public void EmptyTreeInstance()
        {
            BinarySearchTree tree = new BinarySearchTree();
            Assert.Null(tree.Root);
        }

        [Fact]
        public void RootedTreeInstance()
        {
            BinarySearchTree tree = new BinarySearchTree(5);
            Assert.NotNull(tree.Root);
        }
        [Fact]
        public void LeftChildAddition()
        {
            BinarySearchTree tree = new BinarySearchTree(5);
            tree.Add(4);
            Assert.Equal(tree.Root.Left.Value, 4);
        }
        [Fact]
        public void RightChildAddition()
        {
            BinarySearchTree tree = new BinarySearchTree(5);
            tree.Add(6);
            Assert.Equal(tree.Root.Right.Value, 6);
        }

        [Fact]
        public void PostOrderTravesal()
        {
            BinarySearchTree tree = new BinarySearchTree();
            tree.Add(6);
            tree.Add(3);
            tree.Add(1);
            tree.Add(2);
            tree.Add(4);
            tree.Add(5);
            tree.Add(9);
            tree.Add(7);
            tree.Add(8);
            tree.Add(11);
            tree.Add(10);

            List<int> list = new List<int>();
            int[] x = tree.PostOrder(tree.Root, list);
            int[] expected = new int[] { 2, 1, 5, 4, 3, 8, 7, 10, 11, 9, 6 };
            Assert.Equal(expected, x);
        }
        [Fact]
        public void PreOrderTravesal()
        {
            BinarySearchTree tree = new BinarySearchTree();
            tree.Add(6);
            tree.Add(3);
            tree.Add(1);
            tree.Add(2);
            tree.Add(4);
            tree.Add(5);
            tree.Add(9);
            tree.Add(7);
            tree.Add(8);
            tree.Add(11);
            tree.Add(10);

            List<int> list = new List<int>();
            int[] x = tree.PreOrder(tree.Root, list);
            int[] expected = new int[] { 6, 3, 1, 2, 4, 5, 9, 7, 8, 11, 10 };
            Assert.Equal(expected, x);
        }
        [Fact]
        public void InOrderTravesal()
        {
            BinarySearchTree tree = new BinarySearchTree();
            tree.Add(6);
            tree.Add(3);
            tree.Add(1);
            tree.Add(2);
            tree.Add(4);
            tree.Add(5);
            tree.Add(9);
            tree.Add(7);
            tree.Add(8);
            tree.Add(11);
            tree.Add(10);

            List<int> list = new List<int>();
            int[] x = tree.InOrder(tree.Root, list);
            int[] expected = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            Assert.Equal(expected, x);
        }
        [Fact]
        public void ContainsTrue()
        {
            BinarySearchTree tree = new BinarySearchTree();
            tree.Add(6);
            tree.Add(3);
            tree.Add(1);
            tree.Add(2);
            tree.Add(4);
            tree.Add(5);
            tree.Add(9);
            tree.Add(7);
            tree.Add(8);
            tree.Add(11);
            tree.Add(10);

            Assert.True(tree.Contains(10));
        }
        [Fact]
        public void ContainsFalse()
        {
            BinarySearchTree tree = new BinarySearchTree();
            tree.Add(6);
            tree.Add(3);
            tree.Add(1);
            tree.Add(2);
            tree.Add(4);
            tree.Add(5);
            tree.Add(9);
            tree.Add(7);
            tree.Add(8);
            tree.Add(11);
            tree.Add(10);

            Assert.False(tree.Contains(12));
        }

    }
}