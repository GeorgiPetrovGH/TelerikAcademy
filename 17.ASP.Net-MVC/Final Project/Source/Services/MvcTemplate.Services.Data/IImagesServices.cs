namespace MvcTemplate.Services.Data
{    
    using System.Linq;
    using MvcTemplate.Data.Models;

    public interface IImagesServices
    {
        Image CreateImage(Image image);

        Image GetImageById(int id);

        IQueryable<Image> GetImagesByPlaceId(int placeId);
    }
}
