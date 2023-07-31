namespace Trees.Classes
{
    public class BinarySearchTree : BinaryTree
    {
        public Node? Root { get; set; }

        public BinarySearchTree()
        {
            Root = null;
        }
        public BinarySearchTree(int value)
        {
            Root = new Node(value);
        }

        public void Add(int value)
        {
            if (Root == null)
            {
                Root = new Node(value);
                return;
            }

            Node node = Root;
            while (true)
            {
                if (value < node.Value)
                {
                    if (node.Left == null)
                    {
                        node.Left = new Node(value);
                        break;
                    }
                    else
                    {
                        node = node.Left;
                    }
                }
                else
                {
                    if (node.Right == null)
                    {
                        node.Right = new Node(value);
                        break;
                    }
                    else
                    {
                        node = node.Right;
                    }
                }
            }
        }

        public bool Contains(int value)
        {
            Node node = Root;
            while (node != null)
            {
                if (value == node.Value)
                {
                    return true;
                }
                else if (value < node.Value)
                {
                    node = node.Left;
                }
                else
                {
                    node = node.Right;
                }
            }
            return false;
        }

        public int SortedMax()
        {
            if (Root == null)
                throw new Exception("EMPTY TREE! add some elements");
            Node node = Root;
            int max = Root.Value;
            while (node.Right != null)
            {
                node = node.Right;
                max = node.Value;
            }
            return max;
        }

        public int UnSortedMax()
        {
            if (Root == null)
                throw new Exception("EMPTY TREE! add some elements");
            List<int> list = new List<int>();
            int[] arr = InOrder(Root, list);
            return arr[arr.Length - 1];
        }
    }
}
