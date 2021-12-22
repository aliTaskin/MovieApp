using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class MovieManager:IMovieService
    {
        IMovieDal _movieDal;
        public MovieManager(IMovieDal movieDal)
        {
            _movieDal = movieDal;
        }

        public async Task<IEnumerable<Movie>> GetAll()
        {
            return await _movieDal.GetAll();
        }

        public void Add(Movie movie)
        {
            _movieDal.Add(movie);
        }

        public Movie Get(Expression<Func<Movie, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Movie movie)
        {
            throw new NotImplementedException();
        }

        public void Delete(Movie movie)
        {
            throw new NotImplementedException();
        }
    }
}
