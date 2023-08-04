using tree_breadth_first.classes;

namespace tree_breadth_first
{
    internal class Program
    {
        static void Main(string[] args)
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

            Console.WriteLine("Tree Structure:");
            PrintTree(tree.Root);

            Console.WriteLine("Breadth-First Traversal:");
            int[] result = tree.BreadthFirst();
            Console.WriteLine(string.Join(", ", result));
        }

        private static void PrintTree(Node node, string prefix = "", bool isLeft = true)
        {
            if (node != null)
            {
                Console.WriteLine(prefix + (isLeft ? "|-- " : "\\-- ") + node.Value);
                PrintTree(node.Left, prefix + (isLeft ? "|   " : "    "), true);
                PrintTree(node.Right, prefix + (isLeft ? "|   " : "    "), false);
            }
        }
    }
}
