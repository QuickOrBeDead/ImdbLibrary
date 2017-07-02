namespace ImdbLibrary.Data.LiteDb.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;

    using Data.Repository;

    using LiteDB;

    public sealed class LiteDbRepository<T> : IRepository<T>
    {
        private LiteRepository _liteRepository;

        public LiteDbRepository(string connectionString)
        {
            _liteRepository = new LiteRepository(connectionString);
        }

        ~LiteDbRepository()
        {
            Dispose(false);
        }

        public int Delete(Expression<Func<T, bool>> predicate)
        {
            return _liteRepository.Delete(predicate);
        }

        public IList<T> Fetch(Expression<Func<T, bool>> predicate)
        {
            return _liteRepository.Fetch(predicate);
        }

        public T First(Expression<Func<T, bool>> predicate)
        {
            return _liteRepository.First(predicate);
        }

        public T FirstOrDefault(Expression<Func<T, bool>> predicate)
        {
            return _liteRepository.FirstOrDefault(predicate);
        }

        public void Insert(T entity)
        {
            _liteRepository.Insert(entity);
        }

        public int Insert(IEnumerable<T> entities)
        {
            return _liteRepository.Insert(entities);
        }

        public IQuery<T> Query()
        {
            return new LiteDbQuery<T>(_liteRepository.Query<T>());
        }

        public T Single(Expression<Func<T, bool>> predicate)
        {
            return _liteRepository.Single(predicate);
        }

        public T SingleOrDefault(Expression<Func<T, bool>> predicate)
        {
            return _liteRepository.SingleOrDefault(predicate);
        }

        public int Update(IEnumerable<T> entities)
        {
            return _liteRepository.Update(entities);
        }

        public bool Update(T entity)
        {
            return _liteRepository.Update(entity);
        }

        public bool Upsert(T entity)
        {
            return _liteRepository.Upsert(entity);
        }

        public int Upsert(IEnumerable<T> entities)
        {
            return _liteRepository.Upsert(entities);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_liteRepository != null)
                {
                    _liteRepository.Dispose();
                    _liteRepository = null;
                }
            }
        }
    }
}
