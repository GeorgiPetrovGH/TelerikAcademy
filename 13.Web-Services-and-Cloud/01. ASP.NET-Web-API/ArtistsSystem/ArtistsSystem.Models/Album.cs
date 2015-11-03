namespace ArtistsSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Album
    {
        private ICollection<Artist> artists;

        public Album()
        {
            this.Id = Guid.NewGuid();
            this.artists = new HashSet<Artist>();
        }

        public Guid Id { get; set; }

        [MaxLength(25)]
        public string Title { get; set; }

        public short Year { get; set; }

        public virtual ICollection<Artist> Singers
        {
            get { return this.artists; }
            set { this.artists = value; }
        }

        public Guid ProducerId { get; set; }

        public Producer Producer { get; set; }
    }
}
