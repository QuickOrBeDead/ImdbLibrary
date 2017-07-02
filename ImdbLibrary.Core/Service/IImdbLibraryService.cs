namespace ImdbLibrary.Core.Service
{
    using Entity;

    public interface IImdbLibraryService
    {
        void InsertMovie(MovieEntity movieEntity);

        void InsertDirector(DirectorEntity directorEntity);
    }
}
