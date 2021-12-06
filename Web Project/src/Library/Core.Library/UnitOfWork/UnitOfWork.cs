using Core.Common.Repository.Interface;
using System;

namespace Core.Library.UnitOfWork
{
    public interface UnitOfWork : IDisposable
    {
        BaseRepository<TEntity> GetRepository<TEntity>() where TEntity : class;
      //  UserDbContext Context { get; }
        void begin();
        void commit();
        void rollback();
    }
}
