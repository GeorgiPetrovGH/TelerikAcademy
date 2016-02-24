namespace MvcTemplate.Web.Areas.Private.Controllers
{
    using System.Linq;
    using System.Web.Mvc;
    using Infrastructure.Mapping;
    using Models;
    using Models.Categories;
    using Services.Data;

    [Authorize]
    public class CategoriesController : Controller
    {
        private readonly IPlacesServices places;

        public CategoriesController(IPlacesServices places)
        {
            this.places = places;
        }

        [HttpGet]
        public ActionResult Index(int id)
        {
            var places = this.places.GetPlacesByCategory(id)
                .To<PlaceViewModel>()
                .ToList();

            var viewModel = new CategoriesIndexViewModel
            {
                CategoryName = places[0].CategoryName,
                Places = places
            };

            return this.View(viewModel);
        }
    }
}
