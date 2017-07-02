namespace ImdbLibrary.Data.LiteDb.Mapping
{
    using System.Runtime.CompilerServices;

    using ImdbLibrary.Core.Entity;

    using LiteDB;

    public sealed class DirectorEntityMapping : EntityMapping<DirectorEntity>
    {
        protected override void Map(EntityBuilder<DirectorEntity> entityBuilder)
        {
            entityBuilder.Id(x => x.Id)
                .DbRef(x => x.Movies)
                .Index(x => x.ImdbId, true)
                .Index(x => x.Name);
        }
    }
}