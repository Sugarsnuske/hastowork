using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using hastowork.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace hastowork.Models.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private MyDbContext _db;
        private DbSet<Movie> _movies;

        public MovieRepository(MyDbContext db)
        {
            _db = db;
            _movies = db.Movies;
        }

        /*public void Create(Movie item)
        {
            throw new NotImplementedException();
        }

        public void Delete(Movie mo)
        {
            Movie movie = _db.Movies.Find(mo.MovieItemID);
            _db.Movies.Remove(movie);
            _db.SaveChanges();
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
        }*/

        public void Delete(Movie mo)
            {
             Movie movie = _db.Movies.Find(mo.MovieItemID);
             _db.Movies.Remove(movie);
             _db.SaveChanges();
            }

        public Movie Get(int id)
        {
            Movie movie =  _db.Movies.Find(id);
            return movie;
        }

        public IEnumerable<Movie> GetAll()
        {
            IEnumerable<Movie> movies = _db.Movies;
            return movies;
        }

        public void Save(Movie movie)
        {
            _db.Movies.Add(movie);
            _db.SaveChanges();
        }

        public void Update(Movie movie)
        {
            _db.Movies.Update(movie);
            _db.SaveChanges();
        }
    }
}
