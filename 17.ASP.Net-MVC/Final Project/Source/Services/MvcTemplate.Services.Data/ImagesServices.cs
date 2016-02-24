namespace MvcTemplate.Services.Data
{
    using System;
    using System.Linq;
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

        public Image GetImageById(int id)
        {
            return this.images.GetById(id);
        }

        public IQueryable<Image> GetImagesByPlaceId(int placeId)
        {
            return this.images.All()
                .Where(x => x.PlaceId == placeId)
                .OrderBy(x => x.CreatedOn)
                .Take(10);
        }
    }
}
