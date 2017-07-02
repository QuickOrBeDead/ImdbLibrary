namespace ImdbLibrary.Data.LiteDb.Mapping
{
    public sealed class ImdbLibraryDbMapper : DbMapper
    {
        public ImdbLibraryDbMapper()
        {
            AddEntityMapping<MovieEntityMapping>();
            AddEntityMapping<DirectorEntityMapping>();
        }
    }
}