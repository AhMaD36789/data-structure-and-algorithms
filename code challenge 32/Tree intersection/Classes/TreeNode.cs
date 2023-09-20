public class TreeNode
{
    public int Value { get; set; }
    public TreeNode Left { get; set; }
    public TreeNode Right { get; set; }

    public TreeNode(int value)
    {
        Value = value;
    }
}

public class TreeIntersection
{
    public static HashSet<int> FindTreeIntersection(TreeNode tree1, TreeNode tree2)
    {
        HashSet<int> set1 = new HashSet<int>();
        HashSet<int> set2 = new HashSet<int>();
        HashSet<int> intersection = new HashSet<int>();

        PopulateHashSet(tree1, set1);
        PopulateHashSet(tree2, set2);

        foreach (int value in set1)
        {
            if (set2.Contains(value))
            {
                intersection.Add(value);
            }
        }

        return intersection;
    }

    private static void PopulateHashSet(TreeNode node, HashSet<int> set)
    {
        if (node == null)
        {
            return;
        }

        set.Add(node.Value);
        PopulateHashSet(node.Left, set);
        PopulateHashSet(node.Right, set);
    }
}
