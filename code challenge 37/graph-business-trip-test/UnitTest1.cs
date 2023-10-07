using codechallenge37;

namespace graph_business_trip_test
{
    public class UnitTest1
    {
        [Fact]
        public void TestBusinessTrip_PossibleTrip()
        {
            Graph graph = new Graph();
            graph.AddCity("A");
            graph.AddCity("B");
            graph.AddCity("C");
            graph.AddFlight("A", "B", 100);
            graph.AddFlight("B", "C", 150);

            string[] itinerary = { "A", "B", "C" };
            int? result = AlaskaTrip.BusinessTrip(graph, itinerary);

            Assert.Equal(250, result);
        }

        [Fact]
        public void TestBusinessTrip_ImpossibleTrip()
        {
            Graph graph = new Graph();
            graph.AddCity("A");
            graph.AddCity("B");
            graph.AddCity("C");
            graph.AddFlight("A", "B", 100);

            string[] itinerary = { "A", "C" };
            int? result = AlaskaTrip.BusinessTrip(graph, itinerary);

            Assert.Null(result);
        }

    }
}