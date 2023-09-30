namespace Graphs
{
    public class Graph
    {
        public List<GraphNode> ListNodes { get; } = new List<GraphNode>();

        public GraphNode CreateVertex(string value)
        {
            GraphNode newGN = new GraphNode(value);
            ListNodes.Add(newGN);
            return newGN;
        }

        public void AddEdgeWithWeight(GraphNode node1, GraphNode node2, int weight)
        {
            node1.Edges.Add(new GraphNodeEdge(node1, node2, weight));
            node2.Edges.Add(new GraphNodeEdge(node1, node2, weight));
        }

        public void AddEdge(GraphNode node1, GraphNode node2)
        {
            GraphNodeEdge nodeEdge = new GraphNodeEdge(node1, node2);
            node1.Edges.Add(nodeEdge);
            node2.Edges.Add(nodeEdge);
        }

        public List<GraphNode> Neighbors(GraphNode node)
        {
            List<GraphNode> NeighborsNode = new List<GraphNode>();
            GraphNode selectedNode = ListNodes.Find(nodes => nodes == node);

            if (selectedNode != null)
            {
                foreach (GraphNodeEdge edge in selectedNode.Edges)
                {
                    NeighborsNode.Add(edge.Node2);
                }
            }

            return NeighborsNode;
        }

        public List<GraphNode> Vertices()
        {
            return ListNodes;
        }

        public int Size()
        {
            return ListNodes.Count;
        }
    }
}

