namespace ImdbLibrary.Data.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;

    public interface IQuery<T>
    {
        int Count();

        bool Exists();

        T First();

        T FirstOrDefault();

        IQuery<T> Include<K>(Expression<Func<T, K>> dbref);

        IQuery<T> Limit(int limit);

        T Single();

        T SingleOrDefault();

        IQuery<T> Skip(int skip);

        IList<T> ToList();

        IQuery<T> Where(Expression<Func<T, bool>> predicate);
    }
}