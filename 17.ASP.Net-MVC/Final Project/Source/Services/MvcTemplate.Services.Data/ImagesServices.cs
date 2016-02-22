namespace MvcTemplate.Services.Data
{
    using MvcTemplate.Data.Common;
    using MvcTemplate.Data.Models;

    public class ImagesServices : IImagesServices
    {
        private readonly IDbRepository<Image> images;

        public ImagesServices(IDbRepository<Image> images)
        {
            this.images = images;
        }
        public Image CreateImage(Image image)
        {
            this.images.Add(image);
            this.images.Save();

            return image;
        }
    }
}
