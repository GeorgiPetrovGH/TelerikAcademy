namespace MvcTemplate.Web.Areas.Private.Controllers
{
    using System.Web.Mvc;
    using Services.Data;

    public class ImagesController : Controller
    {
        private readonly IImagesServices images;

        public ImagesController(IImagesServices images)
        {
            this.images = images;
        }

        public ActionResult GetImageById(int id)
        {
            var image = this.images.GetImageById(id);

            var contentType = string.Empty;
            if (image.FileExtension.ToLower() == "jpg")
            {
                contentType = "image/jpeg";
            }
            else
            {
                contentType = "image/" + image.FileExtension;
            }

            return this.File(image.Content, contentType);
        }
    }
}
