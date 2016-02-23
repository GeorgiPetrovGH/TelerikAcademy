namespace MvcTemplate.Web.Areas.Private.Models.Comments
{
    using System.ComponentModel.DataAnnotations;
    using Common;
    using Data.Models;
    using Infrastructure.Mapping;

    public class CommentInputModel : IMapFrom<Comment>
    {
        [Required]
        [MinLength(GlobalConstants.CommentTextMinLength)]
        [MaxLength(GlobalConstants.CommentTextMaxLength)]
        public string Text { get; set; }

        [Required]
        [MinLength(GlobalConstants.CommentNameMinLength)]
        [MaxLength(GlobalConstants.CommentNameMaxLength)]
        public string Name { get; set; }
    }
}
