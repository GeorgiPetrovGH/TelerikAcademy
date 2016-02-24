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

        public void DeleteImage(int id)
        {
            var imageToDelete = this.images.GetById(id);
            this.images.HardDelete(imageToDelete);

            this.images.Save();
        }

        public void EditImage(int id, int placeId)
        {
            var imageToBeEdited = this.images.GetById(id);

            imageToBeEdited.PlaceId = placeId;

            this.images.Save();
        }

        public IQueryable<Image> GetAll()
        {
            return this.images.All();
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
