namespace MvcTemplate.Services.Data
{
    using System.Linq;
    using MvcTemplate.Data.Models;    

    public interface ICommentsServices
    {
        IQueryable<Comment> GetAllComments(int placeId);

        IQueryable<Comment> GetCommentsByPlaceId(int placeId, int page);

        int GetPagesByPlaceId(int ideaId);

        Comment AddComment(Comment comment);
    }
}
