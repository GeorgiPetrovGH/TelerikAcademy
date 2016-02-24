namespace MvcTemplate.Services.Data
{
    using System.Linq;
    using Common;
    using MvcTemplate.Data.Models;

    public interface IPlacesServices
    {
        IQueryable<Place> GetTopPlaces(int count);

        IQueryable<Place> GetAllPlaces();

        Place CreatePlace(Place place);

        Place GetPlaceById(int id);

        IQueryable<Place> GetPlacesByPage(int page, OrderByType orderby, string search);

        IQueryable<Place> GetPlacesByCategory(int id);

        IQueryable<Place> GetPlacesByUser(string id);
    }
}
