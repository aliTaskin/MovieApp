﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IRepository<T> where T:class
    {
        Task<IEnumerable<T>> GetAll();
        T Get(Expression<Func<T, bool>> filter);
        Task Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
