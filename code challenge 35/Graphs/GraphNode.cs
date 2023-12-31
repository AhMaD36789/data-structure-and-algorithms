﻿namespace Graphs
{
    public class GraphNode
    {
        public string Value { get; set; }
        public List<GraphNodeEdge> Edges { get; } = new List<GraphNodeEdge>();

        public GraphNode(string val)
        {
            Value = val;
        }

        public GraphNode(string val, GraphNode node1, GraphNode node2)
        {
            Value = val;
            Edges.Add(new GraphNodeEdge(node1, node2));
        }
    }

    public class GraphNodeEdge
    {
        public GraphNode Node1 { get; set; }
        public GraphNode Node2 { get; set; }
        public int EdgeWeight { get; set; }

        public GraphNodeEdge(GraphNode node1, GraphNode node2)
        {
            Node1 = node1;
            Node2 = node2;
        }

        public GraphNodeEdge(GraphNode node1, GraphNode node2, int weight)
        {
            Node1 = node1;
            Node2 = node2;
            EdgeWeight = weight;
        }
    }
}

