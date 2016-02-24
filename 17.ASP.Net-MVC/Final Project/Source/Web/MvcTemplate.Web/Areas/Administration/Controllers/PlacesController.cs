namespace MvcTemplate.Web.Areas.Administration.Controllers
{
    using System.Linq;
    using System.Web.Mvc;
    using Common;
    using Data.Models;
    using Infrastructure.Mapping;
    using Kendo.Mvc.Extensions;
    using Kendo.Mvc.UI;
    using Models.Places;
    using Services.Data;

    [Authorize(Roles = GlobalConstants.AdminRole)]
    public class PlacesController : Controller
    {
        private readonly IPlacesServices places;

        public PlacesController(IPlacesServices places)
        {
            this.places = places;
        }

        public ActionResult Index()
        {
            return this.View();
        }

        public ActionResult Places_Read([DataSourceRequest]DataSourceRequest request)
        {
            IQueryable<Place> places = this.places.GetAll();
            DataSourceResult result = places
                .To<PlacesGridViewModel>()
                .ToDataSourceResult(request);

            return this.Json(result);
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Places_Update([DataSourceRequest]DataSourceRequest request, Place place)
        {
            if (this.ModelState.IsValid)
            {
                this.places.EditPlace(place.Id, place.Name, place.Description, place.AveragePrice);
            }

            return this.Json(new[] { place }.ToDataSourceResult(request, this.ModelState));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Places_Destroy([DataSourceRequest]DataSourceRequest request, Place place)
        {
            this.places.DeletePlace(place.Id);

            return this.Json(new[] { place }.ToDataSourceResult(request, this.ModelState));
        }
    }
}