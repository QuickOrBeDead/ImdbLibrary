namespace ImdbLibrary.Service
{
    using System;

    using Core.Entity;
    using Core.Service;

    using Data.Repository;

    public sealed class ImbdLibraryService : IImdbLibraryService
    {
        private readonly IRepositoryFactory _repositoryFactory;

        public ImbdLibraryService(IRepositoryFactory repositoryFactory)
        {
            if (repositoryFactory == null)
            {
                throw new ArgumentNullException(nameof(repositoryFactory));
            }

            _repositoryFactory = repositoryFactory;
        }

        public void InsertMovie(MovieEntity movieEntity)
        {
            if (movieEntity == null)
            {
                throw new ArgumentNullException(nameof(movieEntity));
            }

            using (IRepository<MovieEntity> movieRepository = _repositoryFactory.CreateRepository<MovieEntity>())
            {
                InsertDirector(movieEntity.Director);

                string imdbId = movieEntity.ImdbId;
                if (!MovieExists(movieRepository, imdbId))
                {
                    movieRepository.Insert(movieEntity);
                }
            }
        }

        public void InsertDirector(DirectorEntity directorEntity)
        {
            if (directorEntity == null)
            {
                throw new ArgumentNullException(nameof(directorEntity));
            }

            using (IRepository<DirectorEntity> directorRepository = _repositoryFactory.CreateRepository<DirectorEntity>())
            {
                string imdbId = directorEntity.ImdbId;
                if (!DirectorExists(directorRepository, imdbId))
                {
                    directorRepository.Insert(directorEntity);
                }
            }
        }

        private static bool DirectorExists(IRepository<DirectorEntity> directorRepository, string imdbId)
        {
            return directorRepository.Query().Where(x => x.ImdbId == imdbId).Exists();
        }

        private static bool MovieExists(IRepository<MovieEntity> movieRepository, string imdbId)
        {
            return movieRepository.Query().Where(x => x.ImdbId == imdbId).Exists();
        }
    }
}
