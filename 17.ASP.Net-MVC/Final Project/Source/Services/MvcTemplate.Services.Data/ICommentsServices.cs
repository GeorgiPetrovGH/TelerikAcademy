namespace MvcTemplate.Services.Data
{
    using MvcTemplate.Data.Models;
    using System.Linq;

    public interface ICommentsServices
    {
        IQueryable<Comment> GetAllComments(int placeId);

        IQueryable<Comment> GetCommentsByPlaceId(int placeId, int page);

        int GetPagesByPlaceId(int ideaId);

        Comment AddComment(Comment comment);
    }
}
