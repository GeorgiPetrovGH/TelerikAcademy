namespace MvcTemplate.Web.Areas.Private.Controllers
{
    using System.Web.Mvc;
    using Models.Comments;
    using Data.Models;
    using Microsoft.AspNet.Identity;
    using Services.Data;
    using System;

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
                Text = model.Text,
                CreatorId = this.User.Identity.GetUserId().ToString(),
                PlaceId = placeId
            };

            this.comments.AddComment(comment);

            return this.Redirect(this.Request.UrlReferrer.ToString());
        }
    }
}