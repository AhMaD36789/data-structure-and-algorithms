using Trees.Classes;

namespace tree_max_xunit
{
    public class UnitTest1
    {
        [Fact]
        public void MaxIsRoot()
        {
            BinarySearchTree tree = new BinarySearchTree();
            tree.Add(11);
            tree.Add(3);
            tree.Add(1);
            tree.Add(2);
            tree.Add(4);
            tree.Add(5);
            tree.Add(9);
            tree.Add(7);
            tree.Add(8);
            tree.Add(6);
            tree.Add(10);

            int result = tree.SortedMax();

            Assert.Equal(11, result);
        }
        [Fact]
        public void MaxInsideTree()
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

            Assert.Equal(11, tree.SortedMax());
        }

        [Fact]
        public void MaxEmptyTree()
        {
            BinarySearchTree tree = new BinarySearchTree();
            Assert.Throws<Exception>(() => tree.SortedMax());
        }
        [Fact]
        public void UnsortedMaxIsRoot()
        {
            BinarySearchTree tree = new BinarySearchTree();
            tree.Add(11);
            tree.Add(3);
            tree.Add(1);
            tree.Add(2);
            tree.Add(4);
            tree.Add(5);
            tree.Add(9);
            tree.Add(7);
            tree.Add(8);
            tree.Add(6);
            tree.Add(10);

            int result = tree.UnSortedMax();

            Assert.Equal(11, result);
        }
        [Fact]
        public void UnsortedMaxInsideTree()
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

            Assert.Equal(11, tree.UnSortedMax());
        }

        [Fact]
        public void UnsortedMaxEmptyTree()
        {
            BinarySearchTree tree = new BinarySearchTree();
            Assert.Throws<Exception>(() => tree.UnSortedMax());
        }
    }
}