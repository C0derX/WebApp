using Core.Common.Repository.Implementations;
using Core.Common.Repository.Interface;
using Core.Context;
using Microsoft.EntityFrameworkCore.Storage;

namespace Core.Library.UnitOfWork
{
    public sealed class UnitOfWorkImpl : UnitOfWork
    {
        private static int transactionCount = 0;
        private static IDbContextTransaction transaction;

        private static readonly object lockIns = new object();

        private static AppDbContext Context { get; set; }

        public UnitOfWorkImpl(AppDbContext context)
        {
            //if (Context == null)
            //{
            //    lock (lockIns)
            //    {
            //        if (Context == null)
            //        {
            Context = context;
            //        }
            //    }
            //}

        }

        public void begin()
        {
            if (transactionCount == 0 && transaction == null)
            {
                transaction = Context.Database.BeginTransaction();
            }
            transactionCount++;
        }

        public void commit()
        {
            if (transactionCount == 1 && transaction != null)
            {
                transaction.Commit();
                transaction = null;
            }
            transactionCount--;
        }

        public void Dispose()
        {
            Context?.Dispose();
        }

        public BaseRepository<TEntity> GetRepository<TEntity>() where TEntity : class
        {
            return new BaseRepositoryImpl<TEntity>(Context);
        }

        public void rollback()
        {
            transactionCount--;
            if (transactionCount == 0 && transaction != null)
            {
                transaction.Dispose();
                transaction = null;
            }
        }
    }
}
