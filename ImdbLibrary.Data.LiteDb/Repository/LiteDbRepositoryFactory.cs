namespace ImdbLibrary.Data.LiteDb.Repository
{
    using System;

    using ImdbLibrary.Data.Repository;

    public sealed class LiteDbRepositoryFactory : IRepositoryFactory
    {
        private readonly string _connectionString;

        public LiteDbRepositoryFactory(string connectionString)
        {
            if (connectionString == null)
            {
                throw new ArgumentNullException(nameof(connectionString));
            }

            _connectionString = connectionString;
        }

        public IRepository<T> CreateRepository<T>()
        {
            return new LiteDbRepository<T>(_connectionString);
        }
    }
}