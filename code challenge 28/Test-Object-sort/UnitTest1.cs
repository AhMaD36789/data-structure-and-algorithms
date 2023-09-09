using Sort_Objects_by_numerical_prop_and_by_string_prop.Classes;

namespace Test_Object_sort
{

    public class UnitTest1
    {
        [Fact]
        public void YearSortAlgorithm()
        {
            //override for assert.equal

            Movie[] movies = new Movie[5]
        {
            new Movie { title = "A Movie", year = 2012, genres = new List<string> { "Action", "Adventure" } },
            new Movie { title = "An Amazing Movie", year = 2011, genres = new List<string> { "Comedy", "Romance" } },
            new Movie { title = "The bestest Movie", year = 2003, genres = new List<string> { "Drama", "Thriller" } },
            new Movie { title = "Zelda", year = 2020, genres = new List<string> { "Sci-Fi", "Mystery" } },
            new Movie { title = "Starfield", year = 2001, genres = new List<string> { "Horror", "Fantasy" } }
        };

            Movie[] SortedByYear = movies[0].SortArrayMoviesByYear(movies);

            Movie[] expected = new Movie[5]
            {
            new Movie { title = "Starfield", year = 2001, genres = new List<string> { "Horror", "Fantasy" } },
            new Movie { title = "The bestest Movie", year = 2003, genres = new List<string> { "Drama", "Thriller" } },
            new Movie { title = "An Amazing Movie", year = 2011, genres = new List<string> { "Comedy", "Romance" } },
            new Movie { title = "A Movie", year = 2012, genres = new List<string> { "Action", "Adventure" } },
            new Movie { title = "Zelda", year = 2020, genres = new List<string> { "Sci-Fi", "Mystery" } },
            };

            Assert.Equal(expected, SortedByYear);
        }
    }
}