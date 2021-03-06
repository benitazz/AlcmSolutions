﻿#region

using System;
using System.Linq;
using System.Linq.Expressions;

#endregion

namespace DurandalAuth.Domain.Repositories
{
    /// <summary>
    ///     Contract with the  generic methods for all the Entities
    /// </summary>
    public interface IRepository<TEntity>
        where TEntity : class
    {
        IQueryable<TEntity> All();

        IQueryable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

        TEntity FirstOrDefault(Expression<Func<TEntity, bool>> predicate);

        TEntity First(Expression<Func<TEntity, bool>> predicate);

        TEntity GetById(int id);

        void Add(TEntity entity);

        void Delete(TEntity entity);

        void Attach(TEntity entity);
    }
}