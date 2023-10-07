namespace graph_depth_first
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public class Node
    {
        public string Value { get; set; }
        public List<Node> Neighbors { get; set; }

        public Node(string value)
        {
            Value = value;
            Neighbors = new List<Node>();
        }
    }
    public class Graph
    {
        public List<Node> Nodes { get; set; }

        public Graph()
        {
            Nodes = new List<Node>();
        }

        public List<Node> DepthFirst(Node start)
        {
            List<Node> result = new List<Node>();
            HashSet<Node> visited = new HashSet<Node>();

            Stack<Node> stack = new Stack<Node>();
            stack.Push(start);

            while (stack.Count > 0)
            {
                Node tempNode = stack.Pop();

                if (!visited.Contains(tempNode))
                {
                    result.Add(tempNode);
                    visited.Add(tempNode);

                    foreach (var neighbor in tempNode.Neighbors)
                    {
                        stack.Push(neighbor);
                    }
                }
            }

            return result;
        }

    }

}