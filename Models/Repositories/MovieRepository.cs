using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using hastowork.Models.Entities;

namespace hastowork.Models.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        List<Movie> movieList;
        public MovieRepository()
        {
            movieList = new List<Movie>();
            movieList.Add(new Movie{MovieItemID = 1, MovieTitle = "First task", YearPublished = 1999, Genre ="Horror",
             Director ="The Stupid Idiot", MovieLength = "1 hour 00 minutes", MoviePlot ="some looooooooong text", Rating = 5 });
            movieList.Add(new Movie{MovieItemID = 3, MovieTitle = "Second task", YearPublished = 2017, Genre ="Fiction",
             Director ="The Other Stupid Idiot", MovieLength = "1 hour 55 minutes", MoviePlot ="some looooooooong text", Rating = 1 });
            movieList.Add(new Movie{MovieItemID = 4, MovieTitle = "Third task", YearPublished = 2007, Genre ="Romance",
             Director ="The Stupidest Idiot", MovieLength = "3 hour 09 minutes", MoviePlot ="some looooooooong text", Rating = 3 });

        }

        public void Create(Movie item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            var movieX = movieList.Find(item => item.MovieItemID == id);
            movieList.Remove(movieX);
        }

        public Movie Get(int id)
        {
            return movieList.Find(item => item.MovieItemID == id);
        }

        public IEnumerable<Movie> GetAll()
        {
            return movieList;
        }

        public void Update(Movie item)
        {
            throw new NotImplementedException();
        }
    }
}
