namespace MvcTemplate.Services.Data
{
    using MvcTemplate.Data.Models;
    using System.Linq;

    public interface IImagesServices
    {
        Image CreateImage(Image image);

        Image GetImageById(int id);

        IQueryable<Image> GetImagesByPlaceId(int placeId);
    }
}
