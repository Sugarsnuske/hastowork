using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using hastowork.Models.Entities;

namespace hastowork.Models.Repositories
{
    public interface IMovieRepository
    {
        // CRUD Functionality

        //void Create(Movie item);
        Movie Get(int id);
        IEnumerable<Movie> GetAll();
        void Update(Movie item);
        void Delete(Movie mo);
        void Save(Movie movie);
    }
}
