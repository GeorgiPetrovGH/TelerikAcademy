namespace MvcTemplate.Services.Data
{
    using System.Linq;
    using MvcTemplate.Data.Models;    

    public interface ICommentsServices
    {
        IQueryable<Comment> GetAll();

        IQueryable<Comment> GetAllComments(int placeId);

        IQueryable<Comment> GetCommentsByPlaceId(int placeId, int page);

        int GetPagesByPlaceId(int ideaId);

        Comment AddComment(Comment comment);

        void EditComment(int id, string name, string text);

        void DeleteComment(int id);
    }
}
