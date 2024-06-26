﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    public interface IEntityRepository <T> where T : class, IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> predicate =null);
        T Get(Expression<Func<T, bool>> predicate);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        int Count(Expression<Func<T, bool>> predicate = null);
        bool Any(Expression<Func<T, bool>> predicate);
    }
}
