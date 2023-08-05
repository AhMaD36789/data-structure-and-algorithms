using tree_breadth_first.classes;

namespace tree_breadth_first_test
{
    public class UnitTest1
    {
        [Fact]
        public void BreadthEmptyTree()
        {
            BinarySearchTree tree = new BinarySearchTree();
            int[] result = tree.BreadthFirstDeprecated();
            Assert.Empty(result);
        }

        [Fact]
        public void BreadthFilledTree()
        {
            BinarySearchTree tree = new BinarySearchTree();

            tree.Add(6);
            tree.Add(3);
            tree.Add(9);
            tree.Add(1);
            tree.Add(2);
            tree.Add(4);
            tree.Add(5);
            tree.Add(7);
            tree.Add(11);
            tree.Add(8);
            tree.Add(10);

            int[] expected = new int[] { 6, 3, 9, 1, 4, 7, 11, 2, 5, 8, 10 };
            int[] result = tree.BreadthFirstDeprecated();

            Assert.Equal(expected, result);
        }
    }
}