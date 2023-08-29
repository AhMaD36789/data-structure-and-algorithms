namespace tree_breadth_first.classes
{
    public class BinaryTree
    {
        public int[] PreOrder(Node node, List<int> list)
        {
            if (node == null)
                return new int[0];
            list.Add(node.Value);
            PreOrder(node.Left, list);
            PreOrder(node.Right, list);
            return list.ToArray();
        }

        public int[] InOrder(Node node, List<int> list)
        {
            if (node == null)
                return new int[0];
            InOrder(node.Left, list);
            list.Add(node.Value);
            InOrder(node.Right, list);
            return list.ToArray();
        }

        public int[] PostOrder(Node node, List<int> list)
        {
            if (node == null)
                return new int[0];
            PostOrder(node.Left, list);
            PostOrder(node.Right, list);
            list.Add(node.Value);
            return list.ToArray();
        }
    }
}
