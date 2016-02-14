namespace MvcTemplate.Data.Models
{
    using Common.Models;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Comment : BaseModel<int>
    {
        [Required]
        [MinLength(2)]
        [MaxLength(200)]
        public string Text { get; set; }

        public string CreatorId { get; set; }

        [ForeignKey("CreatorId")]
        public virtual User Creator { get; set; }

        public int PlaceId { get; set; }

        [ForeignKey("PlaceId")]
        public virtual Place Place { get; set; }
    }
}
