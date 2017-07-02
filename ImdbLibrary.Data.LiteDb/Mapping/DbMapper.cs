namespace ImdbLibrary.Data.LiteDb.Mapping
{
    using System.Collections.Generic;

    public class DbMapper : IDbMapper
    {
        private readonly IList<IEntityMapping> _entityMappings = new List<IEntityMapping>();

        public void AddEntityMapping<TEntity>() where TEntity: IEntityMapping, new()
        {
            _entityMappings.Add(new TEntity());
        }

        public void Init()
        {
            for (int i = 0; i < _entityMappings.Count; i++)
            {
                IEntityMapping entityMapping = _entityMappings[i];
                entityMapping.Map();
            }
        }
    }
}