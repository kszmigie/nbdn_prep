using System.Collections.Generic;
using nothinbutdotnetprep.infrastructure;

namespace nothinbutdotnetprep.collections
{
    public class MovieLibrary
    {
        IList<Movie> movies;

        public MovieLibrary(IList<Movie> list_of_movies)
        {
            this.movies = list_of_movies;
        }

        public IEnumerable<Movie> all_movies()
        {
            return movies.one_at_a_time();
        }

        public void add(Movie movie)
        {
            if (already_contains(movie)) return;

            movies.Add(movie);
        }

        bool already_contains(Movie movie)
        {
            return movies.Contains(movie);
        }

        public IEnumerable<Movie> sort_all_movies_by_title_ascending()
        {
            var listOfMovies = new List<Movie>(movies);

            listOfMovies.Sort((x, y) => { return x.title.CompareTo(y.title); });

            return listOfMovies;
        }

        public IEnumerable<Movie> sort_all_movies_by_movie_studio_and_year_published()
        {
            var listOfMovies = new List<Movie>(movies);

            var rating = new Dictionary<ProductionStudio, int>
            {
                {ProductionStudio.MGM, 1},
                {ProductionStudio.Pixar, 2},
                {ProductionStudio.Dreamworks, 3},
                {ProductionStudio.Universal, 4},
                {ProductionStudio.Disney, 5}
            };

            //MGM
            //Pixar
            //Dreamworks
            //Universal
            //Disney

            listOfMovies.Sort((x, y) =>
            {
                var studioComparison = rating[x.production_studio].CompareTo(rating[y.production_studio]);

                if (studioComparison == 0)
                {
                    studioComparison = x.date_published.CompareTo(y.date_published);
                }

                return studioComparison;
            });

            return listOfMovies;
        }

        public IEnumerable<Movie> sort_all_movies_by_title_descending()
        {
            var listOfMovies = new List<Movie>(movies);

            listOfMovies.Sort((x, y) => { return y.title.CompareTo(x.title); });

            return listOfMovies;
        }

        public IEnumerable<Movie> sort_all_movies_by_date_published_descending()
        {
            var listOfMovies = new List<Movie>(movies);

            listOfMovies.Sort((x, y) => { return y.date_published.CompareTo(x.date_published); });

            return listOfMovies;
        }

        public IEnumerable<Movie> sort_all_movies_by_date_published_ascending()
        {
            var listOfMovies = new List<Movie>(movies);

            listOfMovies.Sort((x, y) => { return x.date_published.CompareTo(y.date_published); });

            return listOfMovies;
        }

        public bool is_a_kids_movie(Movie movie)
        {
            return movie.genre == Genre.kids;
        }
    }
}