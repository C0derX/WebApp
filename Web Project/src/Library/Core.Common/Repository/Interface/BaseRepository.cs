using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Core.Common.Repository.Interface
{
    public interface BaseRepository<T>
    {
        void delete(T entity);
        void insert(T entity);
        void update(T entity);
        void deleteRange(List<T> entities);
        void insertRange(List<T> entities);
        void updateRange(List<T> entities);
        List<T> getAll();
        T getById(long id);
        IQueryable<T> getQueryable();

        List<T> GetAll(bool asNoTracking = false);
        List<T> Get(Expression<Func<T, bool>> filterExpression = null, Expression<Func<T, object>> orderExpression = null);

        List<T> GetWithMultipleInclude(Expression<Func<T, bool>> filterExpression = null,
            Expression<Func<T, object>> orderExpression = null, bool orderDescending = false, string includeProperties = null, int? skip = null,
            int? take = null, bool asNoTracking = false);
    }
}
