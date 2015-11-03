namespace ArtistsSystem.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Artists")]
    public class Artist : Person
    {
        private ICollection<Song> songs;
        private ICollection<Album> albums;

        public Artist()
            : base()
        {
            this.songs = new HashSet<Song>();
            this.albums = new HashSet<Album>();
        }

        public virtual ICollection<Song> Songs
        {
            get { return this.songs; }
            set { this.songs = value; }
        }

        public virtual ICollection<Album> Albums
        {
            get { return this.albums; }
            set { this.albums = value; }
        }
    }
}
