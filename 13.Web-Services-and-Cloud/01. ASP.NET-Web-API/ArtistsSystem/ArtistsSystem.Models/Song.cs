namespace ArtistsSystem.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Song
    {
        public Song()
        {
            this.Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }

        [MaxLength(25)]
        public string Title { get; set; }

        public string Genre { get; set; }

        public short Year { get; set; }

        [InverseProperty("Id")]
        public Guid ArtistId { get; set; }

        [ForeignKey("ArtistId")]
        public virtual Artist Artist { get; set; }
    }
}
