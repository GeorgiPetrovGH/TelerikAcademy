namespace MvcTemplate.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using Common.Models;
    using MvcTemplate.Common;

    public class Comment : BaseModel<int>
    {
        [Required]
        [MinLength(GlobalConstants.CommentNameMinLength)]
        [MaxLength(GlobalConstants.CommentNameMaxLength)]
        public string Name { get; set; }

        [Required]
        [MinLength(GlobalConstants.CommentTextMinLength)]
        [MaxLength(GlobalConstants.CommentTextMaxLength)]
        public string Text { get; set; }

        public string CreatorId { get; set; }

        [ForeignKey("CreatorId")]
        public virtual User Creator { get; set; }

        public int PlaceId { get; set; }

        [ForeignKey("PlaceId")]
        public virtual Place Place { get; set; }
    }
}
