namespace ArtistsSystem.Models
{
    using System;
    using System.Collections.Generic;
    
    using System.ComponentModel.DataAnnotations;

    public class Country
    {
        private readonly ICollection<Person> population;

        public Country()
        {
            this.Id = Guid.NewGuid();
            this.population = new HashSet<Person>();
        }

        public Guid Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Name { get; set; }

        public virtual ICollection<Person> Population { get; set; }
    }
}
