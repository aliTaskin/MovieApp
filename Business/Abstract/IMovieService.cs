using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IMovieService
    {
        Task<IEnumerable<Movie>> GetAll();
        Movie Get(Expression<Func<Movie, bool>> filter);
        void Add(Movie movie);
        void Update(Movie movie);
        void Delete(Movie movie);
    }
}
