namespace ImdbLibrary.Data.LiteDb.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;

    using ImdbLibrary.Data.Repository;

    using LiteDB;

    public sealed class LiteDbQuery<T> : IQuery<T>
    {
        private LiteQueryable<T> _query;

        public LiteDbQuery(LiteQueryable<T> query)
        {
            if (query == null)
            {
                throw new ArgumentNullException(nameof(query));
            }

            _query = query;
        }

        public int Count()
        {
            return _query.Count();
        }

        public bool Exists()
        {
            return _query.Exists();
        }

        public T First()
        {
            return _query.First();
        }

        public T FirstOrDefault()
        {
            return _query.FirstOrDefault();
        }

        public IQuery<T> Include<TK>(Expression<Func<T, TK>> dbref)
        {
            _query = _query.Include(dbref);

            return this;
        }

        public IQuery<T> Limit(int limit)
        {
            _query = _query.Limit(limit);

            return this;
        }

        public T Single()
        {
            return _query.Single();
        }

        public T SingleOrDefault()
        {
            return _query.SingleOrDefault();
        }

        public IQuery<T> Skip(int skip)
        {
            _query = _query.Skip(skip);

            return this;
        }

        public IList<T> ToList()
        {
            return _query.ToList();
        }

        public IQuery<T> Where(Expression<Func<T, bool>> predicate)
        {
            _query = _query.Where(predicate);

            return this;
        }
    }
}