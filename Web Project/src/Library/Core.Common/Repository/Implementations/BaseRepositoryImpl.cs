using Core.Common.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Core.Common.Repository.Implementations
{
    public class BaseRepositoryImpl<T> : BaseRepository<T> where T : class
    {
        private readonly DbContext _appDbContext;
        public BaseRepositoryImpl(DbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void delete(T entity)
        {
            _appDbContext.Set<T>().Remove(entity);
            _appDbContext.SaveChanges();
        }

        public void deleteRange(List<T> entities)
        {
            _appDbContext.Set<T>().RemoveRange(entities);
            _appDbContext.SaveChanges();
        }

        public List<T> getAll()
        {
            return _appDbContext.Set<T>().ToList();
        }

        public T getById(long id)
        {
            return _appDbContext.Set<T>().Find(id);
        }

        public IQueryable<T> getQueryable()
        {
            return _appDbContext.Set<T>();
        }

        public void insert(T entity)
        {
            _appDbContext.Set<T>().Add(entity);
            _appDbContext.SaveChanges();
        }

        public void insertRange(List<T> entities)
        {
            _appDbContext.Set<T>().AddRange(entities);
            _appDbContext.SaveChanges();
        }

        public void update(T entity)
        {
            _appDbContext.SaveChanges();
        }

        public void updateRange(List<T> entities)
        {
            _appDbContext.SaveChanges();
        }

        public List<T> GetAll(bool asNoTracking = false)
        {
            return asNoTracking ? _appDbContext.Set<T>().AsNoTracking().ToList() : _appDbContext.Set<T>().ToList();
        }

        public List<T> Get(Expression<Func<T, bool>> filterExpression = null, Expression<Func<T, object>> orderExpression = null)
        {
            IQueryable<T> query = _appDbContext.Set<T>();
            if (filterExpression != null)
                query = query.Where(filterExpression);
            if (orderExpression != null)
                query = query.OrderBy(orderExpression);
            return query.ToList();
        }
        public List<T> GetWithMultipleInclude(Expression<Func<T, bool>> filterExpression = null, Expression<Func<T, object>> orderExpression = null, bool orderDescending = false, string includeProperties = null, int? skip = null,
            int? take = null, bool asNoTracking = false)
        {
            includeProperties = includeProperties ?? string.Empty;
            IQueryable<T> query = asNoTracking ? _appDbContext.Set<T>().AsNoTracking() : _appDbContext.Set<T>();

            if (filterExpression != null)
                query = asNoTracking ? query.Where(filterExpression).AsNoTracking() : query.Where(filterExpression);
            foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = asNoTracking ? query.Include(includeProperty).AsNoTracking() : query.Include(includeProperty);
            }
            if (orderExpression != null)
            {
                if (orderDescending)
                {
                    query = query.OrderByDescending(orderExpression);
                }
                else
                {
                    query = query.OrderBy(orderExpression);
                }
            }

            if (skip.HasValue)
            {
                query = query.Skip(skip.Value);
            }

            if (take.HasValue)
            {
                query = query.Take(take.Value);
            }
            return query.ToList();
        }

        public Task<T> FirstOrDefaultAsync()
        {
            return _appDbContext.Set<T>().FirstOrDefaultAsync();
        }

        public Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> expression)
        {
            return _appDbContext.Set<T>().FirstOrDefaultAsync(expression);
        }

        public Task<List<T>> GetAllAsync(bool asNoTracking = false)
        {
            return asNoTracking ? _appDbContext.Set<T>().AsNoTracking().ToListAsync() : _appDbContext.Set<T>().ToListAsync();
        }

        public Task<List<T>> GetAsync(Expression<Func<T, bool>> filterExpression = null, Expression<Func<T, object>> orderExpression = null)
        {
            IQueryable<T> query = _appDbContext.Set<T>();

            if (filterExpression != null)
                query = query.Where(filterExpression);

            if (orderExpression != null)
                query = query.OrderBy(orderExpression);
            return query.ToListAsync();
        }

        public Task<List<T>> GetWithMultipleIncludeAsync(Expression<Func<T, bool>> filterExpression = null, Expression<Func<T, object>> orderExpression = null, bool orderDescending = false,
            string includeProperties = null, int? skip = null, int? take = null, bool asNoTracking = false)
        {
            includeProperties = includeProperties ?? string.Empty;
            IQueryable<T> query = _appDbContext.Set<T>();
            if (filterExpression != null)
                query = query.Where(filterExpression);
            foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }


            if (asNoTracking)
                query = query.AsNoTracking();
            if (skip.HasValue)
            {
                query = query.Skip(skip.Value);
            }

            if (take.HasValue)
            {
                query = query.Take(take.Value);
            }
            if (orderExpression != null)
            {
                if (orderDescending)
                {
                    query = query.OrderByDescending(orderExpression);
                }
                else
                {
                    query = query.OrderBy(orderExpression);
                }
            }
            return query.ToListAsync();
        }
    }
}
