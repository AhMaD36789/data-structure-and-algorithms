using Graphs;

namespace Graph_unit_test
{
    public class UnitTest1
    {
        [Fact]
        public void Add_Vertex_Test()
        {
            // Arrange
            Graph graph = new Graph();

            // Act
            GraphNode nodeA = graph.CreateVertex("A");

            // Assert
            Assert.NotNull(nodeA);
            Assert.Equal("A", nodeA.Value);
            Assert.Single(graph.ListNodes);
        }

        [Fact]
        public void Add_Edge_Test()
        {
            // Arrange
            Graph graph = new Graph();
            GraphNode nodeA = graph.CreateVertex("A");
            GraphNode nodeB = graph.CreateVertex("B");

            // Act
            graph.AddEdgeWithWeight(nodeA, nodeB, 5);

            // Assert
            Assert.Single(nodeA.Edges);
            Assert.Single(nodeB.Edges);
        }

        [Fact]
        public void Get_Vertices_Test()
        {
            // Arrange
            Graph graph = new Graph();
            GraphNode nodeA = graph.CreateVertex("A");
            GraphNode nodeB = graph.CreateVertex("B");

            // Act
            var vertices = graph.Vertices();

            // Assert
            Assert.Equal(2, vertices.Count);
            Assert.Contains(nodeA, vertices);
            Assert.Contains(nodeB, vertices);
        }

        [Fact]
        public void Neighbors_Test()
        {
            // Arrange
            Graph graph = new Graph();
            GraphNode nodeA = graph.CreateVertex("A");
            GraphNode nodeB = graph.CreateVertex("B");
            graph.AddEdgeWithWeight(nodeA, nodeB, 5);

            // Act
            var neighbors = graph.Neighbors(nodeA);

            // Assert
            Assert.Single(neighbors);
            Assert.Equal(nodeB, neighbors[0]);
        }

        [Fact]
        public void Neighbors_With_Weight_Test()
        {
            // Arrange
            Graph graph = new Graph();
            GraphNode nodeA = graph.CreateVertex("A");
            GraphNode nodeB = graph.CreateVertex("B");
            graph.AddEdgeWithWeight(nodeA, nodeB, 5);

            // Act
            var edge = nodeA.Edges[0];

            // Assert
            Assert.Equal(5, edge.EdgeWeight);
        }

        [Fact]
        public void Size_Success_Test()
        {
            // Arrange
            Graph graph = new Graph();
            GraphNode nodeA = graph.CreateVertex("A");
            GraphNode nodeB = graph.CreateVertex("B");

            // Act
            var size = graph.Size();

            // Assert
            Assert.Equal(2, size);
        }

        [Fact]
        public void Single_Vertex_Edge_Test()
        {
            // Arrange
            Graph graph = new Graph();
            GraphNode nodeA = graph.CreateVertex("A");

            // Act
            var vertices = graph.Vertices();
            var neighbors = graph.Neighbors(nodeA);

            // Assert
            Assert.Single(vertices);
            Assert.Empty(neighbors);
        }
    }
}