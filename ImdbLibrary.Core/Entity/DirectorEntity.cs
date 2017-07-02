namespace ImdbLibrary.Core.Entity
{
    using System.Collections.Generic;

    public sealed class DirectorEntity
    {
        private IList<MovieEntity> _movies;

        public int Id { get; set; }

        public string Name { get; set; }

        public string ImdbId { get; set; }

        public IList<MovieEntity> Movies
        {
            get
            {
                return _movies ?? (_movies = new List<MovieEntity>());
            }

            set
            {
                _movies = value;
            }
        }
    }
}
