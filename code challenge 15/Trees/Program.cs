using Trees.Classes;

namespace Trees
{
    public class Program
    {
        static void Main(string[] args)
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

            foreach (int x2 in x)
            {
                Console.Write(x2);
            }
        }


    }
}