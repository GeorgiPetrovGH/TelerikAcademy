﻿namespace MvcTemplate.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using Common.Models;

    public class Image : BaseModel<int>
    {      
        [Required]  
        public byte[] Content { get; set; }

        [Required]
        public string FileExtension { get; set; }

        public string Path { get; set; }

        public int PlaceId { get; set; }

        [ForeignKey("PlaceId")]
        public virtual Place Place { get; set; }
    }
}
