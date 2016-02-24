namespace MvcTemplate.Web.Areas.Private.Controllers
{
    using System.Web.Mvc;
    using Data.Models;
    using Microsoft.AspNet.Identity;
    using Models.Comments;
    using Services.Data;

    [Authorize]
    public class CommentsController : Controller
    {
        private readonly ICommentsServices comments;

        public CommentsController(ICommentsServices comments)
        {
            this.comments = comments;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(int placeId, CommentInputModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.Redirect(this.Request.UrlReferrer.ToString());
            }

            var comment = new Comment()
            {
                Name = model.Name,
                Text = model.Text,
                CreatorId = this.User.Identity.GetUserId().ToString(),
                PlaceId = placeId
            };

            this.comments.AddComment(comment);

            return this.Redirect(this.Request.UrlReferrer.ToString());
        }
    }
}
