namespace ImdbLibrary.Module.LiteDb
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;

    using Data.LiteDb.Mapping;
    using Data.LiteDb.Repository;
    using Data.Repository;

    using SimpleInjector;

    public sealed class LiteDbModule
    {
        private readonly string _connectionString;

        public LiteDbModule(string connectionString)
        {
            if (connectionString == null)
            {
                throw new ArgumentNullException(nameof(connectionString));
            }

            _connectionString = connectionString;
        }

        public void RegisterComponents(Container container)
        {
            container.RegisterSingleton<IRepositoryFactory>(() => new LiteDbRepositoryFactory(_connectionString));
            container.RegisterCollection<IDbMapper>(new List<Assembly> { typeof(DirectorEntityMapping).Assembly });
        }
    }
}
