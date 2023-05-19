﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GA.ApplicationCore.Interfaces
{
    public interface IService<T> where T : class
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Delete(Expression<Func<T, bool>> where);
        T GetById(object id);
        T GetById(string id);
        IEnumerable<T> GetMany(Expression<Func<T, bool>> where = null);
        T Get(Expression<Func<T, bool>> where);
        void Commit();
    }
}
