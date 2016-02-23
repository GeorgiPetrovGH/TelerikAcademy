namespace MvcTemplate.Web.Areas.Private.Models.Comments
{
    using MvcTemplate.Data.Models;
    using MvcTemplate.Web.Infrastructure.Mapping;

    public class CommentInputModel : IMapFrom<Comment>
    {
        public string Text { get; set; }
    }
}
