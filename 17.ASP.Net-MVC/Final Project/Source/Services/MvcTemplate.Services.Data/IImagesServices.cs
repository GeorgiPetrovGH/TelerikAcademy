namespace MvcTemplate.Services.Data
{    
    using System.Linq;
    using MvcTemplate.Data.Models;

    public interface IImagesServices
    {
        Image CreateImage(Image image);

        Image GetImageById(int id);

        IQueryable<Image> GetImagesByPlaceId(int placeId);

        IQueryable<Image> GetAll();

        void EditImage(int id, int placeId);

        void DeleteImage(int id);
    }
}
