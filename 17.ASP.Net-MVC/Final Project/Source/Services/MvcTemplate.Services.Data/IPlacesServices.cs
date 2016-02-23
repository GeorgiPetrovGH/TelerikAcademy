namespace MvcTemplate.Services.Data
{
    using Common;
    using MvcTemplate.Data.Models;
    using System.Linq;

    public interface IPlacesServices
    {
        IQueryable<Place> GetTopPlaces(int count);

        IQueryable<Place> GetAllPlaces();

        Place CreatePlace(Place place);

        Place GetPlaceById(int id);

        IQueryable<Place> GetPlacesByPage(int page, OrderByType orderby, string search);

        IQueryable<Place> GetPlacesByCategory(int id);
    }
}
