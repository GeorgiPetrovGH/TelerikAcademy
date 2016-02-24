namespace MvcTemplate.Web.Areas.Administration.Controllers
{
    using System.Linq;
    using System.Web.Mvc;
    using Common;
    using Data.Models;
    using Infrastructure.Mapping;
    using Kendo.Mvc.Extensions;
    using Kendo.Mvc.UI;
    using Models.Categories;
    using Services.Data;
    using Models.Ratings;

    [Authorize(Roles = GlobalConstants.AdminRole)]
    public class RatingsController : Controller
    {
        private readonly IRatingsServices ratings;

        public RatingsController(IRatingsServices ratings)
        {
            this.ratings = ratings;
        }

        public ActionResult Index()
        {
            return this.View();
        }

        public ActionResult Ratings_Read([DataSourceRequest]DataSourceRequest request)
        {
            IQueryable<Rating> ratings = this.ratings.GetAll();
            DataSourceResult result = ratings
                .To<RatingsGridViewModel>()
                .ToDataSourceResult(request);

            return this.Json(result);
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Ratings_Update([DataSourceRequest]DataSourceRequest request, Rating rating)
        {
            if (this.ModelState.IsValid)
            {
                this.ratings.EditRating(rating.Id, rating.Value);
            }

            return this.Json(new[] { rating }.ToDataSourceResult(request, this.ModelState));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Ratings_Destroy([DataSourceRequest]DataSourceRequest request, Rating rating)
        {
            this.ratings.DeleteRating(rating.Id);

            return this.Json(new[] { rating }.ToDataSourceResult(request, this.ModelState));
        }
    }
}