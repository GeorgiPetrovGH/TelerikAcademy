﻿namespace MvcTemplate.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema; 
    using Common.Models;
    using MvcTemplate.Common;

    public class Place : BaseModel<int>
    {
        private ICollection<Rating> ratings;
        private ICollection<Comment> comments;
        private ICollection<Image> images;

        public Place()
        {
            this.ratings = new HashSet<Rating>();
            this.comments = new HashSet<Comment>();
            this.images = new HashSet<Image>();
        }

        [Required]
        [MinLength(GlobalConstants.PlaceNameMinLength)]
        [MaxLength(GlobalConstants.PlaceNameMaxLength)]
        public string Name { get; set; }

        [Required]
        [MinLength(GlobalConstants.PlaceDescriptionMinLength)]
        [MaxLength(GlobalConstants.PlaceDescriptionMaxLength)]
        public string Description { get; set; }

        public double AveragePrice { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }

        [Required]
        public string CreatorId { get; set; }

        [ForeignKey("CreatorId")]
        public virtual User Creator { get; set; }

        public virtual ICollection<Rating> Ratings
        {
            get { return this.ratings; }
            set { this.ratings = value; }
        }

        public virtual ICollection<Comment> Comments
        {
            get { return this.comments; }
            set { this.comments = value; }
        }

        public virtual ICollection<Image> Images
        {
            get { return this.images; }
            set { this.images = value; }
        }
    }
}
