namespace MvcTemplate.Web.Areas.Private.Controllers
{
    using System.Linq;
    using System.Web.Mvc;
    using Infrastructure.Mapping;
    using Microsoft.AspNet.Identity;
    using Models;
    using Models.Users;
    using Services.Data;

    [Authorize]
    public class UsersController : Controller
    {
        private readonly IPlacesServices places;

        public UsersController(IPlacesServices places)
        {
            this.places = places;
        }

        public ActionResult Info(string id)
        {
            var places = this.places.GetPlacesByUser(id)
                .To<PlaceViewModel>()
                .ToList();

            var viewModel = new UserInfoViewModel
            {
                UserName = this.User.Identity.GetUserName(),
                Places = places
            };

            return this.View(viewModel);
        }
    }
}
