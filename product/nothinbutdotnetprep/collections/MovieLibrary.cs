using System;
using System.Collections;
using System.Collections.Generic;

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
            return movies;
        }

        public void add(Movie movie)
        {
            //if (!movies.Contains(movie))
            //    movies.Add(movie);


            int index = 0;
            for (; index < movies.Count; index++)
            {
                Movie m = movies[index];                if (movie.Equals(m) || movie.title.Equals(m.title))
                    break;
            }
            if (index >= movies.Count)
                movies.Add(movie);

        }

        public IEnumerable<Movie> sort_all_movies_by_title_descending()
        {
            List<Movie> list = new List<Movie> ( movies);
            list.Sort((m, n) => { return m.title.CompareTo(n.title); });
            return list;
        }

        public IEnumerable<Movie> all_movies_published_by_pixar()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> all_movies_published_by_pixar_or_disney()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> sort_all_movies_by_title_ascending()
        {
            throw new NotImplementedException();
        }

    }        public IEnumerable<Movie> sort_all_movies_by_movie_studio_and_year_published()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> all_movies_not_published_by_pixar()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> all_movies_published_after(int year)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> all_movies_published_between_years(int startingYear, int endingYear)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> all_kid_movies()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> all_action_movies()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> sort_all_movies_by_date_published_descending()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> sort_all_movies_by_date_published_ascending()
        {
            throw new NotImplementedException();
        }
    