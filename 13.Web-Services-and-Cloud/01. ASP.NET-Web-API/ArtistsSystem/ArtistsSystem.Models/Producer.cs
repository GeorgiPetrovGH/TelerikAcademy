namespace ArtistsSystem.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Producers")]
    public class Producer : Person
    {
        private ICollection<Album> albums;

        public Producer()
            : base()
        {
            this.albums = new HashSet<Album>();
        }        

        public virtual ICollection<Album> Albums
        {
            get { return this.albums; }
            set { this.albums = value; }
        }
    }
}
