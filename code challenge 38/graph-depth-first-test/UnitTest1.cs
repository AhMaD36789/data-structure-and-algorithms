using graph_depth_first;

namespace graph_depth_first_test
{
    public class UnitTest1
    {
        [Fact]
        public void TestDepthFirstSingleNode()
        {
            // Arrange
            Graph graph = new Graph();
            Node node1 = new Node("1");
            graph.Nodes.Add(node1);

            // Act
            List<Node> result = graph.DepthFirst(node1);

            // Assert
            List<string> expectedValues = new List<string> { "1" };
            List<string> actualValues = result.Select(node => node.Value).ToList();

            Assert.Equal(expectedValues, actualValues);
        }

        [Fact]
        public void TestDepthFirstDisconnectedGraph()
        {
            // Arrange
            Graph graph = new Graph();
            Node node1 = new Node("1");
            Node node2 = new Node("2");
            Node node3 = new Node("3");

            graph.Nodes.Add(node1);
            graph.Nodes.Add(node2);
            graph.Nodes.Add(node3);

            // Act
            List<Node> result = graph.DepthFirst(node1);

            // Assert
            List<string> expectedValues = new List<string> { "1" };
            List<string> actualValues = result.Select(node => node.Value).ToList();

            Assert.Equal(expectedValues, actualValues);
        }
    }
}