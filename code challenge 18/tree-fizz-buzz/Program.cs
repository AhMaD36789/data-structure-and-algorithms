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

            int[] breadth = BreadthFirstCorrectMethodPlacement(tree);
        }
        //edit on position of BreadthFirst function
        public static int[] BreadthFirstCorrectMethodPlacement(BinarySearchTree tree)
        {
            if (tree.Root == null)
                return new int[0];
            List<int> valueOrder = new List<int>();
            Queue<Node> addOrder = new Queue<Node>();
            addOrder.Enqueue(tree.Root);

            while (addOrder.Count > 0)
            {
                Node current = addOrder.Dequeue();
                valueOrder.Add(current.Value);

                if (current.Left != null)
                    addOrder.Enqueue(current.Left);
                if (current.Right != null)
                    addOrder.Enqueue(current.Right);

            }
            return valueOrder.ToArray();
        }
    }
}
