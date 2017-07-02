namespace ImdbLibrary.Core.Entity
{
    using System;

    [Serializable]
    public sealed class MovieEntity
    {
        public int Id { get; set; }

        public string ImdbId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public float Rating { get; set; }

        public string Poster { get; set; }

        public DirectorEntity Director { get; set; }
    }
}