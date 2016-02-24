namespace MvcTemplate.Web.Areas.Private.Controllers
{
    using System.Web.Mvc;
    using Data.Models;
    using Microsoft.AspNet.Identity;
    using Services.Data;

    [Authorize]
    public class RatingsController : Controller
    {
        private readonly IRatingsServices ratings;

        public RatingsController(IRatingsServices ratings)
        {
            this.ratings = ratings;
        }

        [HttpPost]
        public ActionResult AddRating(int id, int value)
        {
            var rating = new Rating
            {
                PlaceId = id,
                CreatorId = this.User.Identity.GetUserId(),
                Value = value
            };

            var result = this.ratings.AddRatingToPlace(rating);

            return this.Redirect("/Private/Places/Details/" + id);
        }
    }
}