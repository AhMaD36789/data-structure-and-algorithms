using codechallenge36;

namespace graph_breadth_first_test
{
    public class UnitTest1
    {
        [Fact]
        public void TestBreadthFirst()
        {
            // Create nodes
            Node node1 = new Node { Value = 1 };
            Node node2 = new Node { Value = 2 };
            Node node3 = new Node { Value = 3 };
            Node node4 = new Node { Value = 4 };
            Node node5 = new Node { Value = 5 };

            // Build a simple graph
            node1.Neighbors.Add(node2);
            node1.Neighbors.Add(node3);
            node2.Neighbors.Add(node4);
            node3.Neighbors.Add(node5);

            Graph graph = new Graph { Nodes = new List<Node> { node1, node2, node3, node4, node5 } };

            List<Node> result = graph.BreadthFirst(node1);

            Assert.Equal(5, result.Count);
            Assert.Equal(new[] { node1, node2, node3, node4, node5 }, result);
        }
    }
}