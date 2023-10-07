namespace codechallenge37
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }


    public class Graph
    {
        public Dictionary<string, Dictionary<string, int>> AdjacencyList { get; }

        public Graph()
        {
            AdjacencyList = new Dictionary<string, Dictionary<string, int>>();
        }

        public void AddCity(string city)
        {
            if (!AdjacencyList.ContainsKey(city))
            {
                AdjacencyList[city] = new Dictionary<string, int>();
            }
        }

        public void AddFlight(string fromCity, string toCity, int cost)
        {
            if (AdjacencyList.ContainsKey(fromCity))
            {
                AdjacencyList[fromCity][toCity] = cost;
            }
        }
    }

    public static class AlaskaTrip
    {
        public static int? BusinessTrip(Graph graph, string[] itinerary)
        {
            if (itinerary.Length < 2)
            {
                return 0; // A trip with 0 or 1 cities has a cost of 0.
            }

            int totalCost = 0;

            for (int i = 0; i < itinerary.Length - 1; i++)
            {
                string fromCity = itinerary[i];
                string toCity = itinerary[i + 1];

                if (!graph.AdjacencyList.ContainsKey(fromCity) ||
                    !graph.AdjacencyList[fromCity].ContainsKey(toCity))
                {
                    return null; // Direct flight not available for this segment of the trip.
                }

                totalCost += graph.AdjacencyList[fromCity][toCity];
            }

            return totalCost;
        }
    }

}