namespace MvcTemplate.Services.Data
{
    using MvcTemplate.Data.Common;
    using MvcTemplate.Data.Models;
    using System.Linq;
    using System;
    using Common;

    public class CommentsServices : ICommentsServices
    {
        private readonly IDbRepository<Comment> comments;

        public CommentsServices(IDbRepository<Comment> comments)
        {
            this.comments = comments;
        }

        public Comment AddComment(Comment comment)
        {
            this.comments.Add(comment);
            this.comments.Save();

            return comment;
        }

        public IQueryable<Comment> GetAllComments(int placeId)
        {
            return this.comments.All();
        }

        public IQueryable<Comment> GetCommentsByPlaceId(int placeId, int page)
        {
            return this.comments.All()
                .OrderByDescending(c => c.CreatedOn)
                .Where(c => c.PlaceId == placeId)
                .Skip((page - 1) * GlobalConstants.CommentsPerPage)
                .Take(GlobalConstants.CommentsPerPage);
        }

        public int GetPagesByPlaceId(int placeId)
        {
            var comments = this.comments.All().Where(c => c.PlaceId == placeId);

            return (int)Math.Ceiling(comments.Count() / (decimal)GlobalConstants.CommentsPerPage);
        }
    }
}
