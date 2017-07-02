namespace ImdbLibrary.Data.LiteDb.Mapping
{
    using Core.Entity;

    using LiteDB;

    public sealed class MovieEntityMapping : EntityMapping<MovieEntity>
    {
        protected override void Map(EntityBuilder<MovieEntity> entityBuilder)
        {
            entityBuilder.Id(x => x.Id)
                         .DbRef(x => x.Director)
                         .Index(x => x.ImdbId, true)
                         .Index(x => x.Title);
        }
    }
}
