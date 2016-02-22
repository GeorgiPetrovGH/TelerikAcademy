namespace MvcTemplate.Services.Data
{
    using System;
    using System.Linq;

    using MvcTemplate.Data.Models;
    using MvcTemplate.Data.Common;
    using Common;

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

        public IQueryable<Place> GetPlacesByPage(int page, OrderByType orderby, string search)
        {
            if (search == null)
            {
                search = " ";
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

        public IQueryable<Place> GetTopPlaces(int count)
        {
            return this.places.All().Take(count);
        }
    }
}
