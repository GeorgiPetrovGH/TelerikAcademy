namespace MvcTemplate.Services.Data
{
    using System.Linq;
    using Common;
    using MvcTemplate.Data.Common;
    using MvcTemplate.Data.Models; 

    public class PlacesServices : IPlacesServices
    {
        private readonly IDbRepository<Place> places;

        public PlacesServices(IDbRepository<Place> places)
        {
            this.places = places;
        }

        public Place CreatePlace(Place place)
        {
            this.places.Add(place);
            this.places.Save();

            return place;
        }

        public IQueryable<Place> GetAllPlaces()
        {
            return this.places.All();
        }

        public Place GetPlaceById(int id)
        {
            return this.places.GetById(id);
        }

        public IQueryable<Place> GetPlacesByCategory(int categoryId)
        {
            return this.places.All()
                .Where(x => x.CategoryId == categoryId)
                .OrderBy(x => x.CreatedOn);      
        }

        public IQueryable<Place> GetPlacesByPage(int page, OrderByType orderby, string search)
        {
            if (search == null)
            {
                search = string.Empty;
            }

            switch (orderby)
            {
                case OrderByType.ByDate:
                    return this.places.All()
                            .Where(x => x.Name.Contains(search))
                            .OrderByDescending(x => x.CreatedOn)
                            .ThenByDescending(x => x.Ratings.Sum(v => v.Value))
                            .Skip((page - 1) * GlobalConstants.PlacesPerPage)
                            .Take(GlobalConstants.PlacesPerPage);
                default:
                    return this.places.All()
                            .Where(x => x.Name.Contains(search))
                            .OrderByDescending(x => x.Ratings.Sum(v => v.Value))
                            .ThenByDescending(x => x.CreatedOn)
                            .Skip((page - 1) * GlobalConstants.PlacesPerPage)
                            .Take(GlobalConstants.PlacesPerPage);
            }
        }

        public IQueryable<Place> GetPlacesByUser(string id)
        {
            return this.places.All()
                .Where(x => x.CreatorId == id)
                .OrderByDescending(x => x.CreatedOn);
        }

        public IQueryable<Place> GetTopPlaces(int count)
        {
            return this.places.All()
                .OrderByDescending(x => x.Ratings.Sum(v => v.Value))
                .Take(count);
        }
    }
}
