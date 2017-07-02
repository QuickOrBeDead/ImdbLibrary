namespace ImdbLibrary.Data.LiteDb.Mapping
{
    using System;
    using LiteDB;

    public abstract class EntityMapping<TEntity> : IEntityMapping
        where TEntity: class 
    {
        private readonly BsonMapper _mapper = BsonMapper.Global;

        private EntityBuilder<TEntity> GetMappingBuilder()
        {
            return _mapper.Entity<TEntity>();
        }

        public void Map()
        {
            Map(GetMappingBuilder());
        }

        protected abstract void Map(EntityBuilder<TEntity> entityBuilder);
    }
}