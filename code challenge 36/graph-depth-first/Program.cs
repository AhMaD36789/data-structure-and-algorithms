namespace codechallenge36
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
        public int Value { get; set; }
        public List<Node> Neighbors { get; set; }

        public Node()
        {
            Neighbors = new List<Node>();
        }
    }

    public class Graph
    {
        public List<Node> Nodes { get; set; }

        public List<Node> BreadthFirst(Node startNode)
        {
            List<Node> visitedNodes = new List<Node>();
            Queue<Node> queue = new Queue<Node>();

            if (startNode != null)
            {
                queue.Enqueue(startNode);
                visitedNodes.Add(startNode);
            }

            while (queue.Count > 0)
            {
                Node currentNode = queue.Dequeue();

                foreach (Node neighbor in currentNode.Neighbors)
                {
                    if (!visitedNodes.Contains(neighbor))
                    {
                        queue.Enqueue(neighbor);
                        visitedNodes.Add(neighbor);
                    }
                }
            }

            return visitedNodes;
        }
    }

}