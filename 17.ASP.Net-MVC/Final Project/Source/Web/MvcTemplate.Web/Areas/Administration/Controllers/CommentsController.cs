namespace MvcTemplate.Web.Areas.Administration.Controllers
{
    using System.Linq;
    using System.Web.Mvc;
    using Common;
    using Data.Models;
    using Infrastructure.Mapping;
    using Kendo.Mvc.Extensions;
    using Kendo.Mvc.UI;
    using Models.Comments;
    using Services.Data;

    [Authorize(Roles = GlobalConstants.AdminRole)]
    public class CommentsController : Controller
    {
        private readonly ICommentsServices comments;

        public CommentsController(ICommentsServices comments)
        {
            this.comments = comments;
        }

        public ActionResult Index()
        {
            return this.View();
        }

        public ActionResult Comments_Read([DataSourceRequest]DataSourceRequest request)
        {
            IQueryable<Comment> comments = this.comments.GetAll();
            DataSourceResult result = comments
                .To<CommentsGridViewModel>()
                .ToDataSourceResult(request);

            return this.Json(result);
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Comments_Update([DataSourceRequest]DataSourceRequest request, Comment comment)
        {
            if (this.ModelState.IsValid)
            {
                this.comments.EditComment(comment.Id, comment.Name, comment.Text);
            }

            return this.Json(new[] { comment }.ToDataSourceResult(request, this.ModelState));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Comments_Destroy([DataSourceRequest]DataSourceRequest request, Comment comment)
        {
            this.comments.DeleteComment(comment.Id);

            return this.Json(new[] { comment }.ToDataSourceResult(request, this.ModelState));
        }
    }
}