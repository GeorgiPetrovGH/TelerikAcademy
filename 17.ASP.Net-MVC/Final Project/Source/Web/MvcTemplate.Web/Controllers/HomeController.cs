namespace MvcTemplate.Web.Controllers
{
    using System.Linq;
    using System.Web.Mvc;
    using Infrastructure.Mapping;
    using Services.Data;
    using ViewModels.Home;

    public class HomeController : BaseController
    {
        private readonly IPlacesServices places;

        public HomeController(IPlacesServices places)
        {
            this.places = places;
        }

        public ActionResult Index()
        {
            var places = this.places.GetTopPlaces(3)
                .To<IndexPlaceViewModel>().ToList();

            var viewModel = new IndexViewModel
            {
                Places = places
            };

            return this.View(viewModel);
        }
    }
}
