namespace ImdbLibrary.Data.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;

    public interface IRepository<T> : IDisposable
    {
        int Delete(Expression<Func<T, bool>> predicate);

        IList<T> Fetch(Expression<Func<T, bool>> predicate);

        T First(Expression<Func<T, bool>> predicate);
       
        T FirstOrDefault(Expression<Func<T, bool>> predicate);

        void Insert(T entity);

        int Insert(IEnumerable<T> entities);

        IQuery<T> Query();
 
        T Single(Expression<Func<T, bool>> predicate);

        T SingleOrDefault(Expression<Func<T, bool>> predicate);

        int Update(IEnumerable<T> entities);

        bool Update(T entity);

        bool Upsert(T entity);

        int Upsert(IEnumerable<T> entities);
    }
}
