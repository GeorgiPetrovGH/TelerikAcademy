namespace MvcTemplate.Web.Areas.Administration.Controllers
{
    using System.Linq;
    using System.Web.Mvc;
    using Common;
    using Data.Models;
    using Infrastructure.Mapping;
    using Kendo.Mvc.Extensions;
    using Kendo.Mvc.UI;
    using Models.Images;
    using Services.Data;

    [Authorize(Roles = GlobalConstants.AdminRole)]
    public class ImagesController : Controller
    {
        private readonly IImagesServices images;

        public ImagesController(IImagesServices images)
        {
            this.images = images;
        }

        public ActionResult Index()
        {
            return this.View();
        }

        public ActionResult Images_Read([DataSourceRequest]DataSourceRequest request)
        {
            IQueryable<Image> images = this.images.GetAll();
            DataSourceResult result = images
                .To<ImagesGridViewModel>()
                .ToDataSourceResult(request);

            return this.Json(result);
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Images_Update([DataSourceRequest]DataSourceRequest request, Image image)
        {
            if (this.ModelState.IsValid)
            {
                this.images.EditImage(image.Id, image.PlaceId);
            }

            return this.Json(new[] { image }.ToDataSourceResult(request, this.ModelState));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Images_Destroy([DataSourceRequest]DataSourceRequest request, Image image)
        {
            this.images.DeleteImage(image.Id);

            return this.Json(new[] { image }.ToDataSourceResult(request, this.ModelState));
        }
    }
}