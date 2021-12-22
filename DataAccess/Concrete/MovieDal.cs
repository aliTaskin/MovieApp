using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class MovieDal : IMovieDal
    {
        private readonly DataContext _context;

        public MovieDal(DataContext context)
        {
            _context = context;
        }
        public async  Task Add(Movie movie)
        {
            await _context.Set<Movie>().AddAsync(movie);
        }

        public void Delete(Movie movie)
        {
            throw new NotImplementedException();
        }

        public Movie Get(Expression<Func<Movie, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Movie>> GetAll()
        {
            return await _context.Set<Movie>().ToListAsync();
        }

        public void Update(Movie movie)
        {
            throw new NotImplementedException();
        }
    }
}
