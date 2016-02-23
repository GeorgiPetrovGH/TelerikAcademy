namespace MvcTemplate.Web.Controllers
{
    using System.Linq;
    using System.Web.Mvc;
    using Areas.Private.Models.Images;
    using Infrastructure.Mapping;
    using Services.Data;
    using ViewModels.Home;

    public class HomeController : BaseController
    {
        private readonly IPlacesServices places;
        private readonly IImagesServices images;

        public HomeController(IPlacesServices places, IImagesServices images)
        {
            this.places = places;
            this.images = images;
        }

        public ActionResult Index()
        {
            var places = this.places.GetTopPlaces(3)
                .To<IndexPlaceViewModel>().ToList();
            foreach (var item in places)
            {
                var image = this.images.GetImagesByPlaceId(item.Id)
                    .To<ImageViewModel>()
                    .FirstOrDefault();
                item.Image = image;
            }

            var viewModel = new IndexViewModel
            {
                Places = places
            };

            return this.View(viewModel);
        }
    }
}
